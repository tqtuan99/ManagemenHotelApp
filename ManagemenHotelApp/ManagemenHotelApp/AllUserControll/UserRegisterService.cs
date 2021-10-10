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
    public partial class UserRegisterService : UserControl
    {
        ConnectBase cn = new ConnectBase();
        String query;
        public UserRegisterService()
        {
            InitializeComponent();
        }
        //===========================================================================================//
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
                MessageBox.Show("Không kết nối được với database!" + ex, "Waning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Lấy max id bill
        public String getMaxIdServiceBill()
        {
            query = "Select max(idhoadon) from HOADONDICHVU";
            DataSet ds = cn.getData(query);
            String s = "1";
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                s = (num + 1).ToString();
            }
            return s;
        }

        //lấy số lượng thực phẩm từ db
        public int GetQuantyti(string id)
        {
            DataSet ds = cn.getData("select soluong from dichvu where iddichvu=" + id + "");
            int Quantyti = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            return Quantyti;
        }

        public void Clear()
        {
            txtNameCus.Clear();
            txtNameService.Clear();
            txtIDCus.Clear();
            txtIDService.Clear();
            txtDiscount.Clear();
            txtQuantyti.Clear();
            txtPriceService.Clear();
            txtNote.Clear();
        }
        //================================================================================================//
        private void btnplus_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(txtQuantyti.Text);
                i++;
                txtQuantyti.Text = i.ToString();
            }
            catch (Exception ex)
            {
                txtQuantyti.Text = "1";
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            //FillData vào bảng khách hàng
            String getCus = "Select * From KHACHHANG where  (convert(nvarchar(10),idkhachhang) like N'" + txtNameSearch.Text + "%' or convert(nvarchar(10),hotenkh) like N'" + txtNameSearch.Text + "%')";
            FillData(tbCustumer, getCus);
        }

        private void UserRegisterService_Load(object sender, EventArgs e)
        {
            txtDayCreat.CustomFormat = "dd/MM/yyyy hh:mm tt";
            txtDayCreat.Value = DateTime.Now;
            Clear();
            FillData(tbCustumer, "select * from KHACHHANG");
            FillData(tbService, "select iddichvu,tendichvu,giadichvu,soluong,(case trangthai when 'true' then N'Mở' else N'Đóng'end)as trangthai,mota,mucgiamgia,ghichu from DICHVU");
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
                    String check = @"Select idhoadon from Khachhang, hoadondichvu where khachhang.idkhachhang = hoadondichvu.idkhachhang
                  and hoadondichvu.ngaythanhtoan IS NULL and khachhang.idkhachhang = '" + id + "'";
                    DataSet dsCheck = cn.getData(check);
                    //Nếu tồn tại hóa đơn chưa thanh toán thì id hóa đơn thêm dịch vụ sẽ là id hóa đơn chưa thanh toán
                    if (dsCheck.Tables[0].Rows.Count == 1)
                    {
                        lbIdhoadon.Text = dsCheck.Tables[0].Rows[0][0].ToString();
<<<<<<< HEAD
                        lbDate.Text = "Thời gian yêu cầu";
=======
                        lbDate.Text = "Ngày yêu cầu";
>>>>>>> 18a6aba038ab44fe38a86fe92afb1f1533b86d40
                    }
                    else //Ngược lại thì id hóa đơn sẽ được thêm mới
                    {
                        lbIdhoadon.Text = getMaxIdServiceBill();
                        lbDate.Text = "Ngày tạo";
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

        private void tbService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //FillData vào ô nhập liệu trên form từ phòng vừa chọn trên bảng
            try
            {
                txtIDService.Text = tbService.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameService.Text = tbService.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPriceService.Text = tbService.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiscount.Text = tbService.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnBookService_Click(object sender, EventArgs e)
        {
            try
            {
                String NameCus = txtNameCus.Text;
                String NameSer = txtNameService.Text;
                String IDCus = txtIDCus.Text;
                String IDSe = txtIDService.Text;
                String Discount = txtDiscount.Text;
                int Quantyti = int.Parse(txtQuantyti.Text);
                if (NameCus == "" || NameSer == "" || IDCus == "" || IDSe == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng, chọn dịch vụ, nhập số lượng cần đặt!");

                }

                else if (Quantyti > GetQuantyti(IDSe) || Quantyti == 0)
                {
                    MessageBox.Show("Dịch vụ <" + NameSer + "> số lượng chỉ còn <" + GetQuantyti(IDSe) + ">!");
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn đặt dịch vụ này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (lbIdhoadon.Text == getMaxIdServiceBill())
                        {
                            //ngaythanhtoan mặc định là null khi tạo nên ko thêm
                            String idnv = this.Tag.ToString();
                            query = @"insert into HOADONDICHVU (idnhanvien,idkhachhang,ngaytao, ghichu) 
                            values (N'" + idnv + "',N'" + txtIDCus.Text + "','" + txtDayCreat.Value + "',N'" + txtNote.Text + "')";
                            cn.setData(query, "");
                        }
                        //Sau khi xác định được hóa đơn cần thêm dịch vụ thì tiến hành thêm dịch vụ vào bảng chi tiết của idhoadon
                        query = @"insert into CT_HOADONDICHVU (idhoadon, iddichvu, thoigianyeucau, soluong) values (N'" + lbIdhoadon.Text + "', N'" + IDSe + "',N'" + txtDayCreat.Value + "', N'" + Quantyti + "')";
                        cn.setData(query, "");
                        int SLcon = GetQuantyti(IDSe) - Quantyti;
                        cn.setData("update DICHVU set soluong = " + SLcon + " where iddichvu = " + IDSe + "", "Đã đăng kí dịch vụ thành công");
                        UserRegisterService_Load(sender, e);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn khách hàng, chọn dịch vụ, nhập số lượng cần đặt!");
            }
        }

    }
}
