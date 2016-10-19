using System.ComponentModel.DataAnnotations;

namespace BooksCatalog.Models
{
    /// <summary>
    /// Book model
    /// </summary>
    public class Book:IModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Book's title
        /// </summary>
        [Required]
        [MaxLength(300)]
        public string Title { get; set; }

        /// <summary>
        /// Book's category
        /// </summary>
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

        /// <summary>
        /// Book's image
        /// </summary>
        public byte[] Image { get; set; }
    }
}