using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.Entities.Models
{
<<<<<<< HEAD
<<<<<<<< HEAD:UniversiteYonetimSistemi.Entities/Models/DersAtama.cs
    public class DersAtama:BaseEntity
    {
        public Guid AtamaID {  get; set; } = Guid.NewGuid();

        public int DersID { get; set; }

        public int OgretimGorevlisiID { get; set; }

        public Ders Ders {  get; set; }

        public OgretimGorevlisi OgretimGorevlisi { get; set; }

    public class Fakulte:BaseEntity
    {
        public string FakulteAdi { get; set; }
        public ICollection<Bolum> Bolumler { get; set; }s
    public class Fakulte:BaseEntity
    {
        public string FakulteID { get; set; }
    public class DersAtama:BaseEntity
    {
        public Ders Ders { get; set;}
        public OgretimGorevlisi OgretimGorevlisi { get; set; }
    }
}
