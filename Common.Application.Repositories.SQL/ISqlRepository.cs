using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Repositories.SQL
{
    public interface ISqlRepository<TEntity>
    {
        void Add(TEntity entity);
        Task<int> AddAsync(TEntity entity);
        Task<string> AddOneAsync(TEntity entity);
        long Count(Expression<Func<TEntity, bool>> filter);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> filter);
        TEntity FindOne(params object[] keyValues);
        ValueTask<TEntity> FindOneAsync(params object[] keyValues);
        IList<TEntity> FindAll();
        Task<List<TEntity>> FindAllAsync();
        void Remove(TEntity entity);
        void Remove(params object[] keyValues);
        void Update(TEntity entity);
    }
}
