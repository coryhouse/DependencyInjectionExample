using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Productify.Data.Dapper;
using Productify.Domain.Services;
using Productify.TightlyCoupled.Models.Home;

namespace Productify.TightlyCoupled.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {
	        var productRepository = new ProductRepository();
	        var productService = new ProductService(productRepository);

	        var products = productService.GetProductsOnSale();

	        var vm = new HomePageViewModel();
			vm.Products = new List<ViewModelProduct>();       

			foreach (var product in products)
			{
				vm.Products.Add(new ViewModelProduct(product.Id, product.Name));
	        }
	        return View(vm);
        }

    }
}
