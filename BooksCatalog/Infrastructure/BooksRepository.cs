using System.Data.Entity;
using System.Linq;
using BooksCatalog.Models;
using Microsoft.Ajax.Utilities;

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

        /// <summary>
        /// Update existing model
        /// </summary>
        /// <param name="entity">updated entity</param>
        public override void Update(Book entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;

            if (entity.Image == null || entity.Image.Length<=1)
                entry.Property("Image").IsModified = false;
            
            _context.SaveChanges();
        }

    }
}