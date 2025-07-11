﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UniversiteYonetimSistemi.Entities.Abstractions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniversiteYonetimSistemi.Entities.Models
{
    public class Bolum:BaseEntity
    {
        public string? BolumAdi { get; set; }
        public Guid FakulteID { get; set; }
        public Fakulte? Fakulte { get; set; }
        public ICollection<Ogrenci>? Ogrenciler { get; set; }
        public ICollection<Ders>? Dersler { get; set; }
        public ICollection<OgretimGorevlisi>? OgretimGorevlileri { get; set; }
    }
}
