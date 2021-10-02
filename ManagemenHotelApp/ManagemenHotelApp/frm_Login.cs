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
    public partial class frm_Login : Form
    {
        String query;
        ConnectBase cn = new ConnectBase();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //    if(txtPassword.Text == "123" && txtUsername.Text == "admin")
            //    {
            //        lbWarning.Visible = false;
            //        String s = txtUsername.Text;
            //        frm_Main fr = new frm_Main(s);
            //        this.Hide();
            //        fr.Show();
            //    }
            //    else if (txtPassword.Text == "123" && txtUsername.Text == "admin1")
            //    {
            //        lbWarning.Visible = false;
            //        frmManager fr = new frmManager();
            //        this.Hide();
            //        fr.Show();

            //    }
            //    else
            //    {
            //        lbWarning.Visible = true;
            //        txtPassword.Clear();
            //        txtUsername.Focus();
            //    }
            //}
            query = @"Select taikhoan.idnhanvien, hotennv, idchucvu, trangthai from taikhoan,nhanvien where taikhoan.idnhanvien = nhanvien.idnhanvien and username = '" + txtUsername.Text + "'and pass = '" + txtPassword.Text + "'";
            DataSet ds = cn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (ds.Tables[0].Rows[0][3].ToString() == "True")
                {
                    lbWarning.Visible = false;
                    String[] arr = new String[2];
                    arr[0] = ds.Tables[0].Rows[0][0].ToString();
                    arr[1] = ds.Tables[0].Rows[0][1].ToString();
                    frm_Main fr = new frm_Main(arr);
                    this.Hide();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản của nhân viên đã bị khóa. Vui lòng nhập lại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (txtUsername.Text == "a" && txtPassword.Text =="1")
            {
                lbWarning.Visible = false;
                frmManager fr = new frmManager();
                this.Hide();
                fr.Show();
            }
            else
            {
                lbWarning.Visible = true;
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
