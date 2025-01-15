namespace UniversiteYonetimSistemi.UI.Forms
{
    partial class AdminForm
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
            components = new System.ComponentModel.Container();
            pnlTop = new Panel();
            label1 = new Label();
            btnExit = new Button();
            btnMinimize = new Button();
            pnlLeft = new Panel();
            pictureBox7 = new PictureBox();
            btnKapat = new Button();
            pictureBox6 = new PictureBox();
            btnAyarlar = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnOgretmen = new Button();
            btnKullanici = new Button();
            pictureBox3 = new PictureBox();
            btnOgrenci = new Button();
            btnAnasayfa = new Button();
            label2 = new Label();
            lblName = new Label();
            panel1 = new Panel();
            lblSaat = new Label();
            lblTarih = new Label();
            tmrSaat = new System.Windows.Forms.Timer(components);
            pnlTop.SuspendLayout();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = SystemColors.HotTrack;
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(btnExit);
            pnlTop.Controls.Add(btnMinimize);
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1200, 30);
            pnlTop.TabIndex = 0;
            pnlTop.MouseDown += pnlTop_MouseDown;
            pnlTop.MouseMove += pnlTop_MouseMove;
            pnlTop.MouseUp += pnlTop_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(319, 32);
            label1.TabIndex = 1;
            label1.Text = "Üniversite Yönetim Sistemi";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.OrangeRed;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1170, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Goldenrod;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1134, -10);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 49);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(24, 25, 80);
            pnlLeft.Controls.Add(pictureBox7);
            pnlLeft.Controls.Add(btnKapat);
            pnlLeft.Controls.Add(pictureBox6);
            pnlLeft.Controls.Add(btnAyarlar);
            pnlLeft.Controls.Add(pictureBox5);
            pnlLeft.Controls.Add(pictureBox4);
            pnlLeft.Controls.Add(pictureBox1);
            pnlLeft.Controls.Add(pictureBox2);
            pnlLeft.Controls.Add(btnOgretmen);
            pnlLeft.Controls.Add(btnKullanici);
            pnlLeft.Controls.Add(pictureBox3);
            pnlLeft.Controls.Add(btnOgrenci);
            pnlLeft.Controls.Add(btnAnasayfa);
            pnlLeft.Location = new Point(0, 30);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(260, 650);
            pnlLeft.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.cikisResim;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(4, 590);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(50, 50);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.FromArgb(24, 25, 80);
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.Font = new Font("Cascadia Code", 12.75F, FontStyle.Bold);
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(-1, 585);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(258, 60);
            btnKapat.TabIndex = 4;
            btnKapat.Text = "  Oturumu kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.ayarlarResim;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(3, 522);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 56);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.FromArgb(24, 25, 80);
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.Font = new Font("Cascadia Code", 12.75F, FontStyle.Bold);
            btnAyarlar.ForeColor = Color.White;
            btnAyarlar.Location = new Point(-1, 519);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(258, 60);
            btnAyarlar.TabIndex = 7;
            btnAyarlar.Text = "   Hesap Ayarları";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.anasayfaResmi;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(7, 261);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.kullaniciResmi;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(2, 456);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 56);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MESlogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 250);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.ogretmenResmi;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(2, 390);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 56);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnOgretmen
            // 
            btnOgretmen.BackColor = Color.FromArgb(24, 25, 80);
            btnOgretmen.FlatStyle = FlatStyle.Flat;
            btnOgretmen.Font = new Font("Cascadia Code", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOgretmen.ForeColor = Color.White;
            btnOgretmen.Location = new Point(-1, 387);
            btnOgretmen.Name = "btnOgretmen";
            btnOgretmen.Size = new Size(258, 60);
            btnOgretmen.TabIndex = 5;
            btnOgretmen.Text = "     Öğretmen Yönetimi";
            btnOgretmen.UseVisualStyleBackColor = false;
            btnOgretmen.Click += btnOgretmen_Click;
            // 
            // btnKullanici
            // 
            btnKullanici.BackColor = Color.FromArgb(24, 25, 80);
            btnKullanici.FlatStyle = FlatStyle.Flat;
            btnKullanici.Font = new Font("Cascadia Code", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKullanici.ForeColor = Color.White;
            btnKullanici.Location = new Point(-1, 453);
            btnKullanici.Name = "btnKullanici";
            btnKullanici.Size = new Size(258, 60);
            btnKullanici.TabIndex = 5;
            btnKullanici.Text = "     Kullanıcı Yönetimi";
            btnKullanici.UseVisualStyleBackColor = false;
            btnKullanici.Click += btnKullanici_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.ogrenciResmi;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(2, 325);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 56);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // btnOgrenci
            // 
            btnOgrenci.BackColor = Color.FromArgb(24, 25, 80);
            btnOgrenci.FlatStyle = FlatStyle.Flat;
            btnOgrenci.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOgrenci.ForeColor = Color.White;
            btnOgrenci.Location = new Point(-1, 322);
            btnOgrenci.Name = "btnOgrenci";
            btnOgrenci.Size = new Size(258, 60);
            btnOgrenci.TabIndex = 5;
            btnOgrenci.Text = "     Öğrenci Yönetimi";
            btnOgrenci.UseVisualStyleBackColor = false;
            btnOgrenci.Click += btnOgrenci_Click;
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.BackColor = Color.FromArgb(24, 25, 80);
            btnAnasayfa.FlatStyle = FlatStyle.Flat;
            btnAnasayfa.Font = new Font("Cascadia Code", 15F, FontStyle.Bold);
            btnAnasayfa.ForeColor = Color.White;
            btnAnasayfa.Location = new Point(-1, 256);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.Size = new Size(258, 60);
            btnAnasayfa.TabIndex = 6;
            btnAnasayfa.Text = "   Anasayfa";
            btnAnasayfa.UseVisualStyleBackColor = false;
            btnAnasayfa.Click += btnAnasayfa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(266, 33);
            label2.Name = "label2";
            label2.Size = new Size(129, 26);
            label2.TabIndex = 2;
            label2.Text = "Rol: Yönetici";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.LightGray;
            lblName.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(625, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(135, 26);
            lblName.TabIndex = 2;
            lblName.Text = "Kullanıcı Adı:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(lblSaat);
            panel1.Controls.Add(lblTarih);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(260, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 35);
            panel1.TabIndex = 3;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.BackColor = Color.LightGray;
            lblSaat.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaat.Location = new Point(425, 3);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(57, 26);
            lblSaat.TabIndex = 2;
            lblSaat.Text = "Saat:";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.BackColor = Color.LightGray;
            lblTarih.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarih.Location = new Point(190, 3);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(65, 26);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "Tarih:";
            // 
            // tmrSaat
            // 
            tmrSaat.Enabled = true;
            tmrSaat.Interval = 1000;
            tmrSaat.Tick += tmrSaat_Tick;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 680);
            Controls.Add(label2);
            Controls.Add(pnlTop);
            Controls.Add(pnlLeft);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Button btnMinimize;
        private Button btnExit;
        private Label label1;
        private Panel pnlLeft;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblName;
        private PictureBox pictureBox3;
        private Button btnOgrenci;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Button btnKullanici;
        private Button btnOgretmen;
        private PictureBox pictureBox5;
        private Button btnAnasayfa;
        private Panel panel1;
        private Label lblTarih;
        private Label lblSaat;
        private System.Windows.Forms.Timer tmrSaat;
        private PictureBox pictureBox6;
        private Button btnAyarlar;
        private Button btnKapat;
        private PictureBox pictureBox7;
    }
}