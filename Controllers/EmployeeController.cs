using demo_model.Models;
using Microsoft.AspNetCore.Mvc;
using demo_model.Models;

namespace TvcDay05MModel.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            var emp = new Employee
            {
                Id = 1001,
                FullName = "Nguyễn Văn A",
                Gender = "Nam",
                Phone = "0123456789",
                Email = "nguyenvana@example.com",
                Salary = 12000000,
                Status = true
            };

            ViewBag.Employee = emp;

            return View();
        }

        public IActionResult List()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, FullName = "Nguyễn Văn A", Gender = "Nam", Phone = "0123456789", Email = "a@gmail.com", Salary = 12000000, Status = true },
                new Employee { Id = 2, FullName = "Trần Thị B",   Gender = "Nữ", Phone = "0987654321", Email = "b@gmail.com", Salary = 15000000, Status = true },
                new Employee { Id = 3, FullName = "Lê Văn C",     Gender = "Nam", Phone = "0911223344", Email = "c@gmail.com", Salary = 10000000, Status = false },
                new Employee { Id = 4, FullName = "Phạm Thị D",   Gender = "Nữ", Phone = "0909090909", Email = "d@gmail.com", Salary = 11000000, Status = true }
            };

            return View(employees);
        }
    }
}
