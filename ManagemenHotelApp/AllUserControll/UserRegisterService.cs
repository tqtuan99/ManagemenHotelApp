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
            FillData(tbCustumer, "select * from KHACHHANG");
            FillData(tbService, "select iddichvu,tendichvu,giadichvu,soluong,(case trangthai when 'true' then N'Mở' else N'Đóng'end)as trangthai,mota,mucgiamgia,ghichu from DICHVU");
        }
    }
}
