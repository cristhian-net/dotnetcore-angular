using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using dotnetcore.Models;
using System.Threading.Tasks;

namespace dotnetcore.Repository
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Guid id);
        void Edit(TEntity entity);

        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> Filter();
        Task<IEnumerable<TEntity>> Filter(Expression<Func<TEntity, bool>> predicate);

        //separate method SaveChanges can be helpful when using this pattern with UnitOfWork
        Task<bool> SaveChanges();
    }
}