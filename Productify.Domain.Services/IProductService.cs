using System.Linq;
using Productify.Domain.Model;

namespace Productify.Domain.Services
{
	public interface IProductService
	{
		IQueryable<Product> GetProductsOnSale();
		IQueryable<Product> GetAvailableProductsOnSale();
		IQueryable<Product> GetRelatedProducts(int productId);
	}
}