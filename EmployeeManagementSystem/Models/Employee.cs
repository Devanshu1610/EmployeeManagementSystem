using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        [Key]

        public int Id { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="Name can only be 50 char long ")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Department can only be 50 char long ")]
        public string Department { get; set; }

        [MaxLength(50, ErrorMessage = "Work Location can only be 50 char long ")]
        public string WorkLocation { get; set; }

        [MaxLength(50, ErrorMessage = "Technology can only be 50 char long ")]
        public string TechnologyStack { get; set; }

        public DateTime DateOfJoining { get; set; }

        public int Rating { get; set; }

        public int  CTC { get; set; }

        public int BaseSalary { get; set; }

        public string ManagerName { get; set; }
    }
}
