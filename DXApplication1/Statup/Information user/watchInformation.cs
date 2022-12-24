using DevExpress.XtraEditors;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Statup.Information_user
{
    public partial class watchInformation : MaterialSkin.Controls.MaterialForm
    {
        //Declare
        MaterialSkinManager skinManager;

        public static watchInformation instance;

        public MaterialLabel mlbID_AT,mlbTK_AT, mlbMK_AT, mlbTTK_AT, mlbMTK_AT, mlbLTK_AT, mlbDC_AT, mlbNDK_AT;

        

        public string casechange;
        public watchInformation()
        {
            InitializeComponent();

            instance = this;

            //transfer data to this form
            mlbID_AT = mlbID;
            mlbTK_AT = mlbLTK;
            mlbMK_AT = mlbMK;
            mlbTTK_AT = mlbTTK;
            mlbMTK_AT = mlbMTK;
            mlbDC_AT = mlbDC;
            mlbNDK_AT = mlbNDK;
            mlbLTK_AT = mlbLTK;

            //Design MarterialListview
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo900, Primary.Indigo700, Accent.Indigo700, TextShade.WHITE);
        }


        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void watchInformation_Load(object sender, EventArgs e)
        {
          



        }
    }
}