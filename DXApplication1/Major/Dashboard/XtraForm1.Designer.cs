
using DXApplication1.RJControls;

namespace DXApplication1
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibt_Help = new FontAwesome.Sharp.IconButton();
            this.lbVersion = new System.Windows.Forms.Label();
            this.ibt_Follow = new FontAwesome.Sharp.IconButton();
            this.ibt_Report = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ibt_Work = new FontAwesome.Sharp.IconButton();
            this.ibtHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelMenuMind = new System.Windows.Forms.Panel();
            this.panelMenuLeft = new System.Windows.Forms.Panel();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.plMenuRight = new System.Windows.Forms.Panel();
            this.btnAcount = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Item_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.User_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Supplier_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportDocuments_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportDocuments_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollectDocuments_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpendDocuments_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelMenuLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            this.plMenuRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.panelMenu.Controls.Add(this.ibt_Help);
            this.panelMenu.Controls.Add(this.lbVersion);
            this.panelMenu.Controls.Add(this.ibt_Follow);
            this.panelMenu.Controls.Add(this.ibt_Report);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.ibt_Work);
            this.panelMenu.Controls.Add(this.ibtHome);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.panelMenu.Size = new System.Drawing.Size(299, 737);
            this.panelMenu.TabIndex = 2;
            // 
            // ibt_Help
            // 
            this.ibt_Help.BackColor = System.Drawing.Color.Transparent;
            this.ibt_Help.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibt_Help.FlatAppearance.BorderSize = 0;
            this.ibt_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibt_Help.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibt_Help.ForeColor = System.Drawing.Color.White;
            this.ibt_Help.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.ibt_Help.IconColor = System.Drawing.Color.White;
            this.ibt_Help.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibt_Help.IconSize = 32;
            this.ibt_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibt_Help.Location = new System.Drawing.Point(12, 409);
            this.ibt_Help.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ibt_Help.Name = "ibt_Help";
            this.ibt_Help.Padding = new System.Windows.Forms.Padding(12, 1, 23, 1);
            this.ibt_Help.Size = new System.Drawing.Size(264, 62);
            this.ibt_Help.TabIndex = 11;
            this.ibt_Help.Text = "Trợ giúp";
            this.ibt_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibt_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibt_Help.UseVisualStyleBackColor = false;
            this.ibt_Help.Click += new System.EventHandler(this.ibt_Help_Click);
            this.ibt_Help.MouseEnter += new System.EventHandler(this.ibt_Help_MouseEnter);
            this.ibt_Help.MouseLeave += new System.EventHandler(this.ibt_Help_MouseLeave);
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(198, 711);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(89, 17);
            this.lbVersion.TabIndex = 10;
            this.lbVersion.Text = "Version:1.6.2";
            // 
            // ibt_Follow
            // 
            this.ibt_Follow.BackColor = System.Drawing.Color.Transparent;
            this.ibt_Follow.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibt_Follow.FlatAppearance.BorderSize = 0;
            this.ibt_Follow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibt_Follow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibt_Follow.ForeColor = System.Drawing.Color.White;
            this.ibt_Follow.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.ibt_Follow.IconColor = System.Drawing.Color.White;
            this.ibt_Follow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibt_Follow.IconSize = 32;
            this.ibt_Follow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibt_Follow.Location = new System.Drawing.Point(12, 347);
            this.ibt_Follow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ibt_Follow.Name = "ibt_Follow";
            this.ibt_Follow.Padding = new System.Windows.Forms.Padding(12, 1, 23, 1);
            this.ibt_Follow.Size = new System.Drawing.Size(264, 62);
            this.ibt_Follow.TabIndex = 9;
            this.ibt_Follow.Text = "Theo dõi cây trồng";
            this.ibt_Follow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibt_Follow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibt_Follow.UseVisualStyleBackColor = false;
            this.ibt_Follow.Click += new System.EventHandler(this.ibt_Follow_Click);
            this.ibt_Follow.MouseEnter += new System.EventHandler(this.ibt_Follow_MouseEnter);
            this.ibt_Follow.MouseLeave += new System.EventHandler(this.ibt_Follow_MouseLeave);
            // 
            // ibt_Report
            // 
            this.ibt_Report.BackColor = System.Drawing.Color.Transparent;
            this.ibt_Report.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibt_Report.FlatAppearance.BorderSize = 0;
            this.ibt_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibt_Report.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibt_Report.ForeColor = System.Drawing.Color.White;
            this.ibt_Report.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.ibt_Report.IconColor = System.Drawing.Color.White;
            this.ibt_Report.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibt_Report.IconSize = 32;
            this.ibt_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibt_Report.Location = new System.Drawing.Point(12, 285);
            this.ibt_Report.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ibt_Report.Name = "ibt_Report";
            this.ibt_Report.Padding = new System.Windows.Forms.Padding(12, 1, 23, 1);
            this.ibt_Report.Size = new System.Drawing.Size(264, 62);
            this.ibt_Report.TabIndex = 8;
            this.ibt_Report.Text = "Báo cáo";
            this.ibt_Report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibt_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibt_Report.UseVisualStyleBackColor = false;
            this.ibt_Report.Click += new System.EventHandler(this.ibt_Report_Click);
            this.ibt_Report.MouseEnter += new System.EventHandler(this.ibt_Report_MouseEnter);
            this.ibt_Report.MouseLeave += new System.EventHandler(this.ibt_Report_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(299, 127);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 554);
            this.panel3.TabIndex = 4;
            // 
            // ibt_Work
            // 
            this.ibt_Work.BackColor = System.Drawing.Color.Transparent;
            this.ibt_Work.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibt_Work.FlatAppearance.BorderSize = 0;
            this.ibt_Work.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibt_Work.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibt_Work.ForeColor = System.Drawing.Color.White;
            this.ibt_Work.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.ibt_Work.IconColor = System.Drawing.Color.White;
            this.ibt_Work.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibt_Work.IconSize = 32;
            this.ibt_Work.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibt_Work.Location = new System.Drawing.Point(12, 223);
            this.ibt_Work.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ibt_Work.Name = "ibt_Work";
            this.ibt_Work.Padding = new System.Windows.Forms.Padding(12, 1, 23, 1);
            this.ibt_Work.Size = new System.Drawing.Size(264, 62);
            this.ibt_Work.TabIndex = 7;
            this.ibt_Work.Text = "Nghiệp vụ";
            this.ibt_Work.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibt_Work.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibt_Work.UseVisualStyleBackColor = false;
            this.ibt_Work.Click += new System.EventHandler(this.ibt_Work_Click);
            this.ibt_Work.MouseEnter += new System.EventHandler(this.ibt_Work_MouseEnter);
            this.ibt_Work.MouseLeave += new System.EventHandler(this.ibt_Work_MouseLeave);
            // 
            // ibtHome
            // 
            this.ibtHome.BackColor = System.Drawing.Color.Transparent;
            this.ibtHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtHome.FlatAppearance.BorderSize = 0;
            this.ibtHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtHome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtHome.ForeColor = System.Drawing.Color.White;
            this.ibtHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtHome.IconColor = System.Drawing.Color.White;
            this.ibtHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtHome.IconSize = 32;
            this.ibtHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtHome.Location = new System.Drawing.Point(12, 161);
            this.ibtHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ibtHome.Name = "ibtHome";
            this.ibtHome.Padding = new System.Windows.Forms.Padding(12, 1, 23, 1);
            this.ibtHome.Size = new System.Drawing.Size(264, 62);
            this.ibtHome.TabIndex = 2;
            this.ibtHome.Text = "Trang chủ";
            this.ibtHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtHome.UseVisualStyleBackColor = false;
            this.ibtHome.Click += new System.EventHandler(this.ibtHome_Click);
            this.ibtHome.MouseEnter += new System.EventHandler(this.ibtHome_MouseEnter);
            this.ibtHome.MouseLeave += new System.EventHandler(this.ibtHome_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 161);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DXApplication1.Properties.Resources.Plant_Happy_and_healthy__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-27, -104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(299, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 76);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.panelMenuMind);
            this.panel5.Controls.Add(this.panelMenuLeft);
            this.panel5.Controls.Add(this.plMenuRight);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1218, 76);
            this.panel5.TabIndex = 0;
            // 
            // panelMenuMind
            // 
            this.panelMenuMind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuMind.Location = new System.Drawing.Point(556, 0);
            this.panelMenuMind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenuMind.Name = "panelMenuMind";
            this.panelMenuMind.Size = new System.Drawing.Size(429, 76);
            this.panelMenuMind.TabIndex = 25;
            // 
            // panelMenuLeft
            // 
            this.panelMenuLeft.Controls.Add(this.txtFind);
            this.panelMenuLeft.Controls.Add(this.panel7);
            this.panelMenuLeft.Controls.Add(this.picUsername);
            this.panelMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenuLeft.Name = "panelMenuLeft";
            this.panelMenuLeft.Size = new System.Drawing.Size(556, 76);
            this.panelMenuLeft.TabIndex = 24;
            this.panelMenuLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuLeft_Paint);
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFind.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.White;
            this.txtFind.HideSelection = false;
            this.txtFind.Location = new System.Drawing.Point(63, 30);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(292, 21);
            this.txtFind.TabIndex = 25;
            this.txtFind.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(63, 55);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(292, 1);
            this.panel7.TabIndex = 24;
            // 
            // picUsername
            // 
            this.picUsername.Image = global::DXApplication1.Properties.Resources.iconfind;
            this.picUsername.Location = new System.Drawing.Point(15, 17);
            this.picUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(41, 39);
            this.picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsername.TabIndex = 23;
            this.picUsername.TabStop = false;
            // 
            // plMenuRight
            // 
            this.plMenuRight.Controls.Add(this.btnAcount);
            this.plMenuRight.Controls.Add(this.pictureBox2);
            this.plMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.plMenuRight.Location = new System.Drawing.Point(985, 0);
            this.plMenuRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plMenuRight.Name = "plMenuRight";
            this.plMenuRight.Size = new System.Drawing.Size(233, 76);
            this.plMenuRight.TabIndex = 23;
            // 
            // btnAcount
            // 
            this.btnAcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnAcount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAcount.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAcount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAcount.Location = new System.Drawing.Point(66, 23);
            this.btnAcount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAcount.Name = "btnAcount";
            this.btnAcount.Size = new System.Drawing.Size(153, 28);
            this.btnAcount.TabIndex = 26;
            this.btnAcount.Text = "Nguyễn Võ Khánh ▼";
            this.btnAcount.UseVisualStyleBackColor = false;
            this.btnAcount.Click += new System.EventHandler(this.buttonAcount_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DXApplication1.Properties.Resources.userlogo;
            this.pictureBox2.Location = new System.Drawing.Point(16, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // Item_ToolStripMenuItem
            // 
            this.Item_ToolStripMenuItem.Name = "Item_ToolStripMenuItem";
            this.Item_ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.Item_ToolStripMenuItem.Text = "Sản phẩm";
            // 
            // User_ToolStripMenuItem
            // 
            this.User_ToolStripMenuItem.Name = "User_ToolStripMenuItem";
            this.User_ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.User_ToolStripMenuItem.Text = "Khách hàng";
            // 
            // Supplier_ToolStripMenuItem
            // 
            this.Supplier_ToolStripMenuItem.Name = "Supplier_ToolStripMenuItem";
            this.Supplier_ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.Supplier_ToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // ImportDocuments_ToolStripMenuItem
            // 
            this.ImportDocuments_ToolStripMenuItem.Name = "ImportDocuments_ToolStripMenuItem";
            this.ImportDocuments_ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.ImportDocuments_ToolStripMenuItem.Text = "Chứng từ nhập hàng";
            // 
            // ExportDocuments_ToolStripMenuItem
            // 
            this.ExportDocuments_ToolStripMenuItem.Name = "ExportDocuments_ToolStripMenuItem";
            this.ExportDocuments_ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.ExportDocuments_ToolStripMenuItem.Text = "Chứng từ xuất hàng";
            // 
            // CollectDocuments_ToolStripMenuItem
            // 
            this.CollectDocuments_ToolStripMenuItem.Name = "CollectDocuments_ToolStripMenuItem";
            this.CollectDocuments_ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.CollectDocuments_ToolStripMenuItem.Text = "Chứng từ thu";
            // 
            // SpendDocuments_ToolStripMenuItem
            // 
            this.SpendDocuments_ToolStripMenuItem.Name = "SpendDocuments_ToolStripMenuItem";
            this.SpendDocuments_ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.SpendDocuments_ToolStripMenuItem.Text = "Chứng từ chi";
            // 
            // Warehouse_ToolStripMenuItem
            // 
            this.Warehouse_ToolStripMenuItem.Name = "Warehouse_ToolStripMenuItem";
            this.Warehouse_ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.Warehouse_ToolStripMenuItem.Text = "Kho hàng";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.tabbedView1.Appearance.Options.UseBackColor = true;
            this.tabbedView1.Appearance.Options.UseForeColor = true;
            this.tabbedView1.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.Header.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.Header.Options.UseBackColor = true;
            this.tabbedView1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.HeaderActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.tabbedView1.AppearancePage.HeaderDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.HeaderDisabled.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.HeaderDisabled.Options.UseBackColor = true;
            this.tabbedView1.AppearancePage.HeaderHotTracked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.HeaderHotTracked.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.HeaderHotTracked.Options.UseBackColor = true;
            this.tabbedView1.AppearancePage.HeaderSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.HeaderSelected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.HeaderSelected.Options.UseBackColor = true;
            this.tabbedView1.AppearancePage.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.PageClient.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tabbedView1.AppearancePage.PageClient.Options.UseBackColor = true;
            this.tabbedView1.LoadingIndicatorProperties.AppearanceCaption.BackColor = System.Drawing.Color.Transparent;
            this.tabbedView1.LoadingIndicatorProperties.AppearanceCaption.Options.UseBackColor = true;
            this.tabbedView1.LoadingIndicatorProperties.AppearanceDescription.ForeColor = System.Drawing.Color.Transparent;
            this.tabbedView1.LoadingIndicatorProperties.AppearanceDescription.Options.UseForeColor = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(299, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            this.panel4.TabIndex = 4;
            // 
            // XtraForm1
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 737);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtraForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelMenuLeft.ResumeLayout(false);
            this.panelMenuLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            this.plMenuRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ibtHome;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibt_Work;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plMenuRight;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelMenuLeft;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.Panel panelMenuMind;
        private System.Windows.Forms.Button btnAcount;
        private FontAwesome.Sharp.IconButton ibt_Follow;
        private FontAwesome.Sharp.IconButton ibt_Report;
        private System.Windows.Forms.Label lbVersion;
        private FontAwesome.Sharp.IconButton ibt_Help;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private System.Windows.Forms.Panel panel4;
    }
}