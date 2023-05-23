using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes);
        void Detached(Expression<Func<TEntity, bool>> expression);
        TEntity FindByField(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes);
        List<TEntity> FindList(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes);

    }
}
