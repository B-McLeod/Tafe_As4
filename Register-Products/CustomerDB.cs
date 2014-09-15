using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register_Products
{
	class CustomerDB
	{
		public List<Customer> GetCustomers()
		{
			/* The GetCustomers method in the CustomerDB class should return
			 * a List<Customer> object that can be bound to the Customer combo box */
			
			SqlConnection techConn = TechSupportDB.GetConnection();
			techConn.Open();

			String statement = "SELECT `Name` FROM `Customers`";

			SqlCommand selectCustomers = new SqlCommand(statement, techConn);

			// PAGE 653
			SqlDataReader reader = selectCustomers.ExecuteReader()

			techConn.Close();

			return customerList;
		}
	}
}
