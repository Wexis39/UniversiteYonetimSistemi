using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class Ogrenciler:BaseEntity
    {
        public int OgrenciID { get; set; }

        public string OgrenciAdi { get; set; }

        public string OgrenciSoyAdi { get; set; }

        public string TCNo { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Eposta { get; set; }

        public string Telefon { get; set; }

        public string Adres { get; set; }

        public int BolumID {  get; set; }

    }
}
