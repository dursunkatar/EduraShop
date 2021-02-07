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
    public class UrunManager : IUrunService
    {
        private readonly IUrunDal _urunDal;
        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }
        public async Task AddAsync(Urun entity)
        {
            await _urunDal.AddAsync(entity);
        }

        public void Delete(Urun entity)
        {
            _urunDal.Delete(entity);
        }

        public async Task<IEnumerable<Urun>> GetAllAsync(Expression<Func<Urun, bool>> filter = null)
        {
            return await _urunDal.GetAllAsync(filter);
        }

        public async Task<Urun> GetAsync(Expression<Func<Urun, bool>> filter)
        {
            return await _urunDal.GetAsync(filter);
        }

        public void Update(Urun entity)
        {
            _urunDal.Update(entity);
        }
    }
}
