using DemoVsAzuze.TypeBlogServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoVsAzuze.Controllers
{
    public class TypeBlogController : Controller
    {
        TypeBlogServiceClient client ;
        public TypeBlogController()
        {
            client = new TypeBlogServiceClient();
        }
        // GET: TypeBlog
        public ActionResult Index()
        {
            return View(client.GetTypeBlogList());
        }

        // GET: TypeBlog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TypeBlog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeBlog/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TypeBlog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TypeBlog/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TypeBlog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TypeBlog/Delete/5
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
