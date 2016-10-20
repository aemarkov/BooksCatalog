using System.Linq;
using BooksCatalog.Models;

namespace BooksCatalog.Infrastructure
{
    public class CategoriesRepository:Repository<Category>
    {
        public override IQueryable<Category> OrderByName()
        {
            return Entities.OrderBy(x => x.CategoryName); 
            
        } 

        public CategoriesRepository():base(){ }
        public CategoriesRepository(BooksContext context) : base(context) { }
    }
}