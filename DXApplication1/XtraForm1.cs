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
using DXApplication1.ChangeColorButton;

namespace DXApplication1
{

    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        //Fiel
        


        private RJDropdownMenu rjDropdownMenu1;

        private System.Windows.Forms.ToolStripMenuItem ViewmyProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccoutDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WhatabRongplantToolStripMenuItem;



        //Constructor 
        public XtraForm1()
        {

            InitializeComponent();
            //add Compoinent because Error delete code.maybe i shound do this it
            //Open
            this.components = new System.ComponentModel.Container();

            this.rjDropdownMenu1 = new DXApplication1.RJControls.RJDropdownMenu(this.components);

            this.ViewmyProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccoutDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WhatabRongplantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.rjDropdownMenu1.SuspendLayout();

            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewmyProfileToolStripMenuItem,
            this.AccoutDetailsToolStripMenuItem,
            this.SignOutToolStripMenuItem,
            this.WhatabRongplantToolStripMenuItem,
            });

            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(87, 28);

            this.ViewmyProfileToolStripMenuItem.Name = "aToolStripMenuItem";
            this.ViewmyProfileToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.ViewmyProfileToolStripMenuItem.Text = "View my profile";

            this.AccoutDetailsToolStripMenuItem.Name = "aToolStripMenuItem";
            this.AccoutDetailsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.AccoutDetailsToolStripMenuItem.Text = "Account details";

            this.SignOutToolStripMenuItem.Name = "aToolStripMenuItem";
            this.SignOutToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.SignOutToolStripMenuItem.Text = "Sign out";

            this.WhatabRongplantToolStripMenuItem.Name = "aToolStripMenuItem";
            this.WhatabRongplantToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.WhatabRongplantToolStripMenuItem.Text = "What about Rongplant?";

            this.rjDropdownMenu1.ResumeLayout(false);

            this.ResumeLayout(false);
            //Close


            ClinkChangeColor.leftBorderBtn = new Panel();
            ClinkChangeColor.leftBorderBtn.Size = new Size(10,62);
            panelMenu.Controls.Add(ClinkChangeColor.leftBorderBtn);
            //Form

        




        }
        //Structs Color
        private struct RGBColors
        {
          public static Color color1 = Color.FromArgb(172,126,241);  
          public static Color color2 = Color.FromArgb(249,118,176);  
          public static Color color3 = Color.FromArgb(253,138,167);  
          public static Color color4 = Color.FromArgb(95,77,221);  
          public static Color color5 = Color.FromArgb(249,88,155);  
          public static Color color6 = Color.FromArgb(24,161,251);

          public static Color ColorEnter = Color.FromArgb(0, 128, 255);
          public static Color ColorLeave = Color.FromArgb(0, 0, 51);
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            //Loadropdownmenu is true;
            rjDropdownMenu1.IsMainMenu = true;
        }
        //the constructors change color and backcolor
        private void ibtHome_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);
           
        }

        private void ibtItem_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);
        }

        private void ibtUser_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);
        }

        private void ibtWarehouse_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);
        }

        private void iconGumshoe_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);
        }

        private void ibtGumshoe_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);
        }

        private void ibtHelp_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);
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
        //Event mouseEnter and mouseLeave button => change Backcolor button
        //Open
        private void ibtHome_MouseEnter(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);
        }

        private void ibtHome_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }

        private void ibtItem_MouseEnter(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);

        }

        private void ibtItem_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }

        private void ibtUser_MouseEnter(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);
        }

        private void ibtUser_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }

        private void ibtWarehouse_MouseEnter(object sender, EventArgs e)
        {
           ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);
        }

        private void ibtWarehouse_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }

        private void iconGumshoe_MouseEnter(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);
        }

        private void iconGumshoe_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }

        private void iconButton6_MouseEnter(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);
        }

        private void iconButton6_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }
        private void ibtGumshoe_MouseEnter(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);
        }

        private void ibtGumshoe_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }

        private void ibtHelp_MouseEnter(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);
        }

        private void ibtHelp_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }
        //Close

        //the use the windows is closed
        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void rjDropdownMenu2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rjDropdownMenu2_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void buttonAcount_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(btnAcount, btnAcount.Width - rjDropdownMenu1.Width, btnAcount.Height+3);
        }
    }
}