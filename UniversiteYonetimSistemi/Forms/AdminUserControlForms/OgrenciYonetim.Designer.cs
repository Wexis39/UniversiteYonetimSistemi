namespace UniversiteYonetimSistemi.UI.Forms.AdminUserControlForms
{
    partial class OgrenciYonetim
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
            label1 = new Label();
            panel1 = new Panel();
            dataOgrenciler = new DataGridView();
            panel2 = new Panel();
            cmbBolum = new ComboBox();
            txtDogum = new MaskedTextBox();
            btnEkle = new Button();
            label11 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            txtEposta = new TextBox();
            txtSoyad = new TextBox();
            label8 = new Label();
            label12 = new Label();
            txtTC = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            btnSil = new Button();
            txtID = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataOgrenciler).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci listesi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataOgrenciler);
            panel1.Location = new Point(18, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 334);
            panel1.TabIndex = 7;
            // 
            // dataOgrenciler
            // 
            dataOgrenciler.BackgroundColor = Color.LightBlue;
            dataOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataOgrenciler.DefaultCellStyle = dataGridViewCellStyle1;
            dataOgrenciler.Location = new Point(19, 60);
            dataOgrenciler.Name = "dataOgrenciler";
            dataOgrenciler.Size = new Size(612, 239);
            dataOgrenciler.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(cmbBolum);
            panel2.Controls.Add(txtDogum);
            panel2.Controls.Add(btnEkle);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtAd);
            panel2.Controls.Add(txtTelefon);
            panel2.Controls.Add(txtAdres);
            panel2.Controls.Add(txtEposta);
            panel2.Controls.Add(txtSoyad);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtTC);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(18, 371);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 228);
            panel2.TabIndex = 8;
            // 
            // cmbBolum
            // 
            cmbBolum.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbBolum.FormattingEnabled = true;
            cmbBolum.Location = new Point(714, 48);
            cmbBolum.Name = "cmbBolum";
            cmbBolum.Size = new Size(179, 36);
            cmbBolum.TabIndex = 8;
            // 
            // txtDogum
            // 
            txtDogum.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDogum.Location = new Point(10, 182);
            txtDogum.Mask = "00/00/0000";
            txtDogum.Name = "txtDogum";
            txtDogum.Size = new Size(218, 34);
            txtDogum.TabIndex = 7;
            txtDogum.ValidatingType = typeof(DateTime);
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Green;
            btnEkle.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(714, 100);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(178, 116);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Öğrenciyi Kaydet";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(714, 20);
            label11.Name = "label11";
            label11.Size = new Size(148, 25);
            label11.TabIndex = 4;
            label11.Text = "Bölümü Seçiniz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(10, 20);
            label5.Name = "label5";
            label5.Size = new Size(344, 32);
            label5.TabIndex = 1;
            label5.Text = "Öğrenci kayıt menüsü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 153);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 4;
            label4.Text = "Doğum Tarihi";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.White;
            txtAd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAd.Location = new Point(10, 115);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(218, 35);
            txtAd.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.White;
            txtTelefon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefon.Location = new Point(481, 182);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(218, 35);
            txtTelefon.TabIndex = 3;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.White;
            txtAdres.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAdres.Location = new Point(481, 47);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(218, 35);
            txtAdres.TabIndex = 3;
            // 
            // txtEposta
            // 
            txtEposta.BackColor = Color.White;
            txtEposta.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEposta.Location = new Point(481, 115);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(218, 35);
            txtEposta.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.White;
            txtSoyad.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoyad.Location = new Point(248, 115);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(218, 35);
            txtSoyad.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(481, 154);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 4;
            label8.Text = "Telefon";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(481, 19);
            label12.Name = "label12";
            label12.Size = new Size(63, 25);
            label12.TabIndex = 4;
            label12.Text = "Adres";
            // 
            // txtTC
            // 
            txtTC.BackColor = Color.White;
            txtTC.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTC.Location = new Point(248, 181);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(218, 35);
            txtTC.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(481, 87);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 4;
            label7.Text = "Eposta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(248, 153);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 4;
            label6.Text = "TC No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(248, 87);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 4;
            label3.Text = "Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 87);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 4;
            label2.Text = "Adı";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnSil);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(692, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 241);
            panel3.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Green;
            label9.Location = new Point(10, 13);
            label9.Name = "label9";
            label9.Size = new Size(208, 31);
            label9.TabIndex = 1;
            label9.Text = "Öğrenci silme";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Firebrick;
            btnSil.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(11, 172);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(208, 58);
            btnSil.TabIndex = 2;
            btnSil.Text = "Öğrenci Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.Location = new Point(10, 100);
            txtID.Name = "txtID";
            txtID.Size = new Size(208, 35);
            txtID.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(10, 72);
            label10.Name = "label10";
            label10.Size = new Size(107, 25);
            label10.TabIndex = 4;
            label10.Text = "Öğrenci ID";
            // 
            // OgrenciYonetim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "OgrenciYonetim";
            Size = new Size(940, 615);
            Load += OgrenciYonetim_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataOgrenciler).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHepsiniGetir;
        private Button btnAra;
        private Label label8;
        private Panel panel4;
        private TextBox txtKullaniciAra;
        private Label label6;
        private Button btnSil;
        private TextBox txtID;
        private Label label9;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private DataGridView dataOgrenciler;
        private Panel panel2;
        private TextBox txtAd;
        private TextBox txtTC;
        private TextBox txtTelefon;
        private TextBox txtEposta;
        private Label label7;
        private MaskedTextBox txtDogum;
        private Button btnEkle;
        private TextBox txtSoyad;
        private Label label10;
        private ComboBox cmbBolum;
        private Label label11;
        private TextBox txtAdres;
        private Label label12;
    }
}
