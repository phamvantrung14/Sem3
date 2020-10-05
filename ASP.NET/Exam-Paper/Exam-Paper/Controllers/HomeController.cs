using Exam_Paper.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_Paper.Controllers
{
    public class HomeController : Controller
    {
        FptDbContext db;
        public HomeController()
        {
            db = new FptDbContext();
        }
        public ActionResult Index()
        {
            var data = db.Contacts.ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}