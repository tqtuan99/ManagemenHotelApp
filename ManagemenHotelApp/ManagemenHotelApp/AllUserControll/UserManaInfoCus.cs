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
            query = "select ROW_NUMBER() OVER (ORDER BY idkhachhang) as stt, idkhachhang, hotenkh, gioitinh, Format(ngaysinh,'dd/MM/yyyy') as ngaysinh, socccd, sodienthoai, quoctich, ghichu from KHACHHANG";
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
            lbHD1.Visible = true;
            FillData(dtgCus1);
            setTableCus(525, false);
            setTableBill(0, false);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                UserManaInfoCus_Load(this, null);
            }else if(tabControl1.SelectedIndex == 1)
            {
                txtBirthDay.CustomFormat = "dd/MM/yyyy";
                FillData(dtgCus);
                setVisible(false);
            }
        }
        private void dtgCus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                setVisible(true);
                lbIDCus.Text = dtgCus.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtName.Text = dtgCus.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSex.Text = dtgCus.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtBirthDay.Value = Convert.ToDateTime(dtgCus.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtCCCD.Text = dtgCus.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPhone.Text = dtgCus.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtNationality.Text = dtgCus.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtNote.Text = dtgCus.Rows[e.RowIndex].Cells[8].Value.ToString();

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
                query = @"select ROW_NUMBER() OVER (ORDER BY idnhanvien) as stt, idkhachhang, hotenkh, gioitinh, Format(ngaysinh,'dd/MM/yyyy') as ngaysinh, socccd, sodienthoai, quoctich, ghichu 
                        from KHACHHANG where (convert(nvarchar(10), idkhachhang) like N'" + txtNameSearch.Text + "%' " +
                                           "or convert(nvarchar(10),hotenkh) like N'" + txtNameSearch.Text + "%')";
                DataSet ds = cn.getData(query);
                dtgCus.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Lỗi! Không tìm thấy thông tin khách hàng!");
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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = @"select ROW_NUMBER() OVER (ORDER BY idnhanvien) as stt, idkhachhang, hotenkh, gioitinh, Format(ngaysinh,'dd/MM/yyyy') as ngaysinh, socccd, sodienthoai, quoctich, ghichu 
                        from KHACHHANG where (convert(nvarchar(10), idkhachhang) like N'" + txtSearch.Text + "%' " +
                                           "or convert(nvarchar(10),hotenkh) like N'" + txtSearch.Text + "%')";
                DataSet ds = cn.getData(query);
                dtgCus1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Lỗi! Không tìm thấy thông tin khách hàng!");
            }
        }
        //===============================================Các hàm đổ dữ liệu vào bảng hóa đơn trong tra cứu nhân vien===============================================
        //Hàm fill data hóa đơn phòng vào bảng hóa đơn
        public void FillDataListRoomBill(String id)
        {
            query = @"Select  HOADONPHONG.idhoadon as 'ID Hóa Đơn', hotenkh as 'Tên Khách Hàng', hotennv as 'Tên Nhân Viên',  FORMAT (ngaytao, 'dd/MM/yyyy h:mm tt') as 'Ngày Tạo', FORMAT (ngaythanhtoan, 'dd/MM/yyyy h:mm tt') as 'Ngày Thanh Toán',
                              COUNT(CT_HOADONPHONG.idhoadon) as 'Số Lượng Phòng',
                              SUM(dongia * (1-mucgiamgia) * (case when (5<DATEPART(hour, ngaytao) and 9>=DATEPART(hour, ngaytao) and ngaythanhtoan IS NOT NULL) then 0.5
			                                                     when (9<DATEPART(hour, ngaytao) and 14>= DATEPART(hour, ngaytao) and ngaythanhtoan IS NOT NULL) then 0.3
			                                                     else 0 end 
	                                                      + case when (12<DATEPART(hour, ngaythanhtoan) and 15>=DATEPART(hour, ngaytao) ) then 0.3
			                                                     when (15<DATEPART(hour, ngaythanhtoan) and 18>= DATEPART(hour, ngaytao)) then 0.5
			                                                     when (18<DATEPART(hour, ngaythanhtoan)) then 1
			                                                     else 0 end 
	                                                      + case when ngaythanhtoan IS NOT NULL then DATEDIFF(DAY,ngaytao,ngaythanhtoan)
		                                                    else 0 end)) as 'Tổng Tiền', 
                               (case when ngaythanhtoan IS NULL then N'Chưa thanh toán' else N'Đã thanh toán' end) as 'Trạng Thái'
                              from(((nhanvien inner join hoadonphong
		                                on NHANVIEN.idnhanvien = HOADONPHONG.idnhanvien)
		                                    inner join KHACHHANG on HOADONPHONG.idkhachhang = KHACHHANG.idkhachhang)
                                                inner join CT_HOADONPHONG on CT_HOADONPHONG.idhoadon = HOADONPHONG.idhoadon)
		                                            inner join PHONG on ct_HoaDonPhong.idphong = phong.idphong
                              where khachhang.idkhachhang = '" + id + "'Group by HOADONPHONG.idhoadon,hotenkh,hotennv,ngaytao,ngaythanhtoan,hoadonphong.ghichu";
            DataSet ds = cn.getData(query);
            dtgBill1.DataSource = ds.Tables[0];
        }
        //Hàm fill data hóa đơn dịch vụ vào bảng hóa đơn
        public void FillDataListServiceBill(String id)
        {
            query = @"Select  HOADONDICHVU.idhoadon as 'ID Hóa Đơn',hotenkh as 'Tên Khách Hàng', hotennv as 'Tên Nhân Viên',  FORMAT (ngaytao, 'dd/MM/yyyy h:mm tt') as 'Ngày Tạo', FORMAT (ngaythanhtoan, 'dd/MM/yyyy h:mm tt') as 'Ngày Thanh Toán',
                              COUNT(CT_HOADONDICHVU.iddichvu) as 'Số Lượng DV',
                              SUM(giadichvu * (1-mucgiamgia)* CT_HOADONDICHVU.soluong) as 'Tổng Tiền', (case when ngaythanhtoan IS NULL then N'Chưa thanh toán' else N'Đã thanh toán' end) as 'Trạng Thái'
                              from(((NHANVIEN inner join HOADONDICHVU
		                                on NHANVIEN.idnhanvien = HOADONDICHVU.idnhanvien)
		                                    inner join KHACHHANG on HOADONDICHVU.idkhachhang = KHACHHANG.idkhachhang)
                                                inner join CT_HOADONDICHVU on CT_HOADONDICHVU.idhoadon = HOADONDICHVU.idhoadon)
		                                            inner join DICHVU on CT_HOADONDICHVU.iddichvu = DICHVU.iddichvu
                              where khachhang.idkhachhang = '" + id + "'Group by HOADONDICHVU.idhoadon,hotenkh,hotennv,ngaytao,ngaythanhtoan,hoadondichvu.ghichu";
            DataSet ds = cn.getData(query);
            dtgBill1.DataSource = ds.Tables[0];
        }
        //Hàm fill data hóa đơn thực phẩm vào bảng hóa đơn
        public void FillDataListFoodBill(String id)
        {
            query = @"Select  HOADONTHUCPHAM.idhoadon as 'ID Hóa Đơn',hotenkh as 'Tên Khách Hàng', hotennv as 'Tên Nhân Viên',  FORMAT (ngaytao, 'dd/MM/yyyy h:mm tt') as 'Ngày Tạo', FORMAT (ngaythanhtoan, 'dd/MM/yyyy h:mm tt') as 'Ngày Thanh Toán',
                              COUNT(CT_HOADONTHUCPHAM.idthucpham) as 'Số Lượng TP',
                              SUM(giaban * CT_HOADONTHUCPHAM.soluong) as 'Tổng Tiền', (case when ngaythanhtoan IS NULL then N'Chưa thanh toán' else N'Đã thanh toán' end) as 'Trạng Thái'
                              from(((NHANVIEN inner join HOADONTHUCPHAM
		                                on NHANVIEN.idnhanvien = HOADONTHUCPHAM.idnhanvien)
		                                    inner join KHACHHANG on HOADONTHUCPHAM.idkhachhang = KHACHHANG.idkhachhang)
                                                inner join CT_HOADONTHUCPHAM on CT_HOADONTHUCPHAM.idhoadon = HOADONTHUCPHAM.idhoadon)
		                                            inner join THUCPHAM on CT_HOADONTHUCPHAM.idthucpham = THUCPHAM.idthucpham
                              where khachhang.idkhachhang = '" + id + "'Group by HOADONTHUCPHAM.idhoadon,hotenkh,hotennv,ngaytao,ngaythanhtoan,hoadonthucpham.ghichu";
            DataSet ds = cn.getData(query);
            dtgBill1.DataSource = ds.Tables[0];
        }

        //===============================================END - Các hàm đổ dữ liệu vào bảng hóa đơn trong tra cứu nhân vien===============================================

        //===============================================Các hàm đổ dữ liệu vào bảng chi tiết hóa đơn=====================================================

        public void FillDataRoomBillDetail(String id)
        {
            query = @"Select idhoadon as 'ID Hóa Đơn', tenphong as 'Tên Phòng', dongia as 'Đơn Giá', mucgiamgia as 'Giảm Giá' from CT_HOADONPHONG,PHONG where CT_HOADONPHONG.idphong = PHONG.idphong and idhoadon = '" + id + "'";
            DataSet ds = cn.getData(query);
            dtgDetail1.DataSource = ds.Tables[0];
        }
        public void FillDataServiceBillDetail(String id)
        {
            query = @"Select idhoadon as 'ID Hóa Đơn', tendichvu as 'Tên DV', Format(thoigianyeucau,'dd/MM/yyyy hh:mm tt') as 'Thời Gian Yêu Cầu', giadichvu as 'Giá', CT_HOADONDICHVU.soluong as 'SL', mucgiamgia as 'Giảm Giá' from CT_HOADONDICHVU,DICHVU where CT_HOADONDICHVU.iddichvu = DICHVU.iddichvu and idhoadon = '" + id + "'";
            DataSet ds = cn.getData(query);
            dtgDetail1.DataSource = ds.Tables[0];
        }
        public void FillDataFoodBillDetail(String id)
        {
            query = @"Select idhoadon as 'ID Hóa Đơn', tenthucpham as 'Tên TP', Format(thoigianyeucau,'dd/MM/yyyy hh:mm tt') as 'Thời Gian Yêu Cầu', giaban as 'Giá', CT_HOADONTHUCPHAM.soluong as 'SL' from CT_HOADONTHUCPHAM,THUCPHAM where CT_HOADONTHUCPHAM.idthucpham = THUCPHAM.idthucpham and idhoadon = '" + id + "'";
            DataSet ds = cn.getData(query);
            dtgDetail1.DataSource = ds.Tables[0];
        }
        //===============================================END - Các hàm đổ dữ liệu vào bảng chi tiết hóa đơn===============================================

        private void dtgCus1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            setTableCus(175, true);
            setTableBill(310, false);
            try
            {
                String id = dtgCus1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtgDetail1.DataSource = null;
                lbHD1.Visible = false;
                if (txtNameBill.SelectedIndex == 0)
                {
                    FillDataListRoomBill(id);
                }
                else if (txtNameBill.SelectedIndex == 1)
                {
                    FillDataListServiceBill(id);
                }
                else
                {
                    FillDataListFoodBill(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng click vào hàng chứa thông tin nhân viên cần tra cứu!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNameBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            setTableCus(175, true);
            setTableBill(310, false);
            try
            {
                if (dtgCus1.SelectedCells.Count != 0)
                {
                    String id = dtgCus1.SelectedCells[1].Value.ToString();
                    dtgDetail1.DataSource = null;
                    if (txtNameBill.SelectedIndex == 0)
                    {
                        FillDataListRoomBill(id);
                    }
                    else if (txtNameBill.SelectedIndex == 1)
                    {
                        FillDataListServiceBill(id);
                    }
                    else
                    {
                        FillDataListFoodBill(id);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng lựa chọn khách hàng cần tra cứu thông tin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn hàng chứa thống tin nhân viên cần tra cứu!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgBill1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setTableCus(175, true);
            setTableBill(125, true);
            try
            {
                String idhoadon = dtgBill1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (txtNameBill.SelectedIndex == 0)
                {
                    FillDataRoomBillDetail(idhoadon);
                }
                else if (txtNameBill.SelectedIndex == 1)
                {
                    FillDataServiceBillDetail(idhoadon);
                }
                else
                {
                    FillDataFoodBillDetail(idhoadon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng click vào hàng chứa thông tin nhân viên cần tra cứu!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void setTableCus(int height, Boolean b)
        {
            dtgCus1.Height = height;
            lbName1.Visible = b;
            dtgBill1.Visible = b;
        }
        public void setTableBill(int height, Boolean b)
        {
            dtgBill1.Height = height;
            lbName2.Visible = b;
            dtgDetail1.Visible = b;
        }
    }
}
