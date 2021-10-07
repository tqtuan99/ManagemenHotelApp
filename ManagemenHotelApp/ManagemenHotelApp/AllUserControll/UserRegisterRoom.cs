﻿using System;
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
    public partial class UserRegisterRoom : UserControl
    {
        String query;
        ConnectBase cn = new ConnectBase();
        public UserRegisterRoom()
        {
            InitializeComponent();
        }

        private void UserRegisterRoom_Enter(object sender, EventArgs e)
        {
            UserRegisterRoom_Load(this, null); 
        }

        private void UserRegisterRoom_Leave(object sender, EventArgs e)
        {
            clearRegisRoom();
        }

        private void UserRegisterRoom_Load(object sender, EventArgs e)
        {
            //FillData vào bảng khách hàng
            String getCus = "Select * From KHACHHANG";
            FillData(tbCustumer, getCus);
            txtDayCrea.Value = DateTime.Now;
            clearRegisRoom(); //Hàm reset form
        }

        private void tbCustumer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String id = tbCustumer.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtIDCus.Text = id;
                txtNameCus.Text = tbCustumer.Rows[e.RowIndex].Cells[1].Value.ToString();
                try
                {
                    //Lấy ra bảng chứa hóa đơn mà khách hàng chưa thanh toán
                    String check = @"Select idhoadon from Khachhang, hoadonphong where khachhang.idkhachhang = hoadonphong.idkhachhang
                  and hoadonphong.ngaythanhtoan IS NULL and khachhang.idkhachhang = '" + id + "'";
                    DataSet dsCheck = cn.getData(check);
                    //Nếu tồn tại hóa đơn chưa thanh toán thì id hóa đơn thêm phòng sẽ là id hóa đơn chưa thanh toán
                    if (dsCheck.Tables[0].Rows.Count == 1)
                    {
                        lbIdhoadon.Text = dsCheck.Tables[0].Rows[0][0].ToString();
                    }
                    else //Ngược lại thì id hóa đơn sẽ được thêm mới
                    {
                        lbIdhoadon.Text = getMaxIdRoomBill();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            catch
            {
                return;
            }
        }

        private void tbRoomNull_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //FillData vào ô nhập liệu trên form từ phòng vừa chọn trên bảng
            try
            {
                txtIDRoom.Text = tbRoomNull.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameRoom.Text = tbRoomNull.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomType.Text = tbRoomNull.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrice.Text = tbRoomNull.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSale.Text = tbRoomNull.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            if (txtIDCus.Text != "" && txtIDRoom.Text != "")
            {
                try
                {
                    //Kiểm tra nếu hóa đơn phòng sau khi lựa chọn khách hàng, nếu bằng max id hóa đơn thì insert một hóa đơn mới
                    if(lbIdhoadon.Text == getMaxIdRoomBill())
                    {
                        //ngaythanhtoan mặc định là null khi tạo nên ko thêm
                        String idnv = this.Tag.ToString();
                        query = @"insert into hoadonphong (idkhachhang, idnhanvien, ngaytao, ghichu) 
                            values (N'" + txtIDCus.Text + "',N'" + idnv + "','" + txtDayCrea.Value + "',N'" + txtNote.Text + "')";
                        cn.setData(query, "");
                    }
                    //Sau khi xác định được hóa đơn cần thêm phòng thì tiến hành thêm phòng vào bảng chi tiết của idhoadon
                    query = @"insert into ct_hoadonphong (idhoadon, idphong) values (N'" + lbIdhoadon.Text + "', N'" + txtIDRoom.Text + "')";
                    cn.setData(query, "");
                    //Cập nhật lại trạng thái của phòng vừa được đặt
                    query = @"update Phong set trangthai = '0' where idphong = '" + txtIDRoom.Text + "'";
                    cn.setData(query, "Đã hoàn tất đặt phòng.");
                    clearRegisRoom();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng hoặc dịch vụ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Tạo hành Filldata để tái sử dụng
        public void FillData(DataGridView dtg, String CondiQuery)
        {
            try
            {
                DataSet ds = cn.getData(CondiQuery);
                dtg.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được với database" + ex, "Waning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Hàm lấy ra max id + 1 trong bảng hóa đơn phòng để tạo mới hóa đơn
        public String getMaxIdRoomBill()
        {
            query = "Select max(idhoadon) from HOADONPHONG";
            DataSet ds = cn.getData(query);
            String s = "";
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                s = (num + 1).ToString();
            }
            return s;
        }

        //Hàm reset form khi chuyển form hoặc sau khi tạo mới hóa đơn, để tái sử dụng
        public void clearRegisRoom()
        {
            txtIDCus.Clear();
            txtIDRoom.Clear();
            txtNameCus.Clear();
            txtNameRoom.Clear();
            txtNameSearch.Clear();
            txtPrice.Clear();
            txtRoomType.Clear();
            txtSale.Clear();
            lbIdhoadon.Text = getMaxIdRoomBill();
            String getRoomNull = "Select idphong, tenphong, tang, tenloaiphong, dongia, mucgiamgia, sogiuong, songuoi, phong.ghichu " +
                "from PHONG,LOAIPHONG where trangthai = '1' and phong.idloaiphong = loaiphong.idloaiphong";
            FillData(tbRoomNull, getRoomNull);
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            //FillData vào bảng khách hàng
            String getCus = "Select * From KHACHHANG where  (convert(nvarchar(10),idkhachhang) like N'" + txtNameSearch.Text + "%' or convert(nvarchar(10),hotenkh) like N'" + txtNameSearch.Text + "%')";
            FillData(tbCustumer, getCus);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
