using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Productify.Domain.Model;
using Dapper;
using Productify.Domain.Repositories;

namespace Productify.Data.Dapper
{
    public class ProductRepository : IProductRepository
    {
		public virtual IQueryable<Product> GetAll()
		{
			var connection = new SqlConnection("data source=localhost;initial catalog=Northwind;integrated security=True;");
			connection.Open();
			var products = connection.Query<Product>("SELECT ProductID Id, ProductName Name, Discontinued IsDiscontinued, * FROM Products p");
			return products.AsQueryable();
		}

		public IQueryable<Product> Include(System.Linq.Expressions.Expression<Func<Product, object>> subSelector)
		{
			throw new NotImplementedException();
		}

		public void Update(Product item)
		{
			throw new NotImplementedException();
		}

		public void Add(Product item)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(Product item)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(Product[] array, int arrayIndex)
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

		public bool Remove(Product item)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<Product> GetEnumerator()
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
	}
}