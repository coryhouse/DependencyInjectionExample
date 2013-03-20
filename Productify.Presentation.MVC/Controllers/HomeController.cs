using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Productify.Domain.Services;
using Productify.Presentation.DependencyInjection.StructureMap;
using Productify.Presentation.Models.Home;
using StructureMap;

namespace Productify.Presentation.Controllers
{
    public class HomeController : Controller
    {
	    private readonly IProductService _productService;

		public HomeController(IProductService productService)
		{
			if (productService == null)
			{
				throw new ArgumentNullException("productService");
			}

			_productService = productService;
		}

        //
        // GET: /Default/

		public ActionResult Index()
		{
			var products = _productService.GetProductsOnSale();
			var vm = new HomePageViewModel();
			vm.Products = new List<ViewModelProduct>();

			foreach (var product in products)
			{
				vm.Products.Add(new ViewModelProduct(product.Id, product.Name));
			}
			return View(vm);
		}

		public ActionResult Index()
		{
			var container = new Container(new StructureMapRegistry());
			var productService = container.GetInstance<IProductService>();
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
