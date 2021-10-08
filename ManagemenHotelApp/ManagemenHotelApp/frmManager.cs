using System;
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
            userManaEm1.Visible = false;
            userSta1.Visible = false;
            userRoom1.Visible = false;
            userFood1.Visible = false;
            userServive1.Visible = false;
            btnManaService.PerformClick();
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

            btnTextContent.Text = btnManaEm.Text;

            userManaEm1.Visible = true;
            userManaEm1.BringToFront();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            panelScroll.Left = btnManaRoom.Left + 12;
            btnManaEm.Checked = false;
            btnManaFood.Checked = false;
            btnManaService.Checked = false;
            btnSta.Checked = false;

            btnManaRoom.Checked = true;
            btnTextContent.Text = btnManaRoom.Text;

            userRoom1.Visible = true;
            userRoom1.BringToFront();
        }

        private void btnManaService_Click(object sender, EventArgs e)
        {
            panelScroll.Left = btnManaService.Left + 12;
            btnManaEm.Checked = false;
            btnManaFood.Checked = false;
            btnManaRoom.Checked = false;
            btnSta.Checked = false;

            btnManaService.Checked = true;
            btnTextContent.Text = btnManaService.Text;

            userServive1.Visible = true;
            userServive1.BringToFront();
        }

        private void btnManaFood_Click(object sender, EventArgs e)
        {
            panelScroll.Left = btnManaFood.Left + 12;
            btnManaEm.Checked = false;
            btnManaService.Checked = false;
            btnManaRoom.Checked = false;
            btnSta.Checked = false;

            btnManaFood.Checked = true;
            btnTextContent.Text = btnManaFood.Text;

            userFood1.Visible = true;
            userFood1.BringToFront();
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

            userSta1.Visible = true;
            userSta1.BringToFront();
        }

        private void pnContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn đăng xuất không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
                this.Close();
                frm_Login f = new frm_Login();
                f.Show();
            //}
        }
    }
}
