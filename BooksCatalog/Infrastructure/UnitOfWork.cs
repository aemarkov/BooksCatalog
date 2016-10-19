using System;
using System.CodeDom;
using System.Collections.Generic;
using BooksCatalog.Models;

namespace BooksCatalog.Infrastructure
{
    public class UnitOfWork:IUnitOfWork
    {
        private BooksContext _context;
        private Dictionary<Type, object> _repositories;

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
        }
    }
}