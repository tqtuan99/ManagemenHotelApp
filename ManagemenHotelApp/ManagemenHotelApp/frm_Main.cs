﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagemenHotelApp
{
    public partial class frm_Main : Form
    {
        String idEm;
        public frm_Main()
        {
            InitializeComponent();
        }

        public frm_Main(String[] arr) : this()
        {
            lbIdLogin.Text = idEm = arr[0];
            lbNameLogin.Text = arr[1];
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            panelScroll.Top = btnAddRoom.Top;
            btnAddCus.Checked = false;
            btnAddFood.Checked = false;
            btnAddService.Checked = false;
            btnCheckOut.Checked = false;
            btnManagement.Checked = false;
            
            if(btnAddRoom.Width == 221)
            {
                btnAddRoom.Width = 210;
            }else
            {
                btnAddRoom.Checked = true;
                btnAddRoom.Width = 210;
            }
            btnAddCus.Width = 221;
            btnAddService.Width = 221;
            btnAddFood.Width = 221;
            btnCheckOut.Width = 221;
            btnManagement.Width = 221;
            lbTextContent.Text = btnAddRoom.Text;

            userRegisterRoom1.Visible = true;
            userRegisterRoom1.BringToFront();
            userRegisterRoom1.Tag = idEm;
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {

            userAddCus1.Visible = true;
            userAddCus1.BringToFront();

            panelScroll.Top = btnAddCus.Top;
            btnAddRoom.Checked = false;
            btnAddFood.Checked = false;
            btnAddService.Checked = false;
            btnCheckOut.Checked = false;
            btnManagement.Checked = false;

            if (btnAddCus.Width == 221)
            {
                btnAddCus.Width = 210;
            }
            else
            {
                btnAddCus.Checked = true;
                btnAddCus.Width = 210;
            }
            btnAddRoom.Width = 221;
            btnAddService.Width = 221;
            btnAddFood.Width = 221;
            btnCheckOut.Width = 221;
            btnManagement.Width = 221;
            lbTextContent.Text = btnAddCus.Text;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            userRegisterService1.Visible = true;
            userRegisterService1.BringToFront();

            panelScroll.Top = btnAddService.Top;
            btnAddCus.Checked = false;
            btnAddFood.Checked = false;
            btnAddRoom.Checked = false;
            btnCheckOut.Checked = false;
            btnManagement.Checked = false;

            if (btnAddService.Width == 221)
            {
                btnAddService.Width = 210;
            }
            else
            {
                btnAddService.Checked = true;
                btnAddService.Width = 210;
            }
            btnAddRoom.Width = 221;
            btnAddCus.Width = 221;
            btnAddFood.Width = 221;
            btnCheckOut.Width = 221;
            btnManagement.Width = 221;

            lbTextContent.Text = btnAddService.Text;
            userRegisterService1.Tag = idEm;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            userRegisterFood1.Visible = true;
            userRegisterFood1.BringToFront();

            panelScroll.Top = btnAddFood.Top;
            btnAddCus.Checked = false;
            btnAddRoom.Checked = false;
            btnAddService.Checked = false;
            btnCheckOut.Checked = false;
            btnManagement.Checked = false;

            if (btnAddFood.Width == 221)
            {
                btnAddFood.Width = 210;
            }
            else
            {
                btnAddFood.Checked = true;
                btnAddFood.Width = 210;
            }
            btnAddRoom.Width = 221;
            btnAddCus.Width = 221;
            btnAddService.Width = 221;
            btnCheckOut.Width = 221;
            btnManagement.Width = 221;

            lbTextContent.Text = btnAddFood.Text;
            userRegisterFood1.Tag = idEm;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            panelScroll.Top = btnCheckOut.Top;
            btnAddCus.Checked = false;
            btnAddFood.Checked = false;
            btnAddService.Checked = false;
            btnAddRoom.Checked = false;
            btnManagement.Checked = false;

            if (btnCheckOut.Width == 221)
            {
                btnCheckOut.Width = 210;
            }
            else
            {
                btnCheckOut.Checked = true;
                btnCheckOut.Width = 210;
            }
            btnAddRoom.Width = 221;
            btnAddCus.Width = 221;
            btnAddService.Width = 221;
            btnAddFood.Width = 221;
            btnManagement.Width = 221;

            lbTextContent.Text = btnCheckOut.Text;
            userPayBill1.Visible = true;
            userPayBill1.BringToFront();

        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            panelScroll.Top = btnManagement.Top;
            btnAddCus.Checked = false;
            btnAddFood.Checked = false;
            btnAddService.Checked = false;
            btnCheckOut.Checked = false;
            btnAddRoom.Checked = false;

            if (btnManagement.Width == 221)
            {
                btnManagement.Width = 210;
            }
            else
            {
                btnManagement.Checked = true;
                btnManagement.Width = 210;
            }
            btnAddRoom.Width = 221;
            btnAddCus.Width = 221;
            btnAddService.Width = 221;
            btnAddFood.Width = 221;
            btnCheckOut.Width = 221;

            lbTextContent.Text = btnManagement.Text;
            userManaInfoCus1.Visible = true;
            userManaInfoCus1.BringToFront();
        }

        private void lbTextContent_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            userAddCus1.Visible = false;
            userRegisterRoom1.Visible = false;
            userPayBill1.Visible = false;
            userRegisterService1.Visible = false;
            userRegisterFood1.Visible = false;
            btnAddCus.PerformClick();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không!","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frm_Login f = new frm_Login();
                f.Show();
            }
            
        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_MouseHover(object sender, EventArgs e)
        {
            lbLogout.Visible = true;
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            lbLogout.Visible = false;
        }
    } 
}
