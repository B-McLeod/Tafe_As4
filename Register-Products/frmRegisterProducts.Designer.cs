namespace Register_Products
{
	partial class frmRegisterProducts
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblCustomer = new System.Windows.Forms.Label();
			this.lblProduct = new System.Windows.Forms.Label();
			this.lblRegDate = new System.Windows.Forms.Label();
			this.cmbCustomer = new System.Windows.Forms.ComboBox();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.techSupportDataSet = new Register_Products.TechSupportDataSet();
			this.cmbProduct = new System.Windows.Forms.ComboBox();
			this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtRegDate = new System.Windows.Forms.TextBox();
			this.customersTableAdapter = new Register_Products.TechSupportDataSetTableAdapters.CustomersTableAdapter();
			this.tableAdapterManager = new Register_Products.TechSupportDataSetTableAdapters.TableAdapterManager();
			this.productsTableAdapter = new Register_Products.TechSupportDataSetTableAdapters.ProductsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(12, 100);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(116, 23);
			this.btnRegister.TabIndex = 4;
			this.btnRegister.Text = "Register Product";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(134, 100);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(270, 100);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblCustomer
			// 
			this.lblCustomer.AutoSize = true;
			this.lblCustomer.Location = new System.Drawing.Point(10, 12);
			this.lblCustomer.Name = "lblCustomer";
			this.lblCustomer.Size = new System.Drawing.Size(54, 13);
			this.lblCustomer.TabIndex = 0;
			this.lblCustomer.Text = "Customer:";
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Location = new System.Drawing.Point(17, 39);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(47, 13);
			this.lblProduct.TabIndex = 0;
			this.lblProduct.Text = "Product:";
			// 
			// lblRegDate
			// 
			this.lblRegDate.AutoSize = true;
			this.lblRegDate.Location = new System.Drawing.Point(10, 66);
			this.lblRegDate.Name = "lblRegDate";
			this.lblRegDate.Size = new System.Drawing.Size(54, 13);
			this.lblRegDate.TabIndex = 0;
			this.lblRegDate.Text = "Reg date:";
			// 
			// cmbCustomer
			// 
			this.cmbCustomer.FormattingEnabled = true;
			this.cmbCustomer.Location = new System.Drawing.Point(70, 9);
			this.cmbCustomer.Name = "cmbCustomer";
			this.cmbCustomer.Size = new System.Drawing.Size(275, 21);
			this.cmbCustomer.TabIndex = 1;
			// 
			// customersBindingSource
			// 
			this.customersBindingSource.DataMember = "Customers";
			this.customersBindingSource.DataSource = this.techSupportDataSet;
			// 
			// techSupportDataSet
			// 
			this.techSupportDataSet.DataSetName = "TechSupportDataSet";
			this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmbProduct
			// 
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.Location = new System.Drawing.Point(70, 36);
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.Size = new System.Drawing.Size(275, 21);
			this.cmbProduct.TabIndex = 2;
			// 
			// productsBindingSource
			// 
			this.productsBindingSource.DataMember = "Products";
			this.productsBindingSource.DataSource = this.techSupportDataSet;
			// 
			// txtRegDate
			// 
			this.txtRegDate.Location = new System.Drawing.Point(70, 63);
			this.txtRegDate.Name = "txtRegDate";
			this.txtRegDate.Size = new System.Drawing.Size(100, 20);
			this.txtRegDate.TabIndex = 3;
			// 
			// customersTableAdapter
			// 
			this.customersTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
			this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
			this.tableAdapterManager.RegistrationsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Register_Products.TechSupportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// productsTableAdapter
			// 
			this.productsTableAdapter.ClearBeforeFill = true;
			// 
			// frmRegisterProducts
			// 
			this.AcceptButton = this.btnRegister;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(357, 135);
			this.Controls.Add(this.txtRegDate);
			this.Controls.Add(this.cmbProduct);
			this.Controls.Add(this.cmbCustomer);
			this.Controls.Add(this.lblRegDate);
			this.Controls.Add(this.lblProduct);
			this.Controls.Add(this.lblCustomer);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnRegister);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRegisterProducts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Registration | Technical Support";
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblCustomer;
		private System.Windows.Forms.Label lblProduct;
		private System.Windows.Forms.Label lblRegDate;
		private System.Windows.Forms.ComboBox cmbCustomer;
		private System.Windows.Forms.ComboBox cmbProduct;
		private System.Windows.Forms.TextBox txtRegDate;
		private TechSupportDataSet techSupportDataSet;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private TechSupportDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private TechSupportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private TechSupportDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
		private System.Windows.Forms.BindingSource productsBindingSource;
	}
}

