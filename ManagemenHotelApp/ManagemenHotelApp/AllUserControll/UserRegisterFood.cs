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
    public partial class UserRegisterFood : UserControl
    {
        ConnectBase cn = new ConnectBase();
        String query;
        public UserRegisterFood()
        {
            InitializeComponent();
        }
        //=======================================================================================//
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
        public String getMaxIdFoodBill()
        {
            query = "Select max(idhoadon) from HOADONTHUCPHAM";
            DataSet ds = cn.getData(query);
            String s = "";
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                s = (num + 1).ToString();
            }
            else
            {
                s = "1";
            }
            return s;
        }

        //lấy số lượng thực phẩm từ db
        public int GetQuantyti(string id)
        {
            DataSet ds = cn.getData("select soluong from thucpham where idthucpham =" + id + "");
            int Quantyti = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            return Quantyti;
        }

        public void Clear()
        {
            txtNameCus.ResetText();
            txtNameFood.ResetText();
            txtIDCus.ResetText();
            txtIDFood.ResetText();
            txtTypeFood.ResetText();
            txtQuantyti.ResetText();
            txtPriceFood.ResetText();
            txtNote.ResetText();
        }
        //=======================================================================================//

        private void UserRegisterFood_Enter(object sender, EventArgs e)
        {
            UserRegisterFood_Load(this, null);
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            //FillData vào bảng khách hàng
            String getCus = "Select * From KHACHHANG where  (convert(nvarchar(10),idkhachhang) like N'" + txtNameSearch.Text + "%' or convert(nvarchar(10),hotenkh) like N'" + txtNameSearch.Text + "%')";
            FillData(tbCustumer, getCus);
        }

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

        private void UserRegisterFood_Load(object sender, EventArgs e)
        {
            Clear();
            FillData(tbCustumer, "select * from KHACHHANG");
            FillData(tbFood, "select idthucpham,loaithucpham.tenloai,tenthucpham,giaban,soluong,ghichu " +
                "from THUCPHAM,LOAITHUCPHAM where thucpham.idloaithucpham = loaithucpham.idloaithucpham");
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
                    String check = @"Select idhoadon from Khachhang, hoadonthucpham where khachhang.idkhachhang = hoadonthucpham.idkhachhang
                  and hoadonthucpham.ngaythanhtoan IS NULL and khachhang.idkhachhang = '" + id + "'";
                    DataSet dsCheck = cn.getData(check);
                    //Nếu tồn tại hóa đơn chưa thanh toán thì id hóa đơn thêm phòng sẽ là id hóa đơn chưa thanh toán
                    if (dsCheck.Tables[0].Rows.Count == 1)
                    {
                        lbIdhoadon.Text = dsCheck.Tables[0].Rows[0][0].ToString();
                    }
                    else //Ngược lại thì id hóa đơn sẽ được thêm mới
                    {
                        lbIdhoadon.Text = getMaxIdFoodBill();
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

        private void btnBookFood_Click(object sender, EventArgs e)
        {
            try
            {
                String NameCus = txtNameCus.Text;
                String NameFood = txtNameFood.Text;
                String IDCus = txtIDCus.Text;
                String IDFood = txtIDFood.Text;
                int Quantyti = int.Parse(txtQuantyti.Text);
                if (NameCus == "" || NameFood == "" || IDCus == "" || IDFood == "")
                    MessageBox.Show("Vui lòng chọn khách hàng, chọn dịch vụ, nhập số lượng cần đặt!");
                else
                if (Quantyti > GetQuantyti(IDFood) || Quantyti == 0)
                {
                    MessageBox.Show("Thực phẩm <" + txtNameFood.Text + "> số lượng chỉ còn <" + GetQuantyti(IDFood) + ">!");
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn đặt thực phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int SLcon = GetQuantyti(IDFood) - Quantyti;
                        cn.setData("update THUCPHAM set soluong = " + SLcon + " where idthucpham = " + IDFood + "", "");
                        if (lbIdhoadon.Text == getMaxIdFoodBill())
                        {
                            //ngaythanhtoan mặc định là null khi tạo nên ko thêm
                            String idnv = this.Tag.ToString();
                            query = @"insert into HOADONTHUCPHAM (idnhanvien,idkhachhang,ngaytao, ghichu) 
                        values (N'" + idnv + "',N'" + txtIDCus.Text + "','" + txtDayCreat.Value + "',N'" + txtNote.Text + "')";
                            cn.setData(query, "");
                        }
                        //Sau khi xác định được hóa đơn cần thêm phòng thì tiến hành thêm phòng vào bảng chi tiết của idhoadon
                        query = @"insert into ct_hoadonthucpham (idhoadon, idthucpham,soluong) values (N'" + lbIdhoadon.Text + "', N'" + IDFood + "', N'" + Quantyti + "')";
                        cn.setData(query, "");
                        MessageBox.Show("Đặt thực phẩm thành công!");
                        UserRegisterFood_Load(sender, e);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex +"Vui lòng chọn khách hàng, chọn thực phẩm, nhập số lượng cần đặt!");
            }
        }

        private void tbFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //FillData vào ô nhập liệu trên form từ phòng vừa chọn trên bảng
            try
            {
                txtIDFood.Text = tbFood.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTypeFood.Text = tbFood.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNameFood.Text = tbFood.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPriceFood.Text = tbFood.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
