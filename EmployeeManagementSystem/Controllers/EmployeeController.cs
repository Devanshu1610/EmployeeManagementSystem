using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;


namespace EmployeeManagementSystem.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository?? throw new ArgumentNullException(nameof(employeeRepository));


        }

        [HttpGet]
        
        public IActionResult GetALLEmployee()
        {
          return  Ok(_employeeRepository.GetALL());
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetEmployeeDetails(int id)
        {
            var emp = _employeeRepository.Get(id);
            if (emp == null)
                return NotFound("Employe no found");


            return Ok(emp);
        }

        [HttpPost]

        public IActionResult CreateEmployee(Employee employee )
        {
            _employeeRepository.Add(employee);
            _employeeRepository.Save();     
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id,employee);
        }



        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteEmployee(int id)
        {

            if (!_employeeRepository.EmployeeExist(id))
            { return NotFound(); }

            var emp = _employeeRepository.Get(id);
            _employeeRepository.Delete(emp);
            _employeeRepository.Save();
            return NoContent();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            if (!_employeeRepository.EmployeeExist(id))
            { return NotFound("Employee not found"); }

         var updatedEmp=  _employeeRepository.UpdateEmployee(id,employee);
            _employeeRepository.Save();
            return Ok(updatedEmp);


        }

   
        [Route("{id}/HikePercentage")]
        public IActionResult GetHikePercentagebyEmpId(int id)
        {
             if (!_employeeRepository.EmployeeExist(id))
            { return NotFound("Employee not found"); }

            return Ok(_employeeRepository.GetHikePercentageForEmployee(id));

        }


        [Route("{id}/Bonus")]
        public IActionResult GetBonusByEmpId(int id)
        {
            if (!_employeeRepository.EmployeeExist(id))
            { return NotFound("Employee not found"); }

            return Ok(_employeeRepository.GetBonusByEmployeeId(id));

        }

    }
}