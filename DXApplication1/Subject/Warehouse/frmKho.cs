using Dapper;
using DevExpress.XtraEditors;
using DXApplication1.FolderMajor;
using DXApplication1.Subject.ExportDocuments;
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

namespace DXApplication1.Subject.Warehouse
{
    public partial class frmKho : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        fsEdit Edit = new fsEdit();

        public MaterialListView mLV;

        public string casechange;

        public static frmKho instance;
        public frmKho()
        {
            InitializeComponent();
            instance = this;

            //Design MarterialListview
            skinManager = MaterialSkinManager.Instance;

            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue900, Accent.Blue200, TextShade.BLACK);


            materialListView1.Columns[0].Width = 283;
            materialListView1.Columns[1].Width = 283;
            materialListView1.Columns[2].Width = 283;
            materialListView1.Columns[3].Width = 283;
        

            OpenSql();

        }

        public virtual void OpenSql()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<KhohangDTO>("SELECT * FROM KHOHANG", commandType: CommandType.Text);
                materialListView1.Items.Clear();
                foreach (KhohangDTO p in data)
                {

                    ListViewItem item = new ListViewItem(p.MAKHO);
                    item.SubItems.Add(p.TENKHO);
                    item.SubItems.Add(p.TONGSL.ToString());
                    item.SubItems.Add(p.BAONHIEULOAI.ToString());
                   


                    materialListView1.Items.Add(item);

                }
                db.Close();
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}