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
using Microsoft.EntityFrameworkCore;

namespace UniversiteYonetimSistemi.UI.Forms.AdminControlForms
{
    public partial class Anasayfa : UserControl
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private readonly UniversiteDbContext _context;

        UniversiteDbContext context = new UniversiteDbContext();
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            lblKullaniciSayisi.Text = context.Kullanicilar.Count().ToString();
            lblOgrenciSayisi.Text = context.Ogrenciler.Count().ToString();
            lblOgretmenSayisi.Text = context.OgretimGorevlileri.Count().ToString();

            cmbRol.Items.AddRange(new string[] { "Öğretmen", "Öğrenci" });
            cmbRol.SelectedIndex = 0;
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllDataBySelection();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string cmbSelected = cmbRol.SelectedItem.ToString();

            if (cmbSelected == "Öğrenci")
            {
                var dataSearchOgrenci = context.Ogrenciler.ToList().Where(x => x.Ad == txtAd.Text || x.Soyad == txtSoyad.Text || x.Eposta == txtEposta.Text || x.Telefon == txtTelefon.Text);

                dataAll.DataSource = dataSearchOgrenci.ToList();
            }
            else if (cmbSelected == "Öğretmen")
            {
                var dataSearchOgretmen = context.OgretimGorevlileri.ToList().Where(x => x.Ad == txtAd.Text || x.Soyad == txtSoyad.Text || x.Eposta == txtEposta.Text || x.Telefon == txtTelefon.Text);

                dataAll.DataSource = dataSearchOgretmen.ToList();
            }
        }

        private void btnHepsiniGetir_Click(object sender, EventArgs e)
        {
            GetAllDataBySelection();
        }

        private void GetAllDataBySelection()
        {
            string cmbSelected = cmbRol.SelectedItem.ToString();
            if (cmbSelected == "Öğrenci")
            {
                dataAll.DataSource = context.Ogrenciler.ToList();
            }
            else if (cmbSelected == "Öğretmen")
            {
                dataAll.DataSource = context.OgretimGorevlileri.ToList();
            }
        }

        private void btnHepsiniGetir_Click_1(object sender, EventArgs e)
        {
            GetAllDataBySelection();
        }
    }
}