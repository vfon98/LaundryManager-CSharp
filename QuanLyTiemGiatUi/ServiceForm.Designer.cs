namespace QuanLyTiemGiatUi
{
	partial class ServiceForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSerName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.numSerPrice = new System.Windows.Forms.NumericUpDown();
			this.gridServices = new System.Windows.Forms.DataGridView();
			this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.servicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.quanLyGiatUiDataSet1 = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet1();
			this.btnAddSer = new System.Windows.Forms.Button();
			this.btnModifySer = new System.Windows.Forms.Button();
			this.btnDelSer = new System.Windows.Forms.Button();
			this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.servicesTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet1TableAdapters.ServicesTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.numSerPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridServices)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(66, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Danh sách dịch vụ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên dịch vụ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Đơn giá";
			// 
			// txtSerName
			// 
			this.txtSerName.Location = new System.Drawing.Point(93, 43);
			this.txtSerName.Name = "txtSerName";
			this.txtSerName.Size = new System.Drawing.Size(179, 20);
			this.txtSerName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(225, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "VND/kg";
			// 
			// numSerPrice
			// 
			this.numSerPrice.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numSerPrice.Location = new System.Drawing.Point(93, 78);
			this.numSerPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numSerPrice.Name = "numSerPrice";
			this.numSerPrice.Size = new System.Drawing.Size(126, 20);
			this.numSerPrice.TabIndex = 6;
			this.numSerPrice.ThousandsSeparator = true;
			// 
			// gridServices
			// 
			this.gridServices.AllowUserToResizeColumns = false;
			this.gridServices.AllowUserToResizeRows = false;
			this.gridServices.AutoGenerateColumns = false;
			this.gridServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
			this.gridServices.DataSource = this.servicesBindingSource1;
			this.gridServices.Location = new System.Drawing.Point(5, 158);
			this.gridServices.MultiSelect = false;
			this.gridServices.Name = "gridServices";
			this.gridServices.RowHeadersVisible = false;
			this.gridServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridServices.Size = new System.Drawing.Size(301, 218);
			this.gridServices.TabIndex = 7;
			this.gridServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridServices_CellClick);
			this.gridServices.SelectionChanged += new System.EventHandler(this.gridServices_SelectionChanged);
			// 
			// sTTDataGridViewTextBoxColumn
			// 
			this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
			this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
			this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
			this.sTTDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// servicesBindingSource1
			// 
			this.servicesBindingSource1.DataMember = "Services";
			this.servicesBindingSource1.DataSource = this.quanLyGiatUiDataSet1;
			// 
			// quanLyGiatUiDataSet1
			// 
			this.quanLyGiatUiDataSet1.DataSetName = "QuanLyGiatUiDataSet1";
			this.quanLyGiatUiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnAddSer
			// 
			this.btnAddSer.AutoSize = true;
			this.btnAddSer.Location = new System.Drawing.Point(19, 114);
			this.btnAddSer.Name = "btnAddSer";
			this.btnAddSer.Size = new System.Drawing.Size(82, 23);
			this.btnAddSer.TabIndex = 8;
			this.btnAddSer.Text = "Thêm dịch vụ";
			this.btnAddSer.UseVisualStyleBackColor = true;
			this.btnAddSer.Click += new System.EventHandler(this.btnAddSer_Click);
			// 
			// btnModifySer
			// 
			this.btnModifySer.Location = new System.Drawing.Point(117, 114);
			this.btnModifySer.Name = "btnModifySer";
			this.btnModifySer.Size = new System.Drawing.Size(75, 23);
			this.btnModifySer.TabIndex = 9;
			this.btnModifySer.Text = "Lưu thay đổi";
			this.btnModifySer.UseVisualStyleBackColor = true;
			this.btnModifySer.Click += new System.EventHandler(this.btnModifySer_Click);
			// 
			// btnDelSer
			// 
			this.btnDelSer.Enabled = false;
			this.btnDelSer.Location = new System.Drawing.Point(210, 114);
			this.btnDelSer.Name = "btnDelSer";
			this.btnDelSer.Size = new System.Drawing.Size(75, 23);
			this.btnDelSer.TabIndex = 10;
			this.btnDelSer.Text = "Xóa dịch vụ";
			this.btnDelSer.UseVisualStyleBackColor = true;
			this.btnDelSer.Click += new System.EventHandler(this.btnDelSer_Click);
			// 
			// servicesBindingSource
			// 
			this.servicesBindingSource.DataMember = "Services";
			this.servicesBindingSource.DataSource = this.quanLyGiatUiDataSet1;
			// 
			// servicesTableAdapter
			// 
			this.servicesTableAdapter.ClearBeforeFill = true;
			// 
			// ServiceForm
			// 
			this.AcceptButton = this.btnAddSer;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 381);
			this.Controls.Add(this.btnDelSer);
			this.Controls.Add(this.btnModifySer);
			this.Controls.Add(this.btnAddSer);
			this.Controls.Add(this.gridServices);
			this.Controls.Add(this.numSerPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSerName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ServiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Quản lý dịch vụ";
			this.Load += new System.EventHandler(this.ServiceForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numSerPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridServices)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSerName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numSerPrice;
		private System.Windows.Forms.DataGridView gridServices;
		private System.Windows.Forms.Button btnAddSer;
		private System.Windows.Forms.Button btnModifySer;
		private System.Windows.Forms.Button btnDelSer;
		private QuanLyGiatUiDataSet1 quanLyGiatUiDataSet1;
		private System.Windows.Forms.BindingSource servicesBindingSource;
		private QuanLyGiatUiDataSet1TableAdapters.ServicesTableAdapter servicesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource servicesBindingSource1;
	}
}