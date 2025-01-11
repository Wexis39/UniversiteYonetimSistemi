using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class Ogrenci:BaseEntity
    {
        public Guid OgrenciID { get; set; } = Guid.NewGuid(); 
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string TCNo { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Eposta { get; set; }

        public string Telefon { get; set; }

        public string Adres { get; set; }

        public Bolum Bolum { get; set; }

        public ICollection<OgrenciDersKayit> OgrenciDersKayitlari { get; set; };

        public Kullanici Kullanici { get; set; }
    }
}
