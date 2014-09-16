using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Register_Products
{
	public partial class frmRegisterProducts : Form
	{
		/* Variables */
		private int custID;
		private String prodCode;
		private DateTime regDate;

		/* Default Initializer */

		public frmRegisterProducts()
		{
			InitializeComponent();
			cmbCustomer.Focus();
			populateCmbCustomer();
			populateCmbProduct();
			DTPickerRegistration.Value = DateTime.Now;

			cmbCustomer.SelectedIndex = -1;
			cmbProduct.SelectedIndex = -1;
		}

		/* Register Button */

		private void btnRegister_Click(object sender, EventArgs e)
		{
			try
			{
				custID = Int32.Parse(cmbCustomer.ValueMember);

				prodCode = cmbProduct.ValueMember;
				regDate = DTPickerRegistration.Value;

				Registration reg = new Registration(Convert.ToInt32(cmbCustomer.ValueMember), prodCode, regDate);
				RegistrationDB.AddRegistration(reg);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.GetType().ToString());
			}
		}

		/* Cancel Button - ***** NEEDS WORK ***** */

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Cancel Method
			custID = 0;
			prodCode = null;
			regDate = DateTime.Now;

			cmbCustomer.SelectedIndex = -1;
			cmbProduct.SelectedIndex = -1;
			DTPickerRegistration.Value = DateTime.Now;
		}

		/* Exit Button */

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/* ------ Helper Methods ------ */

		/* Populate Customer List */

		private void populateCmbCustomer()
		{
			List<Customer> customers = new List<Customer>();
			try
			{
				customers = CustomerDB.GetCustomers();
				cmbCustomer.DataSource = customers;
				cmbCustomer.DisplayMember = "CustomerID";
				cmbCustomer.ValueMember = "CustomerID";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.GetType().ToString());
			}
		}

		/* Populate Product List */

		private void populateCmbProduct()
		{
			List<Product> product = new List<Product>();
			try
			{
				product = ProductDB.GetProducts();
				cmbProduct.DataSource = product;
				cmbProduct.DisplayMember = "Name";
				cmbProduct.ValueMember = "ProductCode";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.GetType().ToString());
			}
		}

		private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtTest.Text = cmbCustomer.ValueMember.ToString();
			txtTest2.Text = cmbCustomer.DisplayMember;
		}
	}
}