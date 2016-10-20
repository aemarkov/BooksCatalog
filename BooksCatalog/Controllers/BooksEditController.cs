using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BooksCatalog.Models;

namespace BooksCatalog.Controllers
{
    /// <summary>
    /// Controller for edition main page
    /// </summary>
    public class BooksEditController : Controller
    {
        // GET: Edit
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }
    }
}