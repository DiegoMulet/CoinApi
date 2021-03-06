using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Coin.Domain.Interfaces
{    public interface IBaseService<TEntity> : IDisposable where TEntity : class
    {
        Task Add(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task Delete(Guid id);
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
