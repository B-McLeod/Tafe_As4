namespace Add_Incident
{
	partial class frmAddIncident
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
			this.lblCustomerID = new System.Windows.Forms.Label();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.techSupportDataSet = new Add_Incident.TechSupportDataSet();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtDateOpened = new System.Windows.Forms.TextBox();
			this.lblDateOpened = new System.Windows.Forms.Label();
			this.lblProduct = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.tsrSearchCustomers = new System.Windows.Forms.ToolStrip();
			this.lblSearchCustomers = new System.Windows.Forms.ToolStripLabel();
			this.txtSearchCustomers = new System.Windows.Forms.ToolStripTextBox();
			this.btnSearchCustomers = new System.Windows.Forms.ToolStripButton();
			this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customersTableAdapter = new Add_Incident.TechSupportDataSetTableAdapters.CustomersTableAdapter();
			this.tableAdapterManager = new Add_Incident.TechSupportDataSetTableAdapters.TableAdapterManager();
			this.incidentsTableAdapter = new Add_Incident.TechSupportDataSetTableAdapters.IncidentsTableAdapter();
			this.productsTableAdapter = new Add_Incident.TechSupportDataSetTableAdapters.ProductsTableAdapter();
			this.registrationsTableAdapter = new Add_Incident.TechSupportDataSetTableAdapters.RegistrationsTableAdapter();
			this.registrationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbProducts = new System.Windows.Forms.ComboBox();
			this.fKRegistrationsProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
			this.tsrSearchCustomers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKRegistrationsProductsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCustomerID
			// 
			this.lblCustomerID.AutoSize = true;
			this.lblCustomerID.Location = new System.Drawing.Point(23, 46);
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
			this.lblCustomerID.TabIndex = 0;
			this.lblCustomerID.Text = "Customer ID:";
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentsBindingSource, "CustomerID", true));
			this.txtCustomerID.Location = new System.Drawing.Point(94, 43);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.ReadOnly = true;
			this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerID.TabIndex = 0;
			this.txtCustomerID.TabStop = false;
			// 
			// incidentsBindingSource
			// 
			this.incidentsBindingSource.DataMember = "FK_Incidents_Customers";
			this.incidentsBindingSource.DataSource = this.customersBindingSource;
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
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(301, 274);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(220, 274);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Enabled = false;
			this.btnAdd.Location = new System.Drawing.Point(139, 274);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
			this.txtName.Location = new System.Drawing.Point(94, 69);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(282, 20);
			this.txtName.TabIndex = 0;
			this.txtName.TabStop = false;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(53, 72);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 5;
			this.lblName.Text = "Name:";
			// 
			// txtDateOpened
			// 
			this.txtDateOpened.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentsBindingSource, "DateOpened", true));
			this.txtDateOpened.Location = new System.Drawing.Point(94, 121);
			this.txtDateOpened.Name = "txtDateOpened";
			this.txtDateOpened.ReadOnly = true;
			this.txtDateOpened.Size = new System.Drawing.Size(125, 20);
			this.txtDateOpened.TabIndex = 0;
			this.txtDateOpened.TabStop = false;
			// 
			// lblDateOpened
			// 
			this.lblDateOpened.AutoSize = true;
			this.lblDateOpened.Location = new System.Drawing.Point(14, 124);
			this.lblDateOpened.Name = "lblDateOpened";
			this.lblDateOpened.Size = new System.Drawing.Size(74, 13);
			this.lblDateOpened.TabIndex = 9;
			this.lblDateOpened.Text = "Date Opened:";
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Location = new System.Drawing.Point(41, 150);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(47, 13);
			this.lblProduct.TabIndex = 10;
			this.lblProduct.Text = "Product:";
			// 
			// txtTitle
			// 
			this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentsBindingSource, "Title", true));
			this.txtTitle.Location = new System.Drawing.Point(94, 175);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(282, 20);
			this.txtTitle.TabIndex = 2;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(58, 178);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(30, 13);
			this.lblTitle.TabIndex = 13;
			this.lblTitle.Text = "Title:";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(25, 204);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(63, 13);
			this.lblDescription.TabIndex = 14;
			this.lblDescription.Text = "Description:";
			// 
			// txtDescription
			// 
			this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentsBindingSource, "Description", true));
			this.txtDescription.Location = new System.Drawing.Point(94, 201);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(282, 67);
			this.txtDescription.TabIndex = 3;
			// 
			// tsrSearchCustomers
			// 
			this.tsrSearchCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSearchCustomers,
            this.txtSearchCustomers,
            this.btnSearchCustomers});
			this.tsrSearchCustomers.Location = new System.Drawing.Point(0, 0);
			this.tsrSearchCustomers.Name = "tsrSearchCustomers";
			this.tsrSearchCustomers.Size = new System.Drawing.Size(396, 25);
			this.tsrSearchCustomers.TabIndex = 17;
			this.tsrSearchCustomers.Text = "getCustomerNameToolStrip";
			// 
			// lblSearchCustomers
			// 
			this.lblSearchCustomers.Name = "lblSearchCustomers";
			this.lblSearchCustomers.Size = new System.Drawing.Size(76, 22);
			this.lblSearchCustomers.Text = "Customer ID:";
			// 
			// txtSearchCustomers
			// 
			this.txtSearchCustomers.Name = "txtSearchCustomers";
			this.txtSearchCustomers.Size = new System.Drawing.Size(100, 25);
			// 
			// btnSearchCustomers
			// 
			this.btnSearchCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnSearchCustomers.Name = "btnSearchCustomers";
			this.btnSearchCustomers.Size = new System.Drawing.Size(84, 22);
			this.btnSearchCustomers.Text = "Get Customer";
			this.btnSearchCustomers.Click += new System.EventHandler(this.btnSearchCustomers_Click);
			// 
			// productsBindingSource
			// 
			this.productsBindingSource.DataMember = "Products";
			this.productsBindingSource.DataSource = this.techSupportDataSet;
			// 
			// customersTableAdapter
			// 
			this.customersTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
			this.tableAdapterManager.IncidentsTableAdapter = this.incidentsTableAdapter;
			this.tableAdapterManager.ProductsTableAdapter = null;
			this.tableAdapterManager.RegistrationsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Add_Incident.TechSupportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// incidentsTableAdapter
			// 
			this.incidentsTableAdapter.ClearBeforeFill = true;
			// 
			// productsTableAdapter
			// 
			this.productsTableAdapter.ClearBeforeFill = true;
			// 
			// registrationsTableAdapter
			// 
			this.registrationsTableAdapter.ClearBeforeFill = true;
			// 
			// registrationsBindingSource
			// 
			this.registrationsBindingSource.DataMember = "Registrations";
			this.registrationsBindingSource.DataSource = this.techSupportDataSet;
			// 
			// cmbProducts
			// 
			this.cmbProducts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.incidentsBindingSource, "ProductCode", true));
			this.cmbProducts.DataSource = this.productsBindingSource;
			this.cmbProducts.DisplayMember = "Name";
			this.cmbProducts.FormattingEnabled = true;
			this.cmbProducts.Location = new System.Drawing.Point(94, 147);
			this.cmbProducts.Name = "cmbProducts";
			this.cmbProducts.Size = new System.Drawing.Size(201, 21);
			this.cmbProducts.TabIndex = 18;
			this.cmbProducts.ValueMember = "ProductCode";
			// 
			// fKRegistrationsProductsBindingSource
			// 
			this.fKRegistrationsProductsBindingSource.DataMember = "FK_Registrations_Products";
			this.fKRegistrationsProductsBindingSource.DataSource = this.productsBindingSource;
			// 
			// frmAddIncident
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(396, 317);
			this.Controls.Add(this.cmbProducts);
			this.Controls.Add(this.tsrSearchCustomers);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.lblProduct);
			this.Controls.Add(this.lblDateOpened);
			this.Controls.Add(this.txtDateOpened);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtCustomerID);
			this.Controls.Add(this.lblCustomerID);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddIncident";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Incident | Technical Support";
			this.Shown += new System.EventHandler(this.frmAddIncident_Shown);
			((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
			this.tsrSearchCustomers.ResumeLayout(false);
			this.tsrSearchCustomers.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKRegistrationsProductsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCustomerID;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtDateOpened;
		private System.Windows.Forms.Label lblDateOpened;
		private System.Windows.Forms.Label lblProduct;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox txtDescription;
		private TechSupportDataSet techSupportDataSet;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private TechSupportDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private TechSupportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private TechSupportDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
		private System.Windows.Forms.BindingSource incidentsBindingSource;
		private System.Windows.Forms.BindingSource productsBindingSource;
		private TechSupportDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
		private System.Windows.Forms.ToolStrip tsrSearchCustomers;
		private System.Windows.Forms.ToolStripLabel lblSearchCustomers;
		private System.Windows.Forms.ToolStripButton btnSearchCustomers;
		private System.Windows.Forms.ToolStripTextBox txtSearchCustomers;
		private TechSupportDataSetTableAdapters.RegistrationsTableAdapter registrationsTableAdapter;
		private System.Windows.Forms.BindingSource registrationsBindingSource;
		private System.Windows.Forms.ComboBox cmbProducts;
		private System.Windows.Forms.BindingSource fKRegistrationsProductsBindingSource;
	}
}

