using EmployeePageTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePageTask.Controllers
{
    public class EmployeeController : Controller
    {

        Employee[] employeeData = [new Employee(1,"Fawaz","Alzamel","fawaz@gmail.com","IT Dep." ),
        new Employee(2,"Msalam","Alzamel","msalam@gmail.com","KOC" )];

        public IActionResult Index()
        {
            return View(employeeData);
        }
    }
}
