using DatabaseTask.Data;
using DatabaseTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Controllers
{
    public class StudentController : Controller
    {
        private readonly DatabaseTaskDbContext _context;

        public StudentController(DatabaseTaskDbContext context)
        {
            _context = context;
        }

        public IActionResult Averages()
        {
            // Stored procedure'i kutsumine otse Controller'is
            var averages = _context.Set<StudentAverage>()
                                   .FromSqlRaw("EXEC GetStudentsAverageGrades")
                                   .ToList();

            return View(averages);
        }
    }
}
