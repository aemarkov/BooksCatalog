using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using BooksCatalog.Models;

namespace BooksCatalog.Controllers
{
    /// <summary>
    /// Controller for edition main page
    /// </summary>
    public class BooksEditController : Controller
    {
        private readonly IRepository<Book> _booksRepository;
        private readonly IRepository<Category> _categoryRepository;

        public BooksEditController(IUnitOfWork uow)
        {
            _booksRepository = uow.BooksRepository;
            _categoryRepository = uow.CategoryRepository;
        }

        // GET: Edit
        public ActionResult Index()
        {
            var books = _booksRepository.Entities.GroupBy(x => x.Category.CategoryName).OrderBy(x=>x.Key).ToDictionary(x=>x.Key, x=>x.OrderBy(y=>y.Title).ToList());
            return View(books);
        }

        [HttpGet]
        public ActionResult Create()
        {
            loadCategories();

            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _booksRepository.Insert(book);
                return RedirectToAction("Index");
            }

            loadCategories();
            return View(book);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var book = _booksRepository.GetById(id);

            //TO
            loadCategories();
            return View(book);
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _booksRepository.Update(book);
                return RedirectToAction("Index");
            }

            loadCategories();
            return View(book);
        }

        public ActionResult Delete(int id)
        {
            var book = _booksRepository.GetById(id);

            //TODO: проверка отсутствия записи
            _booksRepository.Delete(book);

            return RedirectToAction("Index");
        }


        //Loads categories for dropdown
        private void loadCategories()
        {
            var categories =
               _categoryRepository.OrderByName().Select(x => new SelectListItem() { Text = x.CategoryName, Value = x.Id.ToString() }).ToList();

            ViewBag.CategoriesSelectList = categories;
        }
    }
}