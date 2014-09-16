using System;

namespace Register_Products
{
	public class Registration
	{
		/* Variables */

		public int CustomerID { get; set; }

		public String ProductCode { get; set; }

		public DateTime RegistrationDate { get; set; }

		/* Default Initializer */

		public Registration()
		{
			CustomerID = 0;
			ProductCode = null;
			RegistrationDate = DateTime.Now;
		}

		/* Overloaded Initializer */

		public Registration(int id, String code, DateTime date)
		{
			this.CustomerID = id;
			this.ProductCode = code;
			this.RegistrationDate = date;
		}
	}
}