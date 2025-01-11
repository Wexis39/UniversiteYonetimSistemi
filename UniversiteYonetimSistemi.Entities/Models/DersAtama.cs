using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class DersAtama:BaseEntity
    {
        public Guid DersID { get; set; }
        public Ders? Ders { get; set; }
        public Guid OgretimGorevlisiID { get; set; }
        public OgretimGorevlisi? OgretimGorevlisi { get; set; }
    }
}
