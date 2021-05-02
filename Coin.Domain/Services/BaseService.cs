using Coin.Domain.Interfaces;
using Coin.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Coin.Domain.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository;

        public BaseService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task Add(TEntity entity)
        {
            await _repository.Add(entity);
        }

        public async Task Update(TEntity entity)
        {
            await _repository.Update(entity);
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repository.Search(predicate);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task Delete(Guid id)
        {
            await _repository.Delete(id);
        }

        public async Task<int> SaveChanges()
        {
            return await _repository.SaveChanges();
        }
    }
}
