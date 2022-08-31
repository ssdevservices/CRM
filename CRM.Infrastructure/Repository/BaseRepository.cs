using CRM.Domain.Repository;
using CRM.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CRM.Infrastructure.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> DbSet;
        private readonly CRMDbContext CRMDbContext;

        public BaseRepository(CRMDbContext cRMDbContext)
        {
            CRMDbContext = cRMDbContext;
            DbSet = CRMDbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] properties)
        {
            var query = DbSet as IQueryable<TEntity>;

            query = properties.Aggregate(query, (current, property) => current.Include(property));

            return query.AsNoTracking().AsEnumerable();
        }

        public TEntity GetById(int Id)
        {
            return DbSet.Find(Id);
        }

        public int SaveChanges()
        {
            return -1;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }
    }
}
