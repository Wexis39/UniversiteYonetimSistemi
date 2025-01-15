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
    public partial class KullaniciYonetim : UserControl
    {
        public KullaniciYonetim()
        {
            InitializeComponent();
        }

        KullaniciService kullaniciService;
        UniversiteDbContext universiteDbContext = new UniversiteDbContext();
        private void KullaniciYonetim_Load(object sender, EventArgs e)
        {
            KullaniciRepository kullaniciRepository = new KullaniciRepository(universiteDbContext);
            kullaniciService = new KullaniciService(kullaniciRepository);
            GetAllData();

            cmbRoller.Items.AddRange(new string[] { "Ogretmen", "Ogrenci" });
        }

        private void GetAllData()
        {
            dataKullanici.DataSource = universiteDbContext.Kullanicilar.ToList().Select(x => new
            {
                x.ID,
                x.KullaniciAdi,
                x.Rol,

            }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRoller.SelectedIndex == -1)
                {
                    MessageBox.Show("Rol boş olamaz.");
                }
                else
                {
                    var kullaniciKayitliMi = universiteDbContext.Kullanicilar.ToList().Where(x => x.KullaniciAdi == txtKullaniciAdi.Text).FirstOrDefault();
                    if (kullaniciKayitliMi!=null)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kayıtlı");
                    }
                    else
                    {
                        Kullanici kullanici = new Kullanici()
                        {
                            KullaniciAdi = txtKullaniciAdi.Text,
                            Sifre = txtSifre.Text,
                            Rol = cmbRoller.SelectedItem.ToString()
                        };

                        kullaniciService.Add(kullanici);
                        GetAllData();

                        MessageBox.Show("Kullanıcı başarıyla eklendi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string kullaniciAdiArama = txtKullaniciAra.Text;
            if (kullaniciAdiArama == string.Empty)
            {
                MessageBox.Show("Lütfen kullanıcı adı giriniz");
            }
            else
            {
                dataKullanici.DataSource = universiteDbContext.Kullanicilar.ToList().Where(x => x.KullaniciAdi == kullaniciAdiArama).Select(x => new
                {
                    x.ID,
                    x.KullaniciAdi,
                    x.Rol,

                }).ToList();
            }
        }

        private void btnHepsiniGetir_Click(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Lütfen bir ID giriniz");
            }
            else
            {
                try
                {
                    kullaniciService.Delete(Guid.Parse(txtID.Text));
                    MessageBox.Show("Kullanıcı başarıyla silindi");
                    GetAllData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
