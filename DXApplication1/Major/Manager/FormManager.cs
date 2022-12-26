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

namespace DXApplication1.Major.Manager
{
    public partial class FormManager : MaterialSkin.Controls.MaterialForm
    {
        public FormManager()
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

                var data = db.Query<ManagerDTO>("SELECT * FROM MANAGER", commandType: CommandType.Text);
                materialListView1.Items.Clear();
                foreach (ManagerDTO p in data)
                {

                    ListViewItem item = new ListViewItem(p.MaQL);
                    item.SubItems.Add(p.TenQL);
                    item.SubItems.Add(p.SDT_MANAGER);
                    item.SubItems.Add(p.LUONG.ToString());
                    item.SubItems.Add(p.THUONG.ToString());
                    item.SubItems.Add(p.GIOITINH);
                    item.SubItems.Add(p.NGAYSINH.ToString());
                    item.SubItems.Add(p.DIACHI);
                    item.SubItems.Add(p.SOTHICH);
                    materialListView1.Items.Add(item);

                }
                db.Close();
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            materialListView1.Columns[0].Width = 140;
            materialListView1.Columns[1].Width = 165;
            materialListView1.Columns[2].Width = 110;
            materialListView1.Columns[3].Width = 90;
            materialListView1.Columns[4].Width = 100;
            materialListView1.Columns[5].Width = 130;
            materialListView1.Columns[6].Width = 130;
            materialListView1.Columns[7].Width = 120;
            materialListView1.Columns[8].Width = 150;
        }
    }
}