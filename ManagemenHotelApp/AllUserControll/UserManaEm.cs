using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ManagemenHotelApp.AllUserControll
{
    public partial class UserManaEm : UserControl
    {
        ConnectBase cn = new ConnectBase();
        String query;
        public UserManaEm()
        {
            InitializeComponent();
        }

        private void UserManaEm_Load(object sender, EventArgs e)
        {
            //Khi load form thêm nhân sự thì lấy ra danh sách chức vụ và idmax +1 trong bảng nhanvien để tiến hành thêm mới
            getMaxIdEm();
            getDuty(txtDuty);
            clear();
        }

        //===================================================Di chuyển giữa các tab thêm mới, tra cứu, chỉnh sửa, xóa==============================================
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                UserManaEm_Load(this, null);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                txtNameSearch.Clear();
                FillData(dtgEmDetail, "");
                dtgListBill.DataSource = null;
                dtgDetailBill.DataSource = null;
                lbNoti1.Visible = true;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                getDuty(txtNewDuty);
                clearDataUp();
                setVisibleDataUp(false);
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                txtIDDel.Clear();
            }
        }

        //======================================================Thêm nhân viên====================================================================

        //Button thêm nhân viên
        private void btnAddEm_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thêm thông tin nhân viên không?","Xác nhận",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (txtName.Text != "" && txtDuty.Text != "" && txtSex.Text != "" && txtPhoneNum.Text != "" && txtAddress.Text != "" && txtCCCD.Text != "" && txtDofB.Text != "" && txtStartDay.Text != "")
                {
                    DateTime DofB = txtDofB.Value;
                    DateTime SDay = txtStartDay.Value;
                    String name = txtName.Text;
                    String cccd = txtCCCD.Text;
                    String phone = txtPhoneNum.Text;
                    int duty = txtDuty.SelectedIndex + 1;
                    String sex = txtSex.Text;
                    String address = txtAddress.Text;
                    String note = txtNote.Text;
                    float hsl = float.Parse(txtHSL.Text);
                    String email = txtEmail.Text;

                    try
                    {
                        //id nhân viên trong bảng sql set tự động tăng nên không cần thêm idnhanvien
                        query = @"insert into NHANVIEN (idchucvu,hotennv,gioitinh,socccd, sodienthoai, ngaysinh, ngayvaolam, diachi, email, hesoluong, trangthai, ghichu) 
                            values (N'" + duty + "',N'" + name + "',N'" + sex + "',N'" + cccd + "',N'" + phone + "',N'" + DofB + "',N'" + SDay + "',N'" + address + "',N'" + email + "', N'" + hsl + "','1',N'" + note + "')";
                        cn.setData(query, "Đã thêm thông tin nhân viên.");
                        clear();
                    }
                    
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thông tin vừa nhập không hợp lệ hoặc thông tin đã trùng lắp", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    UserManaEm_Load(this, null); //reset lại from
                }
                else
                {
                    MessageBox.Show("Vui lòng điển đầy đủ thông tin: ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        //Hàm lấy ra idmax +1
        public void getMaxIdEm()
        {
            query = "Select max(idnhanvien) from nhanvien";
            DataSet ds = cn.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                lbId.Text = (num + 1).ToString();
            }
        } 
        //Clear from 
        public void clear()
        {
            txtDuty.SelectedIndex = -1;
            txtName.Clear();
            txtPhoneNum.Clear();
            txtSex.SelectedIndex = -1;
            txtHSL.Text = "1";
            txtEmail.Clear();
            txtCCCD.Clear();
            txtNote.Clear();
            txtAddress.Clear();
            txtDofB.Value = DateTime.Now;
            txtStartDay.Value = DateTime.Now;
        }

        //======================================================Tra cứu thông tin====================================================================
        //Fill data vào bảng nhân viên khi nhập tên nhân viên vào ô search
        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            query = "and hotennv like N'" + txtNameSearch.Text + "%'";
            FillData(dtgEmDetail, query);
        }

        //Filldata vào bảng danh sách hóa đơn khi click vào nhân viên trong bảng danh sách nhân viên
        private void dtgEmDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (txtNameBill.SelectedIndex == 0)
                {
                    String id = dtgEmDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
                    lbIDEm.Text = id;
                    query = @"Select  HOADONPHONG.idhoadon as 'ID Hóa Đơn', hotennv as 'Tên Nhân Viên', hotenkh as 'Tên Khách Hàng', ngaytao as 'Ngày Tạo', ngaythanhtoan as 'Ngày Thanh Toán',
                              COUNT(CT_HOADONPHONG.idhoadon) as 'Số Lượng Phòng',SUM(dongia * (1-mucgiamgia)) as 'Tổng Tiền', hoadonphong.ghichu as 'Ghi Chú', (case ngaythanhtoan when null then N'Chưa thanh toán' else N'Đã thanh toán' end) as 'Trạng Thái'
                              from(((nhanvien inner join hoadonphong
		                                on NHANVIEN.idnhanvien = HOADONPHONG.idnhanvien)
		                                    inner join KHACHHANG on KHACHHANG.idkhachhang = HOADONPHONG.idkhachhang)
		                                        inner join CT_HOADONPHONG on CT_HOADONPHONG.idhoadon = HOADONPHONG.idhoadon)
		                                            inner join PHONG on ct_HoaDonPhong.idphong = phong.idphong
                                        where nhanvien.idnhanvien = '" + id + "'Group by HOADONPHONG.idhoadon,hotenkh,hotennv,ngaytao,ngaythanhtoan,hoadonphong.ghichu";
                    DataSet ds = cn.getData(query);
                    dtgListBill.DataSource = ds.Tables[0];
                    dtgDetailBill.DataSource = null;
                    lbNoti1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Vui lòng click vào hàng chứa thông tin nhân viên cần tra cứu!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Filldata vào bảng chi tiết hóa đơn sau khi click vào id hóa đơn cần xem trong bảng hóa đơn
        private void dtgListBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String idhoadon = dtgListBill.Rows[e.RowIndex].Cells[0].Value.ToString();
                query = @"Select idhoadon as 'ID Hóa Đơn', tenphong as 'Tên Phòng', dongia as 'Đơn Giá', mucgiamgia as 'Mức Giảm Giá' from CT_HOADONPHONG,PHONG where CT_HOADONPHONG.idphong = PHONG.idphong and idhoadon = '" + idhoadon + "'";
                DataSet ds = cn.getData(query);
                dtgDetailBill.DataSource = ds.Tables[0];
                lbNoti2.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        //======================================================CẬP NHẬT THÔNG TIN====================================================================
        //Fill data vào bảng danh sách nhân viên khi nhập id vào ô search
        private void txtIdUpdate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = @"Select idnhanvien, hotennv, socccd, chucvu.tenchucvu
                    from nhanvien,chucvu where nhanvien.idchucvu=chucvu.idchucvu and convert(nvarchar(10),idnhanvien) like N'" + txtIdUpdate.Text+"%'";
                DataSet ds = cn.getData(query);
                dtgUpdate.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }
        //Fill data vào các ô nhập liệu trên form để chỉnh sửa thông tin
        private void dtgUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(dtgUpdate.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{ 
            setVisibleDataUp(true);
            try
            {
                String id = dtgUpdate.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbIDUpdate.Text = id;
                    
                query = @"Select idnhanvien, hotennv, socccd, sodienthoai, ngaysinh, ngayvaolam, ngaynghiviec ,diachi, email, chucvu.idchucvu, hesoluong, nhanvien.ghichu
                from nhanvien,chucvu where nhanvien.idchucvu=chucvu.idchucvu and idnhanvien = '"+ id +"' ";
                DataSet ds = cn.getData(query);
                txtNewName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtNewCCCD.Text = ds.Tables[0].Rows[0][2].ToString();
                txtNewPhone.Text = ds.Tables[0].Rows[0][3].ToString();
                txtNewDuty.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0][9].ToString()) - 1;
                txtNewDofB.Value = DateTime.ParseExact(getDay(ds.Tables[0].Rows[0][4].ToString()), "dd/M/yyyy", CultureInfo.InvariantCulture);
                txtNewStaDay.Value = DateTime.ParseExact(getDay(ds.Tables[0].Rows[0][5].ToString()), "dd/M/yyyy", CultureInfo.InvariantCulture);
                    
                if(ds.Tables[0].Rows[0][6].ToString() == "")
                {
                    txtEndDay.Value = new DateTime(2050,01,01);
                }
                else
                {
                    txtEndDay.Value = DateTime.ParseExact(getDay(ds.Tables[0].Rows[0][6].ToString()), "dd/M/yyyy", CultureInfo.InvariantCulture);
                }
                txtNewAddr.Text = ds.Tables[0].Rows[0][7].ToString();
                txtNewEmail.Text = ds.Tables[0].Rows[0][8].ToString();
                txtNewHSL.Text = ds.Tables[0].Rows[0][10].ToString();
                txtNewNote.Text = ds.Tables[0].Rows[0][11].ToString();
                    
            }catch(Exception ex)
            {
                MessageBox.Show("Vui lòng click đúng vào hàng chưa thông tin cần chỉnh sửa!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            //
            //else { }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn cập nhật thông tin không","Xác Nhận!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(txtNewName.Text != "" && txtNewCCCD.Text != "" && txtNewPhone.Text != ""  && txtNewHSL.Text != "" && txtNewAddr.Text != "")
                {
                    try
                    {
                        //Kiểm tra ngày trong ngày nghỉ việc, nếu ngày có thay đổi so với ban đầu thì thêm câu truy vấn chỉnh sửa ngày nghỉ và trạng thái là khóa, nếu không thì tiến hành update bình thường
                        String dayend = "";
                        if (txtEndDay.Value != new DateTime(2050, 01, 01))
                        {
                            dayend = ", ngaynghiviec = '"+txtEndDay.Value+"',trangthai = '0', ";
                        }
                        String indexDuty = (txtNewDuty.SelectedIndex + 1).ToString();
                        query = @"Update nhanvien set idchucvu = '" + indexDuty + "', hotennv = N'" + txtNewName.Text + "', diachi = N'" + txtNewAddr.Text +
                        "', sodienthoai = '" + txtNewPhone.Text + "', socccd = '" + txtNewCCCD.Text + "', email = N'" + txtNewEmail.Text + "',ngaysinh = '" + txtNewDofB.Value +
                        "', ngayvaolam = '" + txtNewStaDay.Value + "'" +dayend+ "hesoluong = '" + txtHSL.Text + "', ghichu = N'" + txtNewNote.Text + "'" +
                        "where idnhanvien = '" + lbIDUpdate.Text + "'";
                        cn.setData(query, "Cập nhật thành công!");

                        clearDataUp();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex+"");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần chỉnh sửa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
        public void clearDataUp()
        {
            lbIDUpdate.Text = "___";
            txtIdUpdate.Clear();
            txtNewDuty.SelectedIndex = -1;
            txtNewName.Clear();
            txtNewAddr.Clear();
            txtNewPhone.Clear();
            txtNameSearch.Clear();
            txtNewEmail.Clear();
            txtNewCCCD.Clear();
            txtNewHSL.Text = "1";
            txtNewNote.Clear();
            txtNewDofB.Value = DateTime.Now;
            txtNewStaDay.Value = DateTime.Now;
            txtEndDay.Value = DateTime.Now;
            lbHD.Visible = true;
            FillDataUp();
        }
        //Hàm Fill data vào bảng, để tái sử dụng
        public void FillDataUp()
        {
            try
            {
                query = @"Select idnhanvien, hotennv, socccd,chucvu.tenchucvu
                    from nhanvien,chucvu where nhanvien.idchucvu=chucvu.idchucvu ";
                DataSet ds = cn.getData(query);
                dtgUpdate.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        //======================================================XÓA,LOCK,UNLOCK====================================================================
        //Tìm kiếm nhân viên cần xóa, chỉ hiển thị những nhân viên có ngày nghỉ việc là null, còn những nhân viên có ngày nghỉ việc khác null thì đã tự động set khóa nhân viên (như trên hàm cập nhật)
        private void txtIDDel_TextChanged(object sender, EventArgs e)
        {
            query = "and convert(nvarchar(10),idnhanvien) like N'" + txtIDDel.Text + "' and ngaynghiviec IS NULL";
            FillData(dtgEmDel, query);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String id = txtIDDel.Text;
                if (dtgEmDel.Rows.Count != 1 && txtIDDel.Text != "")
                {
                    //Kiểm tra xem nhân viên có tạo hóa đơn chưa, nếu chưa tạo thì xóa được, còn nếu đã tạo thì thông báo chỉ được khóa nhân viên
                    DataSet dsRoom = cn.getData("Select * from hoadonphong where idnhanvien = '" + id + "'");
                    //DataSet dsSer = cn.getData("Select * from hoadondichvu where idnhanvien = '" + id + "'");
                    //DataSet dsFo = cn.getData("Select * from hoadonthucpham where idnhanvien = '" + id + "'");
                    if (dsRoom.Tables[0].Rows.Count == 0) //&& dsSer.Tables[0].Rows.Count == 0 && dsFo.Tables[0].Rows.Count == 0)
                    {
                        if(MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không!", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                                query = "Delete from nhanvien where idnhanvien = " + id;
                                cn.setData(query, "Xóa thành công!");
                                clearDataDel();  
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên có id là " + id + " đã thực hiện tạo hóa đơn vì vậy không thể xóa nhân viên này mà chỉ có thể khóa nhân viên. Vui lòng chọn khóa nhân viên nếu bạn muốn! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }

                }
                else
                {
                    MessageBox.Show("ID nhân viên vừa nhập không tồn tại! Vui lòng nhập đúng id nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            unLockEm(false);
        }
        private void btnUnlock_Click(object sender, EventArgs e)
        {
            unLockEm(true);
        }

        //Hàm khóa nhân viên
        public void unLockEm(Boolean b) 
        {
            if (dtgEmDel.Rows.Count != 1 && txtIDDel.Text != "")
            {
                try
                {

                    String bol = (b ==true ) ? "1" :"0";
                    String mess1 = (b == true ) ? "mở khóa" : "khóa";
                    String mess2 = (b == true) ? "có thể" : "không thể";
                    String id = txtIDDel.Text;
                    if (MessageBox.Show("Bạn có chắc muốn "+mess1+" nhân viên này không!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        query = "Update nhanvien set trangthai = '"+b+"' where idnhanvien = " + id;
                        cn.setData(query, "Nhân viên đã được "+mess1+", tài khoản của nhân viên này "+mess2+" truy cập vào hệ thống!");
                        clearDataDel();
                    }              
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên hợp lệ cần khóa, nếu mã nhân viên tồn tại thì sẽ hiện thị thông tin ở bảng dưới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 
        public void clearDataDel()
        {
            dtgEmDel.Refresh();
            txtIDDel.Clear();
        }

        //======================================================CÁC HÀM DÙNG CHUNG====================================================================

        public void FillData(DataGridView dtg, String s)
        {
            try
            {
                query = @"Select idnhanvien, hotennv, gioitinh, socccd, sodienthoai, ngaysinh, ngayvaolam, ngaynghiviec,diachi,email,chucvu.tenchucvu, (case nhanvien.trangthai when 1 then N'Hoạt động' when 0 then N'Đã khóa' end) as trangthai, chucvu.luongcoban,hesoluong,nhanvien.ghichu
                    from nhanvien,chucvu where nhanvien.idchucvu=chucvu.idchucvu " + s;
                DataSet ds = cn.getData(query);
                dtg.DataSource = ds.Tables[0];
                //idchucvu hotennv gioitinh socccd sodienthoai ngaysinh ngayvaolam diachi email hesoluong ghichu
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        public void getDuty(ComboBox cb)
        {
            try
            {
                query = "select idchucvu,tenchucvu from chucvu";

                DataSet ds = cn.getData(query);
                cb.DisplayMember = "tenchucvu";
                cb.ValueMember = "idchucvu";
                cb.DataSource = ds.Tables[0];
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Không kết nối được với cơ sở dữ liệu");
            }
        }
        //Hàm set Visible các ô nhập liệu trong form update
        public void setVisibleDataUp(Boolean b)
        {
            txtNewDuty.Enabled = b;
            txtNewName.Enabled = b;
            txtNewPhone.Enabled = b;
            txtNewCCCD.Enabled = b;
            txtNewAddr.Enabled = b;
            txtNewHSL.Enabled = b;
            txtNewDofB.Enabled = b;
            txtNewStaDay.Enabled = b;
            txtEndDay.Enabled = b;
            txtNewNote.Enabled = b;
            txtNewEmail.Enabled = b;
            lbHD.Visible = !b;
        }

        //Format lại ngày để hiển thị ra ô chọn ngày khi gọi ngược data từ CSDL ra form
        public String getDay(String s)
        {
            if (s == null)
            {
                return "01/1/2050";
            }
            else
            {
                String[] arr = new String[5];
                arr = s.Split(' ');
                String[] arr2 = new String[5];
                arr2 = arr[0].Split('/');
                if (arr2[1].Length == 1)
                {
                    arr2[1] = "0" + arr2[1];
                }
                return arr2[1] + "/" + arr2[0] + "/" + arr2[2];
            }
        }

        
    }
}
