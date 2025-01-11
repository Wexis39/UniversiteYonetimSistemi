using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class Fakulte:BaseEntity
    {
        public string? FakulteAdi { get; set; }
        public ICollection<Bolum>? Bolumler { get; set; }
    }
}
