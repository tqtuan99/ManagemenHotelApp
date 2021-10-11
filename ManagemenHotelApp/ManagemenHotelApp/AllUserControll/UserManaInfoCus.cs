using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagemenHotelApp.AllUserControll
{
    public partial class UserManaInfoCus : UserControl
    {
        ConnectBase cn = new ConnectBase();
        String query;
        public UserManaInfoCus()
        {
            InitializeComponent();
        }
        //=========================================================================================//
        //load khách hàng ra bảng
        public void FillData(DataGridView dtg)
        {
            query = "select * from KHACHHANG";
            DataSet ds = cn.getData(query);
            dtg.DataSource = ds.Tables[0];
        }

        public void setVisible(Boolean b)
        {
            lbHDCus.Visible = !b;
            pnCus.Visible = b;
        }

        public void Clear()
        {
            lbIDCus.Text = "___";
            txtBirthDay.ResetText();
            txtCCCD.ResetText();
            txtName.ResetText();
            txtPhone.ResetText();
            txtNote.ResetText();
            txtSex.ResetText();
            txtNationality.ResetText();
        }
        //=========================================================================================//


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void UserManaInfoCus_Load(object sender, EventArgs e)
        {
            txtBirthDay.CustomFormat = "dd/MM/yyyy";
            FillData(dtgCus);
            setVisible(false);
        }

        private void dtgCus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setVisible(true);
                lbIDCus.Text = dtgCus.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dtgCus.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSex.Text = dtgCus.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBirthDay.Value = Convert.ToDateTime(dtgCus.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtCCCD.Text = dtgCus.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhone.Text = dtgCus.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtNationality.Text = dtgCus.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtNote.Text = dtgCus.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = "select * from KHACHHANG where where(convert(nvarchar(10), idkhachhang) like N'" + txtNameSearch.Text + "%' " +
                                           "or convert(nvarchar(10),hotenkh) like N'" + txtNameSearch.Text + "%')";
                DataSet ds = cn.getData(query);
                dtgCus.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
            
        }
        //check khách hàng đã lập hóa đơn chưa
        public int checkBill(String id)
        {
            query = "select hoadondichvu.idhoadon,hoadonphong.idhoadon,hoadonthucpham.idhoadon from hoadondichvu,hoadonphong,hoadonthucpham" +
                " where hoadondichvu.idkhachhang = '" + id + "' or hoadonphong.idkhachhang = '" + id + "' or hoadonthucpham.idkhachhang = '" + id + "'";
            DataSet ds = cn.getData(query);
            if(ds.Tables[0] == null)
            {
                return 1;
            }else
                return 0;
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            try
            {
                if(checkBill(lbIDCus.Text) == 1)
                {
                    MessageBox.Show("Không thể xóa vì khách hàng đã tạo hóa đơn!");
                }
                else if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "Delete from KHACHHANG where idkhachhang = N'" + lbIDCus.Text + "'";
                    cn.setData(query, "Xóa thành công");
                    UserManaInfoCus_Load(sender, e);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công!" + ex);
            }
        }

        private void btnEditCus_Click(object sender, EventArgs e)
        {
            try
            {
                String Name = txtName.Text;
                String Sex = txtSex.Text;
                DateTime DofB = txtBirthDay.Value;
                int CCCD1 = int.Parse(txtCCCD.Text);
                String CCCD = txtCCCD.Text;
                int Phone1 = int.Parse(txtPhone.Text);
                String Phone = txtPhone.Text;
                String Nationality = txtNationality.Text;
                String Note = txtNote.Text;

                if (Name =="" || CCCD =="" || Phone == "" || Sex == "" ||Nationality == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else if(MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "update khachhang set hotenkh = N'"+Name+ "',gioitinh= N'" + Sex + "',ngaysinh= N'" + txtBirthDay.Value + "',socccd = N'" + CCCD + "',sodienthoai= N'" + Phone + "',quoctich= N'" + Nationality + "',ghichu= N'" + Note + "' where idkhachhang = N'" + lbIDCus.Text + "'";
                    cn.setData(query, "Sửa thành công");
                    UserManaInfoCus_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập thông tin đúng định dạng!" + ex);
            }
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbHDCus_Click(object sender, EventArgs e)
        {

        }

        private void lbIDCus_Click(object sender, EventArgs e)
        {

        }

        private void txtSex_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
