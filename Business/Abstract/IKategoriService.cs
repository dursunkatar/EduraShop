using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKategoriService
    {
        Task<IEnumerable<Kategori>> GetAllAsync(Expression<Func<Kategori, bool>> filter = null);
        Task<Kategori> GetAsync(Expression<Func<Kategori, bool>> filter);
        Task AddAsync(Kategori entity);
        void Delete(Kategori entity);
        void Update(Kategori entity);
        IEnumerable<Kategori> KategorilerWithUrunAdet();
    }
}
