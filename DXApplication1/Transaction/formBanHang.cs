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
    }
}