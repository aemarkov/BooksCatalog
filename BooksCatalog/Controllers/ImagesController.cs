using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BooksCatalog.Models;

namespace BooksCatalog.Controllers
{
    /// <summary>
    /// Displays images for book
    /// </summary>
    public class ImagesController : Controller
    {
        private readonly IRepository<Book> _booksRepository;

        public ImagesController(IUnitOfWork uow)
        {
            _booksRepository = uow.BooksRepository;
        }

        // GET: Images
        public ActionResult Show(int? id)
        {
            if (id != null)
            {
                var book = _booksRepository.GetById(id.Value);

                if (book != null && book.Image != null && book.Image.Length >1)
                    return File(book.Image, "image/jpg");
            }

            //No image
            string path = Path.Combine(Server.MapPath("~/Content/Images"), "noimage.jpg");
            return File(System.IO.File.ReadAllBytes(path),"image/jpg");
        }
    }
}