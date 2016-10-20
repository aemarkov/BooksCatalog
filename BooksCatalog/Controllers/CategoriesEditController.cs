using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BooksCatalog.Models;

namespace BooksCatalog.Controllers
{
    public class CategoriesEditController : Controller
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoriesEditController(IUnitOfWork uow)
        {
            _categoryRepository = uow.CategoryRepository;
        }

        // GET: View all books
        public ActionResult Index()
        {
            var categories = _categoryRepository.Entities.ToList();
            return View(categories);
        }

        //Show form for create new book
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //Create new book
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepository.Insert(category);
                return RedirectToAction("Index");
            }

            return View(category);
        }

        //Show form for edit book
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = _categoryRepository.GetById(id);

            //TODO: Обработка отсутствия записи
            return View(category);
        }

        //Edit book
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepository.Update(category);
                return RedirectToAction("Index");
            }

            return View(category);
        }

        //Delete book
        public ActionResult Delete(int id)
        {
            var category = _categoryRepository.GetById(id);

            //TODO: проверка отсутствия записи
            _categoryRepository.Delete(category);

            return RedirectToAction("Index");
        }
    }
}