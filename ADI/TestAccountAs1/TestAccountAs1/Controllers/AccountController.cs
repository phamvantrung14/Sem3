using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAccountAs1.AccountServiceReference;
using TestAccountAs1.Models;

namespace TestAccountAs1.Controllers
{
    public class AccountController : Controller
    {
        Accountclient acClient;
        AccountServiceClient client = new AccountServiceClient();
        public AccountController()
        {
            acClient = new Accountclient();
        }
        // GET: Account
        public ActionResult Index()
        {
            ViewBag.listAccounts = acClient.getAllAccounts();
            return View();
        }

        // GET: Account/Details/5
        public ActionResult Details(string id)
        {
            var data = acClient.getAccountById(id);
            return View(data);
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        public ActionResult Create(Models.Account account)
        {
            try
            {
                acClient.storeAccount(account);

                return RedirectToAction("Index", "Account");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Edit/5
        public ActionResult Edit(string id)
        {
            var data= acClient.getAccountById(id);
            return View(data);
        }

        // POST: Account/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Account ac, FormCollection collection)
        {
            try
            {
                acClient.editAccount(ac);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(string id)
        {
            acClient.deleteAc(id);
            return RedirectToAction("Index");
        }

        // POST: Account/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
