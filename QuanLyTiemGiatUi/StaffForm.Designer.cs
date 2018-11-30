namespace QuanLyTiemGiatUi
{
	partial class StaffForm
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
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.txtPhoneNum = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.gridStaff = new System.Windows.Forms.DataGridView();
			this.btnAddStaff = new System.Windows.Forms.Button();
			this.btnModifyStaff = new System.Windows.Forms.Button();
			this.btnDeleteStaff = new System.Windows.Forms.Button();
			this.cboFunction = new System.Windows.Forms.ComboBox();
			this.quanLyGiatUiDataSet = new QuanLyTiemGiatUi.QuanLyGiatUiDataSet();
			this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.staffTableAdapter = new QuanLyTiemGiatUi.QuanLyGiatUiDataSetTableAdapters.StaffTableAdapter();
			this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridStaff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên nhân viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số điện thoại";
			// 
			// txtStaffName
			// 
			this.txtStaffName.Location = new System.Drawing.Point(153, 55);
			this.txtStaffName.MaxLength = 100;
			this.txtStaffName.Name = "txtStaffName";
			this.txtStaffName.Size = new System.Drawing.Size(191, 20);
			this.txtStaffName.TabIndex = 1;
			// 
			// txtPhoneNum
			// 
			this.txtPhoneNum.Location = new System.Drawing.Point(153, 131);
			this.txtPhoneNum.MaxLength = 11;
			this.txtPhoneNum.Name = "txtPhoneNum";
			this.txtPhoneNum.Size = new System.Drawing.Size(138, 20);
			this.txtPhoneNum.TabIndex = 3;
			this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNum_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(93, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(212, 31);
			this.label3.TabIndex = 4;
			this.label3.Text = "Quản lý nhân viên";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(153, 92);
			this.txtAddress.MaxLength = 200;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(191, 20);
			this.txtAddress.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(50, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Địa chỉ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(50, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Vị trí";
			// 
			// gridStaff
			// 
			this.gridStaff.AllowUserToAddRows = false;
			this.gridStaff.AllowUserToDeleteRows = false;
			this.gridStaff.AllowUserToResizeRows = false;
			this.gridStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridStaff.AutoGenerateColumns = false;
			this.gridStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
			this.gridStaff.DataSource = this.staffBindingSource;
			this.gridStaff.Location = new System.Drawing.Point(6, 254);
			this.gridStaff.MultiSelect = false;
			this.gridStaff.Name = "gridStaff";
			this.gridStaff.ReadOnly = true;
			this.gridStaff.RowHeadersVisible = false;
			this.gridStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridStaff.Size = new System.Drawing.Size(391, 229);
			this.gridStaff.TabIndex = 9;
			this.gridStaff.SelectionChanged += new System.EventHandler(this.gridStaff_SelectionChanged);
			// 
			// btnAddStaff
			// 
			this.btnAddStaff.AutoSize = true;
			this.btnAddStaff.Location = new System.Drawing.Point(23, 207);
			this.btnAddStaff.Name = "btnAddStaff";
			this.btnAddStaff.Size = new System.Drawing.Size(94, 28);
			this.btnAddStaff.TabIndex = 5;
			this.btnAddStaff.Text = "Thêm nhân viên";
			this.btnAddStaff.UseVisualStyleBackColor = true;
			this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
			// 
			// btnModifyStaff
			// 
			this.btnModifyStaff.AutoSize = true;
			this.btnModifyStaff.Location = new System.Drawing.Point(163, 207);
			this.btnModifyStaff.Name = "btnModifyStaff";
			this.btnModifyStaff.Size = new System.Drawing.Size(94, 28);
			this.btnModifyStaff.TabIndex = 6;
			this.btnModifyStaff.Text = "Lưu thay đổi";
			this.btnModifyStaff.UseVisualStyleBackColor = true;
			this.btnModifyStaff.Click += new System.EventHandler(this.btnModifyStaff_Click);
			// 
			// btnDeleteStaff
			// 
			this.btnDeleteStaff.AutoSize = true;
			this.btnDeleteStaff.Location = new System.Drawing.Point(298, 207);
			this.btnDeleteStaff.Name = "btnDeleteStaff";
			this.btnDeleteStaff.Size = new System.Drawing.Size(87, 28);
			this.btnDeleteStaff.TabIndex = 7;
			this.btnDeleteStaff.Text = "Xóa nhân viên";
			this.btnDeleteStaff.UseVisualStyleBackColor = true;
			this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
			// 
			// cboFunction
			// 
			this.cboFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFunction.FormattingEnabled = true;
			this.cboFunction.Items.AddRange(new object[] {
            "Nhân viên tiếp nhận",
            "Nhân viên giao hàng",
            "Nhân viên xử lý",
            "Nhân viên thu ngân"});
			this.cboFunction.Location = new System.Drawing.Point(153, 170);
			this.cboFunction.Name = "cboFunction";
			this.cboFunction.Size = new System.Drawing.Size(138, 21);
			this.cboFunction.TabIndex = 4;
			// 
			// quanLyGiatUiDataSet
			// 
			this.quanLyGiatUiDataSet.DataSetName = "QuanLyGiatUiDataSet";
			this.quanLyGiatUiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// staffBindingSource
			// 
			this.staffBindingSource.DataMember = "Staff";
			this.staffBindingSource.DataSource = this.quanLyGiatUiDataSet;
			// 
			// staffTableAdapter
			// 
			this.staffTableAdapter.ClearBeforeFill = true;
			// 
			// positionDataGridViewTextBoxColumn
			// 
			this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
			this.positionDataGridViewTextBoxColumn.HeaderText = "Vị trí";
			this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
			this.positionDataGridViewTextBoxColumn.ReadOnly = true;
			this.positionDataGridViewTextBoxColumn.Width = 54;
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
			this.addressDataGridViewTextBoxColumn.Width = 65;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 101;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn.Width = 43;
			// 
			// StaffForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 490);
			this.Controls.Add(this.cboFunction);
			this.Controls.Add(this.btnDeleteStaff);
			this.Controls.Add(this.btnModifyStaff);
			this.Controls.Add(this.btnAddStaff);
			this.Controls.Add(this.gridStaff);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPhoneNum);
			this.Controls.Add(this.txtStaffName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "StaffForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Quản lý nhân viên";
			this.Load += new System.EventHandler(this.StaffForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridStaff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyGiatUiDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStaffName;
		private System.Windows.Forms.TextBox txtPhoneNum;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView gridStaff;
		private System.Windows.Forms.Button btnAddStaff;
		private System.Windows.Forms.Button btnModifyStaff;
		private System.Windows.Forms.Button btnDeleteStaff;
		private System.Windows.Forms.ComboBox cboFunction;
		private QuanLyGiatUiDataSet quanLyGiatUiDataSet;
		private System.Windows.Forms.BindingSource staffBindingSource;
		private QuanLyGiatUiDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
	}
}