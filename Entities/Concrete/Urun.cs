using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Urun : IEntity
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int UrunStok { get; set; }
        public string UrunResmi { get; set; }
        public int KategoriId { get; set; }
        public bool IsFeatured { get; set; }
        public Kategori Kategori { get; set; }
    }
}
