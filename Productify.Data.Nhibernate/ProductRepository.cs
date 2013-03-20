using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using NHibernate.Cfg;
using Productify.Domain.Model;
using NHibernate.Driver;
using NHibernate.Dialect;

namespace Productify.Data.Nhibernate
{
    public class ProductRepository
    {
		public ProductRepository()
		{
			var config = new Configuration();
			config.DataBaseIntegration(x =>
				                           {
					                           x.ConnectionString =
						                           "data source=localhost;initial catalog=Northwind;integrated security=True;";
					                           x.Driver<SqlClientDriver>();
					                           x.Dialect<MsSql2005Dialect>();
				                           });
			config.AddAssembly(Assembly.GetExecutingAssembly());
			var sessionFactory = config.BuildSessionFactory();
			using(var session = sessionFactory.OpenSession())
			{
				using (var tx = session.BeginTransaction())
				{
					//perform db logic
					tx.Commit(); 
				}
			}
		}

		public IQueryable<Product> GetAll()
		{
			throw new NotImplementedException();
		}
    }
}
