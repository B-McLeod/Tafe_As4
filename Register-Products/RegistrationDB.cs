using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Register_Products
{
	public class RegistrationDB
	{
		public static bool AddRegistration(Registration reg)
		{
			/*
			 * AddRegistration method in the RegistrationDB class should accept a Registration
			 * object and return a Boolean value that indicates if the operation was successful.
			 * Use the value that’s returned by the AddRegistration method to display a message
			 * indicating the result of the operation.
			 * */
			SqlConnection connection = TechSupportDB.GetConnection();
			String insertStatement = "INSERT Registrations " +
				"(CustomerID, ProductCode, RegistrationDate)" +
				"VALUES (@CustomerID, @ProductCode, @RegistrationDate)";
			SqlCommand insert = new SqlCommand(insertStatement, connection);

			insert.Parameters.AddWithValue("@CustomerID", reg.CustomerID);
			insert.Parameters.AddWithValue("@ProductCode", reg.ProductCode);
			insert.Parameters.AddWithValue("@RegistrationDate", reg.RegistrationDate);

			try
			{
				connection.Open();
				insert.ExecuteNonQuery();
				return true;
			}
			catch (SqlException ex)
			{
				if (ex.Number == 2627)
				{
					MessageBox.Show("This product is already registered to this person!");
				}
				else
				{
					MessageBox.Show(ex.Message, "SQL Exception");
				}
				return false;
			}
			finally
			{
				connection.Close();
			}
		}
	}
}