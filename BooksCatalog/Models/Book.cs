using System.ComponentModel.DataAnnotations;

namespace BooksCatalog.Models
{
    /// <summary>
    /// Модель книги
    /// </summary>
    public class Book
    {
        public int Id { get; set; }

        /// <summary>
        /// Название книги
        /// </summary>
        [Required]
        [MaxLength(60)]
        public string Title { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}