using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity:class
    {
        protected readonly DbContext dbContext;
            
        public Repository(DbContext context)
        {
            dbContext = context;
        }

        public void Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        public void AddBulk(IEnumerable<TEntity> entities)
        {
            dbContext.Set<TEntity>().AddRange(entities);
        }

        public void Delete(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
        }

        public void DeleteBulk(IEnumerable<TEntity> entities)
        {
            dbContext.Set<TEntity>().RemoveRange();
        }

        public TEntity Get(int Id)
        {
            return dbContext.Set<TEntity>().Find(Id);
                
        }

        public IEnumerable<TEntity> GetALL()
        {
            return dbContext.Set<TEntity>().ToList();
        }

   

        public void Save()
        {
             dbContext.SaveChanges();
        }

      
    }
}
