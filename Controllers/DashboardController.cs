using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {

            // Assuming you have a data source or database
            List<Employee> employees = GetEmployeeData();
            return View(employees);
        }

        private List<Employee> GetEmployeeData()
        {
            // Fetch employee data from your data source
            // This could be from a database, API, or any other source
            // For simplicity, creating sample data
            return new List<Employee>
        {
            new Employee { Id = 1, Name = "Ahmed", WorkingHours = 160, Salary = 25000 },
            new Employee { Id = 2, Name = "Mohamed", WorkingHours = 120, Salary = 20000 },
            new Employee { Id = 3, Name = "Kareem", WorkingHours = 160, Salary = 30000 },
            new Employee { Id = 4, Name = "Mostafa", WorkingHours = 100, Salary = 5000 },
            new Employee { Id = 5, Name = "Zaki", WorkingHours = 160, Salary = 15000 },
            new Employee { Id = 6, Name = "Fatma", WorkingHours = 130, Salary = 20000 },
            new Employee { Id = 7, Name = "Nehal", WorkingHours = 150, Salary = 18000 },
            new Employee { Id = 8, Name = "Fahd", WorkingHours = 90, Salary = 28000 },
            new Employee { Id = 9, Name = "Samer", WorkingHours = 160, Salary = 30000 },
            new Employee { Id = 10, Name = "Salah", WorkingHours = 140, Salary = 16000 },
            // Add data for other employees
        };
        }
    }
}
