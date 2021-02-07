using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configurations
{
    public class UrunConfiguration : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.HasKey(x => x.UrunId);
            builder.Property(x => x.UrunId).UseIdentityColumn();
            builder.Property(x => x.UrunAdi).IsRequired().HasMaxLength(50);
            builder.Property(x => x.UrunFiyati).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.UrunStok).IsRequired();
            builder.Property(x => x.UrunResmi).HasMaxLength(55);
            builder.Property(x => x.IsFeatured).IsRequired();
            builder.ToTable("Urunler");
        }
    }
}
