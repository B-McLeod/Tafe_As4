using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Add_Incident
{
	public partial class frmAddIncident : Form
	{
		public static String todaysDate = DateTime.Now.ToString("MM/dd/yyyy");
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

		/* Cancel Button */
		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Cancel edit
			this.incidentsBindingSource.CancelEdit();

			// Clear form
			txtSearchCustomers.Clear();
			txtCustomerID.Clear();
			txtName.Clear();
			txtDateOpened.Clear();
			txtTitle.Clear();
			txtDescription.Clear();
			cmbProducts.Refresh();			//needs work
		}

		/* Search Customers */

		private void searchCustomers()
		{
			try
			{

				// Display todays date
				txtDateOpened.Text = todaysDate;

				// Convert textbox to integer
				int customerID = Convert.ToInt32(txtSearchCustomers.Text);

				// Display Customer Name
				this.customersTableAdapter.setCustomer(this.techSupportDataSet.Customers, customerID);
				// Display Customers Registered Products
				this.productsTableAdapter.getProducts(this.techSupportDataSet.Products, customerID);
				// Add blank Incident row
				this.incidentsBindingSource.AddNew();
				this.incidentsTableAdapter.newIncident(this.techSupportDataSet.Incidents, customerID, todaysDate);

				// Enable 'Add' and 'Cancel' buttons
				btnAdd.Enabled = true;
				btnCancel.Enabled = true;

				// If no record is found
				if (this.techSupportDataSet.Customers.Rows.Count == 0)
				{
					// Disable 'Add' and 'Cancel' buttons
					btnAdd.Enabled = false;
					btnCancel.Enabled = false;
					txtDateOpened.Clear();

					MessageBox.Show("No Record Found");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.GetType().ToString());
			}
		}

		/* Add Incident */

		private void addIncident()
		{
			if (IsValidData())
			{
				try
				{
					this.customersBindingSource.EndEdit();
					this.tableAdapterManager.UpdateAll(this.techSupportDataSet);
				}
				catch (ArgumentException ex)
				{
					MessageBox.Show(ex.Message, "Arguement Exception");
					customersBindingSource.CancelEdit();
				}
				catch (DBConcurrencyException)
				{
					MessageBox.Show("A concurrency error occurred. Some rows were not updated.", "Concurrency Exception");
					this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);
				}
				catch (DataException ex)
				{
					MessageBox.Show(ex.Message, ex.GetType().ToString());
					customersBindingSource.CancelEdit();
				}
				catch (SqlException ex)
				{
					MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
				}
			}
			else
			{
				try
				{
					this.tableAdapterManager.UpdateAll(this.techSupportDataSet);
				}
				catch (DBConcurrencyException)
				{
					MessageBox.Show("A concurrency error occurred. Some rows were not updated.", "Concurrency Exception");
					this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);
				}
				catch (SqlException ex)
				{
					MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
				}
			}
		}

		/* Helper Methods */

		//
		// Set default focus to search field
		//
		private void frmAddIncident_Shown(object sender, EventArgs e)
		{
			txtSearchCustomers.Focus();
		}

		//
		// Pre-Fill Data (Commented Out)
		//
		private void frmAddIncident_Load(object sender, EventArgs e)
		{
			// Products Table
			//this.productsTableAdapter.Fill(this.techSupportDataSet.Products);

			// Incidents Table
			//this.incidentsTableAdapter.Fill(this.techSupportDataSet.Incidents);

			// Customers Table
			//this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);
		}

		//
		// Search Button Click
		//
		private void btnSearchCustomers_Click(object sender, EventArgs e)
		{
			searchCustomers();
		}


	}
}