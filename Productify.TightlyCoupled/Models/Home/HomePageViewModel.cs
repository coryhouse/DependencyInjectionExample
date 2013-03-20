using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Productify.TightlyCoupled.Models.Home
{
	public class HomePageViewModel
	{
		public List<ViewModelProduct> Products { get; set; }
	}

	public class ViewModelProduct
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Slug { get; set; }

		public ViewModelProduct(int id, string name)
		{
			this.Id = id;
			this.Name = name;
			this.Slug = GenerateSlug(name);
		}

		private string GenerateSlug(string name)
		{
			string str = RemoveAccent(name).ToLower();
			// invalid chars           
			str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
			// convert multiple spaces into one space   
			str = Regex.Replace(str, @"\s+", " ").Trim();
			// cut and trim 
			str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
			str = Regex.Replace(str, @"\s", "-"); // hyphens   
			return str;
		}

		private string RemoveAccent(string txt)
		{
			byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(txt);
			return System.Text.Encoding.ASCII.GetString(bytes);
		}
	}
}