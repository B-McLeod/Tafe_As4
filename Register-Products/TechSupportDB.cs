using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Register_Products
{
	static class TechSupportDB
	{
		// Path of database file
		private String sourceDB = "C:\\Users\\2102771708\\" +
									"Dropbox\\GitHub\\C#\\Technical-Support-Project\\Database\\TechSupport.mdf";

		// Connect to the TechSupport.mdf database
		public SqlConnection GetConnection()
		{
			try
			{
				//Connection String
				String connString =
					"Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + sourceDB + ";" +
					"Integrated Security=True";

				SqlConnection connTechSupport = new SqlConnection(connString); // Create connection
				return connTechSupport;
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
				return null;
			}
		}
	}
}