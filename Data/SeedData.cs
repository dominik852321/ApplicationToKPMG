using HomeworkFromKPMG.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeworkFromKPMG.Data
{
    public class SeedData
    {
        public AppDbContext _context { get; set; }

        public SeedData(AppDbContext context)
        {
            _context = context;
        }

        //File to database was created on json-generator.com

        //Jeśli w baziedanych nie ma danych automatycznie tworzone są funkcjami poniżej
        public void SeedManagers()
        {
            if (_context.Managers.Any() == false)
            {
                var managersData = File.ReadAllText("Data/DataFromGenerator/ManagersData.json");
                var managers = JsonConvert.DeserializeObject<List<Manager>>(managersData);

                foreach (var manager in managers)
                {
                    _context.Managers.Add(manager);
                }
                _context.SaveChanges();
            }
        }

        public void SeedEmployee()
        {
            if(_context.Employees.Any()==false)
            {
                var employesData = File.ReadAllText("Data/DataFromGenerator/EmployesData.json");
                var employes = JsonConvert.DeserializeObject<List<Employee>>(employesData);
               
                foreach(var employe in employes)
                {
                    var rnd = new Random ();
                    var randomNumber = rnd.Next(1, 8);
                    var manager =  _context.Managers.First(s => s.Id == randomNumber);

                    employe.Manager = manager;
                    employe.ManagerId = manager.Id;

                    _context.Employees.Add(employe);

                    manager.Employees.Add(employe);
                }
                _context.SaveChanges();
            }
        }
    }
}
