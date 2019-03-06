using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCoreApplication.Models;

namespace MvcCoreApplication.Controllers
{
    public class ManagerController : Controller
    {
        HumanResourceDbContext context = new HumanResourceDbContext();
        public ViewResult Index()
        {
            var managers = context.Managers.ToList();
            ViewBag.managerList = managers;
            return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Manager m1)
        {
            context.Managers.Add(m1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}