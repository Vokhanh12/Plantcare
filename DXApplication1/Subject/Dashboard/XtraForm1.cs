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
using DXApplication1.FolderNV;
using DXApplication1.FolderMajor;
using DXApplication1.Subject.Items;
using DXApplication1.Subject.ImportDocuments;
using DXApplication1.Subject.ExportDocuments;
using DXApplication1.Subject.Warehouse;
using DXApplication1.Subject.Suplier;
using DXApplication1.Reports;
using System.Data.SqlClient;
using System.Configuration;

namespace DXApplication1
{

    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        //Send data to Form login
        public static XtraForm1 instance;
        public static Button btnAccount_DB;

        //Fiel
        private RJDropdownMenu rjDropdownMenu1;

        private System.Windows.Forms.ToolStripMenuItem ViewmyProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccoutDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WhatabRongplantToolStripMenuItem;

        private RJDropdownMenu rjDropdownMenu_Work;
        private System.Windows.Forms.ToolStripMenuItem Item_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem User_ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem Employee_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Supplier_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportDocuments_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportDocuments_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CollectDocuments_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpendDocuments_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Warehouse_ToolStripMenuItem;


        private RJDropdownMenu rjDropdownMenu_Report;
        private System.Windows.Forms.ToolStripMenuItem GeneralView_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PriceList_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderDetails_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatisticsAll_DocumentsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem Statistics_Commodity_DocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Statistics_Expense_DocumentsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem Import_DocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Export_DocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Inventory_DocumentsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem Spend_DocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Collect_DocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Own_DocumentsToolStripMenuItem;



        //Constructor 
        public XtraForm1()
        {

            InitializeComponent();

            instance = this;

            btnAcount.Text = FormLogin.instance.txt0.Text;
        

            //add Compoinent because Error delete code.maybe i shound do this it
            
            //Open rjDropdownMenu1
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

            this.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem";
            this.SignOutToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.SignOutToolStripMenuItem.Text = "Sign out";
            this.SignOutToolStripMenuItem.Click += new System.EventHandler(this.SignOutToolStripMenuItem_Click);

            this.WhatabRongplantToolStripMenuItem.Name = "aToolStripMenuItem";
            this.WhatabRongplantToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.WhatabRongplantToolStripMenuItem.Text = "What about Rongplant?";

            this.rjDropdownMenu1.ResumeLayout(false);

            this.ResumeLayout(false);
            //Close

            //Open rjDropdownMenu_Work
            this.rjDropdownMenu_Work = new DXApplication1.RJControls.RJDropdownMenu(this.components);
            this.Employee_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.User_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Supplier_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportDocuments_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportDocuments_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollectDocuments_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpendDocuments_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();



            this.rjDropdownMenu_Work.SuspendLayout();

            // rjDropdownMenu_Work
            // 
            this.rjDropdownMenu_Work.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu_Work.IsMainMenu = false;
            this.rjDropdownMenu_Work.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Employee_ToolStripMenuItem,
            this.Item_ToolStripMenuItem,
            this.User_ToolStripMenuItem,
            this.ImportDocuments_ToolStripMenuItem,
            this.ExportDocuments_ToolStripMenuItem,
            this.Supplier_ToolStripMenuItem,
            this.Warehouse_ToolStripMenuItem,
            this.CollectDocuments_ToolStripMenuItem,
            this.SpendDocuments_ToolStripMenuItem});;
            this.rjDropdownMenu_Work.MenuItemHeight = 45;
            this.rjDropdownMenu_Work.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu_Work.Name = "rjDropdownMenu2";
            this.rjDropdownMenu_Work.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu_Work.Size = new System.Drawing.Size(250, 368);


            //
            // Employee_ToolStripMenuItem
            //
            this.Employee_ToolStripMenuItem.Name = "Employee_ToolStripMenuItem";
            this.Employee_ToolStripMenuItem.Size = new System.Drawing.Size(249, 45);
            this.Employee_ToolStripMenuItem.Text = "Nhân viên";
            this.Employee_ToolStripMenuItem.Click += new System.EventHandler(this.Employee_ToolStripMenuItem_Click);
            // 
            // Item_ToolStripMenuItem
            // 
            this.Item_ToolStripMenuItem.Name = "Item_ToolStripMenuItem";
            this.Item_ToolStripMenuItem.Size = new System.Drawing.Size(249, 45);
            this.Item_ToolStripMenuItem.Text = "Sản phẩm";
            this.Item_ToolStripMenuItem.Click += new System.EventHandler(this.Item_ToolStripMenuItem_Click);

            // 
            // User_ToolStripMenuItem
            // 
            this.User_ToolStripMenuItem.Name = "User_ToolStripMenuItem";
            this.User_ToolStripMenuItem.Size = new System.Drawing.Size(249, 45);
            this.User_ToolStripMenuItem.Text = "Khách hàng";
            this.User_ToolStripMenuItem.Click += new System.EventHandler(this.User_ToolStripMenuItem_Click);
    
            // 
            // Supplier_ToolStripMenuItem
            // 
            this.Supplier_ToolStripMenuItem.Name = "Supplier_ToolStripMenuItem";
            this.Supplier_ToolStripMenuItem.Size = new System.Drawing.Size(249, 45);
            this.Supplier_ToolStripMenuItem.Text = "Nhà cung cấp";
            this.Supplier_ToolStripMenuItem.Click += new System.EventHandler(this.Supplier_ToolStripMenuItem_Click);

            // 
            // ImportDocuments_ToolStripMenuItem
            // 
            this.ImportDocuments_ToolStripMenuItem.Name = "ImportDocuments_ToolStripMenuItem";
            this.ImportDocuments_ToolStripMenuItem.Size = new System.Drawing.Size(249, 45);
            this.ImportDocuments_ToolStripMenuItem.Text = "Chứng từ nhập hàng";
            this.ImportDocuments_ToolStripMenuItem.Click += new System.EventHandler(this.ImportDocuments_ToolStripMenuItem_Click);
    
            // 
            // ExportDocuments_ToolStripMenuItem
            // 
            this.ExportDocuments_ToolStripMenuItem.Name = "ExportDocuments_ToolStripMenuItem";
            this.ExportDocuments_ToolStripMenuItem.Size = new System.Drawing.Size(249, 45);
            this.ExportDocuments_ToolStripMenuItem.Text = "Chứng từ xuất hàng";
            this.ExportDocuments_ToolStripMenuItem.Click += new System.EventHandler(this.ExportDocuments_ToolStripMenuItem_Click);

            // 
            // CollectDocuments_ToolStripMenuItem
            // 
            this.CollectDocuments_ToolStripMenuItem.Name = "CollectDocuments_ToolStripMenuItem";
            this.CollectDocuments_ToolStripMenuItem.Size = new System.Drawing.Size(249, 45);
            this.CollectDocuments_ToolStripMenuItem.Text = "Chứng từ thu";
 
            // 
            // SpendDocuments_ToolStripMenuItem
            // 
            this.SpendDocuments_ToolStripMenuItem.Name = "SpendDocuments_ToolStripMenuItem";
            this.SpendDocuments_ToolStripMenuItem.Size = new System.Drawing.Size(249, 45);
            this.SpendDocuments_ToolStripMenuItem.Text = "Chứng từ chi";

            // 
            // Warehouse_ToolStripMenuItem
            // 
            this.Warehouse_ToolStripMenuItem.Name = "Warehouse_ToolStripMenuItem";
            this.Warehouse_ToolStripMenuItem.Size = new System.Drawing.Size(249, 45);
            this.Warehouse_ToolStripMenuItem.Text = "Kho hàng";
            this.Warehouse_ToolStripMenuItem.Click += new System.EventHandler(this.Warehouse_ToolStripMenuItem_Click);

            this.rjDropdownMenu_Work.ResumeLayout(false);
            //Close


            //Open rjDropdownMenu_Report
            this.components = new System.ComponentModel.Container();
            this.rjDropdownMenu_Report = new DXApplication1.RJControls.RJDropdownMenu(this.components);

            this.GeneralView_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PriceList_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderDetails_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.StatisticsAll_DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.Statistics_Commodity_DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Statistics_Expense_DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.Import_DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Export_DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Inventory_DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.Collect_DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Spend_DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Own_DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            

            this.rjDropdownMenu_Report.SuspendLayout();
                

            //Setting ItemRjDropdownMenu
            this.rjDropdownMenu_Report.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu_Report.IsMainMenu = false;
            this.rjDropdownMenu_Report.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeneralView_ToolStripMenuItem,
            this.PriceList_ToolStripMenuItem,
            this.OrderDetails_ToolStripMenuItem,
            this.StatisticsAll_DocumentsToolStripMenuItem,
            });

            this.StatisticsAll_DocumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { 
                this.Statistics_Commodity_DocumentsToolStripMenuItem,
                this.Statistics_Expense_DocumentsToolStripMenuItem,
            });

            this.Statistics_Commodity_DocumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.Import_DocumentsToolStripMenuItem,
                this.Export_DocumentsToolStripMenuItem,
                this.Inventory_DocumentsToolStripMenuItem,
            });

            this.Statistics_Expense_DocumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{
                this.Collect_DocumentsToolStripMenuItem,
                this.Export_DocumentsToolStripMenuItem,
                this.Own_DocumentsToolStripMenuItem,
            });


            this.rjDropdownMenu_Report.MenuItemHeight = 25;
            this.rjDropdownMenu_Report.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu_Report.Name = "rjDropdownMenu_Report";
            this.rjDropdownMenu_Report.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu_Report.Size = new System.Drawing.Size(250, 368);

            this.GeneralView_ToolStripMenuItem.Name = "GeneralView_ToolStripMenuItem";
            this.GeneralView_ToolStripMenuItem.Size = new System.Drawing.Size(249, 45);
            this.GeneralView_ToolStripMenuItem.Text = "Tổng quát";
            this.GeneralView_ToolStripMenuItem.Click += new System.EventHandler(this.GeneralView_ToolStripMenuItem_Click);

            this.PriceList_ToolStripMenuItem.Name = "PriceList_ToolStripMenuItem";
            this.PriceList_ToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.PriceList_ToolStripMenuItem.Text = "Danh sách giá cả";

            this.OrderDetails_ToolStripMenuItem.Name = "OrderDetails_ToolStripMenuItem";
            this.OrderDetails_ToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.OrderDetails_ToolStripMenuItem.Text = "Chi tiết đơn hàng";

            this.StatisticsAll_DocumentsToolStripMenuItem.Name = "StatisticsAll_DocumentsToolStripMenuItem.";
            this.StatisticsAll_DocumentsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.StatisticsAll_DocumentsToolStripMenuItem.Text = "Thống kê";

            this.Statistics_Commodity_DocumentsToolStripMenuItem.Name = "Statistics_Commodity_DocumentsToolStripMenuItem";
            this.Statistics_Commodity_DocumentsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.Statistics_Commodity_DocumentsToolStripMenuItem.Text = "Hàng hóa";

            this.Statistics_Expense_DocumentsToolStripMenuItem.Name = "Statistics_Expense_DocumentsToolStripMenuItem";
            this.Statistics_Expense_DocumentsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.Statistics_Expense_DocumentsToolStripMenuItem.Text = "Thu nhập";

            this.Import_DocumentsToolStripMenuItem.Name = "ImportDocuments_ToolStripMenuItem";
            this.Import_DocumentsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.Import_DocumentsToolStripMenuItem.Text = "Nhập hàng";

            this.Export_DocumentsToolStripMenuItem.Name = "ExportDocuments_ToolStripMenuItem";
            this.Export_DocumentsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.Export_DocumentsToolStripMenuItem.Text = "Xuất hàng";

            this.Inventory_DocumentsToolStripMenuItem.Name = "Inventory_DocumentsToolStripMenuItem";
            this.Inventory_DocumentsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.Inventory_DocumentsToolStripMenuItem.Text = "Tồn kho";

            this.Collect_DocumentsToolStripMenuItem.Name = "CollectDocuments_ToolStripMenuItem";
            this.Collect_DocumentsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.Collect_DocumentsToolStripMenuItem.Text = "Thu vào";

            this.Spend_DocumentsToolStripMenuItem.Name = "SpendDocuments_ToolStripMenuItem";
            this.Spend_DocumentsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.Spend_DocumentsToolStripMenuItem.Text = "Chi ra";

            this.Own_DocumentsToolStripMenuItem.Name = "Own_DocumentsToolStripMenuItem";
            this.Own_DocumentsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.Own_DocumentsToolStripMenuItem.Text = "Khoản nợ";

            this.rjDropdownMenu_Report.ResumeLayout(false);

            this.ResumeLayout(false);
            //close


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

            rjDropdownMenu_Work.IsMainMenu = true;

            rjDropdownMenu_Report.IsMainMenu = true;

          


            
        }
        //the constructors change color and backcolor
        private void ibtHome_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);
           
        }
        private void ibt_Work_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);

            rjDropdownMenu_Work.Show(ibt_Work, ibt_Work.Width , 0);
        }
        private void ibt_Follow_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);
        }

        private void ibt_Report_Click(object sender, EventArgs e)
        {
            ClinkChangeColor.DisableButton();
            ClinkChangeColor.ActivateButton(sender, RGBColors.color6);

            rjDropdownMenu_Report.Show(ibt_Report, ibt_Work.Width, 0);
        }


        private void ibt_Help_Click(object sender, EventArgs e)
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
        private void ibt_Help_MouseEnter(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);
        }

        private void ibt_Help_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }


        private void ibt_Report_MouseEnter(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);
        }

        private void ibt_Report_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }

        private void ibt_Follow_MouseEnter(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);
        }

        private void ibt_Follow_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }

        private void ibt_Work_MouseLeave(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorLeave);
        }

        private void ibt_Work_MouseEnter(object sender, EventArgs e)
        {
            ClinkChangeColor.ChangeButtonColor(sender, RGBColors.ColorEnter);
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

        private void RjDropdownMenu_Work_Opening(object sender, CancelEventArgs e)
        {

        }

        private void RjDropdownMenu_Work_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void buttonAcount_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(btnAcount, btnAcount.Width - rjDropdownMenu1.Width, btnAcount.Height+3);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        // Button click DropdownMenu
        private void Employee_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien formNhanVien = new frmNhanVien();
            formNhanVien.MdiParent = this;
            formNhanVien.Show();
        }

        private void User_ToolStripMenuItem_Click(object sender , EventArgs e)
        {
            frmCustomer formCustomer = new frmCustomer();
            formCustomer.MdiParent = this;
            formCustomer.Show();

        }

        private void Item_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMathang formMathhang = new frmMathang();
            formMathhang.MdiParent = this;
            formMathhang.Show();
        }

        private void ImportDocuments_ToolStripMenuItem_Click(object sender ,EventArgs e)
        {
            frmCTNH formCTNH = new frmCTNH();
            formCTNH.MdiParent = this;
            formCTNH.Show();

        
        }

        private void ExportDocuments_ToolStripMenuItem_Click(object sender,EventArgs e)
        {
            frmCTXH formCTXH = new frmCTXH();
            formCTXH.MdiParent = this;
            formCTXH.Show();
        }

        private void Supplier_ToolStripMenuItem_Click(Object sender,EventArgs e)
        {
            frmNCC formNhacungcap = new frmNCC();
            formNhacungcap.MdiParent = this;
            formNhacungcap.Show();

        }

        private void Warehouse_ToolStripMenuItem_Click(object sender,EventArgs e)
        {
            frmKho formKho = new frmKho();
            formKho.MdiParent = this;
            formKho.Show();
        }

        private void GeneralView_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportALL rp = new ReportALL();
            rp.MdiParent = this;
            rp.Show();
        }
        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}