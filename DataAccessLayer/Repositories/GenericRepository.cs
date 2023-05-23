using BusinessObjects.Models;
using DataAccessLayer.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly FUFlowerBouquetManagementContext _context;

        public GenericRepository(FUFlowerBouquetManagementContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;

        }

        public TEntity FindByField(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes)
        => includes
           .Aggregate(_context.Set<TEntity>().AsQueryable(),
               (entity, property) => entity.Include(property)).AsNoTracking()
           .Where(expression).FirstOrDefault();

        public List<TEntity> FindList(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes)
        =>  includes
           .Aggregate(_context.Set<TEntity>().AsQueryable(),
               (entity, property) => entity.Include(property)).AsNoTracking()
           .Where(expression).ToList();


        public List<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {
            return  includes
           .Aggregate(_context.Set<TEntity>().AsQueryable(),
               (entity, property) => entity.Include(property)).AsNoTracking()
           .ToList();

        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Detached(Expression<Func<TEntity, bool>> expression)
        {
            var entity=_context.Set<TEntity>().Where(expression).FirstOrDefault();
            _context.Entry(entity).State = EntityState.Detached;
            _context.SaveChanges();
        }
    }
}
