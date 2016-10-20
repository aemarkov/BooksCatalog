using System;
using System.CodeDom;
using System.Collections.Generic;
using BooksCatalog.Models;

namespace BooksCatalog.Infrastructure
{
    public class UnitOfWork:IUnitOfWork
    {
        //Old realisation for generic repository
        /*private Dictionary<Type, object> _repositories;

        public UnitOfWork()
        {
            _context = new BooksContext();
            _repositories = new Dictionary<Type, object>();
        }

        public IRepository<T> GetRepository<T>() where T : class, IModel
        {
            var type = typeof (T);
            if (!_repositories.ContainsKey(type))
            {
                var repo = new Repository<T>(_context);
                _repositories.Add(type, repo);
                return repo;
            }

            return (IRepository<T>) _repositories[type];
        }*/

        private BooksContext _context;
        private BooksRepository _booksRepository;
        private CategoriesRepository _categoriesRepository;

        public UnitOfWork()
        {
            _context = new BooksContext();         
        }

        /// <summary>
        /// Returns books repository
        /// </summary>
        public IRepository<Book> BooksRepository
        {
            get { return _booksRepository ?? (_booksRepository = new BooksRepository(_context)); }
        }

        /// <summary>
        /// Returns categories repository
        /// </summary>
        public IRepository<Category> CategoryRepository
        {
            get { return _categoriesRepository ?? (_categoriesRepository = new CategoriesRepository(_context)); }
            
        }
    }
}