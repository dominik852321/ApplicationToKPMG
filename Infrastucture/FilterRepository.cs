using HomeworkFromKPMG.Data;
using HomeworkFromKPMG.Models;
using HomeworkFromKPMG.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkFromKPMG.Infrastucture
{
    public class FilterRepository: IFilterRepository
    {
        private readonly AppDbContext _appDbContext;
        public FilterRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Manager>> GetManagers()
            => await _appDbContext.Managers.Include(s=>s.Employees).ToListAsync();


        public async Task<IEnumerable<Employee>> GetEmployees()
            => await _appDbContext.Employees.Include(s=>s.Manager).ToListAsync();


        #region FilterFunctions

        public async Task<IEnumerable<Employee>> SearchEmployees(string name)
        {
            var result = from x in _appDbContext.Employees.Include(x=>x.Manager) select x;

            if(!string.IsNullOrEmpty(name))
            {
               result = result.Where(x => x.EmployeeName + " " + x.EmployeeSurname == name);
            }
            return await result.AsNoTracking().ToListAsync();
        }
      

        public async Task<IEnumerable<Manager>> SearchManagers(string name)
        {
            var result = from x in _appDbContext.Managers.Include(x=>x.Employees) select x;

            if (!string.IsNullOrEmpty(name))
            {
                result = result.Where(x => x.ManagerName + " " + x.ManagerSurname == name);
            }
            return await result.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Employee>> FilterDataEmployee(DateTime date1, DateTime date2)
        {
            var result = from x in _appDbContext.Employees.Include(x=>x.Manager) select x;


            if(date1!=DateTime.MinValue && date2!=DateTime.MinValue)
            {
                result = result.Where(x => x.DateEmployment >= date1 && x.DateEmployment <= date2);
            }
            if(date1!= DateTime.MinValue && date2== DateTime.MinValue)
            {
                result = result.Where(x => x.DateEmployment <= date1);
            }
            if(date1== DateTime.MinValue && date2!= DateTime.MinValue)
            {
                result = result.Where(x => x.DateEmployment >= date2);
            }

            return await result.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Manager>> FilterDataManagers(DateTime date1, DateTime date2)
        {
            var result = from x in _appDbContext.Managers.Include(x=>x.Employees) select x;


            if (date1 != DateTime.MinValue && date2 != DateTime.MinValue)
            {
                result = result.Where(x => x.ManagerEmployment >= date1 && x.ManagerEmployment <= date2);
            }
            if (date1 != DateTime.MinValue && date2 == DateTime.MinValue)
            {
                result = result.Where(x => x.ManagerEmployment <= date1);
            }
            if (date1 == DateTime.MinValue && date2 != DateTime.MinValue)
            {
                result = result.Where(x => x.ManagerEmployment >= date2);
            }

            return await result.AsNoTracking().ToListAsync();
        }

       



        #endregion
    }
}
