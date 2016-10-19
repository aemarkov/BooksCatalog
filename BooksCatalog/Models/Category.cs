using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksCatalog.Models
{
    /// <summary>
    /// Category of books
    /// </summary>
    public class Category:IModel
    {
        public Category()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }

        /// <summary>
        /// Name of the category
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// List of books in this category
        /// </summary>
        public virtual ICollection<Book> Books { get; set; } 
    }
}