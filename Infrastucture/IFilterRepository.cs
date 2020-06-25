using HomeworkFromKPMG.Models;
using HomeworkFromKPMG.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkFromKPMG.Infrastucture
{
    public interface IFilterRepository
    {
        Task<IEnumerable<Manager>> GetManagers();
        Task<IEnumerable<Employee>> GetEmployees();

        Task<IEnumerable<Employee>> SearchEmployees(string name);
        Task<IEnumerable<Manager>> SearchManagers(string name);

        Task<IEnumerable<Employee>> FilterDataEmployee(DateTime date1, DateTime date2);
        Task<IEnumerable<Manager>> FilterDataManagers(DateTime date1, DateTime date2);

       






    }
}
