using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Add_Incident
{
	public partial class frmAddIncident : Form
	{
		/* Default Initializer */
		public frmAddIncident()
		{
			InitializeComponent();
			EnableControls(false);
		}

		/* Search Button */
		private void btnSearchCustomers_Click(object sender, EventArgs e)
		{
			searchCustomers();
		}

		/* Add Button */
		private void btnAdd_Click(object sender, EventArgs e)
		{
			addIncident();
		}

		/* Cancel Button */
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Cancel();
		}

		/* Exit Button */
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
				


		/* ------ Helper Methods ------ */


		/* Search Customers */
		private void searchCustomers()
		{
			try
			{
				int customerID = Convert.ToInt32(txtSearchCustomers.Text);	// Convert textbox to int

				// Set Customer
				this.customersTableAdapter.setCustomer(this.techSupportDataSet.Customers, customerID);

				if (this.customersBindingSource.Count > 0)
				{
					// Populate Products field w/ Registered Products to that Customer
					this.productsTableAdapter.FillByRegistrations(this.techSupportDataSet.Products, customerID);
					
					incidentsBindingSource.AddNew();						// Add new row to incidents table

					txtCustomerID.Text = customerID.ToString();				// Set CustomerID Field
					txtDateOpened.Text = DateTime.Now.ToShortDateString();	// Set TodaysDate Field
					EnableControls(true);									// Enable Controls
					cmbProducts.Focus();
				}

				// No Record Found
				else
				{
					txtCustomerID.Clear();							// Clear CustomerID Field
					txtDateOpened.Clear();							// Clear Date Field
					EnableControls(false);							// Disable Controls
					// Display Notification
					MessageBox.Show("Customer ID (" + txtSearchCustomers.Text + ") does not exist in this database.", "No Record Found");
					
					txtSearchCustomers.Clear();
					txtSearchCustomers.Focus();
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
			if (customersBindingSource.Count > 0)
			{
				if (IsValidData())
				{
					try
					{
						this.customersBindingSource.EndEdit();
						this.incidentsBindingSource.EndEdit();
						this.tableAdapterManager.UpdateAll(this.techSupportDataSet);

						MessageBox.Show("Incident Added:\n" +
							"\tCustomer ID: " + txtCustomerID.Text +
							"\n\tName: " + txtName.Text +
							"\n\tDate Opened: " + txtDateOpened.Text +
							"\n\tTitle: " + txtTitle.Text +
							"\n\tDescription: " + txtDescription.Text, "Incident Added");
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

		/* Validate Data */
		public bool IsValidData()
		{
			return
				IsPresent(txtCustomerID, "CustomerID") &&
				IsPresent(txtName, "Name") &&
				IsPresent(txtDateOpened, "DateOpened") &&
				IsPresent(cmbProducts, "Products") &&
				IsPresent(txtTitle, "Title") &&
				IsPresent(txtDescription, "Description");
		}

		/* Check for controls for content */
		public bool IsPresent(Control control, String name)
		{
			if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
			{
				TextBox textBox = (TextBox)control;
				if (textBox.Text == "")
				{
					MessageBox.Show(name + " is a required field.", "Missing Information");
					textBox.Focus();
					return false;
				}
			}
			else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
			{
				ComboBox comboBox = (ComboBox)control;
				if (comboBox.SelectedIndex == -1)
				{
					MessageBox.Show(name + " is a required field.", "Missing Information");
					comboBox.Focus();
					return false;
				}
			}
			return true;
		}

		 /* Enable/Disable Controls */
		private void EnableControls(bool control)
		{
			// Enable Controls
			if (control == true)
			{
				btnAdd.Enabled = true;
				btnCancel.Enabled = true;
				cmbProducts.Enabled = true;
				txtTitle.ReadOnly = false;
				txtDescription.ReadOnly = false;
			}
			// Disable Controls
			else if (control == false)
			{
				btnAdd.Enabled = false;
				btnCancel.Enabled = false;
				cmbProducts.Enabled = false;
				txtTitle.ReadOnly = true;
				txtDescription.ReadOnly = true;
			}
		}

		/* Cancel Changes */
		private void Cancel()
		{
			// Cancel edits
			this.customersBindingSource.CancelEdit();
			this.incidentsBindingSource.CancelEdit();
			this.productsBindingSource.CancelEdit();
			this.registrationsBindingSource.CancelEdit();

			// Remove Current Customer
			this.customersBindingSource.RemoveCurrent();

			// Clear form
			txtSearchCustomers.Clear();
			txtCustomerID.Clear();
			txtName.Clear();
			txtDateOpened.Clear();
			txtTitle.Clear();
			txtDescription.Clear();

			EnableControls(false);
		}

		/* Set default focus to search field */
		private void frmAddIncident_Shown(object sender, EventArgs e)
		{
			txtSearchCustomers.Focus();
		}
	}
}