namespace UniversiteYonetimSistemi.UI.Forms.AdminUserControlForms
{
    partial class KullaniciYonetim
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataKullanici = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            btnEkle = new Button();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            label3 = new Label();
            cmbRoller = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            btnSil = new Button();
            txtID = new TextBox();
            label9 = new Label();
            panel4 = new Panel();
            btnHepsiniGetir = new Button();
            label7 = new Label();
            btnAra = new Button();
            txtKullaniciAra = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataKullanici).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataKullanici
            // 
            dataKullanici.BackgroundColor = Color.LightBlue;
            dataKullanici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataKullanici.DefaultCellStyle = dataGridViewCellStyle1;
            dataKullanici.Location = new Point(28, 60);
            dataKullanici.Name = "dataKullanici";
            dataKullanici.Size = new Size(424, 239);
            dataKullanici.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataKullanici);
            panel1.Location = new Point(444, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 334);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(28, 11);
            label1.Name = "label1";
            label1.Size = new Size(285, 32);
            label1.TabIndex = 1;
            label1.Text = "Kayıtlı kullanıcılar";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Green;
            btnEkle.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(149, 243);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(258, 57);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Kullanıcı Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.White;
            txtKullaniciAdi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKullaniciAdi.Location = new Point(149, 75);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(258, 35);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 75);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.White;
            txtSifre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSifre.Location = new Point(149, 127);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(258, 35);
            txtSifre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 127);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 4;
            label3.Text = "Geçici Şifre";
            // 
            // cmbRoller
            // 
            cmbRoller.BackColor = Color.White;
            cmbRoller.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRoller.FormattingEnabled = true;
            cmbRoller.Location = new Point(149, 179);
            cmbRoller.Name = "cmbRoller";
            cmbRoller.Size = new Size(258, 33);
            cmbRoller.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 179);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 4;
            label4.Text = "Kullanıcı Rolü";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cmbRoller);
            panel2.Controls.Add(btnEkle);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtKullaniciAdi);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtSifre);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 334);
            panel2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(10, 12);
            label5.Name = "label5";
            label5.Size = new Size(262, 32);
            label5.TabIndex = 1;
            label5.Text = "Kullanıcı ekleme";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(btnSil);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(12, 376);
            panel3.Name = "panel3";
            panel3.Size = new Size(417, 217);
            panel3.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(10, 12);
            label6.Name = "label6";
            label6.Size = new Size(233, 32);
            label6.TabIndex = 1;
            label6.Text = "Kullanıcı silme";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Firebrick;
            btnSil.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(149, 147);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(258, 57);
            btnSil.TabIndex = 2;
            btnSil.Text = "Kullanıcı Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.Location = new Point(149, 77);
            txtID.Name = "txtID";
            txtID.Size = new Size(258, 35);
            txtID.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 77);
            label9.Name = "label9";
            label9.Size = new Size(112, 25);
            label9.TabIndex = 4;
            label9.Text = "Kullanıcı ID";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(btnHepsiniGetir);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(btnAra);
            panel4.Controls.Add(txtKullaniciAra);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(444, 376);
            panel4.Name = "panel4";
            panel4.Size = new Size(482, 217);
            panel4.TabIndex = 6;
            // 
            // btnHepsiniGetir
            // 
            btnHepsiniGetir.BackColor = Color.RoyalBlue;
            btnHepsiniGetir.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold);
            btnHepsiniGetir.ForeColor = Color.White;
            btnHepsiniGetir.Location = new Point(247, 147);
            btnHepsiniGetir.Name = "btnHepsiniGetir";
            btnHepsiniGetir.Size = new Size(194, 57);
            btnHepsiniGetir.TabIndex = 5;
            btnHepsiniGetir.Text = "Hepsini Getir";
            btnHepsiniGetir.UseVisualStyleBackColor = false;
            btnHepsiniGetir.Click += btnHepsiniGetir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(10, 12);
            label7.Name = "label7";
            label7.Size = new Size(248, 32);
            label7.TabIndex = 1;
            label7.Text = "Kullanıcı arama";
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.RoyalBlue;
            btnAra.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(29, 147);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(194, 57);
            btnAra.TabIndex = 2;
            btnAra.Text = "Kullanıcı Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // txtKullaniciAra
            // 
            txtKullaniciAra.BackColor = Color.White;
            txtKullaniciAra.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKullaniciAra.Location = new Point(153, 77);
            txtKullaniciAra.Name = "txtKullaniciAra";
            txtKullaniciAra.Size = new Size(300, 35);
            txtKullaniciAra.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 77);
            label8.Name = "label8";
            label8.Size = new Size(122, 25);
            label8.TabIndex = 4;
            label8.Text = "Kullanıcı Adı";
            // 
            // KullaniciYonetim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "KullaniciYonetim";
            Size = new Size(940, 615);
            Load += KullaniciYonetim_Load;
            ((System.ComponentModel.ISupportInitialize)dataKullanici).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataKullanici;
        private Panel panel1;
        private Label label1;
        private Button btnEkle;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private TextBox txtSifre;
        private Label label3;
        private ComboBox cmbRoller;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private Button btnSil;
        private TextBox txtID;
        private Label label9;
        private Panel panel4;
        private Label label7;
        private Button btnAra;
        private TextBox txtKullaniciAra;
        private Label label8;
        private Button btnHepsiniGetir;
    }
}
