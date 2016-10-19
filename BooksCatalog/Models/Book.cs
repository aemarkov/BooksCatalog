using System.ComponentModel.DataAnnotations;

namespace BooksCatalog.Models
{
    /// <summary>
    /// Book model
    /// </summary>
    public class Book
    {
        public int Id { get; set; }

        /// <summary>
        /// Book's title
        /// </summary>
        [Required]
        [MaxLength(60)]
        public string Title { get; set; }

        /// <summary>
        /// Book's category
        /// </summary>
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}