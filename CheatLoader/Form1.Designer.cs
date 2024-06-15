
namespace CheatLoader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.username = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.password = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneGradientButton1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticonePictureBox3 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticonePictureBox2 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.AnimateWindow = true;
            this.siticoneBorderlessForm1.BorderRadius = 30;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // username
            // 
            this.username.Animated = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.username.BorderRadius = 20;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.Color.Silver;
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Location = new System.Drawing.Point(198, 154);
            this.username.Margin = new System.Windows.Forms.Padding(6);
            this.username.MaxLength = 20;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.username.PlaceholderText = "";
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(376, 50);
            this.username.TabIndex = 1;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Animated = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.password.BorderRadius = 20;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FillColor = System.Drawing.Color.Silver;
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Location = new System.Drawing.Point(198, 245);
            this.password.Margin = new System.Windows.Forms.Padding(6);
            this.password.MaxLength = 16;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.password.PlaceholderText = "";
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(376, 50);
            this.password.TabIndex = 2;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.BorderRadius = 15;
            this.siticoneGradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneGradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Duo quadruple", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(198, 338);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.Size = new System.Drawing.Size(376, 48);
            this.siticoneGradientButton1.TabIndex = 5;
            this.siticoneGradientButton1.Text = "Autorization";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Play", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(731, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(212, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "SIGN UP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Duo quadruple", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(337, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Duo quadruple", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(306, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(15, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "You don\'t have an account?";
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel1.Controls.Add(this.siticoneGradientButton1);
            this.siticoneGradientPanel1.Controls.Add(this.label2);
            this.siticoneGradientPanel1.Controls.Add(this.label5);
            this.siticoneGradientPanel1.Controls.Add(this.label1);
            this.siticoneGradientPanel1.Controls.Add(this.siticonePictureBox3);
            this.siticoneGradientPanel1.Controls.Add(this.siticonePictureBox2);
            this.siticoneGradientPanel1.Controls.Add(this.label4);
            this.siticoneGradientPanel1.Controls.Add(this.label3);
            this.siticoneGradientPanel1.Controls.Add(this.password);
            this.siticoneGradientPanel1.Controls.Add(this.username);
            this.siticoneGradientPanel1.Controls.Add(this.siticonePictureBox1);
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.siticoneGradientPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(-1, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(767, 517);
            this.siticoneGradientPanel1.TabIndex = 0;
            this.siticoneGradientPanel1.UseTransparentBackground = true;
            this.siticoneGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneGradientPanel1_Paint);
            this.siticoneGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.siticoneGradientPanel1_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            // 
            // siticonePictureBox3
            // 
            this.siticonePictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticonePictureBox3.Image = global::CheatLoader.Properties.Resources.hide;
            this.siticonePictureBox3.ImageRotate = 0F;
            this.siticonePictureBox3.Location = new System.Drawing.Point(583, 245);
            this.siticonePictureBox3.Name = "siticonePictureBox3";
            this.siticonePictureBox3.Size = new System.Drawing.Size(51, 50);
            this.siticonePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox3.TabIndex = 12;
            this.siticonePictureBox3.TabStop = false;
            this.siticonePictureBox3.UseTransparentBackground = true;
            this.siticonePictureBox3.Click += new System.EventHandler(this.siticonePictureBox3_Click);
            // 
            // siticonePictureBox2
            // 
            this.siticonePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticonePictureBox2.Image = global::CheatLoader.Properties.Resources.open;
            this.siticonePictureBox2.ImageRotate = 0F;
            this.siticonePictureBox2.Location = new System.Drawing.Point(583, 245);
            this.siticonePictureBox2.Name = "siticonePictureBox2";
            this.siticonePictureBox2.Size = new System.Drawing.Size(51, 50);
            this.siticonePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox2.TabIndex = 11;
            this.siticonePictureBox2.TabStop = false;
            this.siticonePictureBox2.UseTransparentBackground = true;
            this.siticonePictureBox2.Click += new System.EventHandler(this.siticonePictureBox2_Click);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = global::CheatLoader.Properties.Resources.logo;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(240, -40);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(294, 209);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 0;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.UseTransparentBackground = true;
            this.siticonePictureBox1.Click += new System.EventHandler(this.siticonePictureBox1_Click);
            this.siticonePictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.siticonePictureBox1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 516);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader - Autorization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox3;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox password;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox username;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

