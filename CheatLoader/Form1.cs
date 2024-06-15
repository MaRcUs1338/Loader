using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using KeyAuth;

namespace CheatLoader
{
    public partial class Form1 : Form
    {
        public static api KeyAuthApp = new api(
    name: "",
    ownerid: "", 
    secret: "", 
    version: "" 
);
        public Form1()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
            Process[] procList = Process.GetProcesses();
            timer1.Tick += new EventHandler(OnTimedEvent);
            
            
            
        }
        
        
        private void OnTimedEvent(object sender, EventArgs e)
        {
            Process[] procList = Process.GetProcesses();
            string[] processNames = { "x64dbg", "ida", "ghydra", "x32dbg", "dnspy", "ollydbg", "Scylla_x86", "Scylla_x64", "HxD" };
            foreach (Process process in procList)
            {
                if (processNames.Contains(process.ProcessName, StringComparer.OrdinalIgnoreCase))
                {
                    Process.Start("https://cdn.discordapp.com/attachments/1081206230560809000/1250614513409986590/stopcracking.png?ex=666b9507&is=666a4387&hm=1b59290278151f413720bff9baa89f53e02b9bd0fe59327d17caf50ce52eb023&");
                }
            }
            
        }
       

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
            {
                this.Hide();
                Form2 main = new Form2();
                main.Show();
            }
            else
                MessageBox.Show(KeyAuthApp.response.message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();

            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
                Environment.Exit(0);
            }

            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
        }
        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 main = new Form3();
            main.Show();
            this.Hide();
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticonePictureBox3_Click(object sender, EventArgs e)
        {
            siticonePictureBox3.Visible = false;
            siticonePictureBox2.Visible = true;
            password.UseSystemPasswordChar = false;
        }
        

        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {
            siticonePictureBox2.Visible = false;
            siticonePictureBox3.Visible = true;
            password.UseSystemPasswordChar = true;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void siticoneGradientPanel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void siticonePictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
