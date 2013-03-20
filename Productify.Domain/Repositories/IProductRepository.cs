using System.Collections.Generic;
using System.Linq;
using Productify.Domain.Model;

namespace Productify.Domain.Repositories
{
    /// <summary>
    /// Represents the repository of objects of type Product
    /// </summary>
    public interface IProductRepository : IRepository<Product>
    {
		IQueryable<Product> GetAll();
    }
}
