using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Around.Biblioteki;
using Around.Modele;

namespace Around
{
    /*
     * PORT TCP (ŁĄCZENIE Z NOWYMI KLIENTAMI, I PODTRZYMANIE ICH OBECNOŚCI) - 5759
     * PORT UDP (SYNCHRONIZACJA PLIKÓW MUZYCZNYCH / MULTICAST) - 5758
     */

    public partial class Streamer : Form
    {
        #region Zmienne globalne

        #region Zmienne statyczne

        string StrServerIP;

        const int CodliInstructionsPort = 5757;
        const int FileTransferPort = 5758;
        const int ConnectionPort = 5759;

        #endregion

        #region Zmienne obiektowe

        List<KlientIPModel> ListaAdresówKlientów;
        Point previousFormLoc;

        IPAddress AdresIP;

        TcpListener Nasłuchiwacz;
        TcpClient Klient;

        #endregion

        #region Zmienne wątkowe

        Thread WątekNasłuchiwania;
        Thread WątekAktywnychKlientów;
        Thread WątekSynchronizacji;
        Thread WątekOdtwarzania;

        #endregion

        #endregion

        #region Obsługa przenoszenia okna myszką
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Streamer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Inicjalizatory

        public Streamer(Point formLocation, string IPAddressStr)
        {
            //Inicjujemy wszystkie potrzebne zmienne
            previousFormLoc = formLocation;
            StrServerIP = IPAddressStr;
            AdresIP = IPAddress.Parse(IPAddressStr);
            Nasłuchiwacz = new TcpListener(AdresIP, 5759);
            ListaAdresówKlientów = new List<KlientIPModel>();

            InitializeComponent();
        }

        private void Streamer_Load(object sender, EventArgs e)
        {
            this.Location = previousFormLoc;
            StreamingCodeLabel.Text = Around_Lib.GenerateNewConnectionKey(StrServerIP);

            //Oraz uruchamiamy nasłuchiwanie
            WątekNasłuchiwania = new Thread(ListenerThread);
            WątekNasłuchiwania.Start();

            WątekAktywnychKlientów = new Thread(ConnectedClientsCounter);
            WątekAktywnychKlientów.Start();
        }

        #endregion

        #region Nasłuchiwacze wydarzeń

        private void ExitStreamerBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RenewConnectionKeyBtn_Click(object sender, EventArgs e)
        {
            StreamingCodeLabel.Text = Around_Lib.GenerateNewConnectionKey(StrServerIP);
        }

        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            var oknoWyboru = new OpenFileDialog();
            oknoWyboru.Filter = "Pliki dźwiękowe|*.mp3; *.wav; *.flac; *.aac; *.m4a;";
            oknoWyboru.Title = "Wybierz plik do strumieniowania";

            if (oknoWyboru.ShowDialog() == DialogResult.OK)
            {
                var ścieżka = oknoWyboru.FileName;
                FilePathBox.Text = ścieżka;
            }
        }
        
        private void SyncBtn_Click(object sender, EventArgs e)
        {
            //Teraz uruchamiamy wątek synchronizacji
            WątekSynchronizacji = new Thread(() => Synchronizuj(FilePathBox.Text));
            WątekSynchronizacji.Start();

            SyncBtn.Enabled = false;
            SyncBtn.BackColor = Color.Silver;
        }

        #endregion

        #region Wątki pracujące w tle

        private void ListenerThread()
        {
            Nasłuchiwacz.Start();

            while (true)
            {
                //Odbieramy wiadomość
                Klient = Nasłuchiwacz.AcceptTcpClient();
                NetworkStream strumień = Klient.GetStream();

                var bufor = new byte[Klient.ReceiveBufferSize];
                int bajty = strumień.Read(bufor, 0, Klient.ReceiveBufferSize);

                var wiadomość = Encoding.UTF8.GetString(bufor, 0, bajty);

                //Przetwarzamy wiadomość - w której jest po prostu adres IP klienta
                var entry = (from a in ListaAdresówKlientów where a.AdresIP == wiadomość select a).FirstOrDefault();
                if (entry == null)
                {
                    if (Around_Lib.IsIpCorrect(wiadomość) == true)
                        ListaAdresówKlientów.Add(new KlientIPModel(wiadomość, DateTime.Now));
                }

                else
                {
                    entry.Aktualizuj();
                }
            } //Nasłuchiwanie jest aktywne zawsze, więc nie opuszczamy tej metody
        }

        private void ConnectedClientsCounter()
        {
            //W tym wątku sprawdzamy wszystkie wpisy w naszej liście, czy są aktualne
            while (true)
            {
                var Conte = 0;
                var rozmiarListy = ListaAdresówKlientów.Count();

                if (rozmiarListy > 0)
                    while (Conte < rozmiarListy)
                    {
                        {
                            if (ListaAdresówKlientów.ElementAt(Conte).CzyModelJestAktualny() == false)
                                ListaAdresówKlientów.RemoveAt(Conte);

                            Conte++;
                        }
                    }

                //Aktualizujemy nasz licznik podłączonych urządzeń
                ConnectedDevicesLabel.Invoke((MethodInvoker)delegate {
                    ConnectedDevicesLabel.Text = "Podłączeni klienci: " + ListaAdresówKlientów.Count;
                });

                //I dajemy wątkowi 2 sekundki przerwy
                Thread.Sleep(2000);
            }
        }

        private void Synchronizuj(string ścieżkaDoPliku)
        {
            try
            {
                var cacheKlienci = ListaAdresówKlientów;
                var plik = File.ReadAllBytes(ścieżkaDoPliku);
                var Conte = 0;

                foreach (var e in cacheKlienci)
                {
                    //Wysyłanie do pojedynczego klienta z listy
                    TcpClient tcpClient = new TcpClient(e.AdresIP, FileTransferPort);
                    NetworkStream stream = tcpClient.GetStream();
                    stream.Write(plik, 0, plik.Length);
                    tcpClient.Close();

                    //Inkrementacja naszego quantyfikatora
                    Conte++;

                    //Aktualizacja stanu
                    int progress = (Conte / cacheKlienci.Count()) * 100;
                    if (progress > 100)
                        progress = 100;

                    MakeProgress(progress);
                }
            }

            catch
            {

            }
        }

        private void WydajRozkaz(string polecenie)
        {
            foreach (var e in ListaAdresówKlientów)
            {
                TcpClient tcpClient = new TcpClient(e.AdresIP, CodliInstructionsPort);
                NetworkStream stream = tcpClient.GetStream();
                byte[] bytes = Encoding.UTF8.GetBytes(polecenie);
                stream.Write(bytes, 0, bytes.Length);
                tcpClient.Close();
            }

            //Teraz należy ten rozkaz wykonać również u nas...
        }

        private void Odtwarzaj()
        {
            var player = new SoundPlayer(FilePathBox.Text);
            player.Play();
        }

        #endregion

        #region Obsługa interfejsu

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        private void MakeProgress(int value)
        {
            SyncProgressBar.Invoke((MethodInvoker)delegate
           {
               SyncProgressBar.Value = value;
           });
        }

        #endregion

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            var polecenie = new Thread(() => WydajRozkaz("PLAY"));
            polecenie.Start();

            WątekOdtwarzania = new Thread(Odtwarzaj);
            WątekOdtwarzania.Start();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            var polecenie = new Thread(() => WydajRozkaz("STOP"));
            polecenie.Start();

            WątekOdtwarzania.Abort();
        }
    }
}
