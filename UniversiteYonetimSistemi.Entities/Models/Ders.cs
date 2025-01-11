using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class Ders:BaseEntity
    {
        public string? DersAdi { get; set; }
        public int Kredi { get; set; }
        public Guid BolumID { get; set; }
        public Bolum? Bolum { get; set; }
        public ICollection<OgrenciDersKayit>? OgrenciDersKayitlari { get; set; }
        public ICollection<DersAtama>? DersAtamalari { get; set; }
    }
}
