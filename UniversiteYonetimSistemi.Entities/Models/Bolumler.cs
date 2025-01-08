using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class Bolumler:BaseEntity
    {
        public int BolumID {  get; set; }
        
        public string BolumAdi { get; set; }
        
        public int FakulteID { get; set; }
    }
}
