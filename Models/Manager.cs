using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkFromKPMG.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public string ManagerName { get; set; }
        public string ManagerSurname { get; set; }
        public DateTime ManagerEmployment { get; set; }
        

        public ICollection<Employee> Employees { get; set; }
    }
}
