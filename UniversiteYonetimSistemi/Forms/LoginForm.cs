using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteYonetimSistemi.DAL.Context;
using UniversiteYonetimSistemi.DAL.Repositories;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        bool isClicked;
        Point oldLocation;

        KullaniciRepository kullaniciRepository;
        UniversiteDbContext universiteDbContext;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            universiteDbContext = new UniversiteDbContext();
            kullaniciRepository = new KullaniciRepository(universiteDbContext);
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            oldLocation = e.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                this.Location = new Point(this.Location.X + (e.X - oldLocation.X), this.Location.Y + (e.Y - oldLocation.Y));
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked &= false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (kullaniciRolu == string.Empty)
            {
                MessageBox.Show("Lütfen bir kullanıcı türü seçiniz");
            }
            else
            {
                if (txtPassword.Text == string.Empty || txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre boş olamaz");
                }
                else
                {
                    var foundUser = kullaniciRepository.GetAll().Where(x => x.KullaniciAdi == txtUsername.Text && x.Rol == kullaniciRolu && x.Sifre == txtPassword.Text).FirstOrDefault();

                    if (foundUser == null)
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                    }
                    else
                    {
                        if (kullaniciRolu == "Admin")
                        {
                            AdminForm adminForm = new AdminForm(foundUser.KullaniciAdi.ToString());
                            this.Hide();
                            adminForm.Show();
                        }
                        else if(kullaniciRolu == "Ogretmen")
                        {

                        }
                        else if (kullaniciRolu == "Ogrenci")
                        {
                        }
                    }
                }
            }
        }

        private void txtHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        string kullaniciRolu = "";

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            kullaniciRolu = "Admin";
            btnOgrenci.BackColor = Color.FromArgb(52, 158, 232);
            btnAdmin.BackColor = Color.MidnightBlue;
            btnOgretmen.BackColor = Color.FromArgb(52, 158, 232);
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            kullaniciRolu = "Ogretmen";
            btnOgrenci.BackColor = Color.FromArgb(52, 158, 232);
            btnAdmin.BackColor = Color.FromArgb(52, 158, 232);
            btnOgretmen.BackColor = Color.MidnightBlue;
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            kullaniciRolu = "Ogrenci";
            btnOgrenci.BackColor = Color.MidnightBlue;
            btnAdmin.BackColor = Color.FromArgb(52, 158, 232);
            btnOgretmen.BackColor = Color.FromArgb(52, 158, 232);
        }
    }
}
