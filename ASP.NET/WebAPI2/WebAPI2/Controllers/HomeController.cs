using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI2.Models.DataModels;

namespace WebAPI2.Controllers
{
    public class HomeController : Controller
    {
        DRDbContext db = new DRDbContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var data = db.Employees.ToList();
            return View(data);
        }
    }
}
