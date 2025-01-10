using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class OgretimGorevlisi:BaseEntity
    {
        public Guid OgretimGorevlisiID { get; set; } = Guid.NewGuid();

        public string Ad { get; set; }  
        
        public string Soyad { get; set; }

        public string Eposta { get; set; }  

        public string Telefon { get; set; } 

        public int BolumID { get; set; }

    }
}
