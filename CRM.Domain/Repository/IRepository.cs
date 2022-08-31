using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain.Repository
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(int Id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] properties);
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
