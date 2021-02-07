using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configurations
{
    public class KategoriConfiguration : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(x => x.KategoriId);
            builder.Property(x => x.KategoriId).UseIdentityColumn();
            builder.Property(x => x.KategoriAdi).IsRequired().HasMaxLength(50);
            builder.ToTable("Kategoriler");
        }
    }
}
