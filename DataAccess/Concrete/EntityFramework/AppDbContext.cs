using DataAccess.Configurations;
using DataAccess.Seeds;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4U2UG6T\\SQLEXPRESS;Database=Edura;User Id=sa;Password=12345;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KategoriConfiguration());
            modelBuilder.ApplyConfiguration(new KategoriSeed());
            modelBuilder.ApplyConfiguration(new UrunConfiguration());
            modelBuilder.ApplyConfiguration(new UrunSeed());
        }
    }
}
