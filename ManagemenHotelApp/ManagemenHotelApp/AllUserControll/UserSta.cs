using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ManagemenHotelApp.AllUserControll
{
    public partial class UserSta : UserControl
    {
        String query;
        ConnectBase cn = new ConnectBase();
        public UserSta()
        {
            InitializeComponent();
        }

        private void UserSta_Load(object sender, EventArgs e)
        {
            //FillMonthInYear("2021");
            setChart(dataGridView1);
            //FillMonthInYear("2021");
            //chart1.Series[0].ChartType = SeriesChartType.Pie;

        }

        public void setChart(DataGridView dtg)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.Series["Salary"].IsValueShownAsLabel = true;
            chart1.DataSource = dataGridView1.DataSource;
            chart1.Series["Salary"].XValueMember = dataGridView1.Columns[0].Name;
            chart1.Series["Salary"].YValueMembers = dataGridView1.Columns[1].Name;
        }

        public void FillMonthInYear( string year)
        {
            try
            {
                query = @"select Month(ngaytao) as paraname,SUM(dongia * (1-mucgiamgia) * (case when (5<DATEPART(hour, ngaytao) and 9>=DATEPART(hour, ngaytao) and ngaythanhtoan IS NOT NULL) then 0.5
			                                                     when (9<DATEPART(hour, ngaytao) and 14>= DATEPART(hour, ngaytao) and ngaythanhtoan IS NOT NULL) then 0.3
			                                                     else 0 end 
	                                                      + case when (12<DATEPART(hour, ngaythanhtoan) and 15>=DATEPART(hour, ngaytao) ) then 0.3
			                                                     when (15<DATEPART(hour, ngaythanhtoan) and 18>= DATEPART(hour, ngaytao)) then 0.5
			                                                     when (18<DATEPART(hour, ngaythanhtoan)) then 1
			                                                     else 0 end 
	                                                      + case when ngaythanhtoan IS NOT NULL then DATEDIFF(DAY,ngaytao,ngaythanhtoan)
		                                                    else 0 end)) as value
                    from (HOADONPHONG inner join CT_HOADONPHONG
		                    on HOADONPHONG.idhoadon = CT_HOADONPHONG.idhoadon)
			                    inner join phong on CT_HOADONPHONG.idphong = PHONG.idphong
                    where YEAR(ngaytao) = " + year + " and ngaythanhtoan IS NOT NULL group by Month(ngaytao) ";
                DataSet ds = cn.getData(query);  
                 dataGridView1.DataSource = ds.Tables[0];
                chart1.DataSource = ds.Tables[0];
                chart1.Series["Salary"].XValueMember = "Tháng";
                chart1.Series["Salary"].YValueMembers = "Tổng Tiền";
            }
            catch(Exception e)
            {
                MessageBox.Show(e + "");
            }
        }

        public void FillDayInMonthAndYear(String month, String year)
        {
            try
            {
                query = @"select Day(ngaytao) as 'Ngày',SUM(dongia * (1-mucgiamgia) * (case when (5<DATEPART(hour, ngaytao) and 9>=DATEPART(hour, ngaytao) and ngaythanhtoan IS NOT NULL) then 0.5
			                                                     when (9<DATEPART(hour, ngaytao) and 14>= DATEPART(hour, ngaytao) and ngaythanhtoan IS NOT NULL) then 0.3
			                                                     else 0 end 
	                                                      + case when (12<DATEPART(hour, ngaythanhtoan) and 15>=DATEPART(hour, ngaytao) ) then 0.3
			                                                     when (15<DATEPART(hour, ngaythanhtoan) and 18>= DATEPART(hour, ngaytao)) then 0.5
			                                                     when (18<DATEPART(hour, ngaythanhtoan)) then 1
			                                                     else 0 end 
	                                                      + case when ngaythanhtoan IS NOT NULL then DATEDIFF(DAY,ngaytao,ngaythanhtoan)
		                                                    else 0 end)) as 'Tổng Tiền'
                        from (HOADONPHONG inner join CT_HOADONPHONG
		                        on HOADONPHONG.idhoadon = CT_HOADONPHONG.idhoadon)
			                        inner join phong on CT_HOADONPHONG.idphong = PHONG.idphong
                        where Month(ngaytao) = "+month+" and YEAR(ngaytao) ="+year+"group by day(ngaytao)";
                DataSet ds = cn.getData(query);
                 dataGridView1.DataSource = ds.Tables[0];
                chart1.DataSource = ds.Tables[0];
                chart1.Series["Salary"].XValueMember = "Ngày";
                chart1.Series["Salary"].YValueMembers = "Tổng Tiền";
            }
            catch
            {
                return;
            }
        }

        public void FillQuarterInYear(String year)
        {
            try
            {
                query = @"select DATEPART(quarter, ngaytao) as 'Tháng',SUM(dongia * (1-mucgiamgia) * (case when (5<DATEPART(hour, ngaytao) and 9>=DATEPART(hour, ngaytao) and ngaythanhtoan IS NOT NULL) then 0.5
			                                                     when (9<DATEPART(hour, ngaytao) and 14>= DATEPART(hour, ngaytao) and ngaythanhtoan IS NOT NULL) then 0.3
			                                                     else 0 end 
	                                                      + case when (12<DATEPART(hour, ngaythanhtoan) and 15>=DATEPART(hour, ngaytao) ) then 0.3
			                                                     when (15<DATEPART(hour, ngaythanhtoan) and 18>= DATEPART(hour, ngaytao)) then 0.5
			                                                     when (18<DATEPART(hour, ngaythanhtoan)) then 1
			                                                     else 0 end 
	                                                      + case when ngaythanhtoan IS NOT NULL then DATEDIFF(DAY,ngaytao,ngaythanhtoan)
		                                                    else 0 end)) as 'Tổng Tiền'
                    from (HOADONPHONG inner join CT_HOADONPHONG
		                    on HOADONPHONG.idhoadon = CT_HOADONPHONG.idhoadon)
			                    inner join phong on CT_HOADONPHONG.idphong = PHONG.idphong
                    where YEAR(ngaytao) = " + year + " group by DATEPART(quarter, ngaytao)";
                DataSet ds = cn.getData(query);
                 dataGridView1.DataSource = ds.Tables[0];
                chart1.DataSource = ds.Tables[0];
                chart1.Series["Salary"].XValueMember = "Quý";
                chart1.Series["Salary"].YValueMembers = "Tổng Tiền";
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
            }
        }

        private void checkMonthInYear_Click(object sender, EventArgs e)
        {
            FillMonthInYear(txtYear.Text);
            setChart(dataGridView1);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            FillDayInMonthAndYear(txtMonth.Text, txtYear.Text);
            setChart(dataGridView1);
        }

    }
}
