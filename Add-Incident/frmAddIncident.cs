using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Incident
{
	public partial class frmAddIncident : Form
	{
		/* Default Constructor */
		public frmAddIncident()
		{
			InitializeComponent();
		}

		/* Exit Button */
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmAddIncident_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'techSupportDataSet.Products' table. You can move, or remove it, as needed.
			this.productsTableAdapter.Fill(this.techSupportDataSet.Products);
			// TODO: This line of code loads data into the 'techSupportDataSet.Incidents' table. You can move, or remove it, as needed.
			this.incidentsTableAdapter.Fill(this.techSupportDataSet.Incidents);
			// TODO: This line of code loads data into the 'techSupportDataSet.Customers' table. You can move, or remove it, as needed.
			this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);

		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.customersTableAdapter.GetCustomerDetails(this.techSupportDataSet.Customers);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}
	}
}
