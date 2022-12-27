
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
            this.ibtHelp = new FontAwesome.Sharp.IconButton();
            this.ibtBrowJob = new FontAwesome.Sharp.IconButton();
            this.ibtFollow = new FontAwesome.Sharp.IconButton();
            this.lbVersion = new System.Windows.Forms.Label();
            this.ibtReport = new FontAwesome.Sharp.IconButton();
            this.ibtBuy = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ibtWork = new FontAwesome.Sharp.IconButton();
            this.ibtHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelMenuMind = new System.Windows.Forms.Panel();
            this.panelMenuLeft = new System.Windows.Forms.Panel();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.pnFind = new System.Windows.Forms.Panel();
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
            this.panelMenu.Controls.Add(this.ibtHelp);
            this.panelMenu.Controls.Add(this.ibtBrowJob);
            this.panelMenu.Controls.Add(this.ibtFollow);
            this.panelMenu.Controls.Add(this.lbVersion);
            this.panelMenu.Controls.Add(this.ibtReport);
            this.panelMenu.Controls.Add(this.ibtBuy);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.ibtWork);
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
            // ibtHelp
            // 
            this.ibtHelp.BackColor = System.Drawing.Color.Transparent;
            this.ibtHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtHelp.FlatAppearance.BorderSize = 0;
            this.ibtHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtHelp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtHelp.ForeColor = System.Drawing.Color.White;
            this.ibtHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.ibtHelp.IconColor = System.Drawing.Color.White;
            this.ibtHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtHelp.IconSize = 32;
            this.ibtHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtHelp.Location = new System.Drawing.Point(12, 533);
            this.ibtHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ibtHelp.Name = "ibtHelp";
            this.ibtHelp.Padding = new System.Windows.Forms.Padding(12, 1, 23, 1);
            this.ibtHelp.Size = new System.Drawing.Size(264, 62);
            this.ibtHelp.TabIndex = 13;
            this.ibtHelp.Text = "Trợ giúp";
            this.ibtHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtHelp.UseVisualStyleBackColor = false;
            this.ibtHelp.Click += new System.EventHandler(this.ibtHelp_Click);
            this.ibtHelp.MouseEnter += new System.EventHandler(this.ibtHelp_MouseEnter);
            this.ibtHelp.MouseLeave += new System.EventHandler(this.ibtHelp_MouseLeave);
            // 
            // ibtBrowJob
            // 
            this.ibtBrowJob.BackColor = System.Drawing.Color.Transparent;
            this.ibtBrowJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtBrowJob.FlatAppearance.BorderSize = 0;
            this.ibtBrowJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtBrowJob.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtBrowJob.ForeColor = System.Drawing.Color.White;
            this.ibtBrowJob.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.ibtBrowJob.IconColor = System.Drawing.Color.White;
            this.ibtBrowJob.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtBrowJob.IconSize = 32;
            this.ibtBrowJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtBrowJob.Location = new System.Drawing.Point(12, 471);
            this.ibtBrowJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ibtBrowJob.Name = "ibtBrowJob";
            this.ibtBrowJob.Padding = new System.Windows.Forms.Padding(12, 1, 23, 1);
            this.ibtBrowJob.Size = new System.Drawing.Size(264, 62);
            this.ibtBrowJob.TabIndex = 12;
            this.ibtBrowJob.Text = "Duyệt đơn";
            this.ibtBrowJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtBrowJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtBrowJob.UseVisualStyleBackColor = false;
            this.ibtBrowJob.Click += new System.EventHandler(this.ibtBrowseJob_Click);
            this.ibtBrowJob.MouseEnter += new System.EventHandler(this.ibtBrowseJob_MouseEnter);
            this.ibtBrowJob.MouseLeave += new System.EventHandler(this.ibtBrowseJob_MouseLeave);
            // 
            // ibtFollow
            // 
            this.ibtFollow.BackColor = System.Drawing.Color.Transparent;
            this.ibtFollow.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtFollow.FlatAppearance.BorderSize = 0;
            this.ibtFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtFollow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtFollow.ForeColor = System.Drawing.Color.White;
            this.ibtFollow.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.ibtFollow.IconColor = System.Drawing.Color.White;
            this.ibtFollow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtFollow.IconSize = 32;
            this.ibtFollow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtFollow.Location = new System.Drawing.Point(12, 409);
            this.ibtFollow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ibtFollow.Name = "ibtFollow";
            this.ibtFollow.Padding = new System.Windows.Forms.Padding(12, 1, 23, 1);
            this.ibtFollow.Size = new System.Drawing.Size(264, 62);
            this.ibtFollow.TabIndex = 11;
            this.ibtFollow.Text = "Theo dõi cây trồng";
            this.ibtFollow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtFollow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtFollow.UseVisualStyleBackColor = false;
            this.ibtFollow.Click += new System.EventHandler(this.ibtFollow_Click);
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
            // ibtReport
            // 
            this.ibtReport.BackColor = System.Drawing.Color.Transparent;
            this.ibtReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtReport.FlatAppearance.BorderSize = 0;
            this.ibtReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtReport.ForeColor = System.Drawing.Color.White;
            this.ibtReport.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.ibtReport.IconColor = System.Drawing.Color.White;
            this.ibtReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtReport.IconSize = 32;
            this.ibtReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtReport.Location = new System.Drawing.Point(12, 347);
            this.ibtReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ibtReport.Name = "ibtReport";
            this.ibtReport.Padding = new System.Windows.Forms.Padding(12, 1, 23, 1);
            this.ibtReport.Size = new System.Drawing.Size(264, 62);
            this.ibtReport.TabIndex = 9;
            this.ibtReport.Text = "Báo cáo";
            this.ibtReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtReport.UseVisualStyleBackColor = false;
            this.ibtReport.Click += new System.EventHandler(this.ibtReport_Click);
            this.ibtReport.MouseEnter += new System.EventHandler(this.ibt_Follow_MouseEnter);
            this.ibtReport.MouseLeave += new System.EventHandler(this.ibt_Follow_MouseLeave);
            // 
            // ibtBuy
            // 
            this.ibtBuy.BackColor = System.Drawing.Color.Transparent;
            this.ibtBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtBuy.FlatAppearance.BorderSize = 0;
            this.ibtBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtBuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtBuy.ForeColor = System.Drawing.Color.White;
            this.ibtBuy.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.ibtBuy.IconColor = System.Drawing.Color.White;
            this.ibtBuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtBuy.IconSize = 32;
            this.ibtBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtBuy.Location = new System.Drawing.Point(12, 285);
            this.ibtBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ibtBuy.Name = "ibtBuy";
            this.ibtBuy.Padding = new System.Windows.Forms.Padding(12, 1, 23, 1);
            this.ibtBuy.Size = new System.Drawing.Size(264, 62);
            this.ibtBuy.TabIndex = 8;
            this.ibtBuy.Text = "Bán hàng";
            this.ibtBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtBuy.UseVisualStyleBackColor = false;
            this.ibtBuy.Click += new System.EventHandler(this.ibtBuy_Click);
            this.ibtBuy.MouseEnter += new System.EventHandler(this.ibt_Report_MouseEnter);
            this.ibtBuy.MouseLeave += new System.EventHandler(this.ibt_Report_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(299, 127);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 554);
            this.panel3.TabIndex = 4;
            // 
            // ibtWork
            // 
            this.ibtWork.BackColor = System.Drawing.Color.Transparent;
            this.ibtWork.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtWork.FlatAppearance.BorderSize = 0;
            this.ibtWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtWork.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtWork.ForeColor = System.Drawing.Color.White;
            this.ibtWork.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.ibtWork.IconColor = System.Drawing.Color.White;
            this.ibtWork.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtWork.IconSize = 32;
            this.ibtWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtWork.Location = new System.Drawing.Point(12, 223);
            this.ibtWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ibtWork.Name = "ibtWork";
            this.ibtWork.Padding = new System.Windows.Forms.Padding(12, 1, 23, 1);
            this.ibtWork.Size = new System.Drawing.Size(264, 62);
            this.ibtWork.TabIndex = 7;
            this.ibtWork.Text = "Nghiệp vụ";
            this.ibtWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtWork.UseVisualStyleBackColor = false;
            this.ibtWork.Click += new System.EventHandler(this.ibtWork_Click);
            this.ibtWork.MouseEnter += new System.EventHandler(this.ibt_Work_MouseEnter);
            this.ibtWork.MouseLeave += new System.EventHandler(this.ibt_Work_MouseLeave);
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
            this.panelMenuLeft.Controls.Add(this.pnFind);
            this.panelMenuLeft.Controls.Add(this.picUsername);
            this.panelMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenuLeft.Name = "panelMenuLeft";
            this.panelMenuLeft.Size = new System.Drawing.Size(556, 76);
            this.panelMenuLeft.TabIndex = 24;
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
            this.txtFind.MouseEnter += new System.EventHandler(this.txtFind_MouseEnter);
            this.txtFind.MouseLeave += new System.EventHandler(this.txtFind_MouseLeave);
            // 
            // pnFind
            // 
            this.pnFind.BackColor = System.Drawing.Color.White;
            this.pnFind.Location = new System.Drawing.Point(63, 55);
            this.pnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnFind.Name = "pnFind";
            this.pnFind.Size = new System.Drawing.Size(292, 1);
            this.pnFind.TabIndex = 24;
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
        private FontAwesome.Sharp.IconButton ibtWork;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plMenuRight;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelMenuLeft;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Panel pnFind;
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.Panel panelMenuMind;
        private System.Windows.Forms.Button btnAcount;
        private FontAwesome.Sharp.IconButton ibtReport;
        private FontAwesome.Sharp.IconButton ibtBuy;
        private System.Windows.Forms.Label lbVersion;
        private FontAwesome.Sharp.IconButton ibtFollow;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton ibtBrowJob;
        private FontAwesome.Sharp.IconButton ibtHelp;
    }
}