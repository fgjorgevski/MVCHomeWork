using HomeWork2.Models;
using HomeWork2.Models.Division;
using HomeWork2.Models.Emoloyee;
using HomeWork2.Models.Employee.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace HomeWork2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var employee = new Employee
            {
                DateOfHire = 30,
                EmployeeId = 10,
                FirstName = "Filip",
                Salary = 300,
                LastName = "Gjorgevski",
                Position = PositionEnum.Senior

            };
            var division = new Division
            {
                DivisionId = 3,
                HeadOfDivision = employee,
                Name = employee.FirstName
            };

            var EmployeeDetailsViewModel = new EmployeeDetailsViewModel
            {
                DateOfHire = employee.RandomNumber(1, 32),
                DivisionName = "Amazon",
                FullEmployeeName = employee.GetFullName(),
                Position = employee.Position,
                Salary = employee.salaryOfEmployee(employee.Position)
            
                
            };


      
            return View(EmployeeDetailsViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
