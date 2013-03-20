using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Productify.Domain.Services;
using Productify.Presentation.Models.Product;

namespace Productify.Presentation.Controllers
{
    public class ProductController : Controller
    {
	    private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			if (productService == null)
			{
				throw new ArgumentNullException("productService");
			}

			_productService = productService;
		}

        //
        // GET: /Product/

		public ActionResult Index(int? id)
        {
	        var product = _productService.GetProductsOnSale().FirstOrDefault(p => p.Id == id);
			if (product == null)
			{
				throw new HttpException(404, "Product not found");
			}

			var vm = new ProductViewModel(product);
            return View(vm);
        }
    }
}
