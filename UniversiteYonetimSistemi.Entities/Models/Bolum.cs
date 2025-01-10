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
        public string BolumAdi { get; set; }
        public Guid FakulteID { get; set; }
        public Fakulte Fakulte { get; set; }
    }
}
