using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kategori : IEntity
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public virtual ICollection<Urun> Urunler { get; set; }
    }
}
