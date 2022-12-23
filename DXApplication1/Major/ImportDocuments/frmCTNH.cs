using Dapper;
using DevExpress.XtraEditors;
using DXApplication1.FolderMajor;
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

namespace DXApplication1.Subject.ImportDocuments
{
    public partial class frmCTNH : MaterialSkin.Controls.MaterialForm
    {


        MaterialSkinManager skinManager;
        fsEdit Edit = new fsEdit();

        public MaterialListView mLV;

        public string casechange;

        public static frmCTNH instance;

        public frmCTNH()
        {
            InitializeComponent();

            instance = this;

            //Design MarterialListview
            skinManager = MaterialSkinManager.Instance;

            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue900, Accent.Blue200, TextShade.BLACK);


            materialListView1.Columns[0].Width = 153;
            materialListView1.Columns[1].Width = 303;
            materialListView1.Columns[2].Width = 103;
            materialListView1.Columns[3].Width = 153;
            materialListView1.Columns[4].Width = 153;
            materialListView1.Columns[5].Width = 103;
            materialListView1.Columns[6].Width = 103;
            materialListView1.Columns[7].Width = 153;
            materialListView1.Columns[8].Width = 153;
            materialListView1.Columns[9].Width = 103;
            materialListView1.Columns[10].Width = 153;


            OpenSql();

        }

        public virtual void OpenSql()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<ImportDocumentsDTO>("SELECT * FROM MANAGER_KHO", commandType: CommandType.Text);
                materialListView1.Items.Clear();
                foreach (ImportDocumentsDTO p in data)
                {

                    ListViewItem item = new ListViewItem(p.SOHD_MANAGER_NHAPHANG_KHO);
                    item.SubItems.Add(p.TENHD_MANAGER_NHAPHANG_KHO);
                    item.SubItems.Add(p.MAQL);
                    item.SubItems.Add(p.TENQL);
                    item.SubItems.Add(p.SDT_MANAGER);
                    item.SubItems.Add(p.MAQL);
                    item.SubItems.Add(p.TENQL);
                    item.SubItems.Add(p.SDT_MANAGER);
                    item.SubItems.Add(p.MAKHO);
                    item.SubItems.Add(p.TENKHO);
                    item.SubItems.Add(p.SL.ToString());
                    item.SubItems.Add(p.SL_CACLOAI.ToString());
                    item.SubItems.Add(p.TONGIA.ToString());
                    item.SubItems.Add(p.NGAYNHAP.ToString());


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