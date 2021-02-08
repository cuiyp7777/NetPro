using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using XEngine.DAL;

namespace XEngine.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        internal XEngineContext _context;
        internal DbSet<TEntity> _dbSet;

        public GenericRepository(XEngineContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();//db.SysUser
        }
        public IEnumerable<TEntity> Get()
        {
            return _dbSet.ToList();
        }
        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> fileter = null,
          Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (fileter != null)
            {
                query = query.Where(fileter);
            }
            foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(item);
            }
            if (orderBy!=null)
            {
                return orderBy(query).ToList();
            }
            return query.ToList();
        }
        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }
        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(object id)
        {
            TEntity entity = _dbSet.Find(id);
            Delete(entity);
        }
        public virtual void Delete(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Save()
        {
            _context.SaveChanges();
        }


    }
}