using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteYonetimSistemi.Entities.Models;
using UniversiteYonetimSistemi.UI.Forms.AdminControlForms;
using UniversiteYonetimSistemi.UI.Forms.AdminUserControlForms;

namespace UniversiteYonetimSistemi.UI.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm(string kullaniciAdi)
        {
            InitializeComponent();
            lblName.Text = $"Kullanıcı Adı: {kullaniciAdi}";
        }

        private Dictionary<string, UserControl> dicUserControlForms = new Dictionary<string, UserControl>()
        {
            {"Anasayfa",new Anasayfa()},
            {"KullaniciYonetim", new KullaniciYonetim()},
            {"OgrenciYonetim",new OgrenciYonetim()},
            {"OgretmenYonetim",new OgretmenYonetim() },
            {"Ayarlar",new Ayarlar()}
        };
        private void AdminForm_Load(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;
            lblTarih.Text = $"Tarih: {currentDate.ToString("dd/MM/yyyy")}";
            lblSaat.Text = $"Saat: {currentDate.ToString("HH:mm:ss")}";
            btnAnasayfa.PerformClick();
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            lblSaat.Text = $"Saat: {currentDate.ToString("HH:mm:ss")}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool isClicked;
        Point oldLocation;
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            oldLocation = e.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                this.Location = new Point(this.Location.X + e.X - oldLocation.X, this.Location.Y + e.Y - oldLocation.Y);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            ChangeButtonsColor("btnOgrenci");
            ChangeUserControlForms("OgrenciYonetim");
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            ChangeButtonsColor("btnOgretmen");
            ChangeUserControlForms("OgretmenYonetim");
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            ChangeButtonsColor("btnKullanici");
            ChangeUserControlForms("KullaniciYonetim");
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            ChangeButtonsColor("btnAnasayfa");
            ChangeUserControlForms("Anasayfa");
        }
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            ChangeButtonsColor("btnAyarlar");
            ChangeUserControlForms("Ayarlar");
        }

        private void ChangeUserControlForms(string formName)
        {
            foreach (UserControl control in dicUserControlForms.Values)
            {

                if (control != null && control.Name == formName)
                {
                    this.Controls.Add(control);
                    control.Show();
                    control.Location = new Point(260, 65);
                    control.BringToFront();
                }
                else
                {
                    control?.Hide();
                }
            }
        }

        private void ChangeButtonsColor(string btnName)
        {
            foreach (var controls in pnlLeft.Controls)
            {
                if (controls is Button)
                {
                    Button btn = controls as Button;
                    if (btn?.Name == btnName)
                    {
                        btn.BackColor = Color.RoyalBlue;
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(24, 25, 80);
                    }
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istiyor musun?", "Onay", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
