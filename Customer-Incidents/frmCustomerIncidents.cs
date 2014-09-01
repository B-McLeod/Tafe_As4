using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Customer_Incidents
{
	public partial class frmCustomerIncidents : Form
	{
		/* Default Constructor */
		public frmCustomerIncidents()
		{
			InitializeComponent();
		}

		/* Search Customers */
		private void getCustomerToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				/* Convert textbox to integer */
				int customerID = Convert.ToInt32(customerIDToolStripTextBox.Text);

				this.customersTableAdapter.GetCustomer(
				this.techSupportDataSet.Customers, customerID);

				/* If no record is found */
				if (this.techSupportDataSet.Customers.Rows.Count == 0)
				{
					MessageBox.Show("No Record Found");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.GetType().ToString());
			}
		}
	}
}