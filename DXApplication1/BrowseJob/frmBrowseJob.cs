using Dapper;
using DevExpress.XtraEditors;
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

namespace DXApplication1.BrowseJob
{
    public partial class frmBrowseJob : MaterialSkin.Controls.MaterialForm
    {
        public frmBrowseJob()
        {
            InitializeComponent();

            openSQL();
        }

        public void openSQL()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<BrowseJobDTO>("SELECT * FROM DATA_APPLICATION_REGISTER", commandType: CommandType.Text);
                materialListView1.Items.Clear();
                foreach (BrowseJobDTO p in data)
                {

                    ListViewItem item = new ListViewItem(p.UserName);

                    item.SubItems.Add("●●●●●●●●");//item.SubItem.Add(p.UserPassword);
                    
                    item.SubItems.Add(p.FristName);
                    item.SubItems.Add(p.LastName);
                    item.SubItems.Add(p.EmailAdress);
                    item.SubItems.Add(p.Date_of_birth.ToString());
                    item.SubItems.Add(p.NGAY_DANG_KY.ToString());
                    item.SubItems.Add(p.TAI_KHOANG);
                    item.SubItems.Add(p.TINH_TRANG);
                    materialListView1.Items.Add(item);

                }
                db.Close();
            }
        }

        private void BrowseJob_Load(object sender, EventArgs e)
        {
            materialListView1.Columns[0].Width = 170;
            materialListView1.Columns[1].Width = 170;
            materialListView1.Columns[2].Width = 130;
            materialListView1.Columns[3].Width = 110;
            materialListView1.Columns[4].Width = 150;
            materialListView1.Columns[5].Width = 180;
            materialListView1.Columns[6].Width = 180;
            materialListView1.Columns[7].Width = 120;
            materialListView1.Columns[8].Width = 120;


        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}