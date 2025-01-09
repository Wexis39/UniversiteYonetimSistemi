using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Models;

namespace UniversiteYonetimSistemi.DAL.Context
{
    public class UniversiteDbContext:DbContext
    {
        public DbSet<Bolumler> Bolumler { get; set; }
        public DbSet<DersAtamalari> DersAtamalari { get; set; }
        public DbSet<Dersler> Derslers { get; set; }
        public DbSet<Fakulteler> Fakulteler { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<OgrenciDersKayitlari> OgrenciDersKayitlari { get; set; }
        public DbSet<Ogrenciler> Ogrenciler { get; set; }
        public DbSet<OgretimGorevlileri> OgretimGorevlileri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
