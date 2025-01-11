using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class OgrenciDersKayit:BaseEntity
    {
        public float Not { get; set; }
        public Guid DersID { get; set; }
        public Ders? Ders { get; set; }
        public Guid OgrenciID { get; set; }
        public Ogrenci? Ogrenci { get; set; }
    }
}
