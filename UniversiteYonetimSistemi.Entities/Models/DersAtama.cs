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
        public Guid AtamaID {  get; set; } = Guid.NewGuid();

        public int DersID { get; set; }

        public int OgretimGorevlisiID { get; set; }
    }
}
