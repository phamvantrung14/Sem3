using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2.Controllers
{
    public class HomeController : Controller
    {
        FRDbContext db;
        public HomeController()
        {
            db = new FRDbContext();
        }
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Users.ToList();
            return View(data);
        }
    }
}