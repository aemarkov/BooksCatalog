using System.Collections.Generic;
using BooksCatalog.Models;

namespace BooksCatalog.ViewModels
{
    /// <summary>
    /// View model for books list
    /// </summary>
    public class BooksListViewModel
    {
        public IList<SideMenuViewModel> MenuItems { get; set; } 
        public IList<Book> Books { get; set; }
    }
}