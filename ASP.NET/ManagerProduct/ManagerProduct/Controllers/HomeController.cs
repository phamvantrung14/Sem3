using ManagerProduct.Models;
using ManagerProduct.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManagerProduct.Controllers
{

    public class HomeController : Controller
    {
        public GADbContext db = new GADbContext();
        public ActionResult Index()
        {
            if(Session["LoginCust"]==null)
            {
                return RedirectToAction("LoginSession");
            }
            var data = db.Products.ToList();
            return View(data);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Product pro)
        {

            return View();
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
        public ActionResult LoginSession()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginSession(string email, string password)
        {
            var data = db.User.ToList();
            foreach (var item in data)
            {
                if (item.Email == email && item.Password == password)
                {
                    User c = item;
                    Session["LoginCust"] = c;
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User c)
        {
            if (ModelState.IsValid)
            {

                db.User.Add(c);
                db.SaveChanges();
                return RedirectToAction("LoginSession");
            }
            return View(c);
        }
        public ActionResult Logout()
        {
            Session["LoginCust"] = null;
            return View("LoginSession");
        }
    }
}