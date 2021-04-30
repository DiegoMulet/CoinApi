using Coin.Application.Interfaces;
using Coin.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ons.Simons.Application
{
    public class BaseAppService<TEntity> : IDisposable, IBaseAppService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> _serviceBase;

        public BaseAppService(IBaseService<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public async Task Add(TEntity entity)
        {
            await _serviceBase.Add(entity);
        }

        public async Task Update(TEntity entity)
        {
            await _serviceBase.Update(entity);
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await _serviceBase.Search(predicate);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _serviceBase.GetById(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _serviceBase.GetAll();
        }

        public async Task Delete(TEntity entity)
        {
            await _serviceBase.Delete(entity);
        }

        public async Task<int> SaveChanges()
        {
            return await _serviceBase.SaveChanges();
        }
    }
}
