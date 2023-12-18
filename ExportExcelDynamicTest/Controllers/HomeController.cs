using ExportExcelDynamicTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace ExportExcelDynamicTest.Controllers
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
            List<Student> data = new List<Student>
            {
                new Student { 
                    Id = 1, 
                    FullName = "مجید خلقی شیرازی",
                    Gender = Enums.Gender.Male,
                    Salary = 10000000,
                    HasChild = false,
                    EnterDate = new DateTime(2020, 04, 25),
                    Age = 31,
                    ShiftTime = new TimeSpan(8, 30, 0)
                }
            };

            ExportToExcel<Student> exporter = new ExportToExcel<Student>();
            var result = exporter.ExportToExcelFile(data);

            return File(result, "application/vnd.ms-excel", "MyExcel.xlsx");
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
