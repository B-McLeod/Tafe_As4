using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Technician_Maintenance
{
	public partial class frmTechnicianMaintenance : Form
	{
		/* Default Constructor */
		public frmTechnicianMaintenance()
		{
			InitializeComponent();
			
		}

		/* Save Button */
		private void techniciansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			try
			{
				this.techniciansBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.techSupportDataSet);
				lblMessage.Text = "Technician Saved.";
			}
			catch (DBConcurrencyException)
			{
				MessageBox.Show("A concurrency error occurred. " +
					"Some rows were not updated. ", "Concurrency Exception");
				this.techniciansTableAdapter.Fill(this.techSupportDataSet.Technicians);
			}
			catch (DataException ex) {
				MessageBox.Show(ex.Message, ex.GetType().ToString());
				techniciansBindingSource.CancelEdit();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(
					"Database error # " + ex.Number +
					": " + ex.Message, ex.GetType().ToString());
			}
		}

		/* Form Load */

		private void frmTechnicianMaintenance_Load(object sender, EventArgs e)
		{
			try
			{
				this.techniciansTableAdapter.Fill(this.techSupportDataSet.Technicians);
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Database error # " + ex.Number +
					": " + ex.Message, ex.GetType().ToString());
			}
		}

		/* Data Error Method */

		private void techniciansDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			int row = e.RowIndex + 1;
			string errorMessage = "A data error occurred.\n" +
			"Row: " + row + "\n" +
			"Error: " + e.Exception.Message;
			MessageBox.Show(errorMessage, "Data Error");
		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
			lblMessage.Text = "Technician Deleted.";
		}
	}
}