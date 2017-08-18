using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmpDbContext DbContext = new EmpDbContext();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                EmpDbContext DbContext = new EmpDbContext();
                DbContext.employees.Add(employee);
                DbContext.SaveChanges();
                return View();
            }
            else
            {
                return View();
            }
            
        }
    }
}