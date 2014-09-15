using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register_Products
{
	class Product
	{
		/* Variables */
		String Name;
		String ProductCode;

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

		/* -- Getters -- */

		public String getProductName()	// Product Name
		{
			return this.Name;
		}

		public String getProductCode() // Product Code
		{
			return this.ProductCode;
		}
	}
}
