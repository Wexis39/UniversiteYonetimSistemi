using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class DersAtamalari:BaseEntity
    {
        public int AtamaID {  get; set; }

        public int DersID { get; set; }

        public int OgretimGorevlisiID { get; set; }
    }
}
