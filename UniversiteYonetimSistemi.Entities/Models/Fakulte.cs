using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
<<<<<<<< HEAD:UniversiteYonetimSistemi.Entities/Models/Fakulte.cs
    public class Fakulte:BaseEntity
    {
        public int OgretimGorevlisiID { get; set; }
        public ICollection<Bolum> Bolumler { get; set; }; 
    {
    }
}
