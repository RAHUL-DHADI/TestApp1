using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestApp1.Models;

namespace TestApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id = 1, Name = "John", City = "New York"},
            new Employee(){Id = 1, Name = "Jane", City = "Los Angeles"},
            new Employee(){Id = 1, Name = "Sam", City = "Chicago"},
            new Employee(){Id = 1, Name = "Sara", City = "Houston"},
            new Employee(){Id = 1, Name = "Mike", City = "Phoenix"},
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var emp = employees.ToList();
            return View(emp);
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
