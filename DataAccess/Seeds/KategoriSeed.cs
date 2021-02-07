using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Seeds
{
    public class KategoriSeed : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasData(
                new Kategori { KategoriId = 1, KategoriAdi = "Furniture" },
                new Kategori { KategoriId = 2, KategoriAdi = "Electronics" },
                new Kategori { KategoriId = 3, KategoriAdi = "Books" },
                new Kategori { KategoriId = 4, KategoriAdi = "Accessories" },
                new Kategori { KategoriId = 5, KategoriAdi = "Computers" },
                new Kategori { KategoriId = 6, KategoriAdi = "Cameras" }
                );
        }
    }
}
