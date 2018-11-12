using Around.Biblioteki;
using Around.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Around
{
    public partial class MainForm : Form
    {

        #region Zmienne globalne

        #region Zmienne statyczne

        int choosedMode;

        #endregion

        #region Zmienne obiektowe

        List<string> listaInterfejsów;
        List<NetworkInterfaceModel> interfejsy;

        #endregion

        #endregion

        #region Obsługa przenoszenia okna myszką
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Konstruktory i inicjalizatory

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Generujemy kolekcję interfejsów
            interfejsy = Around_Lib.GetLocalIPAddress();
            listaInterfejsów = new List<string>();

            foreach (var x in interfejsy)
                listaInterfejsów.Add(x.InterfaceName + ", Adres IP: " + x.IpAddress);

            InterfacesListBox.DataSource = listaInterfejsów;

            //Teraz ustawiamy zmienne blokujące przejście dalej
            choosedMode = 0;
            InterfacesListBox.SelectedIndex = 0;
        }

        #endregion

        #region Nasłuchiwacze wydarzeń

        private void Exit1Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RunStreamerBtn_Click(object sender, EventArgs e)
        {
            choosedMode = 1;

            RunStreamerBtn.BackColor = Color.FromArgb(26, 35, 126);
            RunPlayerBtn.BackColor = Color.Silver;

            NextBtn.Enabled = true;
            NextBtn.BackColor = Color.FromArgb(26, 35, 126);
        }

        private void RunPlayerBtn_Click(object sender, EventArgs e)
        {
            choosedMode = 2;

            RunPlayerBtn.BackColor = Color.FromArgb(26, 35, 126);
            RunStreamerBtn.BackColor = Color.Silver;

            NextBtn.Enabled = true;
            NextBtn.BackColor = Color.FromArgb(26, 35, 126);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            //Pobieramy potrzebne dane z pierwszego okna
            Point formLocation = this.Location;
            string selectedIp = interfejsy.ElementAt(InterfacesListBox.SelectedIndex).IpAddress;

            if (choosedMode == 1)
            {
                Streamer streamerForm = new Streamer(formLocation, selectedIp);
                streamerForm.Tag = this;

                streamerForm.Show();
                Hide();
            }

            if (choosedMode == 2)
            {
                Player playerForm = new Player(formLocation, selectedIp);
                playerForm.Tag = this;

                playerForm.Show();
                Hide();
            }
        }

        #endregion
    }
}
