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
    public partial class UserService : UserControl
    {
        ConnectBase cn = new ConnectBase();
        String query;
        public UserService()
        {
            InitializeComponent();
        }

        //======================================================================================================//
        //hàm load dữ liệu từ db ra bảng dữ liệu dtg và điều kiên s
        public void FillData(DataGridView dtg, String s)
        {
            try
            {
                query = @"Select iddichvu,tendichvu,giadichvu,soluong,(case trangthai when 'true' then N'Mở' else N'Đóng' end) as trangthai,mota,mucgiamgia,ghichu from DICHVU " + s;
                DataSet ds = cn.getData(query);
                if (ds != null)
                    dtg.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }
        //Lấy max id dịch vụ hiện tại để load ra label id
        public void getMaxID(Label txt)
        {
            query = @"select max(iddichvu) from DICHVU";
            DataSet ds = cn.getData(query);
            if (ds != null)
            {
                int maxid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                txt.Text = (maxid + 1).ToString();
            }
            else
            {
                txt.Text = "001";
            }
        }
        //làm trống các textbox để nhập dữ liệu mới
        public void Clear()
        {
            txtNameService.ResetText();
            txtPriceService.ResetText();
            txtQuantity.ResetText();
            txtDescription.ResetText();
            txtDiscount.ResetText();
            txtNote.ResetText();
        }

        public void setVisible(Boolean b)
        {
            Clear();
            pnUpdate.Enabled = b;
            lbNewID.Text = "___";
            lbNoti1.Visible = !b;
        }
        //==========================================================================================================//
        private void UserService_Load(object sender, EventArgs e)
        {
            FillData(dtgService, "");
            getMaxID(lbIDService);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "") txtDiscount.Text = "0";
            if (txtNameService.Text != "" && txtPriceService.Text != "" && txtQuantity.Text != "")
            {
                try
                {
                    String NameService = txtNameService.Text;
                    float PriceService = float.Parse(txtPriceService.Text);
                    int Quantity = int.Parse(txtQuantity.Text);
                    float Discount = float.Parse(txtDiscount.Text);
                    String Description = txtDescription.Text;
                    String Note = txtNote.Text;
                    if (MessageBox.Show("Bạn có chắc muốn thêm dịch vụ mới không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        try
                        {
                            //id dịch vụ tự tăng nên khi thêm mới không cần thêm id
                            query = @"insert into DICHVU (tendichvu,giadichvu,soluong,trangthai,mota,mucgiamgia,ghichu)  
                                    values (N'" + NameService + "',N'" + PriceService + "',N'" + Quantity + "','1',N'" + Description + "',N'" + Discount + "',N'" + Note + "')";
                            cn.setData(query, "Thêm dịch vụ thành công.");
                            Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể thêm mới dịch vụ vào database!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ! Vui lòng nhập đúng định dạng.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điển đầy đủ thông tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillData(dtgService, "");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                UserService_Load(this, null);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                setVisible(false);
                txtNameSearch.ResetText();
                FillData(dtgNewService, "");
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = @"Select iddichvu,tendichvu,giadichvu,soluong,trangthai,mota,mucgiamgia,ghichu 
                            from DICHVU where (convert(nvarchar(10),iddichvu) like N'" + txtNameSearch.Text + "%' " +
                                           "or convert(nvarchar(10),tendichvu) like N'" + txtNameSearch.Text + "%')";
                DataSet ds = cn.getData(query);
                dtgNewService.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void dtgNewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setVisible(true);
            try
            {
                String id = dtgNewService.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbNewID.Text = id;

                query = @"Select iddichvu, tendichvu, giadichvu, soluong, trangthai, mota, mucgiamgia, ghichu
                            from DICHVU where iddichvu = '" + id + "'";
                DataSet ds = cn.getData(query);
                txtNewNameService.Text = ds.Tables[0].Rows[0][1].ToString();
                txtNewPriceService.Text = ds.Tables[0].Rows[0][2].ToString();
                txtNewQuantity.Text = ds.Tables[0].Rows[0][3].ToString();
                if (ds.Tables[0].Rows[0][4].ToString() == "True")
                {
                    cbNewStatus.SelectedIndex = 0;
                }
                else
                {
                    cbNewStatus.SelectedIndex = 1;
                }
                txtNewDescription.Text = ds.Tables[0].Rows[0][5].ToString();
                txtNewDiscount.Text = ds.Tables[0].Rows[0][6].ToString();
                txtNewNote.Text = ds.Tables[0].Rows[0][7].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng click đúng vào hàng chưa thông tin cần chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dịch vụ ID " + lbNewID.Text + " không?", "Xác Nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                query = "delete from DICHVU where iddichvu = '" + lbNewID.Text + "'";
                cn.setData(query, "Xóa thành thành công!");
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtNewDiscount.Text == "") txtNewDiscount.Text = "0";
            if (txtNewNameService.Text != "" && txtNewPriceService.Text != "" && txtNewQuantity.Text != "")
            {
                try
                {
                    String NameService = txtNewNameService.Text;
                    float PriceService = float.Parse(txtNewPriceService.Text);
                    int Quantity = int.Parse(txtNewQuantity.Text);
                    float Discount = float.Parse(txtNewDiscount.Text);
                    String Description = txtNewDescription.Text;
                    String Note = txtNewNote.Text;
                    int Status;
                    if (cbNewStatus.SelectedIndex == 0)
                    {
                        Status = 1;
                    }
                    else Status = 0;
                    if (MessageBox.Show("Bạn có muốn sửa thông tin không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        try
                        {
                            //id dịch vụ tự tăng nên khi thêm mới không cần thêm id
                            query = @"update DICHVU set tendichvu = N'" + NameService + "',giadichvu = N'" + PriceService + "',soluong=N'" + Quantity + "',trangthai=N'" + Status + "',mota=N'" + Description +
                                "',mucgiamgia=N'" + Discount + "',ghichu=N'" + Note + "' where iddichvu =N'" + lbNewID.Text + "'";
                            cn.setData(query, "Sửa thông tin dịch vụ thành công.");
                            Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể sửa thông tin trong database!!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ!!! Bạn cần nhập đúng định dạng để sửa thông tin.");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng điển đầy đủ thông tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillData(dtgNewService, "");
        }
       
    }
}
