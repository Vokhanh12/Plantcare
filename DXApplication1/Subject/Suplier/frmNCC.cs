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

namespace DXApplication1.Subject.Suplier
{
    public partial class frmNCC : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        fsEdit Edit = new fsEdit();

        public MaterialListView mLV;

        public string casechange;

        public static frmNCC  instance;
        public frmNCC()
        {
            InitializeComponent();
            instance = this;

            //Design MarterialListview
            skinManager = MaterialSkinManager.Instance;

            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue900, Accent.Blue200, TextShade.BLACK);


            materialListView1.Columns[0].Width = 153;
            materialListView1.Columns[1].Width = 273;
            materialListView1.Columns[2].Width = 153;
            materialListView1.Columns[3].Width = 153;
            materialListView1.Columns[4].Width = 103;
            materialListView1.Columns[5].Width = 103;
            materialListView1.Columns[6].Width = 153;
            materialListView1.Columns[7].Width = 253;
            materialListView1.Columns[8].Width = 253;

            OpenSql();

        }

        public virtual void OpenSql()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<NhacungcapDTO>("SELECT * FROM NHACUNGCAP", commandType: CommandType.Text);
                materialListView1.Items.Clear();
                foreach (NhacungcapDTO p in data)
                {

                    ListViewItem item = new ListViewItem(p.MACC);
                    item.SubItems.Add(p.TENCC);
                    item.SubItems.Add(p.MAMATHANG);
                    item.SubItems.Add(p.TENMATHANG);
                    item.SubItems.Add(p.LOAI);
                    item.SubItems.Add(p.SL.ToString());
                    item.SubItems.Add(p.GIA.ToString());
                    item.SubItems.Add(p.SDT_NHACUNGCAP);
                    item.SubItems.Add(p.DIACHI);
                   


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