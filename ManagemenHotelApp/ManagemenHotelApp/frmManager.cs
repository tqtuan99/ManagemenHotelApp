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
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            userManaEm1.Visible = true;
            userRoom1.Visible = false;
            userService1.Visible = false;
            userFood1.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddEm_Click(object sender, EventArgs e)
        {
            panelScroll.Left = btnManaEm.Left + 12;
            btnManaRoom.Checked = false;
            btnManaFood.Checked = false;
            btnManaService.Checked = false;
            btnSta.Checked = false;
            btnManaEm.Checked = true;

            userManaEm1.Visible = true;
            userManaEm1.BringToFront();
            btnTextContent.Text = btnManaEm.Text;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            panelScroll.Left = btnManaRoom.Left + 12;
            btnManaEm.Checked = false;
            btnManaFood.Checked = false;
            btnManaService.Checked = false;
            btnSta.Checked = false;

            btnManaRoom.Checked = true;

            userRoom1.Visible = true;
            userRoom1.BringToFront();
            btnTextContent.Text = btnManaRoom.Text;
        }

        private void btnManaService_Click(object sender, EventArgs e)
        {
            panelScroll.Left = btnManaService.Left + 12;
            btnManaEm.Checked = false;
            btnManaFood.Checked = false;
            btnManaRoom.Checked = false;
            btnSta.Checked = false;

            btnManaService.Checked = true;
            userService1.Visible = true;
            userService1.BringToFront();
            btnTextContent.Text = btnManaService.Text;
        }

        private void btnManaFood_Click(object sender, EventArgs e)
        {
            panelScroll.Left = btnManaFood.Left + 12;
            btnManaEm.Checked = false;
            btnManaService.Checked = false;
            btnManaRoom.Checked = false;
            btnSta.Checked = false;

            btnManaFood.Checked = true;
            userFood1.Visible = true;
            userFood1.BringToFront();
            btnTextContent.Text = btnManaFood.Text;
        }

        private void btnSta_Click(object sender, EventArgs e)
        {
            panelScroll.Left = btnSta.Left + 12;
            btnManaEm.Checked = false;
            btnManaService.Checked = false;
            btnManaRoom.Checked = false;
            btnManaFood.Checked = false;

            btnSta.Checked = true;
            btnTextContent.Text = btnSta.Text;
        }

        private void pnContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Login f = new frm_Login();
            f.Show();
        }

        private void userFood1_Load(object sender, EventArgs e)
        {

        }
    }
}
