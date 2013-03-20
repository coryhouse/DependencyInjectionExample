using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Productify.Domain.Model
{
	public class Address
	{
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
	}
}
