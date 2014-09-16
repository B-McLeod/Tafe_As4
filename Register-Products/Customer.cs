using System;

namespace Register_Products
{
	public class Customer
	{
		/* Variables */

		public int CustomerID { get; set; }

		public String Name { get; set; }

		/* Default Initializer */

		public Customer()
		{
			CustomerID = 0;
			Name = null;
		}

		/* Overloaded Initializer */

		public Customer(int id, String name)
		{
			this.CustomerID = id;
			this.Name = name;
		}
	}
}