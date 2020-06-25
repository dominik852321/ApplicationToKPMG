using HomeworkFromKPMG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkFromKPMG.ViewModels
{
    public class AllWorkersVM
    {
        public IList<Manager> Managers { get; set; }
        public IList<Employee> Employees { get; set; }


    }
}
