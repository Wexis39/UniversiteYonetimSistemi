namespace UniversiteYonetimSistemi.UI.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOgrenci = new Button();
            btnOgretmen = new Button();
            btnAdmin = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlTop = new Panel();
            btnMinimize = new Button();
            btnExit = new Button();
            txtUsername = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txtPassword = new TextBox();
            txtHide = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTop.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtHide).BeginInit();
            SuspendLayout();
            // 
            // btnOgrenci
            // 
            btnOgrenci.BackColor = Color.FromArgb(52, 158, 232);
            btnOgrenci.FlatStyle = FlatStyle.Flat;
            btnOgrenci.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOgrenci.ForeColor = Color.White;
            btnOgrenci.Location = new Point(308, 177);
            btnOgrenci.Name = "btnOgrenci";
            btnOgrenci.Size = new Size(140, 50);
            btnOgrenci.TabIndex = 0;
            btnOgrenci.Text = "Öğrenci";
            btnOgrenci.UseVisualStyleBackColor = false;
            // 
            // btnOgretmen
            // 
            btnOgretmen.BackColor = Color.FromArgb(52, 158, 232);
            btnOgretmen.FlatStyle = FlatStyle.Flat;
            btnOgretmen.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOgretmen.ForeColor = Color.White;
            btnOgretmen.Location = new Point(160, 177);
            btnOgretmen.Name = "btnOgretmen";
            btnOgretmen.Size = new Size(140, 50);
            btnOgretmen.TabIndex = 0;
            btnOgretmen.Text = "Öğretmen";
            btnOgretmen.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(52, 158, 232);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(12, 177);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(140, 50);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "İdari İşler";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(223, 226, 233);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(32, 191);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Türü /";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(223, 226, 233);
            pictureBox1.BackgroundImage = Properties.Resources.profile;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(170, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.LightBlue;
            pnlTop.Controls.Add(btnMinimize);
            pnlTop.Controls.Add(btnExit);
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(500, 32);
            pnlTop.TabIndex = 3;
            pnlTop.MouseDown += pnlTop_MouseDown;
            pnlTop.MouseMove += pnlTop_MouseMove;
            pnlTop.MouseUp += pnlTop_MouseUp;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(146, 165, 246);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(430, -4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(32, 36);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(146, 165, 246);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(468, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(32, 324);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(436, 39);
            txtUsername.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(223, 226, 233);
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(32, 296);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 226, 233);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtHide);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnOgretmen);
            panel1.Controls.Add(btnOgrenci);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(20, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 508);
            panel1.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(12, 359);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(365, 39);
            txtPassword.TabIndex = 4;
            // 
            // txtHide
            // 
            txtHide.BackColor = Color.FromArgb(223, 226, 233);
            txtHide.BackgroundImage = Properties.Resources.eye;
            txtHide.BackgroundImageLayout = ImageLayout.Stretch;
            txtHide.Location = new Point(394, 352);
            txtHide.Name = "txtHide";
            txtHide.Size = new Size(50, 50);
            txtHide.TabIndex = 2;
            txtHide.TabStop = false;
            txtHide.Click += txtHide_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(223, 226, 233);
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(160, 144);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 1;
            label4.Text = "Seçim yapınız";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(223, 226, 233);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(12, 331);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 1;
            label3.Text = "Parola";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(39, 174, 97);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(45, 426);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(371, 55);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Gririş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 210, 225);
            ClientSize = new Size(500, 580);
            Controls.Add(txtUsername);
            Controls.Add(pnlTop);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtHide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOgrenci;
        private Button btnOgretmen;
        private Button btnAdmin;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel pnlTop;
        private Button btnMinimize;
        private Button btnExit;
        private TextBox txtUsername;
        private Label label2;
        private Panel panel1;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private PictureBox txtHide;
        private Label label4;
    }
}