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

        public TEntity Add(TEntity entity)
        {
            var result= _context.Set<TEntity>().Add(entity);
            return result.Entity;
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;

        }

        public TEntity FindByField(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes)
        => includes
           .Aggregate(_context.Set<TEntity>().AsQueryable(),
               (entity, property) => entity.Include(property))
           .Where(expression).FirstOrDefault();

        public List<TEntity> FindList(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes)
        =>  includes
           .Aggregate(_context.Set<TEntity>().AsQueryable(),
               (entity, property) => entity.Include(property))
           .Where(expression).ToList();


        public List<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {
            return  includes
           .Aggregate(_context.Set<TEntity>().AsQueryable(),
               (entity, property) => entity.Include(property))
           .ToList();

        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

        }
    }
}
