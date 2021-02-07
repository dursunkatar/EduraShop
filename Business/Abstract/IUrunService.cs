using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUrunService
    {
        Task<IEnumerable<Urun>> GetAllAsync(Expression<Func<Urun, bool>> filter = null);
        Task<Urun> GetAsync(Expression<Func<Urun, bool>> filter);
        Task AddAsync(Urun entity);
        void Delete(Urun entity);
        void Update(Urun entity);
    }
}
