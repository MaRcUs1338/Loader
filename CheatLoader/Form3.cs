using System;
using System.Windows.Forms;
using KeyAuth;

namespace CheatLoader
{
    public partial class Form3 : Form
    {
        public static api KeyAuthApp = new api(
    name: "",
    ownerid: "", 
    secret: "",
    version: "" 
);
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {

            KeyAuthApp.register(username.Text, password.Text, key.Text);
            if (KeyAuthApp.response.success)
            {
                Form1 main = new Form1();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show(KeyAuthApp.response.message);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void siticonePictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void siticoneGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
