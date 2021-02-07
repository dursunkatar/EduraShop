using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Seeds
{
    public class UrunSeed : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.HasData(
                new Urun { KategoriId = 6, UrunId = 1, UrunAdi = "Photo Camera", UrunFiyati = 153, UrunStok = 220, UrunResmi = "product1" },
                new Urun { KategoriId = 4, UrunId = 2, UrunAdi = "Wood Chair", UrunFiyati = 99, UrunStok = 302, UrunResmi = "product2" },
                new Urun { KategoriId = 4, UrunId = 3, UrunAdi = "Comfortable Sofa", UrunFiyati = 526, UrunStok = 693, UrunResmi = "product3" },
                new Urun { KategoriId = 4, UrunId = 4, UrunAdi = "Hand Bag", UrunFiyati = 125, UrunStok = 56, UrunResmi = "product4" }
                );
        }
    }
}
