using DatabaseTask.Data;
using DatabaseTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DatabaseTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseTaskDbContext _context; // DbContext lisatud

        public HomeController(ILogger<HomeController> logger, DatabaseTaskDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // Kutsume stored procedure'i
            var averages = _context.Set<StudentAverage>()
                                   .FromSqlRaw("EXEC GetStudentsAverageGrades")
                                   .ToList();

            return View(averages); // Modelina edastame View'le
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
