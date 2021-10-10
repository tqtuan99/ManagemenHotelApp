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
                query = @"Select idthucpham,tenloai,tenthucpham,soluong,donvitinh,soluongtong,gianhap,giaban,ghichu from thucpham,loaithucpham 
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
            txtSale.ResetText();
            txtNewSale.ResetText();
            txtNameFood.ResetText();
            txtPriceFood.ResetText();
            txtQuantity.ResetText();
            txtNewUnit.ResetText();
            txtUnit.ResetText();
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

        //lấy số lượng thực phẩm từ db
        public int GetQuantyti(string a,string id)
        {
            DataSet ds = cn.getData("select soluong"+a+" from thucpham where idthucpham =" + id + "");
            int Quantyti = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            return Quantyti;
        }

        //lấy tên thực phẩm từ db
        public int GetName(String s)
        {
            DataSet ds = cn.getData("select tenthucpham from thucpham");
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    if (s == dr[0].ToString())
                    {
                        return 1;
                    }
                }
            }
            return 0;

        }

        public void setVisibleTypeFood(Boolean b)
        {
            lbHDTypeFood.Visible = !b;
            btnDeleteTypeFood.Visible = b;
            btnEditTypeFood.Visible = b;
            lbIDTypeFood.Visible = b;
            lbIdtf.Visible = b;
            ClearTypeFood();
        }

        public void ClearTypeFood()
        {
            txtNameTypeFood.ResetText();
            txtNoteTypeFood.ResetText();
            lbIDTypeFood.Text = "___";
        }

        public void fillDataTypeFood()
        {
            query = @"Select * from loaithucpham";
            DataSet ds = cn.getData(query);
            dtgTypeFood.DataSource = ds.Tables[0];
        }

        //Lấy tên loại thực phẩm từ db
        public int GetNameTypeFood(String s)
        {
            DataSet ds = cn.getData("select tenloai from loaithucpham");
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    if (s == dr[0].ToString())
                    {
                        return 1;
                    }
                }
            }
            return 0;

        }
        //==================================================================================================//

        private void UserFood_Load(object sender, EventArgs e)
        {
            FillData(dtgFood, "");
            getTypeFood(cbTypeFood);
            getMaxIdFood();
            fillDataTypeFood();
            ClearTypeFood();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                getTypeFood(cbTypeFood);
                UserFood_Load(sender, e);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                getTypeFood(cbNewTypeFood);
                txtNameSearch.ResetText();
                FillData(dtgNewFood, "");
                setVisible(false);
                UserFood_Load(sender, e);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                UserFood_Load(sender, e);
                setVisibleTypeFood(false);
            }
        }

        private void btnAddRom_Click(object sender, EventArgs e)
        {
            if (txtNameFood.Text != "" && txtPriceFood.Text != "" && txtQuantity.Text != "")
            {
                try
                {
                    String NameF = txtNameFood.Text;
                    float PriceF = float.Parse(txtPriceFood.Text);
                    float SaleF = float.Parse(txtSale.Text);
                    int Quantity = int.Parse(txtQuantity.Text);
                    int TypeF = cbTypeFood.SelectedIndex + 1;
                    String Note = txtNoteF.Text;
                    if (GetName(NameF) == 1)
                    {
                        MessageBox.Show("Sản phẩm đã tồn tại!");
                    }
                    else
                    if (MessageBox.Show("Bạn có chắc muốn thêm dịch vụ mới không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        try
                        {
                            //id tự tăng nên khi thêm mới không cần thêm id
                            query = @"insert into THUCPHAM (idloaithucpham,tenthucpham,soluong,donvitinh,soluongtong,gianhap,giaban,ghichu)  
                                    values (N'" + TypeF + "',N'" + NameF + "',N'" + Quantity + "',N'" + txtUnit.Text + "',N'" + Quantity + "',N'" + PriceF + "',N'" + SaleF + "',N'" + Note + "')";
                            cn.setData(query, "Thêm thực phẩm thành công.");
                            Clear();
                            UserFood_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể thêm mới thực phẩm vào database!" + ex, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ! Vui lòng nhập đúng định dạng." + ex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điển đầy đủ thông tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgNewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setVisible(true);
            try
            {
                String id = dtgNewFood.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbNewID.Text = id;

                query = @"select idthucpham,loaithucpham.idloaithucpham,tenthucpham,soluong,donvitinh,gianhap,giaban,ghichu from thucpham,loaithucpham
                     where thucpham.idloaithucpham = loaithucpham.idloaithucpham and idthucpham = '" + id + "'";
                DataSet ds = cn.getData(query);
                cbNewTypeFood.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString()) - 1;
                txtNewNameFood.Text = ds.Tables[0].Rows[0][2].ToString();
                txtNewQuantity.Text = ds.Tables[0].Rows[0][3].ToString();
                txtNewUnit.Text = ds.Tables[0].Rows[0][4].ToString();
                txtNewPrice.Text = ds.Tables[0].Rows[0][5].ToString();
                txtNewSale.Text = ds.Tables[0].Rows[0][6].ToString();
                txtNewNote.Text = ds.Tables[0].Rows[0][7].ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = @"select idthucpham,loaithucpham.tenloai,tenthucpham,soluong,donvitinh,soluongtong,,gianhap,giaban,ghichu from thucpham,loaithucpham
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
                    float SaleF = float.Parse(txtNewSale.Text);
                    int Quantity = int.Parse(txtNewQuantity.Text);
                    int TypeF = cbNewTypeFood.SelectedIndex + 1;
                    String Note = txtNewNote.Text;
                    int Sum;
                    try
                    {
                        //nếu số lượng sửa lớn hơn sl hiện có thì sl tổng (tăng sl sửa - sl có)
                        if (GetQuantyti("", lbNewID.Text) < Quantity) Sum = (GetQuantyti("tong", lbNewID.Text) + (Quantity - GetQuantyti("", lbNewID.Text)));
                        else if(GetQuantyti("", lbNewID.Text) == Quantity) Sum = GetQuantyti("", lbNewID.Text);
                        else Sum = (GetQuantyti("tong", lbNewID.Text) - (GetQuantyti("", lbNewID.Text) - Quantity));

                        query = @"Update THUCPHAM set idloaithucpham = '" + TypeF + "', tenthucpham = N'" + NameF + "', soluong = '" + Quantity +
                            "',donvitinh = N'" + txtNewUnit.Text + "', soluongtong = N'" + Sum + "',gianhap = N'" + PriceF + "', giaban = N'" + SaleF + "', ghichu = N'" + Note + "' where idthucpham = '" + lbNewID.Text + "'";
                        cn.setData(query, "Cập nhật thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể sửa dữ liệu trong database!" + ex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ! Vui lòng nhập đúng định dạng." + ex);
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

        private void dtgTypeFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setVisibleTypeFood(true);
                lbIDTypeFood.Text = dtgTypeFood.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameTypeFood.Text = dtgTypeFood.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNoteTypeFood.Text = dtgTypeFood.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnAddTypeFood_Click(object sender, EventArgs e)
        {
            if (lbIDTypeFood.Text != "___")
            {
                setVisibleTypeFood(false);
                ClearTypeFood();
            }
            else
            {
                if (GetNameTypeFood(txtNameTypeFood.Text) == 1)
                {
                    MessageBox.Show("Tên loại phòng trùng! Vui lòng chọn tên khác.");
                }
                else if (txtNameTypeFood.Text != "")
                {
                    if (MessageBox.Show("Bạn có chắc muốn thêm không?", "Xác Nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        cn.setData("insert into loaithucpham (tenloai, ghichuloai) values (N'" + txtNameTypeFood.Text + "',N'" + txtNoteTypeFood.Text + "')", "Thêm mới thành công!");
                        UserFood_Load(sender, e);
                    }
                    
                }
                else
                    MessageBox.Show("Vui lòng nhập thông tin để thêm!");

            }
        }

        private void btnEditTypeFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetNameTypeFood(txtNameTypeFood.Text) == 1)
                {
                    MessageBox.Show("Tên loại phòng trùng! Vui lòng chọn tên khác.");
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa không?", "Xác Nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        cn.setData("update loaithucpham set tenloai = N'" + txtNameTypeFood.Text + "', ghichuloai =N'" + txtNoteTypeFood.Text + "' where idloaithucpham = N'" + lbIDTypeFood.Text + "'", "Sửa thành công!");
                        UserFood_Load(sender, e);
                        setVisibleTypeFood(false);
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗ không thể sửa thông tin!");

            }
        }

        private void btnDeleteTypeFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác Nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    cn.setData("delete from loaithucpham where idloaithucpham = N'" + lbIDTypeFood.Text + "'", "Xóa thành công!");
                    UserFood_Load(sender, e);
                    setVisibleTypeFood(false);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗ không thể xóa thông tin!");

            }
        }
    }
}
