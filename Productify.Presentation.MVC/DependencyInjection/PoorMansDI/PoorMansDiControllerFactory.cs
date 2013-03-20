using System;
using System.Web.Mvc;
using System.Web.Routing;
using Productify.Data.Dapper;
using Productify.Domain.Repositories;
using Productify.Domain.Services;
using Productify.Presentation.Controllers;

namespace Productify.Presentation.DependencyInjection.PoorMansDI
{
	public class PoorMansDiControllerFactory : DefaultControllerFactory
	{
		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			IProductRepository productRepository = new ProductRepository();
			var productService = new ProductService(productRepository);

			if (controllerType == (typeof(HomeController)))
			{
				return new HomeController(productService);
			}

			if (controllerType == (typeof(ProductController)))
			{
				return new ProductController(productService);
			}
			return base.GetControllerInstance(requestContext, controllerType);
		}
	}
}