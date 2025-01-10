using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class Bolum:BaseEntity
    {
        public Guid BolumID {  get; set; } = Guid.NewGuid();

        public string BolumAdi { get; set; } 
        
        public int FakulteID { get; set; }

        public ICollection <Ders> Ders { get; set; }
    }
}
