using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Productify.Domain.Model;

namespace Productify.Domain.Repositories
{
    /// <summary>
    /// Defines the code contract for IRepository&lt;T&gt;
    /// </summary>
    /// <typeparam name="T">The type of the elements managed by the repository</typeparam>
    [ContractClassFor(typeof(IRepository<>))]
    internal sealed class RepositoryContract<T> : IRepository<T> where T : IAggregateRoot
    {
        public void Add(T item)
        {
            Contract.Requires<ArgumentNullException>(item != null, "item");
            Contract.Requires<ArgumentException>(item.CanBeSaved);
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            Contract.Requires<ArgumentNullException>(item != null, "item");            
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(T item)
        {
            Contract.Requires<ArgumentNullException>(item != null, "item");
            Contract.Requires<ArgumentException>(item.CanBeDeleted);
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryProvider Provider
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryable<T> Include(System.Linq.Expressions.Expression<Func<T, object>> subSelector)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            Contract.Requires<ArgumentNullException>(item != null, "item");
            Contract.Requires<ArgumentException>(item.CanBeSaved);
            throw new NotImplementedException();
        }
    }
}
