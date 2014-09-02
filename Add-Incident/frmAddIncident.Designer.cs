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
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtDateOpened = new System.Windows.Forms.TextBox();
			this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblDateOpened = new System.Windows.Forms.Label();
			this.lblProduct = new System.Windows.Forms.Label();
			this.cmbProduct = new System.Windows.Forms.ComboBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
			this.btnSearchCustomers = new System.Windows.Forms.ToolStripButton();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.techSupportDataSet = new Add_Incident.TechSupportDataSet();
			this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customersTableAdapter = new Add_Incident.TechSupportDataSetTableAdapters.CustomersTableAdapter();
			this.tableAdapterManager = new Add_Incident.TechSupportDataSetTableAdapters.TableAdapterManager();
			this.incidentsTableAdapter = new Add_Incident.TechSupportDataSetTableAdapters.IncidentsTableAdapter();
			this.productsTableAdapter = new Add_Incident.TechSupportDataSetTableAdapters.ProductsTableAdapter();
			this.lblSearchCustomers = new System.Windows.Forms.ToolStripLabel();
			this.txtSearchCustomers = new System.Windows.Forms.ToolStripTextBox();
			((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
			this.fillByToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
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
			this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
			this.txtCustomerID.Location = new System.Drawing.Point(94, 43);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.ReadOnly = true;
			this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerID.TabIndex = 1;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(301, 274);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(220, 274);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(139, 274);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
			this.txtName.Location = new System.Drawing.Point(94, 69);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(282, 20);
			this.txtName.TabIndex = 6;
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
			this.txtDateOpened.TabIndex = 8;
			// 
			// incidentsBindingSource
			// 
			this.incidentsBindingSource.DataMember = "FK_Incidents_Customers";
			this.incidentsBindingSource.DataSource = this.customersBindingSource;
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
			// cmbProduct
			// 
			this.cmbProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Name", true));
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.Location = new System.Drawing.Point(94, 147);
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.Size = new System.Drawing.Size(201, 21);
			this.cmbProduct.TabIndex = 11;
			// 
			// txtTitle
			// 
			this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentsBindingSource, "Title", true));
			this.txtTitle.Location = new System.Drawing.Point(94, 175);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(282, 20);
			this.txtTitle.TabIndex = 12;
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
			this.txtDescription.TabIndex = 15;
			// 
			// fillByToolStrip
			// 
			this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSearchCustomers,
            this.txtSearchCustomers,
            this.btnSearchCustomers});
			this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
			this.fillByToolStrip.Name = "fillByToolStrip";
			this.fillByToolStrip.Size = new System.Drawing.Size(396, 25);
			this.fillByToolStrip.TabIndex = 16;
			this.fillByToolStrip.Text = "fillByToolStrip";
			// 
			// btnSearchCustomers
			// 
			this.btnSearchCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnSearchCustomers.Name = "btnSearchCustomers";
			this.btnSearchCustomers.Size = new System.Drawing.Size(84, 22);
			this.btnSearchCustomers.Text = "Get Customer";
			this.btnSearchCustomers.Click += new System.EventHandler(this.fillByToolStripButton_Click);
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
			// frmAddIncident
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(396, 317);
			this.Controls.Add(this.fillByToolStrip);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.cmbProduct);
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
			this.Load += new System.EventHandler(this.frmAddIncident_Load);
			((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
			this.fillByToolStrip.ResumeLayout(false);
			this.fillByToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
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
		private System.Windows.Forms.ComboBox cmbProduct;
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
		private System.Windows.Forms.ToolStrip fillByToolStrip;
		private System.Windows.Forms.ToolStripButton btnSearchCustomers;
		private System.Windows.Forms.ToolStripLabel lblSearchCustomers;
		private System.Windows.Forms.ToolStripTextBox txtSearchCustomers;
	}
}

