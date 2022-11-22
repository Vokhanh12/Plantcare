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
using DXApplication1.RJControls;

namespace DXApplication1
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        //Fiel
        private IconButton currentBtn;
        private Panel leftBorderBtn;
       

        
        
        //Constructor 
        public XtraForm1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10,50);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form





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
                currentBtn.BackColor = Color.FromArgb(0, 128, 255);
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
                currentBtn.BackColor = Color.FromArgb(0, 0, 51);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void XtraForm1_Load(object sender, EventArgs e)
        {
            //load button menu
            rjDropdownMenu_Accout.IsMainMenu = true;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbDashbroad_Click(object sender, EventArgs e)
        {

        }

        private void panelMenuLeft_Paint(object sender, PaintEventArgs e)
        {

        }

    


        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panelDashbroad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ibtHome_MouseEnter(object sender, EventArgs e)
        {
            ibtHome.BackColor = Color.FromArgb(0,128,255);
        }

        private void ibtHome_MouseLeave(object sender, EventArgs e)
        {
            ibtHome.BackColor = Color.FromArgb(0, 0, 51);
        }

        private void ibtItem_MouseEnter(object sender, EventArgs e)
        {

            ibtItem.BackColor = Color.FromArgb(0, 128, 255);
        }

        private void ibtItem_MouseLeave(object sender, EventArgs e)
        {
            ibtItem.BackColor = Color.FromArgb(0, 0, 51);
        }

        private void ibtUser_MouseEnter(object sender, EventArgs e)
        {
            ibtUser.BackColor = Color.FromArgb(0,128,255);
        }

        private void ibtUser_MouseLeave(object sender, EventArgs e)
        {
            ibtUser.BackColor = Color.FromArgb(0,0,51);
        }

        private void ibtWarehouse_MouseEnter(object sender, EventArgs e)
        {
            ibtWarehouse.BackColor = Color.FromArgb(0,128,255);
        }

        private void ibtWarehouse_MouseLeave(object sender, EventArgs e)
        {
            ibtWarehouse.BackColor = Color.FromArgb(0,0,51);
        }

        private void iconGumshoe_MouseEnter(object sender, EventArgs e)
        {
            ibtSell.BackColor = Color.FromArgb(0,128,255);
        }

        private void iconGumshoe_MouseLeave(object sender, EventArgs e)
        {
            ibtSell.BackColor = Color.FromArgb(0,0,51);
        }

        private void iconButton6_MouseEnter(object sender, EventArgs e)
        {
            ibtReport.BackColor = Color.FromArgb(0, 128, 255);
        }

        private void iconButton6_MouseLeave(object sender, EventArgs e)
        {
            ibtReport.BackColor = Color.FromArgb(0, 0, 51);
        }

        private void testTSMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Show button menu
            rjDropdownMenu_Accout.Show(button1,0,button1.Height);
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}