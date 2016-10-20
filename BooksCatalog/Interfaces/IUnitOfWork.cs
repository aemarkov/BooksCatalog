using BooksCatalog.Models;

namespace BooksCatalog
{
    /// <summary>
    /// Unit Of Work provides acess to the repositories
    /// with same DbContext
    /// </summary>
    public interface IUnitOfWork
    {
        //IRepository<T> GetRepository<T>() where T : class, IModel;
        IRepository<Book> BooksRepository { get; } 
        IRepository<Category> CategoryRepository { get; } 
    }
}