using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCoreApplication.Models;

namespace MvcCoreApplication.Controllers
{
    public class EmployeeController : Controller
    {
        HumanResourceDbContext context = new HumanResourceDbContext();
        public ViewResult Index()
        {
            var employee = context.Employees.ToList();
            ViewBag.employeeList = employee;
            return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee e1)
        {
            context.Employees.Add(e1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}