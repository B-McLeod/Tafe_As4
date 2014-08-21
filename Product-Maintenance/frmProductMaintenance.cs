using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Product_Maintenance
{
	public partial class frmProductMaintenance : Form
	{
		/* Default Initializer */

		public frmProductMaintenance()
		{
			InitializeComponent();
		}

		/* Save Button */

		private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			try
			{
				this.productsBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.techSupportDataSet);
			}
			catch (DBConcurrencyException)
			{
				MessageBox.Show("A concurrency error occurred. " +
					"Some rows were not updated. ", "Save Error");
				this.productsTableAdapter.Fill(this.techSupportDataSet.Products);
			}
			catch (SqlException ex)
			{
				MessageBox.Show(
					"Database error # " + ex.Number +
					": " + ex.Message, ex.GetType().ToString());
			}
		}

		/* Form Load */

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'techSupportDataSet.Products' table. You can move, or remove it, as needed.
			try
			{
				this.productsTableAdapter.Fill(this.techSupportDataSet.Products);
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Database error # " + ex.Number +
					": " + ex.Message, ex.GetType().ToString());
			}
		}

		/* Data Error Method */

		private void productsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			int row = e.RowIndex + 1;
			string errorMessage = "A data error occurred.\n" +
				"Row: " + row + "\n" +
				"Error: " + e.Exception.Message;
			MessageBox.Show(errorMessage, "Data Error");
		}
	}
}