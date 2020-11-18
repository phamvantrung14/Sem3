using Consummer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Consummer.Controllers
{
    public class HomeController : Controller
    {
        EmployeeClient dataEmp;
        public HomeController()
        {
            dataEmp = new EmployeeClient();
        }
        public ActionResult Index(string key)
        {
            var data = dataEmp.GetAllEmployee();
            if(key !="")
            {
                data = dataEmp.GetEmployeeByKey(key);

            }
            return View(data);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            dataEmp.AddEmp(emp);
            return RedirectToAction("Index");
        }
        public ActionResult  About()
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