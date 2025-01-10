using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class Kullanici:BaseEntity
    {
        public Guid KullaniciID { get; set; } = Guid.NewGuid();

        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }

        public string Rol { get; set; }

    }
}
