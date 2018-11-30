namespace QuanLyTiemGiatUi
{
	partial class frmMain
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
			this.parentTab = new System.Windows.Forms.TabControl();
			this.tabMain = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gridService = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radDelivery = new System.Windows.Forms.GroupBox();
			this.radDeliver = new System.Windows.Forms.RadioButton();
			this.radAtStore = new System.Windows.Forms.RadioButton();
			this.label13 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnCreateOrder = new System.Windows.Forms.Button();
			this.lblPrice = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cboService = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPhoneNum = new System.Windows.Forms.TextBox();
			this.numWeight = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.txtOrderName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCusName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPending = new System.Windows.Forms.TabPage();
			this.btnAcceptOrder = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.gridPendingOrder = new System.Windows.Forms.DataGridView();
			this.pendingOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.quanLyGiatUiDataSet = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet();
			this.tabUnpaid = new System.Windows.Forms.TabPage();
			this.btnPaid = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.gridUnpaidOrder = new System.Windows.Forms.DataGridView();
			this.unpaidOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOrder = new System.Windows.Forms.ToolStripMenuItem();
			this.menuServices = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStaff = new System.Windows.Forms.ToolStripMenuItem();
			this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.unpaidOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.unpaidOrderTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSetTableAdapters.UnpaidOrderTableAdapter();
			this.pendingOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pendingOrderTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSetTableAdapters.PendingOrderTableAdapter();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deliveryDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.servicesTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSetTableAdapters.ServicesTableAdapter();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.parentTab.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridService)).BeginInit();
			this.panel1.SuspendLayout();
			this.radDelivery.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
			this.tabPending.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridPendingOrder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pendingOrderBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet)).BeginInit();
			this.tabUnpaid.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridUnpaidOrder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unpaidOrderBindingSource1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.unpaidOrderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pendingOrderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// parentTab
			// 
			this.parentTab.Controls.Add(this.tabMain);
			this.parentTab.Controls.Add(this.tabPending);
			this.parentTab.Controls.Add(this.tabUnpaid);
			this.parentTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.parentTab.Location = new System.Drawing.Point(0, 24);
			this.parentTab.Name = "parentTab";
			this.parentTab.SelectedIndex = 0;
			this.parentTab.Size = new System.Drawing.Size(475, 420);
			this.parentTab.TabIndex = 0;
			this.parentTab.Tag = "";
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.panel2);
			this.tabMain.Controls.Add(this.panel1);
			this.tabMain.Location = new System.Drawing.Point(4, 22);
			this.tabMain.Name = "tabMain";
			this.tabMain.Padding = new System.Windows.Forms.Padding(3);
			this.tabMain.Size = new System.Drawing.Size(467, 394);
			this.tabMain.TabIndex = 0;
			this.tabMain.Text = "Tạo phiếu giặt";
			this.tabMain.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.gridService);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(280, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(184, 388);
			this.panel2.TabIndex = 1;
			// 
			// gridService
			// 
			this.gridService.AllowUserToAddRows = false;
			this.gridService.AllowUserToDeleteRows = false;
			this.gridService.AllowUserToResizeRows = false;
			this.gridService.AutoGenerateColumns = false;
			this.gridService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridService.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
			this.gridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn2});
			this.gridService.DataSource = this.servicesBindingSource;
			this.gridService.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridService.Location = new System.Drawing.Point(0, 20);
			this.gridService.MultiSelect = false;
			this.gridService.Name = "gridService";
			this.gridService.ReadOnly = true;
			this.gridService.RowHeadersVisible = false;
			this.gridService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridService.Size = new System.Drawing.Size(184, 368);
			this.gridService.TabIndex = 1;
			this.gridService.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridService_RowEnter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bảng giá dịch vụ:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.radDelivery);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnCreateOrder);
			this.panel1.Controls.Add(this.lblPrice);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.cboService);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtPhoneNum);
			this.panel1.Controls.Add(this.numWeight);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtOrderName);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtAddress);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtCusName);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(275, 388);
			this.panel1.TabIndex = 0;
			// 
			// radDelivery
			// 
			this.radDelivery.BackColor = System.Drawing.Color.Transparent;
			this.radDelivery.Controls.Add(this.radDeliver);
			this.radDelivery.Controls.Add(this.radAtStore);
			this.radDelivery.Location = new System.Drawing.Point(30, 235);
			this.radDelivery.Name = "radDelivery";
			this.radDelivery.Size = new System.Drawing.Size(200, 71);
			this.radDelivery.TabIndex = 23;
			this.radDelivery.TabStop = false;
			this.radDelivery.Text = "Hình thức nhận hàng";
			// 
			// radDeliver
			// 
			this.radDeliver.AutoSize = true;
			this.radDeliver.Location = new System.Drawing.Point(7, 43);
			this.radDeliver.Name = "radDeliver";
			this.radDeliver.Size = new System.Drawing.Size(171, 17);
			this.radDeliver.TabIndex = 1;
			this.radDeliver.Text = "Giao hàng tận nơi (Phí: 5000d)";
			this.radDeliver.UseVisualStyleBackColor = true;
			this.radDeliver.CheckedChanged += new System.EventHandler(this.radDeliver_CheckedChanged);
			// 
			// radAtStore
			// 
			this.radAtStore.AutoSize = true;
			this.radAtStore.Checked = true;
			this.radAtStore.Location = new System.Drawing.Point(7, 20);
			this.radAtStore.Name = "radAtStore";
			this.radAtStore.Size = new System.Drawing.Size(113, 17);
			this.radAtStore.TabIndex = 0;
			this.radAtStore.TabStop = true;
			this.radAtStore.Text = "Nhận tại cửa hàng";
			this.radAtStore.UseVisualStyleBackColor = true;
			this.radAtStore.CheckedChanged += new System.EventHandler(this.radAtStore_CheckedChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(185, 209);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(19, 13);
			this.label13.TabIndex = 22;
			this.label13.Text = "kg";
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnCancel.Location = new System.Drawing.Point(163, 349);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 28);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Hủy bỏ";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnCreateOrder
			// 
			this.btnCreateOrder.AutoSize = true;
			this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnCreateOrder.Location = new System.Drawing.Point(46, 349);
			this.btnCreateOrder.Name = "btnCreateOrder";
			this.btnCreateOrder.Size = new System.Drawing.Size(99, 28);
			this.btnCreateOrder.TabIndex = 7;
			this.btnCreateOrder.Text = "Tạo phiếu giặt";
			this.btnCreateOrder.UseVisualStyleBackColor = true;
			this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblPrice.Location = new System.Drawing.Point(104, 313);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(87, 29);
			this.lblPrice.TabIndex = 18;
			this.lblPrice.Text = "0 VND";
			this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label10.Location = new System.Drawing.Point(4, 313);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(109, 29);
			this.label10.TabIndex = 17;
			this.label10.Text = "Chi phí: ";
			// 
			// cboService
			// 
			this.cboService.DisplayMember = "Services.Price";
			this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboService.FormattingEnabled = true;
			this.cboService.Location = new System.Drawing.Point(109, 172);
			this.cboService.Name = "cboService";
			this.cboService.Size = new System.Drawing.Size(121, 21);
			this.cboService.TabIndex = 5;
			this.cboService.ValueMember = "Services.Price";
			this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(5, 175);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "Dịch vụ";
			// 
			// txtPhoneNum
			// 
			this.txtPhoneNum.Location = new System.Drawing.Point(109, 74);
			this.txtPhoneNum.MaxLength = 11;
			this.txtPhoneNum.Name = "txtPhoneNum";
			this.txtPhoneNum.Size = new System.Drawing.Size(145, 20);
			this.txtPhoneNum.TabIndex = 2;
			this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNum_KeyPress);
			// 
			// numWeight
			// 
			this.numWeight.DecimalPlaces = 1;
			this.numWeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.numWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numWeight.Location = new System.Drawing.Point(109, 207);
			this.numWeight.Name = "numWeight";
			this.numWeight.Size = new System.Drawing.Size(70, 20);
			this.numWeight.TabIndex = 6;
			this.numWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numWeight.ValueChanged += new System.EventHandler(this.numWeight_ValueChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(5, 209);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Khối lượng";
			// 
			// txtOrderName
			// 
			this.txtOrderName.Location = new System.Drawing.Point(109, 142);
			this.txtOrderName.MaxLength = 100;
			this.txtOrderName.Name = "txtOrderName";
			this.txtOrderName.Size = new System.Drawing.Size(145, 20);
			this.txtOrderName.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Tên hàng";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(109, 107);
			this.txtAddress.MaxLength = 200;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(145, 20);
			this.txtAddress.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Địa chỉ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Số điện thoại";
			// 
			// txtCusName
			// 
			this.txtCusName.Location = new System.Drawing.Point(109, 40);
			this.txtCusName.MaxLength = 100;
			this.txtCusName.Name = "txtCusName";
			this.txtCusName.Size = new System.Drawing.Size(145, 20);
			this.txtCusName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tên khách hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(71, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Phiếu giặt ủi";
			// 
			// tabPending
			// 
			this.tabPending.Controls.Add(this.btnAcceptOrder);
			this.tabPending.Controls.Add(this.panel3);
			this.tabPending.Location = new System.Drawing.Point(4, 22);
			this.tabPending.Name = "tabPending";
			this.tabPending.Padding = new System.Windows.Forms.Padding(3);
			this.tabPending.Size = new System.Drawing.Size(467, 394);
			this.tabPending.TabIndex = 1;
			this.tabPending.Text = "Đơn hàng chờ giặt";
			this.tabPending.UseVisualStyleBackColor = true;
			this.tabPending.Enter += new System.EventHandler(this.tabPending_Enter);
			// 
			// btnAcceptOrder
			// 
			this.btnAcceptOrder.Location = new System.Drawing.Point(188, 359);
			this.btnAcceptOrder.Name = "btnAcceptOrder";
			this.btnAcceptOrder.Size = new System.Drawing.Size(91, 26);
			this.btnAcceptOrder.TabIndex = 2;
			this.btnAcceptOrder.Text = "Tiếp nhận";
			this.btnAcceptOrder.UseVisualStyleBackColor = true;
			this.btnAcceptOrder.Click += new System.EventHandler(this.btnAcceptOrder_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.gridPendingOrder);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(461, 348);
			this.panel3.TabIndex = 0;
			// 
			// gridPendingOrder
			// 
			this.gridPendingOrder.AllowUserToResizeRows = false;
			this.gridPendingOrder.AutoGenerateColumns = false;
			this.gridPendingOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.gridPendingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPendingOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.orderNameDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
			this.gridPendingOrder.DataSource = this.pendingOrderBindingSource1;
			this.gridPendingOrder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridPendingOrder.Location = new System.Drawing.Point(0, 0);
			this.gridPendingOrder.MultiSelect = false;
			this.gridPendingOrder.Name = "gridPendingOrder";
			this.gridPendingOrder.ReadOnly = true;
			this.gridPendingOrder.RowHeadersVisible = false;
			this.gridPendingOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridPendingOrder.Size = new System.Drawing.Size(461, 348);
			this.gridPendingOrder.TabIndex = 0;
			this.gridPendingOrder.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPendingOrder_RowEnter);
			// 
			// pendingOrderBindingSource1
			// 
			this.pendingOrderBindingSource1.DataMember = "PendingOrder";
			this.pendingOrderBindingSource1.DataSource = this.quanLyGiatUiDataSet;
			// 
			// quanLyGiatUiDataSet
			// 
			this.quanLyGiatUiDataSet.DataSetName = "QuanLyGiatUiDataSet";
			this.quanLyGiatUiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tabUnpaid
			// 
			this.tabUnpaid.Controls.Add(this.btnPaid);
			this.tabUnpaid.Controls.Add(this.panel4);
			this.tabUnpaid.Location = new System.Drawing.Point(4, 22);
			this.tabUnpaid.Name = "tabUnpaid";
			this.tabUnpaid.Padding = new System.Windows.Forms.Padding(3);
			this.tabUnpaid.Size = new System.Drawing.Size(467, 394);
			this.tabUnpaid.TabIndex = 2;
			this.tabUnpaid.Text = "Đơn hàng chờ nhận";
			this.tabUnpaid.UseVisualStyleBackColor = true;
			this.tabUnpaid.Enter += new System.EventHandler(this.tabUnpaid_Enter);
			// 
			// btnPaid
			// 
			this.btnPaid.AutoSize = true;
			this.btnPaid.Location = new System.Drawing.Point(179, 361);
			this.btnPaid.Name = "btnPaid";
			this.btnPaid.Size = new System.Drawing.Size(102, 27);
			this.btnPaid.TabIndex = 1;
			this.btnPaid.Text = "Đã thanh toán";
			this.btnPaid.UseVisualStyleBackColor = true;
			this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.gridUnpaidOrder);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(461, 352);
			this.panel4.TabIndex = 0;
			// 
			// gridUnpaidOrder
			// 
			this.gridUnpaidOrder.AllowUserToResizeRows = false;
			this.gridUnpaidOrder.AutoGenerateColumns = false;
			this.gridUnpaidOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.gridUnpaidOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridUnpaidOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.customerNameDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.orderNameDataGridViewTextBoxColumn1,
            this.serviceDataGridViewTextBoxColumn1,
            this.weightDataGridViewTextBoxColumn1,
            this.deliveryDataGridViewCheckBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1});
			this.gridUnpaidOrder.DataSource = this.unpaidOrderBindingSource1;
			this.gridUnpaidOrder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridUnpaidOrder.Location = new System.Drawing.Point(0, 0);
			this.gridUnpaidOrder.MultiSelect = false;
			this.gridUnpaidOrder.Name = "gridUnpaidOrder";
			this.gridUnpaidOrder.ReadOnly = true;
			this.gridUnpaidOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridUnpaidOrder.RowHeadersVisible = false;
			this.gridUnpaidOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridUnpaidOrder.Size = new System.Drawing.Size(461, 352);
			this.gridUnpaidOrder.TabIndex = 0;
			this.gridUnpaidOrder.SelectionChanged += new System.EventHandler(this.gridUnpaidOrder_SelectionChanged);
			// 
			// unpaidOrderBindingSource1
			// 
			this.unpaidOrderBindingSource1.DataMember = "UnpaidOrder";
			this.unpaidOrderBindingSource1.DataSource = this.quanLyGiatUiDataSet;
			// 
			// quảnLýToolStripMenuItem
			// 
			this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOrder,
            this.menuServices,
            this.menuStaff});
			this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
			this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.quảnLýToolStripMenuItem.Text = "Quản lý";
			// 
			// menuOrder
			// 
			this.menuOrder.Name = "menuOrder";
			this.menuOrder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.menuOrder.Size = new System.Drawing.Size(213, 22);
			this.menuOrder.Text = "Quản lý đơn hàng";
			this.menuOrder.Click += new System.EventHandler(this.menuOrder_Click);
			// 
			// menuServices
			// 
			this.menuServices.Name = "menuServices";
			this.menuServices.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.menuServices.Size = new System.Drawing.Size(213, 22);
			this.menuServices.Text = "Quản lý dịch vụ";
			this.menuServices.Click += new System.EventHandler(this.menuServices_Click);
			// 
			// menuStaff
			// 
			this.menuStaff.Name = "menuStaff";
			this.menuStaff.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.menuStaff.Size = new System.Drawing.Size(213, 22);
			this.menuStaff.Text = "Quản lý nhân viên";
			this.menuStaff.Click += new System.EventHandler(this.menuStaff_Click);
			// 
			// menuLogout
			// 
			this.menuLogout.Name = "menuLogout";
			this.menuLogout.Size = new System.Drawing.Size(72, 20);
			this.menuLogout.Text = "Đăng xuất";
			this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.menuLogout});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(475, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// unpaidOrderTableAdapter
			// 
			this.unpaidOrderTableAdapter.ClearBeforeFill = true;
			// 
			// pendingOrderTableAdapter
			// 
			this.pendingOrderTableAdapter.ClearBeforeFill = true;
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
			this.customerNameDataGridViewTextBoxColumn.HeaderText = "Khách hàng";
			this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
			this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.customerNameDataGridViewTextBoxColumn.Width = 90;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
			this.statusDataGridViewTextBoxColumn.Width = 80;
			// 
			// orderNameDataGridViewTextBoxColumn
			// 
			this.orderNameDataGridViewTextBoxColumn.DataPropertyName = "OrderName";
			this.orderNameDataGridViewTextBoxColumn.HeaderText = "Loại hàng";
			this.orderNameDataGridViewTextBoxColumn.Name = "orderNameDataGridViewTextBoxColumn";
			this.orderNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.orderNameDataGridViewTextBoxColumn.Width = 79;
			// 
			// serviceDataGridViewTextBoxColumn
			// 
			this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
			this.serviceDataGridViewTextBoxColumn.HeaderText = "Dịch vụ";
			this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
			this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
			this.serviceDataGridViewTextBoxColumn.Width = 69;
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "K.Lượng";
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			this.weightDataGridViewTextBoxColumn.ReadOnly = true;
			this.weightDataGridViewTextBoxColumn.Width = 72;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Chi phí";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			this.priceDataGridViewTextBoxColumn.Width = 66;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Ngày nhận";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateDataGridViewTextBoxColumn.Width = 84;
			// 
			// iDDataGridViewTextBoxColumn1
			// 
			this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
			this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn1.Width = 43;
			// 
			// customerNameDataGridViewTextBoxColumn1
			// 
			this.customerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName";
			this.customerNameDataGridViewTextBoxColumn1.HeaderText = "Khách hàng";
			this.customerNameDataGridViewTextBoxColumn1.Name = "customerNameDataGridViewTextBoxColumn1";
			this.customerNameDataGridViewTextBoxColumn1.ReadOnly = true;
			this.customerNameDataGridViewTextBoxColumn1.Width = 90;
			// 
			// statusDataGridViewTextBoxColumn1
			// 
			this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn1.HeaderText = "Trạng thái";
			this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
			this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
			this.statusDataGridViewTextBoxColumn1.Width = 80;
			// 
			// orderNameDataGridViewTextBoxColumn1
			// 
			this.orderNameDataGridViewTextBoxColumn1.DataPropertyName = "OrderName";
			this.orderNameDataGridViewTextBoxColumn1.HeaderText = "Loại hàng";
			this.orderNameDataGridViewTextBoxColumn1.Name = "orderNameDataGridViewTextBoxColumn1";
			this.orderNameDataGridViewTextBoxColumn1.ReadOnly = true;
			this.orderNameDataGridViewTextBoxColumn1.Width = 79;
			// 
			// serviceDataGridViewTextBoxColumn1
			// 
			this.serviceDataGridViewTextBoxColumn1.DataPropertyName = "Service";
			this.serviceDataGridViewTextBoxColumn1.HeaderText = "Dịch vụ";
			this.serviceDataGridViewTextBoxColumn1.Name = "serviceDataGridViewTextBoxColumn1";
			this.serviceDataGridViewTextBoxColumn1.ReadOnly = true;
			this.serviceDataGridViewTextBoxColumn1.Width = 69;
			// 
			// weightDataGridViewTextBoxColumn1
			// 
			this.weightDataGridViewTextBoxColumn1.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn1.HeaderText = "K.Lượng";
			this.weightDataGridViewTextBoxColumn1.Name = "weightDataGridViewTextBoxColumn1";
			this.weightDataGridViewTextBoxColumn1.ReadOnly = true;
			this.weightDataGridViewTextBoxColumn1.Width = 72;
			// 
			// deliveryDataGridViewCheckBoxColumn1
			// 
			this.deliveryDataGridViewCheckBoxColumn1.DataPropertyName = "Delivery";
			this.deliveryDataGridViewCheckBoxColumn1.HeaderText = "Giao hàng";
			this.deliveryDataGridViewCheckBoxColumn1.Name = "deliveryDataGridViewCheckBoxColumn1";
			this.deliveryDataGridViewCheckBoxColumn1.ReadOnly = true;
			this.deliveryDataGridViewCheckBoxColumn1.Width = 62;
			// 
			// priceDataGridViewTextBoxColumn1
			// 
			this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn1.HeaderText = "Chi phí";
			this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
			this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
			this.priceDataGridViewTextBoxColumn1.Width = 66;
			// 
			// dateDataGridViewTextBoxColumn1
			// 
			this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn1.HeaderText = "Ngày nhận";
			this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
			this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
			this.dateDataGridViewTextBoxColumn1.Width = 84;
			// 
			// servicesBindingSource
			// 
			this.servicesBindingSource.DataMember = "Services";
			this.servicesBindingSource.DataSource = this.quanLyGiatUiDataSet;
			// 
			// servicesTableAdapter
			// 
			this.servicesTableAdapter.ClearBeforeFill = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Tên dịch vụ";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn2
			// 
			this.priceDataGridViewTextBoxColumn2.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn2.HeaderText = "Đơn giá";
			this.priceDataGridViewTextBoxColumn2.Name = "priceDataGridViewTextBoxColumn2";
			this.priceDataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 444);
			this.Controls.Add(this.parentTab);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm quản lý giặt ủi";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.parentTab.ResumeLayout(false);
			this.tabMain.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridService)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.radDelivery.ResumeLayout(false);
			this.radDelivery.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
			this.tabPending.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridPendingOrder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pendingOrderBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet)).EndInit();
			this.tabUnpaid.ResumeLayout(false);
			this.tabUnpaid.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridUnpaidOrder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unpaidOrderBindingSource1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.unpaidOrderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pendingOrderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl parentTab;
		private System.Windows.Forms.TabPage tabMain;
		private System.Windows.Forms.TabPage tabPending;
		private System.Windows.Forms.TabPage tabUnpaid;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView gridService;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCusName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboService;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPhoneNum;
		private System.Windows.Forms.NumericUpDown numWeight;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtOrderName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuOrder;
		private System.Windows.Forms.ToolStripMenuItem menuServices;
		private System.Windows.Forms.ToolStripMenuItem menuStaff;
		private System.Windows.Forms.ToolStripMenuItem menuLogout;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnCreateOrder;
		private System.Windows.Forms.GroupBox radDelivery;
		private System.Windows.Forms.RadioButton radDeliver;
		private System.Windows.Forms.RadioButton radAtStore;
		private System.Windows.Forms.Button btnAcceptOrder;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView gridPendingOrder;
		private System.Windows.Forms.Button btnPaid;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridView gridUnpaidOrder;
		private System.Windows.Forms.BindingSource unpaidOrderBindingSource;
		private QuanLyGiatUiDataSetTableAdapters.UnpaidOrderTableAdapter unpaidOrderTableAdapter;
		private System.Windows.Forms.BindingSource pendingOrderBindingSource;
		private QuanLyGiatUiDataSet quanLyGiatUiDataSet;
		private System.Windows.Forms.BindingSource pendingOrderBindingSource1;
		private QuanLyGiatUiDataSetTableAdapters.PendingOrderTableAdapter pendingOrderTableAdapter;
		private System.Windows.Forms.BindingSource unpaidOrderBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn deliveryDataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
		private System.Windows.Forms.BindingSource servicesBindingSource;
		private QuanLyGiatUiDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
	}
}