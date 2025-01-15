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
    public partial class OgrenciYonetim : UserControl
    {
        public OgrenciYonetim()
        {
            InitializeComponent();
        }

        UniversiteDbContext dbContext = new UniversiteDbContext();
        private void OgrenciYonetim_Load(object sender, EventArgs e)
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
            var ogrenciDataContext = dbContext.Ogrenciler.ToList();
            var bolumDataContext = dbContext.Bolumler.ToList();

            var data = from ogrenci in ogrenciDataContext
                       join bolum in bolumDataContext on ogrenci.BolumID equals bolum.ID
                       select new
                       {
                           ogrenci.ID,
                           ogrenci.Ad,
                           ogrenci.Soyad,
                           bolum.BolumAdi,
                           ogrenci.DogumTarihi,
                           ogrenci.Eposta,
                           ogrenci.Telefon,
                           ogrenci.Adres
                       };
            dataOgrenciler.DataSource = data.ToList();
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
                    OgrenciRepository ogrenciRepository = new OgrenciRepository(dbContext);
                    OgrenciService ogrenciService = new OgrenciService(ogrenciRepository);

                    ogrenciService.Delete(Guid.Parse(txtID.Text));
                    MessageBox.Show("Öğrenci başarıyla silindi");
                    GetAllData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSoyad.Text == string.Empty || txtAd.Text == string.Empty || txtEposta.Text == string.Empty ||
                string.IsNullOrEmpty(txtDogum.Text) || txtTC.Text == string.Empty || txtTelefon.Text == string.Empty
                )
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz");
            }
            else
            {
                try
                {
                    OgrenciRepository ogrenciRepository = new OgrenciRepository(dbContext);
                    BolumRepository bolumRepository = new BolumRepository(dbContext);
                    OgrenciService ogrenciService = new OgrenciService(ogrenciRepository);
                    BolumService bolumService = new BolumService(bolumRepository);

                    string secilenBolumAdi = cmbBolum.SelectedItem.ToString();

                    Guid bolumID = bolumService.GetAll().Where(x => x.BolumAdi == secilenBolumAdi).Select(x => x.ID).FirstOrDefault();

                    Ogrenci ogrenci = new Ogrenci()
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Eposta = txtEposta.Text,
                        DogumTarihi = DateTime.Parse(txtDogum.Text),
                        TCNo = txtTC.Text,
                        Telefon = txtTelefon.Text,
                        Adres = txtAdres.Text,
                        BolumID=bolumID

                    };

                    ogrenciService.Add(ogrenci);
                    MessageBox.Show("Öğrenci başarıyla eklendi");
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
