using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class OgrenciDersKayitlari:BaseEntity
    {
        public int KayitID { get; set; }

        public int OgrenciID { get; set; }

        public int DersID { get; set; }

        public decimal Not { get; set; }

    }
}
