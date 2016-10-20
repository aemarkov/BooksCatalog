using System.Linq;
using BooksCatalog.Models;

namespace BooksCatalog
{
    /// <summary>
    /// Repository interface. Provides method for 
    /// working with models.
    /// </summary>
    /// <typeparam name="T">Class of the model</typeparam>
    public interface IRepository<T> where T: class, IModel
    {
        /// <summary>
        /// Access to models and quering
        /// </summary>
        IQueryable<T> Entities { get;}

        /// <summary>
        /// Returns ordered by name entities
        /// </summary>
        IQueryable<T> OrderByName();

            /// <summary>
        /// Find entity with specific id
        /// </summary>
        /// <param name="id">Entity id</param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Insert new entity to DB
        /// </summary>
        /// <param name="entity">new entity</param>
        void Insert(T entity);

        /// <summary>
        /// Update existing model
        /// </summary>
        /// <param name="entity">updated entity</param>
        void Update(T entity);

        /// <summary>
        /// Remove entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);
    }
}

/*
 * Notes
 * 
 * General Repository is usually anti-pattern for
 * big projects and it's not recomended to provide
 * acess to IQueryable outside the repository. 
 * It is better to use
 *  - query method in repository
 *  - use Specification pattern
 *  
 * 
 * But in this small project I think it's enough
 * to just provide IQueryble
 */