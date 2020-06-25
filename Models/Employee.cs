using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkFromKPMG.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public DateTime DateEmployment { get; set; }

        public Manager Manager { get; set; }
        public int? ManagerId { get; set; }
    }
}
