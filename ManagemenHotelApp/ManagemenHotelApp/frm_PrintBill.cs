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
    public partial class frm_PrintBill : Form
    {
        public frm_PrintBill()
        {
            InitializeComponent();
        }

        private void frm_PrintBill_Load(object sender, EventArgs e)
        {
            lbDV.Location = new Point(lbSum.Left + lbSum.Width, 624);
        }
     

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void PrintScreen()
        {

            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private bool button1WasClicked = false;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.Visible = false;
            //if (MessageBox.Show("Mở giao diện in hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //{
            button1WasClicked = true;
            PrintScreen();
            printPreviewDialog1.ShowDialog();
            this.Close();  
            //}
            //else
            //{
            //    guna2Button1.Visible = true;
            //}
        }

        private void frm_PrintBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (button1WasClicked == false)
            {
                e.Cancel = true;
            }
        }
    }
}
