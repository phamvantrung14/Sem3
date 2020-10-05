using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First_Web_Application.Areas.AdminBostrap.Controllers
{
    public class HomeController : Controller
    {
        // GET: AdminBostrap/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}