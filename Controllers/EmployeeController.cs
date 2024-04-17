using EmployeePageTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePageTask.Controllers
{
    public class EmployeeController : Controller
    {

        // Employee[] employeeData = [new Employee(1,"Fawaz","Alzamel","fawaz@gmail.com","IT Dep." ),
        // new Employee(2,"Msalam","Alzamel","msalam@gmail.com","KOC" )];

        static List<Employee> employeeData = [
        new Employee {EmployeeId = "1",FirstName="Fawaz",LastName="Alz",Email="fas@gmail.com",Department="IT"},
        new Employee {EmployeeId = "2",FirstName="msalam",LastName="Alza",Email="msal@gmail.com",Department="KOC"}
        ];
        public IActionResult Index()
        {
            return View(employeeData);
        }


        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddEmployee(IFormCollection form) {

            var employeeId = form["EmployeeId"];
            var firstname = form["FirstName"]; 
            var lastName = form["LastName"];
            var email = form["Email"];
            var department = form["Department"];
            var e = new Employee();

            e.EmployeeId = employeeId;
            e.FirstName = firstname;
            e.LastName = lastName;
            e.Email = email;
            e.Department = department;

            employeeData.Add(e);
           


            return RedirectToAction("Index");
        
        }
    }
}
