using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Around.Biblioteki;
using Around.Modele;

namespace Around
{
    public partial class Streamer : Form
    {
        #region Zmienne globalne

        #region Zmienne statyczne

        string StrServerIP;

        #endregion

        #region Zmienne obiektowe

        List<KlientIPModel> ListaAdresówKlientów;
        IPAddress AdresIP;
        Point previousFormLoc;

        TcpListener Nasłuchiwacz;
        TcpClient Klient;

        #endregion

        #region Zmienne wątkowe

        Thread WątekNasłuchiwania;
        Thread WątekAktywnychKlientów;

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

        #endregion
    }
}
