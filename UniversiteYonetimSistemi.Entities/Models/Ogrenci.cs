using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UniversiteYonetimSistemi.Entities.Abstractions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class Ogrenci:BaseEntity
    {
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? TCNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }
        public string? Adres { get; set; }
        public Guid BolumID { get; set; }
        public Bolum? Bolum { get; set; }
        public ICollection<OgrenciDersKayit>? OgrenciDersKayitlari { get; set; }
    }
}