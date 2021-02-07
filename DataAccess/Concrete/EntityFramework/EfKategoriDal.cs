using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKategoriDal : EfEntityRepositoryBase<Kategori, AppDbContext>, IKategoriDal
    {
        public IEnumerable<Kategori> KategorilerWithUrunAdet()
        {
            using (var context = new AppDbContext())
            {
                return context.Kategoriler.Include(m => m.Urunler).ToList();
            }
        }
    }
}
