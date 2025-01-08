using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class Dersler:BaseEntity
    {
        public int DersID {  get; set; }

        public string DersAdi { get; set; }

        public int Kredi { get; set; }

        public int BolumID { get; set; }
    }
}
