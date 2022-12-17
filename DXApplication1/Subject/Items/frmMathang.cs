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

namespace DXApplication1.Subject.Items
{
    public partial class frmMathang : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        fsEdit Edit = new fsEdit();

        public MaterialListView mLV;

        public string casechange;

        public static frmMathang instance;

        public frmMathang()
        {
            InitializeComponent();

            instance = this;

            //Design MarterialListview
            skinManager = MaterialSkinManager.Instance;

            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue900, Accent.Blue200, TextShade.BLACK);


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

                var data = db.Query<MathangDTO>("SELECT * FROM MATHANG", commandType: CommandType.Text);
                materialListView1.Items.Clear();
                foreach (MathangDTO p in data)
                {

                    ListViewItem item = new ListViewItem(p.MAMATHANG);
                    item.SubItems.Add(p.TENMATHANG);
                    item.SubItems.Add(p.LOAI);
                    item.SubItems.Add(p.SL.ToString());
                    item.SubItems.Add(p.GIA.ToString());

                    materialListView1.Items.Add(item);

                }
                db.Close();
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}