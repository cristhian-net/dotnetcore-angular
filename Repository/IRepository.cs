using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using dotnetcore.Models;

namespace dotnetcore.Repository
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Guid id);
        void Edit(TEntity entity);

        TEntity GetById(Guid id);
        IEnumerable<TEntity> Filter();
        IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);

        //separate method SaveChanges can be helpful when using this pattern with UnitOfWork
        void SaveChanges();
    }
}