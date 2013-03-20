using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Productify.Presentation.Models.Product
{
	public class ProductViewModel
	{
		public ProductViewModel(Domain.Model.Product product)
		{
			Name = product.Name;
			Price = string.Format("{0:C}", product.UnitPrice);
			UnitsInStock = product.UnitsInStock;
		}

		public string Name;
		public string Price;
		public int UnitsInStock;
	}
}