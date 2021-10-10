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
    public partial class UserPayBill : UserControl
    {
        String query;
        ConnectBase cn = new ConnectBase();
        public UserPayBill()
        {
            InitializeComponent();
        }
        //Gọi form xem trước hóa đơn
        frm_PrintBill frm = new frm_PrintBill();

        private void UserPayBill_Load(object sender, EventArgs e)
        {
            try
            {
                fillData("");
                lbNote1.Visible = true;
                //txttesst.CustomFormat = "d/M/yyyy h:mm:ss tt";
                //query = @"select ngaytao from hoadonphong where idhoadon = '8'";
                //DataSet ds = cn.getData(query);
                //MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());
                //txttesst.Value = DateTime.ParseExact("6/12/2000 2:02:00 PM", "d/M/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void UserPayBill_Leave(object sender, EventArgs e)
        {
            UserPayBill_Load(this, null);
        }

        private void UserPayBill_Enter(object sender, EventArgs e)
        {
            UserPayBill_Load(this, null);
        }
        String idroom, idser, idfood;
        private void tbCustumer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbNote1.Visible = false;
            try
            {
                //Lấy danh sách những khách hàng có hóa đơn chưa thanh toán
                String idCus = tbCustumer.Rows[e.RowIndex].Cells[0].Value.ToString();//Lấy ra id khách hàng cần thanh toán khi click vào bảng
                FillDataTbInfCus(idCus);
                //Lấy ngày đến và ngày đi ở bảng thông tin khách hàng để tính thành tiền
                FillDataTbBillRoom(idCus, DateTime.ParseExact(tbInfCus.Rows[0].Cells[3].Value.ToString(), "dd/MM/yyyy h:mm tt", CultureInfo.InvariantCulture), DateTime.ParseExact(tbInfCus.Rows[0].Cells[4].Value.ToString(), "dd/MM/yyyy h:mm tt", CultureInfo.InvariantCulture));
                FillDataTbBillService(idCus);
                FillDataTbBillFood(idCus);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex +"Không kết nối!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void FillDataTbBillRoom( String idCus, DateTime checkIn, DateTime checkOut)
        {
            try
            {
           
                query = @"select ROW_NUMBER() OVER (ORDER BY ct_hoadonphong.idphong) AS stt, tenphong, dongia, mucgiamgia, "+CalSum(checkIn,checkOut)+"*(dongia-mucgiamgia*dongia) as tongtien " +
                        "from hoadonphong, ct_hoadonphong, phong where hoadonphong.idkhachhang = "+idCus+" and ngaythanhtoan IS NULL" +
                        " and hoadonphong.idhoadon = ct_hoadonphong.idhoadon and ct_hoadonphong.idphong = phong.idphong ";
                DataSet dsBillRoom = cn.getData(query);
                tbBillRoom.DataSource = dsBillRoom.Tables[0];
            }
            catch
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng vừa chọn","Cảnh Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void FillDataTbBillService(String idCus)
        {
            try
            {

                query = @"select ROW_NUMBER() OVER (ORDER BY ct_hoadondichvu.iddichvu) AS stt, tendichvu, FORMAT(thoigianyeucau,'dd/MM/yyyy hh:mm tt') as thoigianyeucau, CT_HOADONDICHVU.soluong, giadichvu, mucgiamgia, (giadichvu-mucgiamgia*giadichvu)*CT_HOADONDICHVU.soluong as tongtien
                            from hoadondichvu, ct_hoadondichvu, dichvu
                            where HOADONDICHVU.idkhachhang = "+idCus+@" and ngaythanhtoan IS NULL
		                    and HOADONDICHVU.idhoadon = CT_HOADONDICHVU.idhoadon and CT_HOADONDICHVU.iddichvu = DICHVU.iddichvu";
                DataSet dsBillService = cn.getData(query);
                tbBillSer.DataSource = dsBillService.Tables[0];
            }
            catch
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng vừa chọn", "Cảnh Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void FillDataTbBillFood(String idCus)
        {
            try
            {

                query = @"select ROW_NUMBER() OVER (ORDER BY ct_hoadonthucpham.idthucpham) AS stt, tenthucpham, FORMAT(thoigianyeucau,'dd/MM/yyyy hh:mm tt') as thoigianyeucau, CT_HOADONTHUCPHAM.soluong, giaban, CT_HOADONTHUCPHAM.soluong*giaban as tongtien
                        from hoadonthucpham, CT_HOADONTHUCPHAM, THUCPHAM
                        where HOADONTHUCPHAM.idkhachhang = "+idCus+@" and ngaythanhtoan IS NULL
		                and HOADONTHUCPHAM.idhoadon = CT_HOADONTHUCPHAM.idhoadon and CT_HOADONTHUCPHAM.idthucpham = THUCPHAM.idthucpham";
                DataSet dsBillFood = cn.getData(query);
                tbBillFood.DataSource = dsBillFood.Tables[0];
            }
            catch
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng vừa chọn", "Cảnh Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void FillDataTbInfCus(String idCus)
        {
            try
            {

                query = @"Select  hotenkh, socccd, sodienthoai, FORMAT (ngaytao, 'dd/MM/yyyy h:mm tt') as ngaytao, ngaythanhtoan = '" + DateTime.Now.ToString("dd/MM/yyyy h:mm tt") + "' from KHACHHANG,HOADONPHONG " +
                    "where khachhang.idkhachhang = hoadonphong.idkhachhang and khachhang.idkhachhang = '" + idCus + "' and ngaythanhtoan IS NULL";
                DataSet dsCus = cn.getData(query);
                tbInfCus.DataSource = dsCus.Tables[0];
                //TimeSpan spaceTime = DateTime.ParseExact(dsCus.Tables[0].Rows[0][4].ToString(), "dd/MM/yyyy h:mm tt", CultureInfo.InvariantCulture) - DateTime.ParseExact(dsCus.Tables[0].Rows[0][3].ToString(), "dd/MM/yyyy h:mm tt", CultureInfo.InvariantCulture);
                //double hour = Math.Ceiling(spaceTime.TotalHours)/24;
                //MessageBox.Show(hour + "");
                //MessageBox.Show(CalSum(DateTime.ParseExact(dsCus.Tables[0].Rows[0][3].ToString(), "dd/MM/yyyy h:mm tt", CultureInfo.InvariantCulture), DateTime.ParseExact(dsCus.Tables[0].Rows[0][4].ToString(), "dd/MM/yyyy h:mm tt", CultureInfo.InvariantCulture), 1).ToString());
                //MessageBox.Show(DateTime.ParseExact(dsCus.Tables[0].Rows[0][3].ToString(), "dd/MM/yyyy h:mm tt", CultureInfo.InvariantCulture).Hour + "");
                //MessageBox.Show(DateTime.ParseExact(dsCus.Tables[0].Rows[0][4].ToString(), "dd/MM/yyyy h:mm tt", CultureInfo.InvariantCulture).ToString("HH"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "Không lấy được dữ liệu khách hàng vừa chọn", "Cảnh Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Vui lòng kiểm tra kĩ thông tin trước khi tiến hành xuất hóa đơn, không thể quay lại bước kiểm tra sau khi click vào đây, bạn có chắc muốn xuất hóa đơn không?","Xác nhận",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
               // query = "update ngaythanhtoan from hoadonphong where idhoadon = "
                int hr = 26;
                frm_PrintBill frm = new frm_PrintBill();
                frm.tbCus.DataSource = tbInfCus.DataSource;
                frm.tbRoom.DataSource = tbBillRoom.DataSource;
                if (tbBillSer.Rows.Count > 1)
                {
                    frm.tbSer.DataSource = tbBillSer.DataSource;
                }
                else frm.tbSer.Visible = false;
                if (tbBillFood.Rows.Count > 1)
                {
                    frm.tbFood.DataSource = tbBillFood.DataSource;
                }
                else frm.tbFood.Visible = false;

                setAutoHeight(frm.tbRoom, frm.tbSer);
                //.....Filldata to tbSer
                setAutoHeight(frm.tbSer, frm.tbFood);
                //.....Filldata to tbFood
                setAutoHeight(frm.tbFood, frm.tbBot);
                frm.Show();
            } 
        }
        public void setAutoHeight(DataGridView dtgNative, DataGridView dtg)
        {
           // int hr = frm.tbRoom.ColumnHeadersHeight;
            int sumHr = 0;
            if (dtgNative.DataSource == null)
            {
                dtgNative.Height = sumHr;
                dtgNative.Visible = false;
            }
            else
            {
                foreach (DataGridViewRow row in dtgNative.Rows)
                    sumHr += row.Height;
                dtgNative.Height = sumHr;
            }
            dtg.Location = new Point(dtgNative.Location.X, dtgNative.Location.Y + dtgNative.Height + 2);
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
                query = " and hotenkh like N'" + txtNameSearch.Text + "%'";
                fillData(query);
        }
        public void fillData(String s)
        {
            try
            {
                query = @"select khachhang.idkhachhang, hotenkh, gioitinh, FORMAT (ngaysinh, 'dd/MM/yyyy') as ngaysinh, socccd, sodienthoai, quoctich, khachhang.ghichu 
                            from khachhang, hoadonphong where khachhang.idkhachhang = hoadonphong.idkhachhang and ngaythanhtoan IS NULL " + s ;
                DataSet ds = cn.getData(query);
                tbCustumer.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex+"Không thể kết nối với DB", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public double CalSum (DateTime checkIn, DateTime checkOut)
        {
            double sum = 0;
            TimeSpan ts = checkOut - checkIn;
            double day = Math.Floor(ts.TotalDays);
            if (day < 1) day = 1; 
            sum = day; 
            if(checkIn.Hour >= 5 && checkIn.Hour <=9)
            {
                sum += 0.5;
            }else if(checkIn.Hour >9 && checkIn.Hour <= 14)
            {
                sum += 0.3;
            }
            if(checkOut.Hour > 12 && checkOut.Hour <15)
            {
                sum +=  0.3;
            }
            else if(checkOut.Hour >15 && checkOut.Hour <18)
            {
                sum +=  0.5;
            }
            else if (checkOut.Hour>18)
            {
                sum += 1;
            } 
            return sum;
        }
    }
}
