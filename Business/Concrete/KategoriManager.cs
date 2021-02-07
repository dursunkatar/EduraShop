using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        private readonly IKategoriDal _kategoriDal;
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }
        public async Task AddAsync(Kategori entity)
        {
            await _kategoriDal.AddAsync(entity);
        }

        public void Delete(Kategori entity)
        {
            _kategoriDal.Delete(entity);
        }

        public async Task<IEnumerable<Kategori>> GetAllAsync(Expression<Func<Kategori, bool>> filter = null)
        {
            return await _kategoriDal.GetAllAsync(filter);
        }

        public async Task<Kategori> GetAsync(Expression<Func<Kategori, bool>> filter)
        {
            return await _kategoriDal.GetAsync(filter);
        }

        public IEnumerable<Kategori> KategorilerWithUrunAdet()
        {
            return _kategoriDal.KategorilerWithUrunAdet();
        }

        public void Update(Kategori entity)
        {
            _kategoriDal.Update(entity);
        }
    }
}
