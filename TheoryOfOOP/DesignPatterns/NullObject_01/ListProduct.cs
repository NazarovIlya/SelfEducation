using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_01
{
	internal sealed class ListProduct
	{
		public List<string> products;

		public ListProduct()
		{
			this.products = new List<string>();
			products.Add("Milk");
			products.Add("Cakes");
			products.Add("Cream");
			products.Add("Soda");
			products.Add("Cofee");
			products.Add("Latte");
			products.Add("Cocoa");
			products.Add(string.Empty);
			products.Add(string.Empty);
		}
	}
}
