using Dapper;
using DevExpress.XtraEditors;
using DXApplication1.Subject.Customer;
using MaterialSkin;
using MaterialSkin.Controls;
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

namespace DXApplication1.FolderMajor
{
    public partial class frmCustomer : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        fsEdit Edit = new fsEdit();

        public MaterialListView mLV;

        public string casechange;

        public static frmCustomer instance;

        public frmCustomer()
        {
            InitializeComponent();

            instance = this;

            //Design MarterialListview
            skinManager = MaterialSkinManager.Instance;

            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo900, Primary.Indigo700, Accent.Indigo700, TextShade.WHITE);


            materialListView1.Columns[0].Width = 290;
            materialListView1.Columns[1].Width = 290;
            materialListView1.Columns[2].Width = 260;
            materialListView1.Columns[3].Width = 270;

            mLV = materialListView1;

            OpenSql();

        }

        public virtual void OpenSql()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<KhachhangDTO>("SELECT * FROM KHACHHANG", commandType: CommandType.Text);
                materialListView1.Items.Clear();
                foreach (KhachhangDTO p in data)
                {

                    ListViewItem item = new ListViewItem(p.MAKH);
                    item.SubItems.Add(p.TENKH);
                    item.SubItems.Add(p.SDT_KHACHHANG);
                    item.SubItems.Add(p.DIACHI);

                    materialListView1.Items.Add(item);

                }
                db.Close();
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeChartRangeControlClient1_CustomizeSeries(object sender, ClientDataSourceProviderCustomizeSeriesEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbE_Select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ibtRefesh_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ibtEdit_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ibtDelete_Click(object sender, EventArgs e)
        {

        }

        private void mRB_Save_Click(object sender, EventArgs e)
        {

        }

        private void mRB_New_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}