using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCoreApplication.Models;

namespace MvcCoreApplication.Controllers
{
    public class DepartmentController : Controller
    {
        HumanResourceDbContext context = new HumanResourceDbContext();
        public ViewResult Index()
        {
            var departments = context.Departments.ToList();
            ViewBag.departmentList = departments;

            //ViewBag.depts = context.Departments.ToList();
            return View();
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department d1)
        {
            context.Departments.Add(d1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Department dept = context.Departments.Where(x => x.Id == id).SingleOrDefault();
               
            return View(dept);

        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Department dept = context.Departments.Find(id);
            return View(dept);
        }
        [HttpPost]
        public ActionResult Delete(int id, Department d1)
        {
            var dept = context.Departments.Where(x => x.Id == id).SingleOrDefault();
            context.Departments.Remove(dept);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Department dept = context.Departments.Where(x => x.Id == id).SingleOrDefault();

            return View(dept);
        }
        [HttpPost]
        public ActionResult Edit(int id, Department d1)
        {
            Department dept = context.Departments.Where(x => x.Id == d1.Id).SingleOrDefault();
            context.Entry(dept).CurrentValues.SetValues(d1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
