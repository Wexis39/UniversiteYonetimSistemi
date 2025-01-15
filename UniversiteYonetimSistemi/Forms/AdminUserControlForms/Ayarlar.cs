using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteYonetimSistemi.Business.Services;
using UniversiteYonetimSistemi.DAL.Context;
using UniversiteYonetimSistemi.DAL.Repositories;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.UI.Forms.AdminUserControlForms
{
    public partial class Ayarlar : UserControl
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        UniversiteDbContext dbContext = new UniversiteDbContext();
        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            KullaniciRepository KullaniciRepository = new KullaniciRepository(dbContext);
            KullaniciService KullaniciService = new KullaniciService(KullaniciRepository);

            if (txtEskiSifre.Text == string.Empty || txtKullaniciAdiSifre.Text == string.Empty || txtYeniSifre.Text == string.Empty || txtYeniSifreTekrar.Text == string.Empty)
            {
                MessageBox.Show("Lütfen bilgilerinizi doldurunuz");
            }
            else
            {
                if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler uyuşmuyor");
                }
                else
                {
                    try
                    {
                        Guid isFound = KullaniciService.GetAll().Where(x => x.KullaniciAdi == txtKullaniciAdiSifre.Text && x.Sifre == txtEskiSifre.Text).Select(x => x.ID).FirstOrDefault();

                        if (isFound == Guid.Empty)
                        {
                            MessageBox.Show("Bilgileriniz yanlış");
                        }
                        else
                        {
                            Kullanici kullanici = KullaniciService.GetById(isFound);
                            kullanici.Sifre = txtYeniSifre.Text;
                            KullaniciService.Update(kullanici);
                            MessageBox.Show("Şifre başarılı bir şekilde değişti");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnKullaniciDegistir_Click(object sender, EventArgs e)
        {
            KullaniciRepository KullaniciRepository = new KullaniciRepository(dbContext);
            KullaniciService KullaniciService = new KullaniciService(KullaniciRepository);

            if (txtYeniNick.Text == string.Empty || txtEskiNick.Text == string.Empty || txtSifreKullanici.Text == string.Empty)
            {
                MessageBox.Show("Lütfen bilgilerinizi doldurunuz");
            }
            else
            {
                Guid isFound = KullaniciService.GetAll().Where(x => x.KullaniciAdi == txtEskiNick.Text && x.Sifre == txtSifreKullanici.Text).Select(x => x.ID).FirstOrDefault();

                if (isFound== Guid.Empty)
                {
                    MessageBox.Show("Bilgileriniz yanlış");
                }
                else
                {
                    try
                    {
                        Kullanici kullanici = KullaniciService.GetById(isFound);
                        kullanici.KullaniciAdi = txtYeniNick.Text;
                        KullaniciService.Update(kullanici);
                        MessageBox.Show("Kullanıcı adı başarılı bir şekilde değişti");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
