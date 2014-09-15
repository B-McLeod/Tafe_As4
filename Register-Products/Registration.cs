using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register_Products
{
	class Registration
	{
		/* Variables */
		int CustomerID;
		String ProductCode;
		Nullable<DateTime> RegistrationDate;

		/* Default Initializer */

		public Registration()
		{
			CustomerID = 0;
			ProductCode = null;
			RegistrationDate = null;
		}

		/* Overloaded Initializer */

		public Registration(int id, String code, DateTime date)
		{
			this.CustomerID = id;
			this.ProductCode = code;
			this.RegistrationDate = date;
		}

		/* -- Getters -- */

		public int getCustomerID()	// CustomerID
		{
			return this.CustomerID;
		}

		public String getProductCode() // Product Code
		{
			return this.ProductCode;
		}

		public Nullable<DateTime> getRegistrationDate() // Registration Date
		{
			return this.RegistrationDate;
		}
	}
}
