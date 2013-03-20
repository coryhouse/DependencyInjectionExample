using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Productify.Domain.Model;
using Productify.Domain.Repositories;

namespace Productify.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class, IAggregateRoot
	{
       public Repository()
        {
            this.ActiveContext = new ProductifyModelContainer();
        }

	   //[Dependency]
	   //public ProductifyModel ActiveContext { get; private set; }

	   //private DbSet<T> set = null;

	   //public DbSet<T> Set
	   //{
	   //	get
	   //	{
	   //		if (set == null)
	   //		{
	   //			set = this.ActiveContext.Set<T>();
	   //		}
	   //		return set;
	   //	}
	   //}

		//public void Add(T item)
		//{
		//	this.Set.Add(item);
		//	this.ActiveContext.SaveChanges();
		//}

		//public void Clear()
		//{
		//	throw new NotSupportedException();
		//}

		//public bool Contains(T item)
		//{
		//	throw new NotSupportedException();
		//}

		//public void CopyTo(T[] array, int arrayIndex)
		//{
		//	throw new NotSupportedException();
		//}

		//public int Count
		//{
		//	get
		//	{
		//		return this.Set.Count();
		//	}
		//}

		//public bool IsReadOnly
		//{
		//	get
		//	{
		//		return false;
		//	}
		//}

		//public bool Remove(T item)
		//{

		//	try
		//	{
		//		this.Set.Remove(item);
		//		this.ActiveContext.SaveChanges();
		//		return true;
		//	}
		//	catch
		//	{
		//		return false;
		//	}
		//}

		//public IQueryable<T> Include(Expression<Func<T, object>> subSelector)
		//{
		//	return this.Set.Include(subSelector);
		//}

		//public void Update(T item)
		//{
		//	this.ActiveContext.SaveChanges();
		//}

		//public IEnumerator<T> GetEnumerator()
		//{
		//	return this.Set.AsQueryable().AsEnumerable().GetEnumerator();
		//}

		//System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		//{
		//	return GetEnumerator();
		//}

	   //#region Implementation of IQueryable

	   //public Type ElementType
	   //{
	   //	get
	   //	{
	   //		return (this.Set.AsQueryable() as IQueryable).ElementType;
	   //	}
	   //}

	   //public System.Linq.Expressions.Expression Expression
	   //{
	   //	get
	   //	{
	   //		return (this.Set.AsQueryable() as IQueryable).Expression;
	   //	}
	   //}

	   //public IQueryProvider Provider
	   //{
	   //	get
	   //	{
	   //		return (this.Set.AsQueryable() as IQueryable).Provider;
	   //	}
	   //}

	   //#endregion
    }
}
