using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Register_Products
{
	class Customer
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



	}
}
