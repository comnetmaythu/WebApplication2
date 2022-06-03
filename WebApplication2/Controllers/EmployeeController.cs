using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        static IList<Employee> EmployeeList = new List<Employee>{
                new Employee() { EmployeeName = "Hanny" ,Salary=1000000 },
                 new Employee() { EmployeeName = "Marry" ,Salary=2000000 },
                  new Employee() { EmployeeName = "David" ,Salary=1000000 }
            };

        // GET: Employee
        public ActionResult Index()
        {
            return View(EmployeeList);
        }
    }
}