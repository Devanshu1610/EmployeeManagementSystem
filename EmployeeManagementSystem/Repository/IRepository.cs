using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repository
{
    public interface IRepository<TEntity> where TEntity:class
    {

        TEntity Get(int Id);
        IEnumerable<TEntity> GetALL();

        void Add(TEntity entity);
        void AddBulk(IEnumerable<TEntity> entities);


        void Delete(TEntity entity);
        void DeleteBulk(IEnumerable<TEntity> entities);

        void Save();




    }
}
