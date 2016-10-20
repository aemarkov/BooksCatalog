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
        [MaxLength(300,ErrorMessage = "Название книги не должно быть длиннее 300 символов")]
        [Display(Name="Название")]
        public string Title { get; set; }

        /// <summary>
        /// Book's category
        /// </summary>
        [Display(Name="Категория")]
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

        /// <summary>
        /// Book's image
        /// </summary>
        [Display(Name="Обложка")]
        public byte[] Image { get; set; }
    }
}