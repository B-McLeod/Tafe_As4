using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register_Products
{
	public partial class frmRegisterProducts : Form
	{
		/* Default Initializer */
		public frmRegisterProducts()
		{
			InitializeComponent();
			cmbCustomer.Focus();
		}

		/* Register Button */
		private void btnRegister_Click(object sender, EventArgs e)
		{
			// Registration Method
		}
		
		/* Cancel Button */
		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Cancel Method
		}

		/* Exit Button */
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		/* ------ Helper Methods ------ */


	}
}
