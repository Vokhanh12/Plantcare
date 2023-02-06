using DevExpress.XtraEditors;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        KhungBH pnKhungBH = new KhungBH();
        KhungBH khungBH1 = new KhungBH();
        KhungBH khungBH2 = new KhungBH();
        KhungBH khungBH3 = new KhungBH();
        KhungBH khungBH4 = new KhungBH();
        KhungBH khungBH5 = new KhungBH();


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
           

            flowLayoutPanel1.Controls.Add(pnKhungBH);
            flowLayoutPanel1.Controls.Add(khungBH1);
            flowLayoutPanel1.Controls.Add(khungBH2);
            flowLayoutPanel1.Controls.Add(khungBH3);
            flowLayoutPanel1.Controls.Add(khungBH4);
            flowLayoutPanel1.Controls.Add(khungBH5);
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
    }
}