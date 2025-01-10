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
        public Guid KayitID { get; set; } = Guid.NewGuid();

        public int OgrenciID { get; set; }

        public int DersID { get; set; }

        public decimal Not { get; set; }

    }
}
