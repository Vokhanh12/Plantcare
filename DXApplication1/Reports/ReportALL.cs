using Dapper;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DXApplication1.Subject.Items;
using DXApplication1.Subject.Warehouse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DXApplication1.Reports
{
    public partial class ReportALL : DevExpress.XtraEditors.XtraForm
    {
        private object materialListView1;

        Series series1 = new Series("Kho A", ViewType.Bar);
        Series series2 = new Series("Kho B", ViewType.Bar);
        Series series3 = new Series("Kho C", ViewType.Bar);

        Series series4 = new Series("Land Area by Country", ViewType.Pie);
        public ReportALL()
        {
            InitializeComponent();

           

            OpenSql();

        }
        public virtual void OpenSql()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var dataA = db.Query<KH_MH_DTO>("SELECT * FROM KHOHANG_MATHANG WHERE TENKHO ='KHA'", commandType: CommandType.Text);
                var dataB = db.Query<KH_MH_DTO>("SELECT * FROM KHOHANG_MATHANG WHERE TENKHO ='KHB'", commandType: CommandType.Text);
                var dataC = db.Query<KH_MH_DTO>("SELECT * FROM KHOHANG_MATHANG WHERE TENKHO ='KHC'", commandType: CommandType.Text);

                var data = db.Query<KhohangDTO>("SELECT * FROM KHOHANG", commandType: CommandType.Text);

                foreach (KH_MH_DTO p in dataA)
                {

                    series1.Points.Add(new SeriesPoint(""+p.TENMATHANG,p.SL));
                    
                    //terialListView1.Items.Add(item);

                }
                foreach (KH_MH_DTO p in dataB)
                {

                    series2.Points.Add(new SeriesPoint("" + p.TENMATHANG, p.SL));

                    //terialListView1.Items.Add(item);

                }

                foreach (KH_MH_DTO p in dataC)
                {

                    series3.Points.Add(new SeriesPoint("" + p.TENMATHANG, p.SL));

                    //terialListView1.Items.Add(item);

                }
                foreach (KhohangDTO p in data)
                {

                    series4.Points.Add(new SeriesPoint("" + p.TENKHO, p.TONGSL));

                    //terialListView1.Items.Add(item);

                }


                chartControl1.Series.Add(series1);
                chartControl1.Series.Add(series2);
                chartControl1.Series.Add(series3);

                chartControl2.Series.Add(series4);
                db.Close();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ReportALL_Load(object sender, EventArgs e)
        {
            

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void chartControl2_Click(object sender, EventArgs e)
        {

        }
    }
}