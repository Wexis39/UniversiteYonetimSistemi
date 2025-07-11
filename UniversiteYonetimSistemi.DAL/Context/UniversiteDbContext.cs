﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<DersAtama> DersAtamalari { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<OgrenciDersKayit> OgrenciDersKayitlari { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgretimGorevlisi> OgretimGorevlileri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial Catalog=UniversiteDB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OgrenciDersKayit>()
                .HasOne(odk => odk.Ogrenci)
                .WithMany(o => o.OgrenciDersKayitlari)
                .HasForeignKey(odk => odk.OgrenciID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OgrenciDersKayit>()
                .HasOne(odk => odk.Ders)
                .WithMany(d => d.OgrenciDersKayitlari)
                .HasForeignKey(odk => odk.DersID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DersAtama>()
                .HasOne(d => d.OgretimGorevlisi)
                .WithMany()
                .HasForeignKey(d => d.OgretimGorevlisiID)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
