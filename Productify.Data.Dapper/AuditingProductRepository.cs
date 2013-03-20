using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Productify.Domain.Model;

namespace Productify.Data.Dapper
{
	/// <summary>
	/// Decorates ProductRepository to add auditing
	/// </summary>
	public class AuditingProductRepository : ProductRepository
	{
		private readonly ProductRepository innerRepository;
		private readonly IAuditor auditor;

		public AuditingProductRepository(ProductRepository repository, IAuditor auditor)
		{
			innerRepository = repository;
			this.auditor = auditor;
		}

		public override IQueryable<Product> GetAll()
		{
			auditor.Record("Got all products");
			return innerRepository.GetAll();
		}
	}
}
