using Dapper;
using DevExpress.XtraEditors;
using DXApplication1.Subject.Items;
using MaterialSkin;
using System;
using System.Collections;
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

namespace DXApplication1.Transaction
{
 
    public partial class formBanHang : MaterialSkin.Controls.MaterialForm
    {

        MaterialSkinManager skinManager;

       

        ArrayList ArraySP = new ArrayList();
        string[] arrName;

        public formBanHang()
        {
            InitializeComponent();


            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo900, Primary.Indigo700, Accent.Indigo700, TextShade.WHITE);

            //Set flowLayoutPanel1

        }

        
        private void formBanHang_Load(object sender, EventArgs e)
        {
            OpenSqlGetItems();

           foreach(string item in arrName)
            {
                flowLayoutPanel1.Controls.Add(new KhungBH(item));
            }
        }


        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        //

        //Contructor used to got the infomation of items in ArraySP
        public void OpenSqlGetItems()
        {
            int i = 0;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<MathangDTO>("SELECT * FROM MATHANG", commandType: CommandType.Text);
                foreach (MathangDTO p in data)
                {
                    ArraySP.Add(new ThongTinSanPham(p.MAMATHANG, p.TENMATHANG, p.LOAI, p.SL, p.GIA));

                }

                arrName = new string[ArraySP.Count];

                foreach (MathangDTO p in data)
                {

                    arrName[i] = p.TENMATHANG;
                    i++;

                }


                db.Close();
            }
            
           
        }

    }
}