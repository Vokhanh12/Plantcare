using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace DXApplication1
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private void asd() { }
        
        //Constructor 
        public XtraForm1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10,60);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        //Structs
        private struct RGBColors
        {
          public static Color color1 = Color.FromArgb(172,126,241);  
          public static Color color2 = Color.FromArgb(249,118,176);  
          public static Color color3 = Color.FromArgb(253,138,167);  
          public static Color color4 = Color.FromArgb(95,77,221);  
          public static Color color5 = Color.FromArgb(249,88,155);  
          public static Color color6 = Color.FromArgb(24,161,251);  
        }
        //Method
        private void ActivateButton(object senderBtn,Color color)
        {
            if(senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(20, 29, 55);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(20, 29, 55);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        private void ibtHome_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, RGBColors.color6);
        }

        private void ibtItem_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, RGBColors.color6);
        }

        private void ibtUser_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, RGBColors.color6);
        }

        private void ibtWarehouse_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, RGBColors.color6);
        }

        private void iconGumshoe_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, RGBColors.color6);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, RGBColors.color6);
        }

        private void bntHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }
    }
}