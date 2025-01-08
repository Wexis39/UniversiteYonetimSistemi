using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class Kullanicilar:BaseEntity
    {
        public int KullaniciID { get; set; }

        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }

        public string Rol { get; set; }

    }
}
