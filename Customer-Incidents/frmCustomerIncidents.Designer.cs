namespace Customer_Incidents
{
	partial class frmCustomerIncidents
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
			this.lblName = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblAddress2 = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.techSupportDataSet = new Customer_Incidents.TechSupportDataSet();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtState = new System.Windows.Forms.TextBox();
			this.txtZip = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.incidentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.incidentsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.getCustomerToolStrip = new System.Windows.Forms.ToolStrip();
			this.customerIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.customerIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.getCustomerToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.incidentsTableAdapter = new Customer_Incidents.TechSupportDataSetTableAdapters.IncidentsTableAdapter();
			this.tableAdapterManager = new Customer_Incidents.TechSupportDataSetTableAdapters.TableAdapterManager();
			this.customersTableAdapter = new Customer_Incidents.TechSupportDataSetTableAdapters.CustomersTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).BeginInit();
			this.getCustomerToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCustomerID
			// 
			this.lblCustomerID.AutoSize = true;
			this.lblCustomerID.Location = new System.Drawing.Point(23, 45);
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
			this.lblCustomerID.TabIndex = 24;
			this.lblCustomerID.Text = "Customer ID:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(53, 71);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 23;
			this.lblName.Text = "Name:";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(43, 97);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(48, 13);
			this.lblAddress.TabIndex = 22;
			this.lblAddress.Text = "Address:";
			// 
			// lblAddress2
			// 
			this.lblAddress2.AutoSize = true;
			this.lblAddress2.Location = new System.Drawing.Point(12, 123);
			this.lblAddress2.Name = "lblAddress2";
			this.lblAddress2.Size = new System.Drawing.Size(79, 13);
			this.lblAddress2.TabIndex = 21;
			this.lblAddress2.Text = "City, State, Zip:";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Location = new System.Drawing.Point(50, 150);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(41, 13);
			this.lblPhone.TabIndex = 20;
			this.lblPhone.Text = "Phone:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(56, 176);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(35, 13);
			this.lblEmail.TabIndex = 19;
			this.lblEmail.Text = "Email:";
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
			this.txtCustomerID.Location = new System.Drawing.Point(97, 42);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.ReadOnly = true;
			this.txtCustomerID.Size = new System.Drawing.Size(60, 20);
			this.txtCustomerID.TabIndex = 1;
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
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
			this.txtName.Location = new System.Drawing.Point(97, 68);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(250, 20);
			this.txtName.TabIndex = 2;
			// 
			// txtAddress
			// 
			this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
			this.txtAddress.Location = new System.Drawing.Point(97, 94);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.ReadOnly = true;
			this.txtAddress.Size = new System.Drawing.Size(250, 20);
			this.txtAddress.TabIndex = 3;
			// 
			// txtCity
			// 
			this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
			this.txtCity.Location = new System.Drawing.Point(97, 120);
			this.txtCity.Name = "txtCity";
			this.txtCity.ReadOnly = true;
			this.txtCity.Size = new System.Drawing.Size(113, 20);
			this.txtCity.TabIndex = 4;
			// 
			// txtState
			// 
			this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
			this.txtState.Location = new System.Drawing.Point(216, 120);
			this.txtState.Name = "txtState";
			this.txtState.ReadOnly = true;
			this.txtState.Size = new System.Drawing.Size(50, 20);
			this.txtState.TabIndex = 5;
			// 
			// txtZip
			// 
			this.txtZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ZipCode", true));
			this.txtZip.Location = new System.Drawing.Point(272, 120);
			this.txtZip.Name = "txtZip";
			this.txtZip.ReadOnly = true;
			this.txtZip.Size = new System.Drawing.Size(75, 20);
			this.txtZip.TabIndex = 6;
			// 
			// txtPhone
			// 
			this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
			this.txtPhone.Location = new System.Drawing.Point(97, 147);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.ReadOnly = true;
			this.txtPhone.Size = new System.Drawing.Size(150, 20);
			this.txtPhone.TabIndex = 7;
			// 
			// txtEmail
			// 
			this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
			this.txtEmail.Location = new System.Drawing.Point(97, 173);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.ReadOnly = true;
			this.txtEmail.Size = new System.Drawing.Size(250, 20);
			this.txtEmail.TabIndex = 8;
			// 
			// incidentsBindingSource1
			// 
			this.incidentsBindingSource1.DataMember = "FK_Incidents_Customers";
			this.incidentsBindingSource1.DataSource = this.customersBindingSource;
			// 
			// incidentsDataGridView
			// 
			this.incidentsDataGridView.AutoGenerateColumns = false;
			this.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.incidentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.incidentsDataGridView.DataSource = this.incidentsBindingSource1;
			this.incidentsDataGridView.Location = new System.Drawing.Point(12, 199);
			this.incidentsDataGridView.Name = "incidentsDataGridView";
			this.incidentsDataGridView.Size = new System.Drawing.Size(618, 221);
			this.incidentsDataGridView.TabIndex = 9;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductCode";
			this.dataGridViewTextBoxColumn3.HeaderText = "Product";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "DateOpened";
			this.dataGridViewTextBoxColumn4.HeaderText = "Date Opened";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 95;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "DateClosed";
			this.dataGridViewTextBoxColumn5.HeaderText = "Date Closed";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 95;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Title";
			this.dataGridViewTextBoxColumn6.HeaderText = "Title";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 250;
			// 
			// getCustomerToolStrip
			// 
			this.getCustomerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripLabel,
            this.customerIDToolStripTextBox,
            this.getCustomerToolStripButton});
			this.getCustomerToolStrip.Location = new System.Drawing.Point(0, 0);
			this.getCustomerToolStrip.Name = "getCustomerToolStrip";
			this.getCustomerToolStrip.Size = new System.Drawing.Size(650, 25);
			this.getCustomerToolStrip.TabIndex = 18;
			this.getCustomerToolStrip.Text = "getCustomerToolStrip";
			// 
			// customerIDToolStripLabel
			// 
			this.customerIDToolStripLabel.Name = "customerIDToolStripLabel";
			this.customerIDToolStripLabel.Size = new System.Drawing.Size(73, 22);
			this.customerIDToolStripLabel.Text = "CustomerID:";
			// 
			// customerIDToolStripTextBox
			// 
			this.customerIDToolStripTextBox.Name = "customerIDToolStripTextBox";
			this.customerIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
			// 
			// getCustomerToolStripButton
			// 
			this.getCustomerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.getCustomerToolStripButton.Name = "getCustomerToolStripButton";
			this.getCustomerToolStripButton.Size = new System.Drawing.Size(84, 22);
			this.getCustomerToolStripButton.Text = "Get Customer";
			this.getCustomerToolStripButton.ToolTipText = "Search Customers";
			this.getCustomerToolStripButton.Click += new System.EventHandler(this.getCustomerToolStripButton_Click);
			// 
			// incidentsBindingSource
			// 
			this.incidentsBindingSource.DataMember = "Incidents";
			this.incidentsBindingSource.DataSource = this.techSupportDataSet;
			// 
			// incidentsTableAdapter
			// 
			this.incidentsTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
			this.tableAdapterManager.IncidentsTableAdapter = this.incidentsTableAdapter;
			this.tableAdapterManager.UpdateOrder = Customer_Incidents.TechSupportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// customersTableAdapter
			// 
			this.customersTableAdapter.ClearBeforeFill = true;
			// 
			// frmCustomerIncidents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 440);
			this.Controls.Add(this.getCustomerToolStrip);
			this.Controls.Add(this.incidentsDataGridView);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtZip);
			this.Controls.Add(this.txtState);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtCustomerID);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblPhone);
			this.Controls.Add(this.lblAddress2);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblCustomerID);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCustomerIncidents";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer Incidents | Technical Support";
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).EndInit();
			this.getCustomerToolStrip.ResumeLayout(false);
			this.getCustomerToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCustomerID;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblAddress2;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.TextBox txtZip;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtEmail;
		private TechSupportDataSet techSupportDataSet;
		private System.Windows.Forms.BindingSource incidentsBindingSource;
		private TechSupportDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
		private TechSupportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private TechSupportDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private System.Windows.Forms.BindingSource incidentsBindingSource1;
		private System.Windows.Forms.DataGridView incidentsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.ToolStrip getCustomerToolStrip;
		private System.Windows.Forms.ToolStripLabel customerIDToolStripLabel;
		private System.Windows.Forms.ToolStripTextBox customerIDToolStripTextBox;
		private System.Windows.Forms.ToolStripButton getCustomerToolStripButton;

	}
}

