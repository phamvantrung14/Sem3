using EAP_ExamPaper.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EAP_ExamPaper.Controllers
{
    public class HomeController : Controller
    {
        EXDbContext db;
        public HomeController()
        {
            db = new EXDbContext();
        }
        // GET: Home
        public ActionResult Index()
        {

            return View(db.Employees.ToList());
        }
    }
}