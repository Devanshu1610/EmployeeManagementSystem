using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace EmployeeManagementSystem.Controllers
{
 
    [ApiController]
    public class EmployeeCollectionController : ControllerBase
    {

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeCollectionController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));


        }

        [HttpPost]
        [Route("api/[controller]")]
        public ActionResult<IEnumerable<Employee>> CreateEmployeeInBulk(IEnumerable<Employee> employeesCollection)
        {
            foreach (var employee in employeesCollection)
            {
                _employeeRepository.Add(employee);
                _employeeRepository.Save();
            }
            

            return Ok();
        }

        [HttpPut]
        [Route("api/[controller]/UpdateBulk")]
        public ActionResult<IEnumerable<Employee>> UpdateEmployeeInBulk([FromQuery]int [] Id,IEnumerable<Employee> employeesCollection)
        {
            int i = 0;
            foreach (var emp in employeesCollection)
            {
                if (_employeeRepository.EmployeeExist(Id[i]))
                {
                    _employeeRepository.UpdateEmployee(Id[i], emp);
                    _employeeRepository.Save();
                    
                }
                i++;
            }


            return Ok();
        }



    }
}
