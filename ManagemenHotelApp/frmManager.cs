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
    }
}
