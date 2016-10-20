using System.Collections.Generic;
using BooksCatalog.Models;

namespace BooksCatalog.ViewModels
{
    /// <summary>
    /// View model for books list
    /// </summary>
    public class BooksListViewModel
    {
        public IList<SideMenuItemViewModel> MenuItems { get; set; } 
        public IList<Book> Books { get; set; }
        public string CategoryName { get; set; }
    }
}