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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gridService = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.quanLyGiatUiDataSet = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radDelivery = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radAtStore = new System.Windows.Forms.RadioButton();
			this.label13 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
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
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button5 = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOrder = new System.Windows.Forms.ToolStripMenuItem();
			this.menuServices = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStaff = new System.Windows.Forms.ToolStripMenuItem();
			this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.servicesTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSetTableAdapters.ServicesTableAdapter();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridService)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet)).BeginInit();
			this.panel1.SuspendLayout();
			this.radDelivery.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(475, 420);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.Tag = "";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(467, 394);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Tạo phiếu giặt";
			this.tabPage1.UseVisualStyleBackColor = true;
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
            this.priceDataGridViewTextBoxColumn});
			this.gridService.DataSource = this.servicesBindingSource;
			this.gridService.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridService.Location = new System.Drawing.Point(0, 20);
			this.gridService.Name = "gridService";
			this.gridService.ReadOnly = true;
			this.gridService.RowHeadersVisible = false;
			this.gridService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridService.Size = new System.Drawing.Size(184, 368);
			this.gridService.TabIndex = 1;
			this.gridService.SelectionChanged += new System.EventHandler(this.gridService_SelectionChanged);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Dịch vụ";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// servicesBindingSource
			// 
			this.servicesBindingSource.DataMember = "Services";
			this.servicesBindingSource.DataSource = this.quanLyGiatUiDataSet;
			// 
			// quanLyGiatUiDataSet
			// 
			this.quanLyGiatUiDataSet.DataSetName = "QuanLyGiatUiDataSet";
			this.quanLyGiatUiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
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
			this.radDelivery.Controls.Add(this.radioButton2);
			this.radDelivery.Controls.Add(this.radAtStore);
			this.radDelivery.Location = new System.Drawing.Point(30, 235);
			this.radDelivery.Name = "radDelivery";
			this.radDelivery.Size = new System.Drawing.Size(200, 71);
			this.radDelivery.TabIndex = 23;
			this.radDelivery.TabStop = false;
			this.radDelivery.Text = "Hình thức nhận hàng";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(7, 43);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(171, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Giao hàng tận nơi (Phí: 5000d)";
			this.radioButton2.UseVisualStyleBackColor = true;
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
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button2.Location = new System.Drawing.Point(163, 349);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 28);
			this.button2.TabIndex = 21;
			this.button2.Text = "Hủy bỏ";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button1.Location = new System.Drawing.Point(46, 349);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 28);
			this.button1.TabIndex = 20;
			this.button1.Text = "Tạo phiếu giặt";
			this.button1.UseVisualStyleBackColor = true;
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
			this.cboService.DataSource = this.quanLyGiatUiDataSet;
			this.cboService.DisplayMember = "Services.Name";
			this.cboService.FormattingEnabled = true;
			this.cboService.Location = new System.Drawing.Point(109, 172);
			this.cboService.Name = "cboService";
			this.cboService.Size = new System.Drawing.Size(121, 21);
			this.cboService.TabIndex = 13;
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
			this.txtPhoneNum.Name = "txtPhoneNum";
			this.txtPhoneNum.Size = new System.Drawing.Size(145, 20);
			this.txtPhoneNum.TabIndex = 11;
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
			this.numWeight.TabIndex = 10;
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
			this.txtOrderName.Name = "txtOrderName";
			this.txtOrderName.Size = new System.Drawing.Size(145, 20);
			this.txtOrderName.TabIndex = 8;
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
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(145, 20);
			this.txtAddress.TabIndex = 6;
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
			this.txtCusName.Name = "txtCusName";
			this.txtCusName.Size = new System.Drawing.Size(145, 20);
			this.txtCusName.TabIndex = 2;
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
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.panel3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(467, 394);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Đơn hàng chờ giặt";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.Location = new System.Drawing.Point(120, 359);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(101, 26);
			this.button3.TabIndex = 3;
			this.button3.Text = "Xóa đơn hàng";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(246, 359);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(91, 26);
			this.button4.TabIndex = 2;
			this.button4.Text = "Tiếp nhận";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dataGridView2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(461, 348);
			this.panel3.TabIndex = 0;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(0, 0);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(461, 348);
			this.dataGridView2.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.button5);
			this.tabPage3.Controls.Add(this.panel4);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(467, 394);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Đơn hàng chờ nhận";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.Location = new System.Drawing.Point(179, 361);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(102, 27);
			this.button5.TabIndex = 1;
			this.button5.Text = "Đã thanh toán";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridView3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(461, 352);
			this.panel4.TabIndex = 0;
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView3.Location = new System.Drawing.Point(0, 0);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(461, 352);
			this.dataGridView3.TabIndex = 0;
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
			this.menuOrder.Size = new System.Drawing.Size(197, 22);
			this.menuOrder.Text = "Quản lý đơn hàng";
			this.menuOrder.Click += new System.EventHandler(this.menuOrder_Click);
			// 
			// menuServices
			// 
			this.menuServices.Name = "menuServices";
			this.menuServices.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.menuServices.Size = new System.Drawing.Size(197, 22);
			this.menuServices.Text = "Quản lý dịch vụ";
			this.menuServices.Click += new System.EventHandler(this.menuServices_Click);
			// 
			// menuStaff
			// 
			this.menuStaff.Name = "menuStaff";
			this.menuStaff.Size = new System.Drawing.Size(197, 22);
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
			// servicesTableAdapter
			// 
			this.servicesTableAdapter.ClearBeforeFill = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 444);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm quản lý giặt ủi";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridService)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.radDelivery.ResumeLayout(false);
			this.radDelivery.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
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
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox radDelivery;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radAtStore;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridView dataGridView3;
		private QuanLyGiatUiDataSet quanLyGiatUiDataSet;
		private System.Windows.Forms.BindingSource servicesBindingSource;
		private QuanLyGiatUiDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
	}
}