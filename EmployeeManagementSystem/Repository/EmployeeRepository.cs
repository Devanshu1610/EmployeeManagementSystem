using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repository
{
    public class EmployeeRepository : Repository<Employee>,IEmployeeRepository
    {
        private EmployeeDBContext _dbContext;

        public EmployeeRepository(EmployeeDBContext context) : base(context)
        {
            _dbContext = context;
        }

        public Employee UpdateEmployee(int id,Employee entity)
        {
            var existingemployee = _dbContext.Employees.Where(e => e.Id == id).FirstOrDefault();
            existingemployee.Name = entity.Name;
            existingemployee.Department = entity.Department;
            existingemployee.ManagerName = entity.ManagerName;
            existingemployee.Rating = entity.Rating;
            existingemployee.CTC = entity.CTC;
            existingemployee.DateOfJoining = entity.DateOfJoining;
            existingemployee.BaseSalary = entity.BaseSalary;
            existingemployee.WorkLocation = entity.WorkLocation;
            existingemployee.TechnologyStack = entity.TechnologyStack;

            return existingemployee;

        }
        /// <summary>
        /// Check if Employee exit in da
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool EmployeeExist(int id)
        {
            var employeeObj = _dbContext.Employees.Where(e => e.Id == id).FirstOrDefault();
            if (employeeObj != null)
                return true;

            return false;
        }

        public string GetHikePercentageForEmployee(int id)
        {
            var employeeRating = _dbContext.Employees.Where(e => e.Id == id).FirstOrDefault().Rating;

            if (employeeRating == 0)
            {
                return "No rating assigned";
            }
            else if (employeeRating < 5)
            {
                return "Terminate Employee";
            }
            else if (employeeRating == 6)
            {
                return "10%";
            }
            else if (employeeRating == 7)
            {
                return "20%";
            }
            else if (employeeRating >= 8)
            {
                return "50%";
            }
            else
            {
                return "75%";
            }

            
        }

        public string GetBonusByEmployeeId(int id)
        {
            var employeDOJ = _dbContext.Employees.Where(e => e.Id == id).FirstOrDefault().DateOfJoining;
            int yearOfService = CalculateYearOfService(employeDOJ);

            if (yearOfService < 5)
            {
                return "10%";
            }
            else if (yearOfService >= 6 && yearOfService < 10)
            {
                return "20%";
            }
            else if ((yearOfService>= 10) && (yearOfService <=20))
            {
                return "30%";

            }
            else {
                return "50%";
            }
        }

        private int CalculateYearOfService(DateTime dateOfJoining)
        {
            return (DateTime.Today.Year - dateOfJoining.Year);

        }
    }
}
