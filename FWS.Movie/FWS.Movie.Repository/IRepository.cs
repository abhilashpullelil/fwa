using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Make as the query as queryable.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> AsQueryable();

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Finds the entity which satisfies specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Get single item for the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        T Single(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Get the first item or default for the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        T Add(T entity);

        /// <summary>
        /// Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Remove(T entity);

        /// <summary>
        /// Removes the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        void Remove(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Attaches the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Attach(T entity);

        /// <summary>
        /// Soft delete the entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void SoftDelete(T entity);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Update(T entity);

        /// <summary>
        /// Gets the item count for the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        int GetCount(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Executes the funtion.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        IEnumerable<T> ExecuteFuntion(string functionName, string parameter);

        /// <summary>
        /// Adds the items.
        /// </summary>
        /// <param name="items">The items.</param>
        void AddItems(List<T> items);
    }
}
