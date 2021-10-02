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
    public partial class UserService : UserControl
    {
        ConnectBase cn = new ConnectBase();
        String query;
        public UserService()
        {
            InitializeComponent();
        }

        //======================================================================================================//
        //hàm load dữ liệu từ db ra bảng dữ liệu dtg và điều kiên s
        public void FillData(DataGridView dtg, String s)
        {
            try
            {
                query = @"Select * from DICHVU " + s;
                DataSet ds = cn.getData(query);
                if(ds != null)
                    dtg.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        //Lấy max id dịch vụ hiện tại để load ra label id
        public void getMaxID(Label txt)
        {
            query = @"select max(iddichvu) from DICHVU";
            DataSet ds = cn.getData(query);
            if(ds != null)
            {
                int maxid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                txt.Text = (maxid + 1).ToString();
            }
            else
            {
                txt.Text = "001";
            }
        }

        //làm trống các textbox để nhập dữ liệu mới
        public void Clear()
        {
            txtNameService.ResetText();
            txtPriceService.ResetText();
            txtQuantity.ResetText();
            txtDescription.ResetText();
            txtDiscount.ResetText();
            txtNote.ResetText();
        }
        //==========================================================================================================//
 
        private void UserService_Load(object sender, EventArgs e)
        {
            FillData(dtgService, "");
            getMaxID(lbIDService);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "") txtDiscount.Text = "0";
            if (txtNameService.Text != "" && txtPriceService.Text != "" && txtQuantity.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm phòng mới không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    String NameService = txtNameService.Text;
                    float PriceService = float.Parse(txtPriceService.Text);
                    int Quantity = int.Parse(txtQuantity.Text);
                    float Discount = float.Parse(txtDiscount.Text);
                    String Description = txtDescription.Text;
                    String Note = txtNote.Text;
                    try
                    {
                        //id dịch vụ tự tăng nên khi thêm mới không cần thêm id
                        query = @"insert into DICHVU (tendichvu,giadichvu,soluong,trangthai,mota,mucgiamgia,ghichu)  
                                    values (N'" + NameService + "',N'" + PriceService + "',N'" + Quantity + "','1',N'" + Description + "',N'" + Discount + "',N'" + Note + "')";
                        cn.setData(query, "Thêm dịch vụ thành công.");
                        Clear();
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Thông tin vừa nhập không hợp lệ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

            }
            }
            else
            {
                MessageBox.Show("Vui lòng điển đầy đủ thông tin: ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillData(dtgService, "");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                UserService_Load(this, null);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                txtNameSearch.ResetText();
                FillData(dtgNewService, "");
            }
        }
    }
}
