namespace UniversiteYonetimSistemi.UI.Forms.AdminUserControlForms
{
    partial class OgretmenYonetim
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
            panel3 = new Panel();
            label9 = new Label();
            btnSil = new Button();
            txtID = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            dataOgretmenler = new DataGridView();
            panel2 = new Panel();
            cmbBolum = new ComboBox();
            btnEkle = new Button();
            label11 = new Label();
            label5 = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtTelefon = new TextBox();
            txtEposta = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataOgretmenler).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnSil);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(698, 369);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 228);
            panel3.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Green;
            label9.Location = new Point(7, 9);
            label9.Name = "label9";
            label9.Size = new Size(216, 28);
            label9.TabIndex = 1;
            label9.Text = "Öğretmen silme";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Firebrick;
            btnSil.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(11, 151);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(208, 65);
            btnSil.TabIndex = 2;
            btnSil.Text = "Öğretmeni Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.Location = new Point(11, 87);
            txtID.Name = "txtID";
            txtID.Size = new Size(208, 35);
            txtID.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 59);
            label10.Name = "label10";
            label10.Size = new Size(127, 25);
            label10.TabIndex = 4;
            label10.Text = "Öğretmen ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataOgretmenler);
            panel1.Location = new Point(18, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 334);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(21, 15);
            label1.Name = "label1";
            label1.Size = new Size(263, 32);
            label1.TabIndex = 1;
            label1.Text = "Öğretmen listesi";
            // 
            // dataOgretmenler
            // 
            dataOgretmenler.BackgroundColor = Color.LightBlue;
            dataOgretmenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataOgretmenler.DefaultCellStyle = dataGridViewCellStyle1;
            dataOgretmenler.Location = new Point(21, 60);
            dataOgretmenler.Name = "dataOgretmenler";
            dataOgretmenler.Size = new Size(867, 239);
            dataOgretmenler.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(cmbBolum);
            panel2.Controls.Add(btnEkle);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtSoyad);
            panel2.Controls.Add(txtAd);
            panel2.Controls.Add(txtTelefon);
            panel2.Controls.Add(txtEposta);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(18, 369);
            panel2.Name = "panel2";
            panel2.Size = new Size(663, 228);
            panel2.TabIndex = 11;
            // 
            // cmbBolum
            // 
            cmbBolum.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbBolum.FormattingEnabled = true;
            cmbBolum.Location = new Point(454, 113);
            cmbBolum.Name = "cmbBolum";
            cmbBolum.Size = new Size(200, 36);
            cmbBolum.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Green;
            btnEkle.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(454, 165);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 52);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Öğretmeni Kaydet";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(454, 85);
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
            label5.Size = new Size(378, 32);
            label5.TabIndex = 1;
            label5.Text = "Öğretmen kayıt menüsü";
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.White;
            txtSoyad.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoyad.Location = new Point(233, 114);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 35);
            txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.White;
            txtAd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAd.Location = new Point(10, 115);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 35);
            txtAd.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.White;
            txtTelefon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefon.Location = new Point(10, 181);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 35);
            txtTelefon.TabIndex = 3;
            // 
            // txtEposta
            // 
            txtEposta.BackColor = Color.White;
            txtEposta.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEposta.Location = new Point(233, 182);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(199, 35);
            txtEposta.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 153);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 4;
            label8.Text = "Telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(234, 154);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 4;
            label7.Text = "Eposta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(233, 86);
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
            // OgretmenYonetim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "OgretmenYonetim";
            Size = new Size(940, 615);
            Load += OgretmenYonetim_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataOgretmenler).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label9;
        private Button btnSil;
        private TextBox txtID;
        private Label label10;
        private Panel panel1;
        private Label label1;
        private DataGridView dataOgretmenler;
        private Panel panel2;
        private Button btnEkle;
        private Label label11;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtTelefon;
        private TextBox txtEposta;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label2;
        private TextBox txtSoyad;
        private ComboBox cmbBolum;
    }
}
