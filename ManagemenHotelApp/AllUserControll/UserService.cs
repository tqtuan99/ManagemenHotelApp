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
                if (ds != null)
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
            if (ds != null)
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

        public void setVisible(Boolean b)
        {
            Clear();
            pnUpdate.Enabled = b;
            lbNewID.Text = "___";
            lbNoti1.Visible = !b;
        }
        //==========================================================================================================//

        private void UserService_Load(object sender, EventArgs e)
        {
            FillData(dtgService, "");
            getMaxID(lbIDService);

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgNewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
