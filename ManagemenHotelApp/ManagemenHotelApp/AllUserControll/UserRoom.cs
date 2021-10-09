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
    public partial class UserRoom : UserControl
    {
        ConnectBase cn = new ConnectBase();
        String query;


        public UserRoom()
        {
            InitializeComponent();
        }

        private void UserRoom_Load(object sender, EventArgs e)
        {
            fillData(dtgRoom);
            fillData(dtgNewRoom);
            getTypeRoom(cbTypeRoom);
            clear();
        }
        public void getTypeRoom(ComboBox cb)
        {
            try
            {
                query = "select idloaiphong,tenloaiphong from loaiphong";
                DataSet ds = cn.getData(query);
                cb.DataSource = ds.Tables[0];
                cb.DisplayMember = "tenloaiphong";
                cb.ValueMember = "idloaiphong";
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Không kết nối được với cơ sở dữ liệu");
            }
        }
        public void clear()
        {
            cbFloor.SelectedIndex = -1;
            cbTypeRoom.SelectedIndex = -1;
            txtBedNumber.Clear();
            txtDiscount.Text = "0";
            txtPriceRoom.Clear();
            txtNoteP.Text = "";
            txtPersonNumber.Clear();
            txtNameRoom.Clear();
            getMaxIdRoom();
        }
        public void getMaxIdRoom()
        {

            query = "Select max(idphong) from phong";
            DataSet ds = cn.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                lbIdp.Text = (num + 1).ToString();
            }
            else
            {
                lbIdp.Text = "0001";
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                UserRoom_Load(this, null);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                UserRoom_Load(this, null);
                getTypeRoom(cbNewTypeRoom);
                setVisibleUpdate(false);
            }
        }
        public void setVisibleUpdate(bool b)
        {
            pnUpdate.Enabled = b;
            lbNoti1.Visible = !b;
        }
        //làm sạch 
        public void Clear()
        {
            cbNewTypeRoom.SelectedIndex = -1;
            cbNewFloor.SelectedIndex = -1;
            txtNewNameRoom.ResetText();
            txtNewPrice.ResetText();
            txtNewDiscount.ResetText();
            txtNewBedNumber.ResetText();
            txtNewPersonNumber.ResetText();
            cbNewStatus.SelectedIndex = -1;
            txtNewNote.ResetText();
            txtNameSearch.ResetText();
            lbNewID.Text = "___";
        }
        //load dữ liêu từ data ra bảng phòng 
        public void fillData(DataGridView dtg)
        {
            query = @"Select idphong,loaiphong.tenloaiphong,tang,tenphong,dongia,mucgiamgia,sogiuong,songuoi,(case trangthai when 'true' then N'Còn trống' else 'Đã thuê' end) as trangthai,phong.ghichu 
                        from phong,loaiphong where phong.idloaiphong = loaiphong.idloaiphong";
            DataSet ds = cn.getData(query);
            dtg.DataSource = ds.Tables[0];
        }

        //lấy tên phòng từ db
        public int GetName(String s)
        {
            DataSet ds = cn.getData("select tenphong from phong");
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

        private void btnAddRom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thêm phòng mới không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (txtNameRoom.Text != "" && txtPriceRoom.Text != "" && txtBedNumber.Text != "" && txtPersonNumber.Text != "")
                {
                    try
                    {
                        int IdRoom = int.Parse(lbIdp.Text);
                        int Floor = int.Parse(cbFloor.Text);
                        int TypeRoom = cbTypeRoom.SelectedIndex + 1;
                        String NameRoom = txtNameRoom.Text;
                        float BedNumber = float.Parse(txtBedNumber.Text);
                        float Discount = float.Parse(txtDiscount.Text);
                        int PriceRoom = int.Parse(txtPriceRoom.Text);
                        String Note = txtNoteP.Text;
                        int PersonNumber = int.Parse(txtPersonNumber.Text);
                        if (GetName(NameRoom) == 1)
                        {
                            MessageBox.Show("Tên phòng đã tồn tại!");
                        }
                        else
                        {
                            try
                            {
                                //id nhân viên trong bảng sql set tự động tăng nên không cần thêm idnhanvien
                                query = @"insert into PHONG (idloaiphong,tang,tenphong,dongia,mucgiamgia,sogiuong,songuoi,trangthai,ghichu)  
                                    values (N'" + TypeRoom + "',N'" + Floor + "',N'" + NameRoom + "',N'" + PriceRoom + "',N'" + Discount + "',N'" + BedNumber + "',N'" + PersonNumber + "','1',N'" + Note + "')";
                                cn.setData(query, "Thêm phòng thành công.");
                                UserRoom_Load(this, null); //reset lại from
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show("Thông tin vừa nhập không hợp lệ hoặc thông tin đã trùng lắp", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điển đầy đủ thông tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = @"Select idphong,loaiphong.tenloaiphong,tang,tenphong,dongia,mucgiamgia,sogiuong,songuoi,trangthai,phong.ghichu 
                            from phong,loaiphong where phong.idloaiphong = loaiphong.idloaiphong 
                            and (convert(nvarchar(10),idphong) like N'" + txtNameSearch.Text + "%' or convert(nvarchar(10),tenphong) like N'" + txtNameSearch.Text + "%')";
                DataSet ds = cn.getData(query);
                dtgNewRoom.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void dtgNewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setVisibleUpdate(true);
            try
            {
                String id = dtgRoom.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbNewID.Text = id;

                query = @"Select idphong,loaiphong.idloaiphong,tang,tenphong,dongia,mucgiamgia,sogiuong,songuoi,trangthai,phong.ghichu
                        from phong,loaiphong where phong.idloaiphong = loaiphong.idloaiphong and idphong = '" + id + "'";
                DataSet ds = cn.getData(query);
                cbNewTypeRoom.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString()) - 1;
                cbNewFloor.Text = ds.Tables[0].Rows[0][2].ToString();
                txtNewNameRoom.Text = ds.Tables[0].Rows[0][3].ToString();
                txtNewPrice.Text = ds.Tables[0].Rows[0][4].ToString();
                txtNewDiscount.Text = ds.Tables[0].Rows[0][5].ToString();
                txtNewBedNumber.Text = ds.Tables[0].Rows[0][6].ToString();
                txtNewPersonNumber.Text = ds.Tables[0].Rows[0][7].ToString();
                if (ds.Tables[0].Rows[0][8].ToString() == "True")
                {
                    cbNewStatus.SelectedIndex = 0;
                }
                else
                {
                    cbNewStatus.SelectedIndex = 1;
                }
                txtNewNote.Text = ds.Tables[0].Rows[0][9].ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa phòng ID " + lbNewID.Text + " không?", "Xác Nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                query = "delete from PHONG where idphong = '" + lbNewID.Text + "'";
                cn.setData(query, "Xóa thành thành công!");
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtNewNameRoom.Text == "" && txtNewPrice.Text == "" && cbNewTypeRoom.Text == "" && cbNewFloor.Text == "" && cbNewStatus.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần chỉnh sửa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin phòng không?", "Xác Nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    int Floor = int.Parse(cbNewFloor.Text);
                    int TypeRoom = cbNewTypeRoom.SelectedIndex + 1;
                    String NameRoom = txtNewNameRoom.Text;
                    float BedNumber = float.Parse(txtNewBedNumber.Text);
                    float Discount = float.Parse(txtNewDiscount.Text);
                    int PriceRoom = int.Parse(txtNewPrice.Text);
                    String Note = txtNewNote.Text;
                    int PersonNumber = int.Parse(txtNewPersonNumber.Text);
                    int Status;

                    if (cbNewStatus.SelectedIndex == 0)
                    {
                        Status = 1;
                    }
                    else Status = 0;
                    try
                    {
                        query = @"Update PHONG set idloaiphong = '" + TypeRoom + "', tang = '" + Floor + "', tenphong = N'" + NameRoom +
                            "', dongia = '" + PriceRoom + "', mucgiamgia = '" + Discount + "',sogiuong = '" + BedNumber +
                            "',songuoi = '" + PersonNumber + "',trangthai = '" + Status + "',ghichu = N'" + Note + "' where idphong = '" + lbNewID.Text + "'";
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

    }
}
