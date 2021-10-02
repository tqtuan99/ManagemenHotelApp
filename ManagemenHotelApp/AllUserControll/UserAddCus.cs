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
    public partial class UserAddCus : UserControl
    {
        ConnectBase cn = new ConnectBase();
        String query;
        public UserAddCus()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserAddCus_Load(object sender, EventArgs e)
        {
            try
            {
                query = "Select * from Khachhang";
                DataSet ds = cn.getData(query);
                tbCustumer.DataSource = ds.Tables[0];
            }catch(Exception ex)
            {
                MessageBox.Show("Không kết nối được với database", "Waning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            getMaxId();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
                if (txtName.Text != "" && txtCCNum.Text != "" && txtPhoneNum.Text != "" && txtDofB.Text != "" && txtNationnaly.Text != "" && txtSex.Text != "")
                {
                    DateTime DofB = txtDofB.Value;
                    String name = txtName.Text;
                    String ccNum = txtCCNum.Text;
                    String phone = txtPhoneNum.Text;
                    String nati = txtNationnaly.Text;
                    String sex = txtSex.Text;
                    String note = txtNote.Text;
                    MessageBox.Show(name);

                    try{
                            query = "insert into KhachHang (hotenkh,gioitinh,ngaysinh,socccd,sodienthoai,quoctich,ghichu) values (N'" + name + "',N'" + sex + "',N'" + DofB + "',N'" + ccNum + "',N'" + phone + "',N'" + nati + "',N'" + note + "')";           
                            cn.setData(query, "Đã thêm khách hàng");
                    }catch(Exception ex){
                        MessageBox.Show("Thông tin vừa nhập không hợp lệ hoặc thông tin đã trùng lắp", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }

                    UserAddCus_Load(this, null);
                    clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng điển đầy đủ thông tin: ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }   
        }
        public void getMaxId()
        {
            query = "Select max(idkhachhang) from khachhang" ;
            DataSet ds = cn.getData(query);
            if(ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                lbId.Text = (num + 1).ToString();
            }
        }
        public void clear()
        {
            txtCCNum.Clear();
            txtName.Clear();
            txtNationnaly.SelectedIndex = -1;
            txtSex.SelectedIndex = -1;
            txtPhoneNum.Clear();
            txtDofB.Value = DateTime.Now;
        }

        private void UserAddCus_Enter(object sender, EventArgs e)
        {
            UserAddCus_Load(this, null);
        }

        private void UserAddCus_Leave(object sender, EventArgs e)
        {
            clear();
        }
    }
}
