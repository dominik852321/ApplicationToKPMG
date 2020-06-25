using HomeworkFromKPMG.Data;
using HomeworkFromKPMG.Infrastucture;
using HomeworkFromKPMG.Models;
using HomeworkFromKPMG.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace HomeworkFromKPMG.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFilterRepository _repository;
        private readonly AppDbContext _appDbContext;

        public HomeController(IFilterRepository repository, AppDbContext appDbContext)
        {
            _repository = repository;
            _appDbContext = appDbContext;
        }

        //Pobieramy wszystkich pracowników
        public async Task<IActionResult> Index()
        {
            var managersToReturn = await _repository.GetManagers();
            var employesToReturn = await _repository.GetEmployees();

            var workersToReturn = new AllWorkersVM()
            {
                Managers = managersToReturn.ToList(),
                Employees = employesToReturn.ToList()
            };
            

            return View(workersToReturn);
        }

        //Funkcja pomagająca wyszukać pracowników (autocomplete)
        [HttpGet]
        public JsonResult GetWorkers(string name)
       {
            var result = (from x in _appDbContext.Employees
                          where x.EmployeeName.ToLower().Contains(name) || x.EmployeeSurname.ToLower().Contains(name)
                          select new { x.EmployeeName, x.EmployeeSurname });
            return Json(result);
        }

       
        //Wyszukiwanie pracowników
        [HttpPost]
        public async Task<IActionResult> SearchByName(string CurrentFilterName)
        {
            ViewBag.CurrentFilterName = CurrentFilterName;

            var employees = await _repository.SearchEmployees(CurrentFilterName);
            var managers = await _repository.SearchManagers(CurrentFilterName);

            var workers = new AllWorkersVM()
            {
                Employees = employees.ToList(),
                Managers = managers.ToList()
            };

            return PartialView("_Workers", workers);
        }

        //Wyszukiwanie pracowników po dacie zatrudnienia
        [HttpPost]
        public async Task<IActionResult> SearchByData(DateTime CurrentFilterSince, DateTime CurrentFilterTo)
        {
            ViewBag.CurrentFilterSince = CurrentFilterSince;
            ViewBag.CurrentFilterTo = CurrentFilterTo;

            var employees = await _repository.FilterDataEmployee(CurrentFilterSince, CurrentFilterTo);
            var managers = await _repository.FilterDataManagers(CurrentFilterSince, CurrentFilterTo);

            var workers = new AllWorkersVM()
            {
                Employees = employees.ToList(),
                Managers = managers.ToList()
            };

            return PartialView("_Workers", workers);
        }

        

      
    }
}
