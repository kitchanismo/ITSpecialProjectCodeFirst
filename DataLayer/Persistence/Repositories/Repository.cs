
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataLayer.Core.Model;

namespace DataLayer.Persistence.Repositories
{

    public class Repository<TEntity> where TEntity : class, IEntity
    {
        protected readonly DbContext Context;

        private readonly DbSet<TEntity> _entities;

        public Repository(DbContext context)
        {
            Context = context;
            _entities = Context.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public IEnumerable<TEntity> GetAll(int skip, int take = 50)
        {
            return _entities.OrderBy(e=>e.Id).Skip(skip).Take(take).ToList();
        }

        public int Count()
        {
            return _entities.Count();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate).ToList();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _entities.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _entities.RemoveRange(entities);
        }
    }
}
