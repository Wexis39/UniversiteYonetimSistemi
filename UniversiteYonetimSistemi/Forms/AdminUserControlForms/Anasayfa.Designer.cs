namespace UniversiteYonetimSistemi.UI.Forms.AdminControlForms
{
    partial class Anasayfa
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel3 = new Panel();
            lblOgrenciSayisi = new Label();
            label6 = new Label();
            panel4 = new Panel();
            lblKullaniciSayisi = new Label();
            label8 = new Label();
            label4 = new Label();
            lblOgretmenSayisi = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            dataAll = new DataGridView();
            cmbRol = new ComboBox();
            label2 = new Label();
            panel5 = new Panel();
            btnAra = new Button();
            txtTelefon = new TextBox();
            label9 = new Label();
            txtEposta = new TextBox();
            label7 = new Label();
            txtSoyad = new TextBox();
            label5 = new Label();
            txtAd = new TextBox();
            label3 = new Label();
            btnHepsiniGetir = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataAll).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(lblOgrenciSayisi);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(324, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(293, 134);
            panel3.TabIndex = 0;
            // 
            // lblOgrenciSayisi
            // 
            lblOgrenciSayisi.AutoSize = true;
            lblOgrenciSayisi.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOgrenciSayisi.ForeColor = Color.White;
            lblOgrenciSayisi.Location = new Point(118, 60);
            lblOgrenciSayisi.Name = "lblOgrenciSayisi";
            lblOgrenciSayisi.Size = new Size(56, 65);
            lblOgrenciSayisi.TabIndex = 1;
            lblOgrenciSayisi.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(7, 9);
            label6.Name = "label6";
            label6.Size = new Size(278, 30);
            label6.TabIndex = 1;
            label6.Text = "Toplam Öğrenci Sayısı";
            // 
            // panel4
            // 
            panel4.BackColor = Color.ForestGreen;
            panel4.Controls.Add(lblKullaniciSayisi);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(631, 29);
            panel4.Name = "panel4";
            panel4.Size = new Size(293, 134);
            panel4.TabIndex = 0;
            // 
            // lblKullaniciSayisi
            // 
            lblKullaniciSayisi.AutoSize = true;
            lblKullaniciSayisi.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKullaniciSayisi.ForeColor = Color.White;
            lblKullaniciSayisi.Location = new Point(118, 62);
            lblKullaniciSayisi.Name = "lblKullaniciSayisi";
            lblKullaniciSayisi.Size = new Size(56, 65);
            lblKullaniciSayisi.TabIndex = 1;
            lblKullaniciSayisi.Text = "0";
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(40, 0);
            label8.Name = "label8";
            label8.Size = new Size(253, 116);
            label8.TabIndex = 1;
            label8.Text = "Sisteme Kayıtlı Kullanıcı Sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(7, 9);
            label4.Name = "label4";
            label4.Size = new Size(279, 27);
            label4.TabIndex = 1;
            label4.Text = "Toplam Öğretmen Sayısı";
            // 
            // lblOgretmenSayisi
            // 
            lblOgretmenSayisi.AutoSize = true;
            lblOgretmenSayisi.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOgretmenSayisi.ForeColor = Color.White;
            lblOgretmenSayisi.Location = new Point(118, 55);
            lblOgretmenSayisi.Name = "lblOgretmenSayisi";
            lblOgretmenSayisi.Size = new Size(56, 65);
            lblOgretmenSayisi.TabIndex = 1;
            lblOgretmenSayisi.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Brown;
            panel2.Controls.Add(lblOgretmenSayisi);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(17, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 134);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataAll);
            panel1.Location = new Point(17, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 414);
            panel1.TabIndex = 8;
            // 
            // dataAll
            // 
            dataAll.BackgroundColor = Color.LightBlue;
            dataAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataAll.DefaultCellStyle = dataGridViewCellStyle2;
            dataAll.Location = new Point(18, 17);
            dataAll.Name = "dataAll";
            dataAll.Size = new Size(619, 379);
            dataAll.TabIndex = 0;
            // 
            // cmbRol
            // 
            cmbRol.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(15, 39);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(206, 28);
            cmbRol.TabIndex = 9;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 7);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 10;
            label2.Text = "Kullanıcı Tipi";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            panel5.Controls.Add(btnHepsiniGetir);
            panel5.Controls.Add(btnAra);
            panel5.Controls.Add(txtTelefon);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtEposta);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(txtSoyad);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txtAd);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(cmbRol);
            panel5.Location = new Point(687, 187);
            panel5.Name = "panel5";
            panel5.Size = new Size(237, 414);
            panel5.TabIndex = 11;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.RoyalBlue;
            btnAra.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAra.ForeColor = Color.White;
            btnAra.Location = new Point(3, 345);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(115, 57);
            btnAra.TabIndex = 12;
            btnAra.Text = "Kullanıcı Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefon.Location = new Point(15, 304);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(206, 27);
            txtTelefon.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 272);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 10;
            label9.Text = "Telefon";
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEposta.Location = new Point(15, 238);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(206, 27);
            txtEposta.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 206);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 10;
            label7.Text = "Eposta";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoyad.Location = new Point(15, 172);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(206, 27);
            txtSoyad.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 140);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 10;
            label5.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAd.Location = new Point(15, 106);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(206, 27);
            txtAd.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 74);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 10;
            label3.Text = "Ad";
            // 
            // btnHepsiniGetir
            // 
            btnHepsiniGetir.BackColor = Color.RoyalBlue;
            btnHepsiniGetir.Font = new Font("Cambria", 15F, FontStyle.Bold);
            btnHepsiniGetir.ForeColor = Color.White;
            btnHepsiniGetir.Location = new Point(119, 345);
            btnHepsiniGetir.Name = "btnHepsiniGetir";
            btnHepsiniGetir.Size = new Size(115, 57);
            btnHepsiniGetir.TabIndex = 6;
            btnHepsiniGetir.Text = "Hepsini Getir";
            btnHepsiniGetir.UseVisualStyleBackColor = false;
            btnHepsiniGetir.Click += btnHepsiniGetir_Click_1;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Name = "Anasayfa";
            Size = new Size(940, 615);
            Load += Anasayfa_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataAll).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label lblOgrenciSayisi;
        private Label label6;
        private Panel panel4;
        private Label lblKullaniciSayisi;
        private Label label8;
        private Label label4;
        private Label lblOgretmenSayisi;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private DataGridView dataAll;
        private ComboBox cmbRol;
        private Label label2;
        private Panel panel5;
        private TextBox txtTelefon;
        private Label label9;
        private TextBox txtEposta;
        private Label label7;
        private TextBox txtSoyad;
        private Label label5;
        private TextBox txtAd;
        private Label label3;
        private Button btnAra;
        private Button btnHepsiniGetir;
    }
}
