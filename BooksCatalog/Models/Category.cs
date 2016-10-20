using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        [MaxLength(60,ErrorMessage = "Название категории должно быть не длиннее 30 символов")]
        [Display(Name = "Название")]
        public string CategoryName { get; set; }

        /// <summary>
        /// List of books in this category
        /// </summary>
        public virtual ICollection<Book> Books { get; set; } 
    }
}