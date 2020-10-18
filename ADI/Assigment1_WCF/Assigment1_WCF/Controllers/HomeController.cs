using Assigment1_WCF.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assigment1_WCF.Controllers
{
    public class HomeController : Controller
    {
        FRDbContext db = new FRDbContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Accounts.ToList();
            return View(data);
        }
    }
}