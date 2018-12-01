namespace QuanLyTiemGiatUi
{
	partial class OrderForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gridOrderList = new System.Windows.Forms.DataGridView();
			this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.quanLyGiatUiDataSet2 = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet2();
			this.btnDelOrder = new System.Windows.Forms.Button();
			this.ordersTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet2TableAdapters.OrdersTableAdapter();
			this.btnExit = new System.Windows.Forms.Button();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deliveryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridOrderList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet2)).BeginInit();
			this.SuspendLayout();
			// 
			// gridOrderList
			// 
			this.gridOrderList.AllowUserToAddRows = false;
			this.gridOrderList.AllowUserToDeleteRows = false;
			this.gridOrderList.AllowUserToResizeRows = false;
			this.gridOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridOrderList.AutoGenerateColumns = false;
			this.gridOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gridOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.orderNameDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.deliveryDataGridViewCheckBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
			this.gridOrderList.DataSource = this.ordersBindingSource;
			this.gridOrderList.Location = new System.Drawing.Point(4, 3);
			this.gridOrderList.MultiSelect = false;
			this.gridOrderList.Name = "gridOrderList";
			this.gridOrderList.ReadOnly = true;
			this.gridOrderList.RowHeadersVisible = false;
			this.gridOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridOrderList.Size = new System.Drawing.Size(799, 362);
			this.gridOrderList.TabIndex = 0;
			this.gridOrderList.SelectionChanged += new System.EventHandler(this.gridOrderList_SelectionChanged);
			// 
			// ordersBindingSource
			// 
			this.ordersBindingSource.DataMember = "Orders";
			this.ordersBindingSource.DataSource = this.quanLyGiatUiDataSet2;
			// 
			// quanLyGiatUiDataSet2
			// 
			this.quanLyGiatUiDataSet2.DataSetName = "QuanLyGiatUiDataSet2";
			this.quanLyGiatUiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnDelOrder
			// 
			this.btnDelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelOrder.AutoSize = true;
			this.btnDelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnDelOrder.Location = new System.Drawing.Point(296, 374);
			this.btnDelOrder.Name = "btnDelOrder";
			this.btnDelOrder.Size = new System.Drawing.Size(97, 30);
			this.btnDelOrder.TabIndex = 1;
			this.btnDelOrder.Text = "Xóa đơn hàng";
			this.btnDelOrder.UseVisualStyleBackColor = true;
			this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
			// 
			// ordersTableAdapter
			// 
			this.ordersTableAdapter.ClearBeforeFill = true;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.AutoSize = true;
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnExit.Location = new System.Drawing.Point(420, 373);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(84, 30);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn.Width = 43;
			// 
			// customerNameDataGridViewTextBoxColumn
			// 
			this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
			this.customerNameDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
			this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
			this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.customerNameDataGridViewTextBoxColumn.Width = 102;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "SDT";
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
			this.phoneDataGridViewTextBoxColumn.Width = 54;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			this.addressDataGridViewTextBoxColumn.Width = 48;
			// 
			// orderNameDataGridViewTextBoxColumn
			// 
			this.orderNameDataGridViewTextBoxColumn.DataPropertyName = "OrderName";
			this.orderNameDataGridViewTextBoxColumn.HeaderText = "Tên hàng";
			this.orderNameDataGridViewTextBoxColumn.Name = "orderNameDataGridViewTextBoxColumn";
			this.orderNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.orderNameDataGridViewTextBoxColumn.Width = 72;
			// 
			// serviceDataGridViewTextBoxColumn
			// 
			this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
			this.serviceDataGridViewTextBoxColumn.HeaderText = "Dịch vụ";
			this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
			this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
			this.serviceDataGridViewTextBoxColumn.Width = 64;
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "Khối lượng (kg)";
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			this.weightDataGridViewTextBoxColumn.ReadOnly = true;
			this.weightDataGridViewTextBoxColumn.Width = 95;
			// 
			// deliveryDataGridViewCheckBoxColumn
			// 
			this.deliveryDataGridViewCheckBoxColumn.DataPropertyName = "Delivery";
			this.deliveryDataGridViewCheckBoxColumn.HeaderText = "Giao hàng tận nơi";
			this.deliveryDataGridViewCheckBoxColumn.Name = "deliveryDataGridViewCheckBoxColumn";
			this.deliveryDataGridViewCheckBoxColumn.ReadOnly = true;
			this.deliveryDataGridViewCheckBoxColumn.Width = 75;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			dataGridViewCellStyle1.Format = "N0";
			dataGridViewCellStyle1.NullValue = null;
			this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.priceDataGridViewTextBoxColumn.HeaderText = "Thành tiền (VND)";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			this.priceDataGridViewTextBoxColumn.Width = 105;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
			this.statusDataGridViewTextBoxColumn.Width = 74;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Thời gian";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateDataGridViewTextBoxColumn.Width = 70;
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(807, 410);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnDelOrder);
			this.Controls.Add(this.gridOrderList);
			this.Name = "OrderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Quản lý đơn hàng";
			this.Load += new System.EventHandler(this.OrderForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridOrderList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridOrderList;
		private System.Windows.Forms.Button btnDelOrder;
		private QuanLyGiatUiDataSet2 quanLyGiatUiDataSet2;
		private System.Windows.Forms.BindingSource ordersBindingSource;
		private QuanLyGiatUiDataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn deliveryDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
	}
}