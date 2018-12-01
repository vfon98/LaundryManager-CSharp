namespace QuanLyTiemGiatUi
{
	partial class ReportForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cboYear = new System.Windows.Forms.ComboBox();
			this.getYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.quanLyGiatUiDataSet2 = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet2();
			this.cboMonth = new System.Windows.Forms.ComboBox();
			this.getMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cboDay = new System.Windows.Forms.ComboBox();
			this.getDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gridReport = new System.Windows.Forms.DataGridView();
			this.paidOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.quanLyGiatUiDataSet21 = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet2();
			this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.txtRevenue = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.ordersTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet2TableAdapters.OrdersTableAdapter();
			this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.getYearTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet2TableAdapters.GetYearTableAdapter();
			this.getMonthTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet2TableAdapters.GetMonthTableAdapter();
			this.getDayTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet2TableAdapters.GetDayTableAdapter();
			this.paidOrderTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet2TableAdapters.PaidOrderTableAdapter();
			this.radYear = new System.Windows.Forms.RadioButton();
			this.radMonth = new System.Windows.Forms.RadioButton();
			this.radDay = new System.Windows.Forms.RadioButton();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.getYearBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.getMonthBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.getDayBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridReport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paidOrderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(127, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thống kê doanh thu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Thống kê theo:";
			// 
			// cboYear
			// 
			this.cboYear.DataSource = this.getYearBindingSource;
			this.cboYear.DisplayMember = "Year";
			this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboYear.FormattingEnabled = true;
			this.cboYear.Location = new System.Drawing.Point(125, 82);
			this.cboYear.Name = "cboYear";
			this.cboYear.Size = new System.Drawing.Size(52, 21);
			this.cboYear.TabIndex = 2;
			this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
			// 
			// getYearBindingSource
			// 
			this.getYearBindingSource.DataMember = "GetYear";
			this.getYearBindingSource.DataSource = this.quanLyGiatUiDataSet2;
			// 
			// quanLyGiatUiDataSet2
			// 
			this.quanLyGiatUiDataSet2.DataSetName = "QuanLyGiatUiDataSet2";
			this.quanLyGiatUiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cboMonth
			// 
			this.cboMonth.DataSource = this.getMonthBindingSource;
			this.cboMonth.DisplayMember = "Month";
			this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMonth.Enabled = false;
			this.cboMonth.FormattingEnabled = true;
			this.cboMonth.Location = new System.Drawing.Point(251, 82);
			this.cboMonth.Name = "cboMonth";
			this.cboMonth.Size = new System.Drawing.Size(52, 21);
			this.cboMonth.TabIndex = 3;
			this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
			// 
			// getMonthBindingSource
			// 
			this.getMonthBindingSource.DataMember = "GetMonth";
			this.getMonthBindingSource.DataSource = this.quanLyGiatUiDataSet2;
			// 
			// cboDay
			// 
			this.cboDay.DataSource = this.getDayBindingSource;
			this.cboDay.DisplayMember = "Day";
			this.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDay.Enabled = false;
			this.cboDay.FormattingEnabled = true;
			this.cboDay.Location = new System.Drawing.Point(382, 82);
			this.cboDay.Name = "cboDay";
			this.cboDay.Size = new System.Drawing.Size(52, 21);
			this.cboDay.TabIndex = 4;
			this.cboDay.SelectedIndexChanged += new System.EventHandler(this.cboDay_SelectedIndexChanged);
			// 
			// getDayBindingSource
			// 
			this.getDayBindingSource.DataMember = "GetDay";
			this.getDayBindingSource.DataSource = this.quanLyGiatUiDataSet2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.gridReport);
			this.groupBox1.Location = new System.Drawing.Point(15, 123);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(457, 223);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chi tiết doanh thu";
			// 
			// gridReport
			// 
			this.gridReport.AllowUserToAddRows = false;
			this.gridReport.AllowUserToDeleteRows = false;
			this.gridReport.AllowUserToResizeRows = false;
			this.gridReport.AutoGenerateColumns = false;
			this.gridReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.gridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.orderNameDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
			this.gridReport.DataSource = this.paidOrderBindingSource;
			this.gridReport.Location = new System.Drawing.Point(5, 19);
			this.gridReport.MultiSelect = false;
			this.gridReport.Name = "gridReport";
			this.gridReport.ReadOnly = true;
			this.gridReport.RowHeadersVisible = false;
			this.gridReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridReport.Size = new System.Drawing.Size(446, 198);
			this.gridReport.TabIndex = 0;
			this.gridReport.DataSourceChanged += new System.EventHandler(this.gridReport_DataSourceChanged);
			// 
			// paidOrderBindingSource
			// 
			this.paidOrderBindingSource.DataMember = "PaidOrder";
			this.paidOrderBindingSource.DataSource = this.quanLyGiatUiDataSet21;
			// 
			// quanLyGiatUiDataSet21
			// 
			this.quanLyGiatUiDataSet21.DataSetName = "QuanLyGiatUiDataSet2";
			this.quanLyGiatUiDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ordersBindingSource
			// 
			this.ordersBindingSource.DataMember = "Orders";
			this.ordersBindingSource.DataSource = this.quanLyGiatUiDataSet2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Sitka Small", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(17, 354);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(173, 26);
			this.label6.TabIndex = 9;
			this.label6.Text = "Tổng doanh thu :";
			// 
			// txtRevenue
			// 
			this.txtRevenue.AutoSize = true;
			this.txtRevenue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtRevenue.Location = new System.Drawing.Point(196, 354);
			this.txtRevenue.Name = "txtRevenue";
			this.txtRevenue.Size = new System.Drawing.Size(83, 29);
			this.txtRevenue.TabIndex = 10;
			this.txtRevenue.Text = "0 VND";
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(133, 404);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(86, 26);
			this.btnPrint.TabIndex = 11;
			this.btnPrint.Text = "In báo cáo";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(264, 404);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(86, 26);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// ordersTableAdapter
			// 
			this.ordersTableAdapter.ClearBeforeFill = true;
			// 
			// ordersBindingSource1
			// 
			this.ordersBindingSource1.DataMember = "Orders";
			this.ordersBindingSource1.DataSource = this.quanLyGiatUiDataSet2;
			// 
			// getYearTableAdapter
			// 
			this.getYearTableAdapter.ClearBeforeFill = true;
			// 
			// getMonthTableAdapter
			// 
			this.getMonthTableAdapter.ClearBeforeFill = true;
			// 
			// getDayTableAdapter
			// 
			this.getDayTableAdapter.ClearBeforeFill = true;
			// 
			// paidOrderTableAdapter
			// 
			this.paidOrderTableAdapter.ClearBeforeFill = true;
			// 
			// radYear
			// 
			this.radYear.AutoSize = true;
			this.radYear.Checked = true;
			this.radYear.Location = new System.Drawing.Point(125, 56);
			this.radYear.Name = "radYear";
			this.radYear.Size = new System.Drawing.Size(47, 17);
			this.radYear.TabIndex = 13;
			this.radYear.TabStop = true;
			this.radYear.Text = "Năm";
			this.radYear.UseVisualStyleBackColor = true;
			this.radYear.CheckedChanged += new System.EventHandler(this.radYear_CheckedChanged);
			// 
			// radMonth
			// 
			this.radMonth.AutoSize = true;
			this.radMonth.Location = new System.Drawing.Point(251, 56);
			this.radMonth.Name = "radMonth";
			this.radMonth.Size = new System.Drawing.Size(56, 17);
			this.radMonth.TabIndex = 14;
			this.radMonth.Text = "Tháng";
			this.radMonth.UseVisualStyleBackColor = true;
			this.radMonth.CheckedChanged += new System.EventHandler(this.radMonth_CheckedChanged);
			// 
			// radDay
			// 
			this.radDay.AutoSize = true;
			this.radDay.Location = new System.Drawing.Point(382, 56);
			this.radDay.Name = "radDay";
			this.radDay.Size = new System.Drawing.Size(50, 17);
			this.radDay.TabIndex = 15;
			this.radDay.Text = "Ngày";
			this.radDay.UseVisualStyleBackColor = true;
			this.radDay.CheckedChanged += new System.EventHandler(this.radDay_CheckedChanged);
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			dataGridViewCellStyle1.Format = "dd/MM/yyyy";
			this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.dateDataGridViewTextBoxColumn.HeaderText = "Ngày";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateDataGridViewTextBoxColumn.Width = 57;
			// 
			// customerNameDataGridViewTextBoxColumn
			// 
			this.customerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
			this.customerNameDataGridViewTextBoxColumn.HeaderText = "Khách hàng";
			this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
			this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.customerNameDataGridViewTextBoxColumn.Width = 5;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			dataGridViewCellStyle2.Format = "N0";
			this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.priceDataGridViewTextBoxColumn.HeaderText = "Thành tiền (VND)";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			this.priceDataGridViewTextBoxColumn.Width = 105;
			// 
			// orderNameDataGridViewTextBoxColumn
			// 
			this.orderNameDataGridViewTextBoxColumn.DataPropertyName = "OrderName";
			this.orderNameDataGridViewTextBoxColumn.HeaderText = "Loại hàng";
			this.orderNameDataGridViewTextBoxColumn.Name = "orderNameDataGridViewTextBoxColumn";
			this.orderNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.orderNameDataGridViewTextBoxColumn.Width = 73;
			// 
			// serviceDataGridViewTextBoxColumn
			// 
			this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
			this.serviceDataGridViewTextBoxColumn.HeaderText = "Dịch vụ";
			this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
			this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
			this.serviceDataGridViewTextBoxColumn.Width = 64;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
			this.statusDataGridViewTextBoxColumn.Width = 74;
			// 
			// ReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 441);
			this.Controls.Add(this.radDay);
			this.Controls.Add(this.radMonth);
			this.Controls.Add(this.radYear);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.txtRevenue);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cboDay);
			this.Controls.Add(this.cboMonth);
			this.Controls.Add(this.cboYear);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ReportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thống kê doanh thu";
			this.Load += new System.EventHandler(this.ReportForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.getYearBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.getMonthBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.getDayBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridReport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paidOrderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboYear;
		private System.Windows.Forms.ComboBox cboMonth;
		private System.Windows.Forms.ComboBox cboDay;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView gridReport;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label txtRevenue;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnExit;
		private QuanLyGiatUiDataSet2 quanLyGiatUiDataSet2;
		private System.Windows.Forms.BindingSource ordersBindingSource;
		private QuanLyGiatUiDataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter;
		private System.Windows.Forms.BindingSource ordersBindingSource1;
		private System.Windows.Forms.BindingSource getYearBindingSource;
		private QuanLyGiatUiDataSet2TableAdapters.GetYearTableAdapter getYearTableAdapter;
		private System.Windows.Forms.BindingSource getMonthBindingSource;
		private QuanLyGiatUiDataSet2TableAdapters.GetMonthTableAdapter getMonthTableAdapter;
		private System.Windows.Forms.BindingSource getDayBindingSource;
		private QuanLyGiatUiDataSet2TableAdapters.GetDayTableAdapter getDayTableAdapter;
		private QuanLyGiatUiDataSet2 quanLyGiatUiDataSet21;
		private System.Windows.Forms.BindingSource paidOrderBindingSource;
		private QuanLyGiatUiDataSet2TableAdapters.PaidOrderTableAdapter paidOrderTableAdapter;
		private System.Windows.Forms.RadioButton radYear;
		private System.Windows.Forms.RadioButton radMonth;
		private System.Windows.Forms.RadioButton radDay;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
	}
}