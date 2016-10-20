using System.ComponentModel.DataAnnotations;
using System.Web;
using BooksCatalog.Models;

namespace BooksCatalog.ViewModels
{
    /// <summary>
    /// View model for creating and editing book
    /// </summary>
    public class EditBookViewModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Book's title
        /// </summary>
        [Required]
        [MaxLength(300, ErrorMessage = "Название книги не должно быть длиннее 300 символов")]
        [Display(Name = "Название")]
        public string Title { get; set; }

        /// <summary>
        /// Book's category
        /// </summary>
        [Display(Name = "Категория")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Book's image
        /// </summary>
        [Display(Name = "Обложка")]
        public HttpPostedFileBase Image { get; set; }
    }
}