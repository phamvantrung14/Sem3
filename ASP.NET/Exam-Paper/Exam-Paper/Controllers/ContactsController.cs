using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using Exam_Paper.DAL;
using Exam_Paper.Models;
using Microsoft.Ajax.Utilities;

namespace Exam_Paper.Controllers
{
    public class ContactsController : Controller
    {
        private FptDbContext db = new FptDbContext();

        // GET: Contacts
        public ActionResult Index(string key , string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc":"";
            /*var data = db.Contacts.ToList();*/
            var data = from x in db.Contacts select x;
            if(!String.IsNullOrEmpty(key))
            {
                /* data = data.Where(x => x.ContactName.ToLower().Contains(key.ToLower())).ToList();*/
                data = data.Where(x => x.ContactName.Contains(key)||x.ContactName.Contains(key));
                ViewBag.key = key;
            }
            switch(sortOrder)
            {
                case "name_desc":
                    data = data.OrderByDescending(x => x.ContactName);
                    break;
                default:
                    data = data.OrderBy(x => x.ContactName);
                    break;
            }
            return View(data);
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ContactName,ContactNumber,GroupName,HireDate,BirthDay")] Contact contact,HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    /*string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);*/
                    string _path = Path.Combine(HostingEnvironment.MapPath("~/UploadedFiles"), _FileName);
                    string _path2 = Path.Combine("C:/Users/asuspc/Desktop/BookCover", _FileName);
                    file.SaveAs(_path2);
                    file.SaveAs(_path);
                    ViewBag.Message = _path;
                    ViewBag.Message2 = _path2;
                    if (ModelState.IsValid)
                    {

                        contact.GroupName = _path;
                        db.Contacts.Add(contact);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                
            }
            catch(Exception ex)
            {
                ViewBag.Message = "ko thanh cong";
            }
            return View(contact);


        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ContactName,ContactNumber,GroupName,HireDate,BirthDay")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: Contacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = db.Contacts.Find(id);
            db.Contacts.Remove(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
