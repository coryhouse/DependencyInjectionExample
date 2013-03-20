using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using Productify.Domain.Model;

namespace Productify.Domain.Repositories
{
    /// <summary>
    /// Represents a repository of domain objects.
    /// </summary>
    /// <typeparam name="T">The type of elements in the repository</typeparam>
    [ContractClass(typeof(RepositoryContract<>))]
    public interface IRepository<T> : ICollection<T>, IQueryable<T> where T : IAggregateRoot
    {
        /// <summary>
        /// Specifies the related objects to include in the query results.
        /// </summary>
        /// <param name="subSelector">Identifies the field or property to be retrieved. 
        /// If the expression does not identify a field or property that represents a one-to-one or one-to-many relationship, an exception is thrown.</param>
        /// <returns>A new System.Linq.IQueryable&lt;T&gt; with the defined query path.</returns>
        /// <remarks>You cannot specify the loading of two levels of relationships (for example, Orders.OrderDetails).</remarks>
        IQueryable<T> Include(Expression<Func<T, object>> subSelector);

        /// <summary>
        /// Update the persistent instance with the identifier of the given transient instance
        /// </summary>
        /// <param name="item">An instance containing updated state</param>
        void Update(T item);
    }
}
