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
    public partial class UserFood : UserControl
    {
        ConnectBase cn = new ConnectBase();
        String query;
        public UserFood()
        {
            InitializeComponent();
        }
        //==================================================================================================//
        //Hàm lấy ra idmax +1
        public void getMaxIdFood()
        {

            query = "Select max(idthucpham) from THUCPHAM";
            DataSet ds = cn.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                lbIDFood.Text = (num + 1).ToString();
            }
            else
            {
                lbIDFood.Text = "0001";
            }
        }

        //Hàm lấy loại load lên comboBox
        public void getTypeFood(ComboBox cb)
        {
            try
            {
                query = "select idloaithucpham,tenloai from loaithucpham";
                DataSet ds = cn.getData(query);
                cb.DataSource = ds.Tables[0];
                cb.DisplayMember = "tenloai";
                cb.ValueMember = "idloaithucpham";
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Không kết nối được với cơ sở dữ liệu");
            }
        }

        //hàm load dữ liệu từ db ra bảng dữ liệu dtg và điều kiên s
        public void FillData(DataGridView dtg, String s)
        {
            try
            {
                query = @"Select idthucpham,tenloai,tenthucpham,soluong,gianhap,ghichu from thucpham,loaithucpham 
                        where thucpham.idloaithucpham = loaithucpham.idloaithucpham " + s;
                DataSet ds = cn.getData(query);
                if (ds != null)
                    dtg.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        //clear text box
        public void Clear()
        {
            txtNameFood.ResetText();
            txtPriceFood.ResetText();
            txtQuantity.ResetText();
            cbTypeFood.SelectedIndex = -1;
            txtNoteF.ResetText();
            txtNewNameFood.ResetText();
            txtNewPrice.ResetText();
            txtNewQuantity.ResetText();
            cbNewTypeFood.SelectedIndex = -1;
            txtNewNote.ResetText();
        }

        public void setVisible(Boolean b)
        {
            Clear();
            pnUpdate.Enabled = b;
            lbNoti1.Visible = !b;
            lbNewID.Text = "___";
        }
        //==================================================================================================//

        private void UserFood_Load(object sender, EventArgs e)
        {
            FillData(dtgFood, "");
            getTypeFood(cbTypeFood);
            getMaxIdFood();
        }

        private void btnAddRom_Click(object sender, EventArgs e)
        {
            if (txtNameFood.Text != "" && txtPriceFood.Text != "" && txtQuantity.Text != "")
            {
                try
                {
                    String NameF = txtNameFood.Text;
                    float PriceF = float.Parse(txtPriceFood.Text);
                    int Quantity = int.Parse(txtQuantity.Text);
                    int TypeF = cbTypeFood.SelectedIndex + 1;
                    String Note = txtNoteF.Text;
                    if (MessageBox.Show("Bạn có chắc muốn thêm dịch vụ mới không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        try
                        {
                            //id tự tăng nên khi thêm mới không cần thêm id
                            query = @"insert into THUCPHAM (idloaithucpham,tenthucpham,soluong,gianhap,ghichu)  
                                    values (N'" + TypeF + "',N'" + NameF + "',N'" + Quantity + "',N'" + PriceF + "',N'" + Note + "')";
                            cn.setData(query, "Thêm thực phẩm thành công.");
                            Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể thêm mới thực phẩm vào database!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            UserFood_Load(sender, e);
        }

        private void dtgNewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setVisible(true);
            try
            {
                String id = dtgNewFood.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbNewID.Text = id;

                query = @"select idthucpham,loaithucpham.idloaithucpham,tenthucpham,soluong,gianhap,ghichu from thucpham,loaithucpham
                     where thucpham.idloaithucpham = loaithucpham.idloaithucpham and idthucpham = '" + id + "'";
                DataSet ds = cn.getData(query);
                cbNewTypeFood.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString()) - 1;
                txtNewNameFood.Text = ds.Tables[0].Rows[0][2].ToString();
                txtNewQuantity.Text = ds.Tables[0].Rows[0][3].ToString();
                txtNewPrice.Text = ds.Tables[0].Rows[0][4].ToString();
                txtNewNote.Text = ds.Tables[0].Rows[0][5].ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                getTypeFood(cbTypeFood);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                getTypeFood(cbNewTypeFood);
                txtNameSearch.ResetText();
                FillData(dtgNewFood, "");
                setVisible(false);
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = @"select idthucpham,loaithucpham.tenloai,tenthucpham,soluong,gianhap,ghichu from thucpham,loaithucpham
                    where thucpham.idloaithucpham = loaithucpham.idloaithucpham and (convert(nvarchar(10),idthucpham) like N'" + txtNameSearch.Text + "%' or convert(nvarchar(10),tenthucpham) like N'" + txtNameSearch.Text + "%')";
                DataSet ds = cn.getData(query);
                dtgNewFood.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối database!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtNameFood.Text != "" && txtPriceFood.Text != "" && txtQuantity.Text != "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần chỉnh sửa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin thực phẩm không?", "Xác Nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    String NameF = txtNewNameFood.Text;
                    float PriceF = float.Parse(txtNewPrice.Text);
                    int Quantity = int.Parse(txtNewQuantity.Text);
                    int TypeF = cbNewTypeFood.SelectedIndex + 1;
                    String Note = txtNewNote.Text;
                    try
                    {
                        query = @"Update THUCPHAM set idloaithucpham = '" + TypeF + "', tenthucpham = N'" + NameF + "', soluong = '" + Quantity +
                            "', gianhap = N'" + PriceF + "', ghichu = N'" + Note + "' where idthucpham = '" + lbNewID.Text + "'";
                        cn.setData(query, "Cập nhật thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể sửa dữ liệu trong database!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ! Vui lòng nhập đúng định dạng.");
                }
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thực phẩm ID " + lbNewID.Text + " không?", "Xác Nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                query = "delete from THUCPHAM where idthucpham = '" + lbNewID.Text + "'";
                cn.setData(query, "Xóa thành thành công!");
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
    }
}
