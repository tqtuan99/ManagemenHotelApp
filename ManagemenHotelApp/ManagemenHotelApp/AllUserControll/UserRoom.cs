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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UserRoom_Load(object sender, EventArgs e)
        {
            getTypeRoom(cbTypeRoom);
            clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                UserRoom_Load(this, null);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                getTypeRoom(cbNewTypeRoom);
                fillData();
                Clear();
                setVisibleUpdate(false);
            }
        }
        //=================================================================================================================//
        //Clear from 
        public void clear()
        {
            cbFloor.SelectedIndex = -1;
            cbTypeRoom.SelectedIndex = -1;
            txtBedNumber.Clear();
            txtDiscount.Clear();
            txtPriceRoom.Clear();
            txtNoteP.Clear();
            txtPersonNumber.Clear();
            txtNameRoom.Clear();
            getMaxIdRoom();
        }
        //Hàm lấy ra idmax +1
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

        //Hàm lấy loại phòng load lên comboBox
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
        public void fillData()
        {
            query = @"Select idphong,loaiphong.tenloaiphong,tang,tenphong,dongia,mucgiamgia,sogiuong,songuoi,trangthai,phong.ghichu 
                        from phong,loaiphong where phong.idloaiphong = loaiphong.idloaiphong";
            DataSet ds = cn.getData(query);
            dtgRoom.DataSource = ds.Tables[0];
        }

        private void btnAddRom_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn thêm phòng mới không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (txtNameRoom.Text != "" && txtPriceRoom.Text != "" && txtBedNumber.Text != "" && txtPersonNumber.Text != "")
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
                    try
                    {
                        //id nhân viên trong bảng sql set tự động tăng nên không cần thêm idnhanvien
                        query = @"insert into PHONG (idloaiphong,tang,tenphong,dongia,mucgiamgia,sogiuong,songuoi,trangthai,ghichu)  
                                    values (N'" + TypeRoom + "',N'" + Floor + "',N'" + NameRoom + "',N'" + PriceRoom + "',N'" + Discount + "',N'" + BedNumber + "',N'" + PersonNumber + "','1',N'" + Note + "')";
                        cn.setData(query, "Thêm phòng thành công.");
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Thông tin vừa nhập không hợp lệ hoặc thông tin đã trùng lắp", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    UserRoom_Load(this, null); //reset lại from
                }
                else
                {
                    MessageBox.Show("Vui lòng điển đầy đủ thông tin: ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                dtgRoom.DataSource = ds.Tables[0];
            }catch(Exception ex){
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void dtgRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setVisibleUpdate(true);
            //try
            //{
                String id = dtgRoom.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbNewID.Text = id;

                query = @"Select idphong,loaiphong.idloaiphong,tang,tenphong,dongia,mucgiamgia,sogiuong,songuoi,trangthai,phong.ghichu
                        from phong,loaiphong where phong.idloaiphong = loaiphong.idloaiphong and idphong = '" + id + "'";
                DataSet ds = cn.getData(query);
                cbNewTypeRoom.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString()) -1;
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
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Vui lòng click đúng vào hàng chưa thông tin cần chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa phòng ID " + lbNewID.Text + " không?", "Xác Nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                query = "delete from PHONG where idphong = '" + lbNewID.Text + "'";
                cn.setData(query, "Xóa thành thành công!");
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (txtNewNameRoom.Text == "" && txtNewPrice.Text == "" && cbNewTypeRoom.Text == "" && cbNewFloor.Text == "" && cbNewStatus.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần chỉnh sửa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin phòng không?", "Xác Nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
                    Status = 0;
                }
                else Status = 1;
                try
                {
                    query = @"Update PHONG set idloaiphong = '" + TypeRoom + "', tang = '" + Floor + "', tenphong = '" + NameRoom +
                        "', dongia = '" + PriceRoom + "', mucgiamgia = '" + Discount + "',sogiuong = '" + BedNumber +
                        "',songuoi = '" + PersonNumber + "',trangthai = '" + Status + "',ghichu = '" + Note + "' where idphong = '" + lbNewID.Text + "'";
                    cn.setData(query, "Cập nhật thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
    }
}
