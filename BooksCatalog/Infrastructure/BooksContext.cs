using System.Data.Entity;
using BooksCatalog.Models;

namespace BooksCatalog.Infrastructure
{
    public class BooksContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}