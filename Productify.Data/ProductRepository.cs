using Productify.Domain.Model;
using Productify.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Productify.Data.EF
{
	public class ProductRepository : IProductRepository
    {
		public ProductRepository(string connectionString)
		{
			
		}
    
		public Product FindById(int id)
		{
			return new Product();
		}

		public IQueryable<Domain.Model.Product> GetAll()
		{
			throw new NotImplementedException();
			//Productify.Data.Entities(
			//using (var db = new Productify. ProductifyModel.Entities())
			//{
				
			//}
		}

		public IQueryable<Domain.Model.Product> Include(System.Linq.Expressions.Expression<Func<Domain.Model.Product, object>> subSelector)
		{
			throw new NotImplementedException();
		}

		public void Update(Domain.Model.Product item)
		{
			throw new NotImplementedException();
		}

		public void Add(Domain.Model.Product item)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(Domain.Model.Product item)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(Domain.Model.Product[] array, int arrayIndex)
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

		public bool Remove(Domain.Model.Product item)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<Domain.Model.Product> GetEnumerator()
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
