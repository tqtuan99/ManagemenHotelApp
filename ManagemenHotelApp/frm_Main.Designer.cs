namespace ManagemenHotelApp
{
    partial class frm_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNameLogin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbIdLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddService = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.btnAddCus = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lbTextContent = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userRegisterRoom1 = new ManagemenHotelApp.AllUserControll.UserRegisterRoom();
            this.userAddCus1 = new ManagemenHotelApp.AllUserControll.UserAddCus();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnManagement);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.btnAddService);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Controls.Add(this.panelScroll);
            this.panel1.Controls.Add(this.btnAddCus);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 845);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbNameLogin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbIdLogin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 92);
            this.panel2.TabIndex = 2;
            // 
            // lbNameLogin
            // 
            this.lbNameLogin.AutoSize = true;
            this.lbNameLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.lbNameLogin.Location = new System.Drawing.Point(74, 60);
            this.lbNameLogin.Name = "lbNameLogin";
            this.lbNameLogin.Size = new System.Drawing.Size(40, 21);
            this.lbNameLogin.TabIndex = 3;
            this.lbNameLogin.Text = "___";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ Tên: ";
            // 
            // lbIdLogin
            // 
            this.lbIdLogin.AutoSize = true;
            this.lbIdLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.lbIdLogin.Location = new System.Drawing.Point(129, 39);
            this.lbIdLogin.Name = "lbIdLogin";
            this.lbIdLogin.Size = new System.Drawing.Size(40, 21);
            this.lbIdLogin.TabIndex = 1;
            this.lbIdLogin.Text = "___";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Nhân Viên: ";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.BorderRadius = 15;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Image = global::ManagemenHotelApp.Properties.Resources.check_out;
            this.btnCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckOut.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCheckOut.Location = new System.Drawing.Point(22, 504);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(221, 87);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.BorderColor = System.Drawing.Color.Transparent;
            this.btnManagement.BorderRadius = 15;
            this.btnManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnManagement.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnManagement.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnManagement.CheckedState.Parent = this.btnManagement;
            this.btnManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagement.CustomImages.Parent = this.btnManagement;
            this.btnManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnManagement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.ForeColor = System.Drawing.Color.White;
            this.btnManagement.HoverState.Parent = this.btnManagement;
            this.btnManagement.Image = global::ManagemenHotelApp.Properties.Resources.file;
            this.btnManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManagement.ImageSize = new System.Drawing.Size(32, 32);
            this.btnManagement.Location = new System.Drawing.Point(22, 597);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.ShadowDecoration.Parent = this.btnManagement;
            this.btnManagement.Size = new System.Drawing.Size(221, 87);
            this.btnManagement.TabIndex = 4;
            this.btnManagement.Text = "Quản lý TTKH";
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddFood.BorderRadius = 15;
            this.btnAddFood.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAddFood.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddFood.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnAddFood.CheckedState.Parent = this.btnAddFood;
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.CustomImages.Parent = this.btnAddFood;
            this.btnAddFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.HoverState.Parent = this.btnAddFood;
            this.btnAddFood.Image = global::ManagemenHotelApp.Properties.Resources.order_food;
            this.btnAddFood.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddFood.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddFood.Location = new System.Drawing.Point(22, 411);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.ShadowDecoration.Parent = this.btnAddFood;
            this.btnAddFood.Size = new System.Drawing.Size(221, 87);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Đặt thực phẩm";
            this.btnAddFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddService.BorderRadius = 15;
            this.btnAddService.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAddService.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddService.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnAddService.CheckedState.Parent = this.btnAddService;
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.CustomImages.Parent = this.btnAddService;
            this.btnAddService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.HoverState.Parent = this.btnAddService;
            this.btnAddService.Image = global::ManagemenHotelApp.Properties.Resources.car_rental;
            this.btnAddService.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddService.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddService.Location = new System.Drawing.Point(22, 318);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.ShadowDecoration.Parent = this.btnAddService;
            this.btnAddService.Size = new System.Drawing.Size(221, 87);
            this.btnAddService.TabIndex = 2;
            this.btnAddService.Text = "Đặt dịch vụ";
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddRoom.BorderRadius = 15;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Image = global::ManagemenHotelApp.Properties.Resources.room;
            this.btnAddRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddRoom.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddRoom.Location = new System.Drawing.Point(22, 225);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(221, 87);
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = "Đặt phòng";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panelScroll
            // 
            this.panelScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panelScroll.Location = new System.Drawing.Point(10, 132);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(8, 87);
            this.panelScroll.TabIndex = 0;
            // 
            // btnAddCus
            // 
            this.btnAddCus.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddCus.BorderRadius = 15;
            this.btnAddCus.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAddCus.Checked = true;
            this.btnAddCus.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddCus.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnAddCus.CheckedState.Parent = this.btnAddCus;
            this.btnAddCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCus.CustomImages.Parent = this.btnAddCus;
            this.btnAddCus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnAddCus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCus.ForeColor = System.Drawing.Color.White;
            this.btnAddCus.HoverState.Parent = this.btnAddCus;
            this.btnAddCus.Image = global::ManagemenHotelApp.Properties.Resources.follow;
            this.btnAddCus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddCus.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddCus.Location = new System.Drawing.Point(22, 132);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.ShadowDecoration.Parent = this.btnAddCus;
            this.btnAddCus.Size = new System.Drawing.Size(210, 87);
            this.btnAddCus.TabIndex = 0;
            this.btnAddCus.Text = "Thêm khách";
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Checked = true;
            this.guna2CircleButton1.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = global::ManagemenHotelApp.Properties.Resources._24h128;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(128, 128);
            this.guna2CircleButton1.Location = new System.Drawing.Point(271, 0);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(147, 128);
            this.guna2CircleButton1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(1496, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(35, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Controls.Add(this.userRegisterRoom1);
            this.panelContent.Controls.Add(this.userAddCus1);
            this.panelContent.Location = new System.Drawing.Point(271, 134);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1251, 711);
            this.panelContent.TabIndex = 3;
            // 
            // lbTextContent
            // 
            this.lbTextContent.Checked = true;
            this.lbTextContent.CheckedState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTextContent.CheckedState.Parent = this.lbTextContent;
            this.lbTextContent.CustomImages.Parent = this.lbTextContent;
            this.lbTextContent.FillColor = System.Drawing.Color.Transparent;
            this.lbTextContent.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.lbTextContent.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.lbTextContent.HoverState.Parent = this.lbTextContent;
            this.lbTextContent.Location = new System.Drawing.Point(428, 0);
            this.lbTextContent.Name = "lbTextContent";
            this.lbTextContent.ShadowDecoration.Parent = this.lbTextContent;
            this.lbTextContent.Size = new System.Drawing.Size(919, 128);
            this.lbTextContent.TabIndex = 0;
            this.lbTextContent.Text = "THÊM KHÁCH HÀNG";
            this.lbTextContent.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.lbTextContent.Click += new System.EventHandler(this.lbTextContent_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panelContent;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panelContent;
            // 
            // userRegisterRoom1
            // 
            this.userRegisterRoom1.BackColor = System.Drawing.Color.White;
            this.userRegisterRoom1.Location = new System.Drawing.Point(0, 0);
            this.userRegisterRoom1.Name = "userRegisterRoom1";
            this.userRegisterRoom1.Size = new System.Drawing.Size(1251, 696);
            this.userRegisterRoom1.TabIndex = 1;
            // 
            // userAddCus1
            // 
            this.userAddCus1.BackColor = System.Drawing.Color.White;
            this.userAddCus1.Location = new System.Drawing.Point(0, 0);
            this.userAddCus1.Name = "userAddCus1";
            this.userAddCus1.Size = new System.Drawing.Size(1251, 696);
            this.userAddCus1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-2, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 30);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.label2.Location = new System.Drawing.Point(21, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thông tin nhân viên";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1532, 884);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.lbTextContent);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Panel panelContent;
        private Guna.UI2.WinForms.Guna2Button btnAddCus;
        private System.Windows.Forms.Panel panelScroll;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnManagement;
        private Guna.UI2.WinForms.Guna2Button btnAddFood;
        private Guna.UI2.WinForms.Guna2Button btnAddService;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button lbTextContent;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private AllUserControll.UserAddCus userAddCus1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AllUserControll.UserRegisterRoom userRegisterRoom1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNameLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbIdLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}