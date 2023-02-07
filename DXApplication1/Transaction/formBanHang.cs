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


        const int NEXT_ITEM = 9;
        int page = 1;
        int firstItemPage = 0;
        int lastItemPage = 9;


        ArrayList ArraySP = new ArrayList();
        string[] arrName;
        decimal[] arrPrice;

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

            for(int i = 0; i < NEXT_ITEM; i++)
            {
                flowLayoutPanel1.Controls.Add(new KhungBH(arrName[i], arrPrice[i]));
            }




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
                arrPrice = new decimal[ArraySP.Count];

                foreach (MathangDTO p in data)
                {

                    arrName[i] = p.TENMATHANG;
                    arrPrice[i] = p.GIA;
                    i++;

                }


                db.Close();
            }


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            page--;

            if (page > 0)
            {
                for (int i = (page - 1) * NEXT_ITEM; i < lastItemPage * page; i++)
                {
                    try
                    {
                        flowLayoutPanel1.Controls.Add(new KhungBH(arrName[i], arrPrice[i]));
                    }
                    catch (Exception ex) { };
                }
            }
            else
            {
                page = 1;
                MessageBox.Show("Het page");

                for (int i = (page - 1) * NEXT_ITEM; i < lastItemPage * page; i++)
                {
                    try
                    {
                        flowLayoutPanel1.Controls.Add(new KhungBH(arrName[i], arrPrice[i]));
                    }
                    catch (Exception ex) { };
                }

            }


        }

       // const int NEXT_ITEM = 9;
        //int page = 0;
        //int checkNextPage = 9; // check load 9 items
        //int TestNextPage = 0;


        private void iconButton2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            page++;

            if (page <= (ArraySP.Count / NEXT_ITEM)+1)
            {
                for (int i = (page - 1) * NEXT_ITEM; i < lastItemPage * page; i++)
                {
                    try
                    {
                        flowLayoutPanel1.Controls.Add(new KhungBH(arrName[i], arrPrice[i]));
                    }
                    catch (Exception ex) { };
                }
            }
            else
            {
                page = ArraySP.Count / NEXT_ITEM;
                MessageBox.Show("Het page"+ ArraySP.Count);

                for (int i = (page - 1) * NEXT_ITEM; i < lastItemPage * page; i++)
                {
                    try
                    {
                        flowLayoutPanel1.Controls.Add(new KhungBH(arrName[i], arrPrice[i]));
                    }
                    catch (Exception ex) { };
                }
            }

           

        }
    }
}