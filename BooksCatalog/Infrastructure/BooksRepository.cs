using System.Linq;
using BooksCatalog.Models;

namespace BooksCatalog.Infrastructure
{

    public class BooksRepository:Repository<Book>
    {
        public override IQueryable<Book> OrderByName()
        {
            return Entities.OrderBy(x => x.Title);
        }

        public BooksRepository():base(){}
        public BooksRepository(BooksContext context) : base(context) { }
        
    }
}