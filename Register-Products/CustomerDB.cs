using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Register_Products
{
	public static class CustomerDB
	{
		public static List<Customer> GetCustomers()
		{
			/* The GetCustomers method in the CustomerDB class should return
			 * a List<Customer> object that can be bound to the Customer combo box */

			SqlConnection connection = TechSupportDB.GetConnection();
			String queryString = "SELECT CustomerID, Name FROM Customers";
			SqlCommand selectCustomers = new SqlCommand(queryString, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCustomers.ExecuteReader();

				// Initialize and build customerList from SQL query
				List<Customer> customerList = new List<Customer>();
				while (reader.Read())
				{
					int id = Convert.ToInt32(reader["CustomerID"]);
					String name = reader["Name"].ToString();
					Customer c = new Customer(id, name);
					customerList.Add(c);
				}
				reader.Close();

				return customerList;
			}
			catch (SqlException ex)
			{
				return null;
				throw ex;
			}
			finally
			{
				connection.Close();
			}
		}
	}
}