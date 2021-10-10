using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagemenHotelApp
{
    class ConnectBase
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
<<<<<<< HEAD
            con.ConnectionString = @"data source = DESKTOP-OA1P7JF;database = ManaHotelDB; Integrated Security=True";
=======
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive\Destop\git-hub\CDIO4\ManagemenHotelApp\ManagemenHotelApp\ManagemenHotelApp\QLKS.mdf;Integrated Security=True";
>>>>>>> 18a6aba038ab44fe38a86fe92afb1f1533b86d40
            //data source = DESKTOP - OA1P7JF; database = ManaHotelDB; Integrated Security = True
            //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\OneDrive\Destop\git - hub\CDIO4\ManagemenHotelApp\ManagemenHotelApp\ManagemenHotelApp\QLKS.mdf; Integrated Security = True
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            if (message != "")
            {
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
