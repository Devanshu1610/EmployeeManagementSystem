using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repository
{
   public interface IEmployeeRepository:IRepository<Employee>
    {
        bool EmployeeExist(int id);

        Employee UpdateEmployee(int id,Employee entity);

        string GetHikePercentageForEmployee(int id);

        string GetBonusByEmployeeId(int id);


    }
}
