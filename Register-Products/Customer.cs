using System;

namespace Register_Products
{
	internal class Customer
	{
		/* Variables */
		private int CustomerID;
		private String CustomerName;

		/* Default Initializer */

		public Customer()
		{
			CustomerID = 0;
			CustomerName = null;
		}

		/* Overloaded Initializer */

		public Customer(int id, String name)
		{
			this.CustomerID = id;
			this.CustomerName = name;
		}

		/* -- Getters -- */

		public int getCustomerID()	// CustomerID
		{
			return this.CustomerID;
		}

		public String getCustomerName() // Customer Name
		{
			return this.CustomerName;
		}
	}
}