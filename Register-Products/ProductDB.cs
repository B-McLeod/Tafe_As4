using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Register_Products
{
	public static class ProductDB
	{
		public static List<Product> GetProducts()
		{
			/* The GetProducts method in the ProductDB class should return a
			* List<Product> object that can be bound to the Product combo box. */

			SqlConnection connection = TechSupportDB.GetConnection();
			String queryString = "SELECT Name, ProductCode FROM Products";
			SqlCommand selectProducts = new SqlCommand(queryString, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectProducts.ExecuteReader();

				// Initialize and build customerList from SQL query
				List<Product> productList = new List<Product>();
				while (reader.Read())
				{
					String name = reader["Name"].ToString();
					String code = reader["ProductCode"].ToString();
					Product p = new Product(name, code);
					productList.Add(p);
				}
				reader.Close();

				return productList;
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