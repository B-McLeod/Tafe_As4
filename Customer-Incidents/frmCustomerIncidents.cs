using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		/* Window Load */
		private void frmCustomerIncidents_Load(object sender, EventArgs e)
		{
			// Load data into 'techSupportDataSet.Customers' table. - Commented out to stop pre-loading first customer.
			//this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);

			// Load data into 'techSupportDataSet.Incidents' table.
			this.incidentsTableAdapter.Fill(this.techSupportDataSet.Incidents);

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