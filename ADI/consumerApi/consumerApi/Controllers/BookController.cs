using consumerApi.BookServiceReference;
using consumerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace consumerApi.Controllers
{
    public class BookController : Controller
    {
        BookClient bookClient = new BookClient();

        // GET: Book
        public ActionResult Index()
        {
            ViewBag.listBooks = bookClient.getAllBook();
            return View();
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
           var data = bookClient.getBookById(id);
            return View(data);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Models.Book book)
        {
            try
            {
                bookClient.storeBook(book);
                // TODO: Add insert logic here

                return RedirectToAction("Index","Book");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            var data = bookClient.getBookById(id);
            return View(data);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Book book)
        {
            try
            {
                bookClient.editBook(book);

                return RedirectToAction("Index","Book");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            bookClient.deleteBook(id);
            return RedirectToAction("Index", "Book");
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                bookClient.deleteBook(id);
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
