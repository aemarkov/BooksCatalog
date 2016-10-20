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
    /// <summary>
    /// Controller for display list of books
    /// </summary>
    public class BooksController : Controller
    {
        private readonly IRepository<Book> _booksRepository;
        private readonly IRepository<Category> _categoryRepository;
        private IMapper _mapper;

        public BooksController(IUnitOfWork uow, IMapper mapper)
        {
            _booksRepository = uow.BooksRepository;
            _categoryRepository = uow.CategoryRepository;
            _mapper = mapper;
        }

        // GET all books
        public ActionResult Index()
        {
            var books = _booksRepository.OrderByName().ToList();
            var menuItems = GetCategoriesMenuItems();

            return View(new BooksListViewModel() {Books = books, MenuItems = menuItems});
        }

        //Get books in specified category
        //[Route("category/{id}")]
        public ActionResult Category(int id)
        {
            var books = _booksRepository.Entities.Where(x => x.CategoryId == id).ToList();
            var category = _categoryRepository.GetById(id);

            //Category not found
            if(category==null)
                throw new HttpException(404,"Not found");

            var menuItems = GetCategoriesMenuItems();

            return View("Index", new BooksListViewModel() { Books = books, MenuItems = menuItems, CategoryName = category.CategoryName});
        }

        //Map list of the categories to the list of menu items
        private IList<SideMenuItemViewModel> GetCategoriesMenuItems()
        {
            return _categoryRepository.OrderByName().ToList().Select(x => _mapper.Map<Category,SideMenuItemViewModel>(x)).ToList();
        }
    }
}