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
    public partial class OgretmenYonetim : UserControl
    {
        public OgretmenYonetim()
        {
            InitializeComponent();
        }

        UniversiteDbContext dbContext = new UniversiteDbContext();
        private void OgretmenYonetim_Load(object sender, EventArgs e)
        {
            var bolumDataContext = dbContext.Bolumler.ToList();
            foreach (var bolumler in bolumDataContext.Select(x => x.BolumAdi))
            {
                cmbBolum.Items.Add(bolumler);
            }

            GetAllData();
        }

        private void GetAllData()
        {
            var bolumData = dbContext.Bolumler.ToList();
            var ogretmenData = dbContext.OgretimGorevlileri.ToList();

            var data = from ogretmen in ogretmenData
                       join bolum in bolumData on ogretmen.BolumID equals bolum.ID
                       select new
                       {
                           ogretmen.Ad,
                           ogretmen.Soyad,
                           ogretmen.Eposta,
                           ogretmen.Telefon,
                           bolum.BolumAdi,
                           ogretmen.ID,
                       };
            dataOgretmenler.DataSource = data.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSoyad.Text == string.Empty || txtAd.Text == string.Empty || txtEposta.Text == string.Empty || txtTelefon.Text == string.Empty)
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz");
            }
            else
            {
                try
                {
                    OgretimGorevlisiRepository ogretimGorevlisi = new OgretimGorevlisiRepository(dbContext);
                    OgretimGorevlisiService ogretimGorevlisiService = new OgretimGorevlisiService(ogretimGorevlisi);
                    BolumRepository bolumRepository = new BolumRepository(dbContext);
                    BolumService bolumService = new BolumService(bolumRepository);

                    string secilenBolumAdi = cmbBolum.SelectedItem.ToString();

                    Guid bolumID = bolumService.GetAll().Where(x => x.BolumAdi == secilenBolumAdi).Select(x => x.ID).FirstOrDefault();

                    OgretimGorevlisi ogretmen = new OgretimGorevlisi()
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Eposta = txtEposta.Text,
                        Telefon = txtTelefon.Text,
                        BolumID = bolumID

                    };

                    ogretimGorevlisiService.Add(ogretmen);
                    MessageBox.Show("Öğretmen başarıyla eklendi");
                    GetAllData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Lütfen ID kısmını doldurunuz");
            }
            else
            {
                try
                {
                    OgretimGorevlisiRepository ogretimGorevlisiRepository = new OgretimGorevlisiRepository(dbContext);
                    OgretimGorevlisiService gorevlisiService = new OgretimGorevlisiService(ogretimGorevlisiRepository);

                    gorevlisiService.Delete(Guid.Parse(txtID.Text));
                    MessageBox.Show("Öğretmen başarıyla silindi");
                    GetAllData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            GetAllData();
        }
    }
}
