using System;

namespace Register_Products
{
	public class Product
	{
		/* Variables */

		public String Name { get; set; }

		public String ProductCode { get; set; }

		/* Default Initializer */

		public Product()
		{
			Name = null;
			ProductCode = null;
		}

		/* Overloaded Initializer */

		public Product(String name, String code)
		{
			this.Name = name;
			this.ProductCode = code;
		}
	}
}