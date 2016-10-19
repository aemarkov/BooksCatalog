using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksCatalog.Controllers
{
    [RoutePrefix("books")]
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        [Route("category/{categoryId}")]
        public ActionResult Category(int categoryId)
        {
            return View();
        }
    }
}