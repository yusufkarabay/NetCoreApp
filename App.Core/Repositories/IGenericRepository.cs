using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

        //list olarak kullanılsaydı. verileri alır sorgulama işlemini burada yapardı
        //IQueryable ise sorgunun tamamını veritabanında yapar ve sonucu getirir
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(Guid id);
        void DeleteRange(IEnumerable<T> entities);
    }
}
