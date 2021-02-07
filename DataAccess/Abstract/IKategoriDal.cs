using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IKategoriDal : IEntityRepository<Kategori>
    {
        IEnumerable<Kategori> KategorilerWithUrunAdet();
    }
}
