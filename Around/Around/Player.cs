using Around.Biblioteki;
using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Around
{
    public partial class Player : Form
    {
        #region Zmienne

        #region Zmienne statyczne

        bool connected;
        string AdresIP;

        #endregion

        #region

        Thread WątekPierwszegoPołączenia;
        Thread WątekUtrzymaniaPołączenia;

        #endregion Zmienne wątkowe

        #endregion

        #region Obsługa przenoszenia okna myszką
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void WindowMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Inicjalizatory

        public Player(Point formLocation, string ip)
        {
            connected = false;
            AdresIP = ip;

            InitializeComponent();
        }

        #endregion

        #region Nasłuchiwanie wydarzeń

        private void ConnectToServerBtn_Click(object sender, EventArgs e)
        {
            //Teraz próbujemy połączyć się z serwerem
            try
            {
                WątekPierwszegoPołączenia = new Thread(PierwszePołączenie);
                var sprawdzeniePierwszegoPołączenia = new Thread(PierwszePołączenieChecker);

                WątekPierwszegoPołączenia.Start();
                sprawdzeniePierwszegoPołączenia.Start();

                ConnectToServerBtn.Text = "Czekaj...";
                ConnectToServerBtn.BackColor = Color.Silver;
                Cursor.Current = Cursors.WaitCursor;
            }

            catch
            {
                ConnectToServerBtn.BackColor = Color.FromArgb(26, 35, 126);
                ConnectToServerBtn.Enabled = true;
                ConnectToServerBtn.Text = "Połącz";

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Nie można uzyskać połączenia z serwerem! Upewnij się że kod połączenia jest poprawny oraz że połączenie sieciowe pracuje prawidłowo.", "Błąd połączenia");
            }
        }

        private void ExitPlayerBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConnectionKeyBox_TextChanged(object sender, EventArgs e)
        {
            var currentText = ConnectionKeyBox.Text;
            if (currentText.Length >= 4)
            {
                currentText = currentText.Replace("-", null);

                var newText = String.Empty;
                var Conte = 0;
                foreach (char znak in currentText)
                {
                    if (Conte == 4)
                        newText += "-";

                    newText += znak;
                    Conte++;
                }

                ConnectionKeyBox.Text = newText;
            }

            else
                ConnectionKeyBox.Text = ConnectionKeyBox.Text.Replace("-", null);

            ConnectionKeyBox.Focus();
            ConnectionKeyBox.SelectionStart = ConnectionKeyBox.Text.Length;
        }

        #endregion

        #region Wątki pracujące w tle

        private void PierwszePołączenie()
        {
            try
            {
                TcpClient tcpClient = new TcpClient(Around_Lib.GetIpByConnectionKey(ConnectionKeyBox.Text), 5759);
                NetworkStream stream = tcpClient.GetStream();
                byte[] bytes = Encoding.UTF8.GetBytes(AdresIP);
                stream.Write(bytes, 0, bytes.Length);
                tcpClient.Close();
                connected = true;
            }

            catch
            {

            }
        }

        private void PierwszePołączenieChecker()
        {
            var opóźnienie = 100;
            while (opóźnienie <= 3000)
            {
                if (connected == true)
                    break;

                Thread.Sleep(opóźnienie);
            }

            if (connected == false)
            {
                WątekPierwszegoPołączenia.Abort();
                this.Invoke((MethodInvoker)delegate {
                    MessageBox.Show("Nie można uzyskać połączenia z serwerem! Upewnij się że kod połączenia jest poprawny oraz że połączenie sieciowe pracuje prawidłowo.", "Błąd połączenia");
                    ConnectToServerBtn.BackColor = Color.FromArgb(26, 35, 126);
                    ConnectToServerBtn.Enabled = true;
                    ConnectToServerBtn.Text = "Połącz";
                    Cursor.Current = Cursors.Default;
                });
            }

            else
            {
                this.Invoke((MethodInvoker)delegate {
                    ConnectToServerBtn.BackColor = Color.Silver;
                    ConnectToServerBtn.Enabled = false;
                    ConnectToServerBtn.Text = "Połączono";
                    ConnectionKeyBox.Enabled = false;
                    ConnectionKeyBox.Visible = false;
                    ConnectToServerBtn.Visible = false;
                    Cursor.Current = Cursors.Default;

                    ConnectionKeyLabel.Text = "Kod połączenia: " + ConnectionKeyBox.Text;

                    //Teraz ustawiamy podtrzymywanie połączenia
                    WątekUtrzymaniaPołączenia = new Thread(PodtrzymaniePołączenia);
                    WątekUtrzymaniaPołączenia.Start();

                    MessageBox.Show("Połączono!");
                });
            }
        }

        private void PodtrzymaniePołączenia()
        {
            try
            {
                while (true)
                {
                    TcpClient tcpClient = new TcpClient(Around_Lib.GetIpByConnectionKey(ConnectionKeyBox.Text), 5759);
                    NetworkStream stream = tcpClient.GetStream();
                    byte[] bytes = Encoding.UTF8.GetBytes(AdresIP);
                    stream.Write(bytes, 0, bytes.Length);
                    tcpClient.Close();
                    connected = true;

                    Thread.Sleep(2000);
                }
            }

            catch
            {
                this.Invoke((MethodInvoker)delegate
                {
                    ConnectToServerBtn.BackColor = Color.FromArgb(26, 35, 126);
                    ConnectToServerBtn.Enabled = true;
                    ConnectToServerBtn.Text = "Połącz";
                    ConnectionKeyBox.Enabled = true;
                    ConnectionKeyBox.Visible = true;
                    ConnectToServerBtn.Visible = true;

                    ConnectionKeyLabel.Text = "Kod połączenia: " + ConnectionKeyBox.Text;

                    MessageBox.Show("Utracono połączenie z serwerem!", "Utracono połączenie");
                });
            }
        }

        #endregion
    }
}
