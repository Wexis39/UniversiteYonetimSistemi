using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class OgretimGorevlisi:BaseEntity
    {
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }
        public Guid BolumID { get; set; }
        public Bolum? Bolum { get; set; }
        public ICollection<DersAtama>? DersAtamalari { get; set; }
    }
}