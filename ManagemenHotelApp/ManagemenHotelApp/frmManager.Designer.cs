namespace ManagemenHotelApp
{
    partial class frmManager
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSta = new Guna.UI2.WinForms.Guna2Button();
            this.btnManaFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnManaService = new Guna.UI2.WinForms.Guna2Button();
            this.btnManaRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.btnManaEm = new Guna.UI2.WinForms.Guna2Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.btnTextContent = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userService1 = new ManagemenHotelApp.AllUserControll.UserService();
            this.userRoom1 = new ManagemenHotelApp.AllUserControll.UserRoom();
            this.userManaEm1 = new ManagemenHotelApp.AllUserControll.UserManaEm();
            this.userFood1 = new ManagemenHotelApp.AllUserControll.UserFood();
            this.panel1.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.guna2CircleButton1);
            this.panel1.Controls.Add(this.btnSta);
            this.panel1.Controls.Add(this.btnManaFood);
            this.panel1.Controls.Add(this.btnManaService);
            this.panel1.Controls.Add(this.btnManaRoom);
            this.panel1.Controls.Add(this.panelScroll);
            this.panel1.Controls.Add(this.btnManaEm);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2044, 190);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = global::ManagemenHotelApp.Properties.Resources.Logout_icon;
            this.button1.Location = new System.Drawing.Point(48, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 37);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(-3, -2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(43, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(102, 102);
            this.guna2CircleButton1.Location = new System.Drawing.Point(48, 36);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(167, 132);
            this.guna2CircleButton1.TabIndex = 6;
            // 
            // btnSta
            // 
            this.btnSta.BorderColor = System.Drawing.Color.Transparent;
            this.btnSta.BorderRadius = 15;
            this.btnSta.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSta.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSta.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnSta.CheckedState.Parent = this.btnSta;
            this.btnSta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSta.CustomImages.Parent = this.btnSta;
            this.btnSta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnSta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSta.ForeColor = System.Drawing.Color.White;
            this.btnSta.HoverState.Parent = this.btnSta;
            this.btnSta.Image = global::ManagemenHotelApp.Properties.Resources.check_out;
            this.btnSta.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSta.Location = new System.Drawing.Point(1637, 41);
            this.btnSta.Margin = new System.Windows.Forms.Padding(4);
            this.btnSta.Name = "btnSta";
            this.btnSta.ShadowDecoration.Parent = this.btnSta;
            this.btnSta.Size = new System.Drawing.Size(327, 107);
            this.btnSta.TabIndex = 5;
            this.btnSta.Text = "Thống Kê";
            this.btnSta.Click += new System.EventHandler(this.btnSta_Click);
            // 
            // btnManaFood
            // 
            this.btnManaFood.BorderColor = System.Drawing.Color.Transparent;
            this.btnManaFood.BorderRadius = 15;
            this.btnManaFood.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnManaFood.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnManaFood.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnManaFood.CheckedState.Parent = this.btnManaFood;
            this.btnManaFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManaFood.CustomImages.Parent = this.btnManaFood;
            this.btnManaFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnManaFood.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManaFood.ForeColor = System.Drawing.Color.White;
            this.btnManaFood.HoverState.Parent = this.btnManaFood;
            this.btnManaFood.Image = global::ManagemenHotelApp.Properties.Resources.order_food;
            this.btnManaFood.ImageSize = new System.Drawing.Size(24, 24);
            this.btnManaFood.Location = new System.Drawing.Point(1289, 41);
            this.btnManaFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnManaFood.Name = "btnManaFood";
            this.btnManaFood.ShadowDecoration.Parent = this.btnManaFood;
            this.btnManaFood.Size = new System.Drawing.Size(327, 107);
            this.btnManaFood.TabIndex = 3;
            this.btnManaFood.Text = "Quản Lý Thực Phẩm";
            this.btnManaFood.Click += new System.EventHandler(this.btnManaFood_Click);
            // 
            // btnManaService
            // 
            this.btnManaService.BorderColor = System.Drawing.Color.Transparent;
            this.btnManaService.BorderRadius = 15;
            this.btnManaService.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnManaService.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnManaService.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnManaService.CheckedState.Parent = this.btnManaService;
            this.btnManaService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManaService.CustomImages.Parent = this.btnManaService;
            this.btnManaService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnManaService.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManaService.ForeColor = System.Drawing.Color.White;
            this.btnManaService.HoverState.Parent = this.btnManaService;
            this.btnManaService.Image = global::ManagemenHotelApp.Properties.Resources.car_rental;
            this.btnManaService.ImageSize = new System.Drawing.Size(24, 24);
            this.btnManaService.Location = new System.Drawing.Point(941, 41);
            this.btnManaService.Margin = new System.Windows.Forms.Padding(4);
            this.btnManaService.Name = "btnManaService";
            this.btnManaService.ShadowDecoration.Parent = this.btnManaService;
            this.btnManaService.Size = new System.Drawing.Size(327, 107);
            this.btnManaService.TabIndex = 2;
            this.btnManaService.Text = "Quản Lý Dịch Vụ";
            this.btnManaService.Click += new System.EventHandler(this.btnManaService_Click);
            // 
            // btnManaRoom
            // 
            this.btnManaRoom.BorderColor = System.Drawing.Color.Transparent;
            this.btnManaRoom.BorderRadius = 15;
            this.btnManaRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnManaRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnManaRoom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnManaRoom.CheckedState.Parent = this.btnManaRoom;
            this.btnManaRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManaRoom.CustomImages.Parent = this.btnManaRoom;
            this.btnManaRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnManaRoom.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManaRoom.ForeColor = System.Drawing.Color.White;
            this.btnManaRoom.HoverState.Parent = this.btnManaRoom;
            this.btnManaRoom.Image = global::ManagemenHotelApp.Properties.Resources.room;
            this.btnManaRoom.ImageSize = new System.Drawing.Size(24, 24);
            this.btnManaRoom.Location = new System.Drawing.Point(592, 41);
            this.btnManaRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnManaRoom.Name = "btnManaRoom";
            this.btnManaRoom.ShadowDecoration.Parent = this.btnManaRoom;
            this.btnManaRoom.Size = new System.Drawing.Size(327, 107);
            this.btnManaRoom.TabIndex = 1;
            this.btnManaRoom.Text = "Quản Lý Phòng";
            this.btnManaRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panelScroll
            // 
            this.panelScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panelScroll.Location = new System.Drawing.Point(260, 155);
            this.panelScroll.Margin = new System.Windows.Forms.Padding(4);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(297, 12);
            this.panelScroll.TabIndex = 0;
            // 
            // btnManaEm
            // 
            this.btnManaEm.BorderColor = System.Drawing.Color.Transparent;
            this.btnManaEm.BorderRadius = 15;
            this.btnManaEm.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnManaEm.Checked = true;
            this.btnManaEm.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnManaEm.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnManaEm.CheckedState.Parent = this.btnManaEm;
            this.btnManaEm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManaEm.CustomImages.Parent = this.btnManaEm;
            this.btnManaEm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnManaEm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManaEm.ForeColor = System.Drawing.Color.White;
            this.btnManaEm.HoverState.Parent = this.btnManaEm;
            this.btnManaEm.Image = global::ManagemenHotelApp.Properties.Resources.follow;
            this.btnManaEm.ImageSize = new System.Drawing.Size(24, 24);
            this.btnManaEm.Location = new System.Drawing.Point(245, 41);
            this.btnManaEm.Margin = new System.Windows.Forms.Padding(4);
            this.btnManaEm.Name = "btnManaEm";
            this.btnManaEm.ShadowDecoration.Parent = this.btnManaEm;
            this.btnManaEm.Size = new System.Drawing.Size(327, 107);
            this.btnManaEm.TabIndex = 0;
            this.btnManaEm.Text = "Quản Lý Nhân Sự";
            this.btnManaEm.Click += new System.EventHandler(this.btnAddEm_Click);
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.userFood1);
            this.pnContent.Controls.Add(this.userService1);
            this.pnContent.Controls.Add(this.userRoom1);
            this.pnContent.Controls.Add(this.userManaEm1);
            this.pnContent.Location = new System.Drawing.Point(16, 278);
            this.pnContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(2011, 774);
            this.pnContent.TabIndex = 2;
            this.pnContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContent_Paint);
            // 
            // btnTextContent
            // 
            this.btnTextContent.Checked = true;
            this.btnTextContent.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnTextContent.CheckedState.Parent = this.btnTextContent;
            this.btnTextContent.CustomImages.Parent = this.btnTextContent;
            this.btnTextContent.FillColor = System.Drawing.Color.Transparent;
            this.btnTextContent.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(133)))));
            this.btnTextContent.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnTextContent.HoverState.Parent = this.btnTextContent;
            this.btnTextContent.Location = new System.Drawing.Point(848, 215);
            this.btnTextContent.Margin = new System.Windows.Forms.Padding(4);
            this.btnTextContent.Name = "btnTextContent";
            this.btnTextContent.ShadowDecoration.Parent = this.btnTextContent;
            this.btnTextContent.Size = new System.Drawing.Size(737, 55);
            this.btnTextContent.TabIndex = 4;
            this.btnTextContent.Text = "Quản lý nhân sự";
            this.btnTextContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.pnContent;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.pnContent;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.pnContent;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.pnContent;
            // 
            // userService1
            // 
            this.userService1.BackColor = System.Drawing.Color.White;
            this.userService1.Location = new System.Drawing.Point(0, 0);
            this.userService1.Name = "userService1";
            this.userService1.Size = new System.Drawing.Size(2011, 774);
            this.userService1.TabIndex = 2;
            // 
            // userRoom1
            // 
            this.userRoom1.BackColor = System.Drawing.Color.White;
            this.userRoom1.Location = new System.Drawing.Point(0, 0);
            this.userRoom1.Name = "userRoom1";
            this.userRoom1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userRoom1.Size = new System.Drawing.Size(2011, 774);
            this.userRoom1.TabIndex = 1;
            // 
            // userManaEm1
            // 
            this.userManaEm1.BackColor = System.Drawing.Color.White;
            this.userManaEm1.Location = new System.Drawing.Point(0, 0);
            this.userManaEm1.Margin = new System.Windows.Forms.Padding(5);
            this.userManaEm1.Name = "userManaEm1";
            this.userManaEm1.Size = new System.Drawing.Size(2011, 774);
            this.userManaEm1.TabIndex = 0;
            // 
            // userFood1
            // 
            this.userFood1.BackColor = System.Drawing.Color.White;
            this.userFood1.Location = new System.Drawing.Point(0, 0);
            this.userFood1.Name = "userFood1";
            this.userFood1.Size = new System.Drawing.Size(2011, 774);
            this.userFood1.TabIndex = 3;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnTextContent);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManager";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.panel1.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button btnSta;
        private Guna.UI2.WinForms.Guna2Button btnManaFood;
        private Guna.UI2.WinForms.Guna2Button btnManaService;
        private Guna.UI2.WinForms.Guna2Button btnManaRoom;
        private System.Windows.Forms.Panel panelScroll;
        private Guna.UI2.WinForms.Guna2Button btnManaEm;
        private System.Windows.Forms.Panel pnContent;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnTextContent;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AllUserControll.UserManaEm userManaEm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AllUserControll.UserRoom userRoom1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControll.UserService userService1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControll.UserFood userFood1;
    }
}