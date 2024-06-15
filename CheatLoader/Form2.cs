using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;



namespace CheatLoader
{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load_1(object sender, EventArgs e)
        {
            username.Text = Form1.KeyAuthApp.user_data.username;
            hwid.Text = "" + UnixTimeToDateTime(long.Parse(Form1.KeyAuthApp.user_data.lastlogin));
            license.Text = "" + UnixTimeToDateTime(long.Parse(Form1.KeyAuthApp.user_data.subscriptions[0].expiry));
        }
        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }

        public static bool SubExist(string name, int len)
        {
            for (var i = 0; i < len; i++)
            {
                if (Form1.KeyAuthApp.user_data.subscriptions[i].subscription == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
           

            if (siticoneComboBox1.SelectedItem != null && siticoneComboBox1.SelectedItem.ToString() == "CS2")
            {
                Process.Start("cmd.exe", "/c Injector.exe SourceEngine.dll cs2.exe");
            }


            else
            {
                MessageBox.Show("Choose a game");
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void siticonePictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void siticoneGradientPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
