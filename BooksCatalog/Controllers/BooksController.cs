using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using BooksCatalog.Models;
using BooksCatalog.ViewModels;

namespace BooksCatalog.Controllers
{
    public class BooksController : Controller
    {
        private readonly IRepository<Book> _booksRepository;
        private readonly IRepository<Category> _categoryRepository;
        private IMapper _mapper;

        public BooksController(IUnitOfWork uow, IMapper mapper)
        {
            _booksRepository = uow.GetRepository<Book>();
            _categoryRepository = uow.GetRepository<Category>();
            _mapper = mapper;
        }

        // GET all books
        public ActionResult Index()
        {
            var books = _booksRepository.Entities.OrderBy(x=>x.Title).ToList();
            var menuItems = GetCategoriesMenuItems();

            return View(new BooksListViewModel() {Books = books, MenuItems = menuItems});
        }

        //Get books in specified category
        //[Route("category/{id}")]
        public ActionResult Category(int id)
        {
            var books = _booksRepository.Entities.Where(x => x.CategoryId == id).ToList();

            //TODO: обработка ошибок отсутствия категории
            var menuItems = GetCategoriesMenuItems();

            return View("Index", new BooksListViewModel() { Books = books, MenuItems = menuItems });
        }

        //Map list of the categories to the list of menu items
        private IList<SideMenuViewModel> GetCategoriesMenuItems()
        {
            return _categoryRepository.Entities.OrderBy(x=>x.CategoryName).ToList().Select(x => _mapper.Map<Category,SideMenuViewModel>(x)).ToList();
        }
    }
}