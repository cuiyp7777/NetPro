using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace XEngine.Repositories
{
    //使用泛型抽象
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> fileter = null, 
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, 
            string includeProperties = "");

        TEntity GetById(object id);


        void Insert(TEntity entity);
        void Delete(object id);
        void Update(TEntity entity);
        void Save();
    }
}
