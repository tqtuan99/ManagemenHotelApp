﻿namespace ManagemenHotelApp.AllUserControll
{
    partial class UserManaInfoCus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbHDCus = new System.Windows.Forms.Label();
            this.dtgCus = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtNameSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.idphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sogiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCus = new System.Windows.Forms.Panel();
            this.btnEditCus = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCus = new Guna.UI2.WinForms.Guna2Button();
            this.lbIDCus = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSex = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBirthDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCus)).BeginInit();
            this.pnCus.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.tabControl1.Location = new System.Drawing.Point(18, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1613, 803);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1597, 748);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin khách hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteCus);
            this.tabPage2.Controls.Add(this.btnEditCus);
            this.tabPage2.Controls.Add(this.pnCus);
            this.tabPage2.Controls.Add(this.lbHDCus);
            this.tabPage2.Controls.Add(this.dtgCus);
            this.tabPage2.Controls.Add(this.txtNameSearch);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1605, 758);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tra cứu khách hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lbHDCus
            // 
            this.lbHDCus.AutoSize = true;
            this.lbHDCus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHDCus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbHDCus.Location = new System.Drawing.Point(250, 95);
            this.lbHDCus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHDCus.Name = "lbHDCus";
            this.lbHDCus.Size = new System.Drawing.Size(405, 23);
            this.lbHDCus.TabIndex = 13;
            this.lbHDCus.Text = "Click vào phòng để sửa hoặc xóa phòng";
            // 
            // dtgCus
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgCus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCus.ColumnHeadersHeight = 68;
            this.dtgCus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idphong,
            this.tenloaiphong,
            this.tenphong,
            this.tang,
            this.songuoi,
            this.sogiuong,
            this.dongia,
            this.ghichu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCus.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCus.EnableHeadersVisualStyles = false;
            this.dtgCus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCus.Location = new System.Drawing.Point(19, 131);
            this.dtgCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCus.Name = "dtgCus";
            this.dtgCus.ReadOnly = true;
            this.dtgCus.RowHeadersVisible = false;
            this.dtgCus.RowTemplate.Height = 24;
            this.dtgCus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCus.Size = new System.Drawing.Size(919, 595);
            this.dtgCus.TabIndex = 12;
            this.dtgCus.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgCus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCus.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgCus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgCus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgCus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgCus.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgCus.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgCus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgCus.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dtgCus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgCus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgCus.ThemeStyle.HeaderStyle.Height = 68;
            this.dtgCus.ThemeStyle.ReadOnly = true;
            this.dtgCus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCus.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dtgCus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgCus.ThemeStyle.RowsStyle.Height = 24;
            this.dtgCus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgCus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCus_CellContentClick);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.BorderRadius = 15;
            this.txtNameSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameSearch.DefaultText = "";
            this.txtNameSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameSearch.DisabledState.Parent = this.txtNameSearch;
            this.txtNameSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameSearch.FocusedState.Parent = this.txtNameSearch;
            this.txtNameSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameSearch.HoverState.Parent = this.txtNameSearch;
            this.txtNameSearch.Location = new System.Drawing.Point(254, 21);
            this.txtNameSearch.Margin = new System.Windows.Forms.Padding(9);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.PasswordChar = '\0';
            this.txtNameSearch.PlaceholderText = "Nhập tên hoặc ID khách hàng";
            this.txtNameSearch.SelectedText = "";
            this.txtNameSearch.ShadowDecoration.Parent = this.txtNameSearch;
            this.txtNameSearch.Size = new System.Drawing.Size(624, 55);
            this.txtNameSearch.TabIndex = 11;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtNameSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.Checked = true;
            this.btnSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::ManagemenHotelApp.Properties.Resources.search;
            this.btnSearch.ImageSize = new System.Drawing.Size(32, 32);
            this.btnSearch.Location = new System.Drawing.Point(19, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(223, 55);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Tìm Kiếm";
            // 
            // idphong
            // 
            this.idphong.DataPropertyName = "idkhachhang";
            this.idphong.HeaderText = "ID khách hàng";
            this.idphong.Name = "idphong";
            this.idphong.ReadOnly = true;
            // 
            // tenloaiphong
            // 
            this.tenloaiphong.DataPropertyName = "hotenkh";
            this.tenloaiphong.HeaderText = "Họ tên";
            this.tenloaiphong.Name = "tenloaiphong";
            this.tenloaiphong.ReadOnly = true;
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "gioitinh";
            this.tenphong.HeaderText = "Giới tính";
            this.tenphong.Name = "tenphong";
            this.tenphong.ReadOnly = true;
            // 
            // tang
            // 
            this.tang.DataPropertyName = "ngaysinh";
            this.tang.HeaderText = "Ngày sinh";
            this.tang.Name = "tang";
            this.tang.ReadOnly = true;
            // 
            // songuoi
            // 
            this.songuoi.DataPropertyName = "socccd";
            this.songuoi.HeaderText = "Số CCCD";
            this.songuoi.Name = "songuoi";
            this.songuoi.ReadOnly = true;
            // 
            // sogiuong
            // 
            this.sogiuong.DataPropertyName = "sodienthoai";
            this.sogiuong.HeaderText = "Số điện thoại";
            this.sogiuong.Name = "sogiuong";
            this.sogiuong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "quoctich";
            this.dongia.HeaderText = "Quốc tịch";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            // 
            // pnCus
            // 
            this.pnCus.Controls.Add(this.txtBirthDay);
            this.pnCus.Controls.Add(this.txtNationality);
            this.pnCus.Controls.Add(this.txtNote);
            this.pnCus.Controls.Add(this.label1);
            this.pnCus.Controls.Add(this.txtName);
            this.pnCus.Controls.Add(this.lbIDCus);
            this.pnCus.Controls.Add(this.label29);
            this.pnCus.Controls.Add(this.label32);
            this.pnCus.Controls.Add(this.txtPhone);
            this.pnCus.Controls.Add(this.label3);
            this.pnCus.Controls.Add(this.txtSex);
            this.pnCus.Controls.Add(this.label11);
            this.pnCus.Controls.Add(this.label12);
            this.pnCus.Controls.Add(this.label16);
            this.pnCus.Controls.Add(this.txtCCCD);
            this.pnCus.Controls.Add(this.label31);
            this.pnCus.Location = new System.Drawing.Point(978, 6);
            this.pnCus.Name = "pnCus";
            this.pnCus.Size = new System.Drawing.Size(613, 585);
            this.pnCus.TabIndex = 14;
            // 
            // btnEditCus
            // 
            this.btnEditCus.BorderRadius = 20;
            this.btnEditCus.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnEditCus.CheckedState.Parent = this.btnEditCus;
            this.btnEditCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCus.CustomImages.Parent = this.btnEditCus;
            this.btnEditCus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditCus.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCus.ForeColor = System.Drawing.Color.White;
            this.btnEditCus.HoverState.Parent = this.btnEditCus;
            this.btnEditCus.Location = new System.Drawing.Point(989, 650);
            this.btnEditCus.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.ShadowDecoration.Parent = this.btnEditCus;
            this.btnEditCus.Size = new System.Drawing.Size(289, 64);
            this.btnEditCus.TabIndex = 42;
            this.btnEditCus.Text = "Sửa";
            this.btnEditCus.Click += new System.EventHandler(this.btnEditCus_Click);
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.BorderRadius = 20;
            this.btnDeleteCus.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnDeleteCus.CheckedState.Parent = this.btnDeleteCus;
            this.btnDeleteCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCus.CustomImages.Parent = this.btnDeleteCus;
            this.btnDeleteCus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteCus.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCus.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCus.HoverState.Parent = this.btnDeleteCus;
            this.btnDeleteCus.Location = new System.Drawing.Point(1325, 650);
            this.btnDeleteCus.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.ShadowDecoration.Parent = this.btnDeleteCus;
            this.btnDeleteCus.Size = new System.Drawing.Size(240, 64);
            this.btnDeleteCus.TabIndex = 43;
            this.btnDeleteCus.Text = "Xóa";
            this.btnDeleteCus.Click += new System.EventHandler(this.btnDeleteCus_Click);
            // 
            // lbIDCus
            // 
            this.lbIDCus.AutoSize = true;
            this.lbIDCus.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbIDCus.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbIDCus.Location = new System.Drawing.Point(79, 15);
            this.lbIDCus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDCus.Name = "lbIDCus";
            this.lbIDCus.Size = new System.Drawing.Size(63, 36);
            this.lbIDCus.TabIndex = 107;
            this.lbIDCus.Text = "___";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label29.ForeColor = System.Drawing.Color.OrangeRed;
            this.label29.Location = new System.Drawing.Point(15, 15);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 36);
            this.label29.TabIndex = 106;
            this.label29.Text = "ID - ";
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(334, 327);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(131, 38);
            this.label32.TabIndex = 104;
            this.label32.Text = "Quốc tịch";
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.Parent = this.txtPhone;
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedState.Parent = this.txtPhone;
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.HoverState.Parent = this.txtPhone;
            this.txtPhone.Location = new System.Drawing.Point(16, 375);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.ShadowDecoration.Parent = this.txtPhone;
            this.txtPhone.Size = new System.Drawing.Size(244, 48);
            this.txtPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPhone.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 33);
            this.label3.TabIndex = 100;
            this.label3.Text = "Họ tên";
            // 
            // txtSex
            // 
            this.txtSex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSex.DefaultText = "";
            this.txtSex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSex.DisabledState.Parent = this.txtSex;
            this.txtSex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSex.FocusedState.Parent = this.txtSex;
            this.txtSex.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSex.HoverState.Parent = this.txtSex;
            this.txtSex.Location = new System.Drawing.Point(347, 132);
            this.txtSex.Margin = new System.Windows.Forms.Padding(5);
            this.txtSex.Name = "txtSex";
            this.txtSex.PasswordChar = '\0';
            this.txtSex.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSex.PlaceholderText = "";
            this.txtSex.SelectedText = "";
            this.txtSex.ShadowDecoration.Parent = this.txtSex;
            this.txtSex.Size = new System.Drawing.Size(244, 44);
            this.txtSex.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSex.TabIndex = 99;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(342, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 33);
            this.label11.TabIndex = 98;
            this.label11.Text = "Giới tính";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 336);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 38);
            this.label12.TabIndex = 97;
            this.label12.Text = "Số điện thoại";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 213);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 33);
            this.label16.TabIndex = 96;
            this.label16.Text = "Ngày sinh";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.Parent = this.txtCCCD;
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.FocusedState.Parent = this.txtCCCD;
            this.txtCCCD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.HoverState.Parent = this.txtCCCD;
            this.txtCCCD.Location = new System.Drawing.Point(339, 251);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PasswordChar = '\0';
            this.txtCCCD.PlaceholderText = "";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.ShadowDecoration.Parent = this.txtCCCD;
            this.txtCCCD.Size = new System.Drawing.Size(244, 48);
            this.txtCCCD.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCCCD.TabIndex = 95;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(332, 213);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(137, 35);
            this.label31.TabIndex = 94;
            this.label31.Text = "Số CCCD";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(23, 132);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(244, 44);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 108;
            // 
            // txtNote
            // 
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.DisabledState.Parent = this.txtNote;
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.FocusedState.Parent = this.txtNote;
            this.txtNote.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.HoverState.Parent = this.txtNote;
            this.txtNote.Location = new System.Drawing.Point(16, 484);
            this.txtNote.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderText = "";
            this.txtNote.SelectedText = "";
            this.txtNote.ShadowDecoration.Parent = this.txtNote;
            this.txtNote.Size = new System.Drawing.Size(558, 48);
            this.txtNote.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNote.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 445);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 38);
            this.label1.TabIndex = 109;
            this.label1.Text = "Ghi chú";
            // 
            // txtNationality
            // 
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.DefaultText = "";
            this.txtNationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.DisabledState.Parent = this.txtNationality;
            this.txtNationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.FocusedState.Parent = this.txtNationality;
            this.txtNationality.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.HoverState.Parent = this.txtNationality;
            this.txtNationality.Location = new System.Drawing.Point(339, 375);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PasswordChar = '\0';
            this.txtNationality.PlaceholderText = "";
            this.txtNationality.SelectedText = "";
            this.txtNationality.ShadowDecoration.Parent = this.txtNationality;
            this.txtNationality.Size = new System.Drawing.Size(244, 48);
            this.txtNationality.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNationality.TabIndex = 111;
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.CheckedState.Parent = this.txtBirthDay;
            this.txtBirthDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBirthDay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBirthDay.HoverState.Parent = this.txtBirthDay;
            this.txtBirthDay.Location = new System.Drawing.Point(16, 251);
            this.txtBirthDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirthDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtBirthDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.ShadowDecoration.Parent = this.txtBirthDay;
            this.txtBirthDay.Size = new System.Drawing.Size(251, 50);
            this.txtBirthDay.TabIndex = 112;
            this.txtBirthDay.Value = new System.DateTime(2021, 9, 19, 10, 48, 19, 17);
            // 
            // UserManaInfoCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserManaInfoCus";
            this.Size = new System.Drawing.Size(1668, 857);
            this.Load += new System.EventHandler(this.UserManaInfoCus_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCus)).EndInit();
            this.pnCus.ResumeLayout(false);
            this.pnCus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnCus;
        private System.Windows.Forms.Label lbHDCus;
        private Guna.UI2.WinForms.Guna2DataGridView dtgCus;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tang;
        private System.Windows.Forms.DataGridViewTextBoxColumn songuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sogiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private Guna.UI2.WinForms.Guna2TextBox txtNameSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCus;
        private Guna.UI2.WinForms.Guna2Button btnEditCus;
        private Guna.UI2.WinForms.Guna2TextBox txtNationality;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lbIDCus;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label32;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private System.Windows.Forms.Label label31;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtBirthDay;
    }
}
