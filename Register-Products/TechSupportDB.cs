using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Register_Products
{
	static class TechSupportDB
	{
		/* Variables */
		private String sourceDB = "C:\\Users\\2102771708\\Dropbox\\GitHub\\C#" +
							"\\Technical-Support-Project\\Database\\TechSupport.mdf";

		public void GetConnection()
		{
			String connString =
				"Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + sourceDB + ";" +
				"Integrated Security=True";

			SqlConnection connection = new SqlConnection(connString);
			connection.Open();

			// ...

			connection.Close();
		}
	}
}
