using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksCatalog.Models
{
    /// <summary>
    /// Категория книг
    /// </summary>
    public class Category
    {
        public Category()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }

        /// <summary>
        /// Название категории
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Книги в этой категории
        /// </summary>
        public virtual ICollection<Book> Books { get; set; } 
    }
}