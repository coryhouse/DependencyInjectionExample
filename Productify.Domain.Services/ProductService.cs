using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Productify.Domain.Model;
using Productify.Domain.Repositories;

namespace Productify.Domain.Services
{
	public class ProductService : IProductService
	{
        public IProductRepository ProductRepository { get; private set; }

		public ProductService(IProductRepository productRepository)
        {
            Contract.Requires<ArgumentNullException>(productRepository != null, "productRepository");
            Contract.Ensures(this.ProductRepository==productRepository, "productRepository");

            this.ProductRepository = productRepository;
        }

        public IQueryable<Product> GetProductsOnSale()
        {
	        return from p in this.ProductRepository.GetAll() where p.IsDiscontinued == false select p;
        }

        public IQueryable<Product> GetAvailableProductsOnSale()
        {
            return from p in GetProductsOnSale() where p.UnitsInStock > 0 select p;
        }

        public IQueryable<Product> GetRelatedProducts(int productId)
        {
            int categoryId = (from pd in this.GetProductsOnSale() where pd.Id == productId select pd.Category.Id).Single();
            return from p in GetAvailableProductsOnSale()
                   where p.Id!=productId && p.Category.Id == categoryId 
                   select p;
        }
    }
}