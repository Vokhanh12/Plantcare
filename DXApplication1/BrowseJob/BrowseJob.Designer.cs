
namespace DXApplication1.BrowseJob
{
    partial class BrowseJob
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
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbE_Select = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ibtRefesh = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mRB_Save = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mRB_New = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.cH_Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH_UserPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH_Fristname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH_Lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH_EmailAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH_Dateofbirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH_Ngaydangky = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH_Tinhtrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbE_Select.Properties)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 65);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 65);
            this.panel3.TabIndex = 1;
            // 
            // cbE_Select
            // 
            this.cbE_Select.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbE_Select.Location = new System.Drawing.Point(6, 23);
            this.cbE_Select.Name = "cbE_Select";
            this.cbE_Select.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbE_Select.Properties.Appearance.Options.UseFont = true;
            this.cbE_Select.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbE_Select.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbE_Select.Size = new System.Drawing.Size(136, 28);
            this.cbE_Select.TabIndex = 14;
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(148, 23);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(136, 30);
            this.txtFind.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbE_Select);
            this.panel7.Controls.Add(this.txtFind);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(290, 71);
            this.panel7.TabIndex = 14;
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(6, 17);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(48, 39);
            this.iconButton4.TabIndex = 10;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.iconButton4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(290, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(66, 71);
            this.panel8.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(644, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(356, 71);
            this.panel6.TabIndex = 10;
            // 
            // ibtRefesh
            // 
            this.ibtRefesh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtRefesh.FlatAppearance.BorderSize = 0;
            this.ibtRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtRefesh.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.ibtRefesh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ibtRefesh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtRefesh.Location = new System.Drawing.Point(22, 16);
            this.ibtRefesh.Name = "ibtRefesh";
            this.ibtRefesh.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.ibtRefesh.Size = new System.Drawing.Size(48, 39);
            this.ibtRefesh.TabIndex = 20;
            this.ibtRefesh.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            this.iconButton6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            this.iconButton6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Location = new System.Drawing.Point(85, 17);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.iconButton6.Size = new System.Drawing.Size(48, 39);
            this.iconButton6.TabIndex = 19;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.materialLabel1);
            this.panel9.Controls.Add(this.mRB_Save);
            this.panel9.Controls.Add(this.mRB_New);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(644, 71);
            this.panel9.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ibtRefesh);
            this.panel10.Controls.Add(this.iconButton6);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(465, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(179, 71);
            this.panel10.TabIndex = 15;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 24);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "BROWSE JOB";
            // 
            // mRB_Save
            // 
            this.mRB_Save.AutoSize = true;
            this.mRB_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mRB_Save.Depth = 0;
            this.mRB_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRB_Save.Icon = null;
            this.mRB_Save.Location = new System.Drawing.Point(300, 17);
            this.mRB_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRB_Save.Name = "mRB_Save";
            this.mRB_Save.Primary = true;
            this.mRB_Save.Size = new System.Drawing.Size(56, 36);
            this.mRB_Save.TabIndex = 11;
            this.mRB_Save.Text = "Xóa";
            this.mRB_Save.UseVisualStyleBackColor = true;
            // 
            // mRB_New
            // 
            this.mRB_New.AutoSize = true;
            this.mRB_New.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mRB_New.Depth = 0;
            this.mRB_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRB_New.Icon = null;
            this.mRB_New.Location = new System.Drawing.Point(189, 17);
            this.mRB_New.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRB_New.Name = "mRB_New";
            this.mRB_New.Primary = true;
            this.mRB_New.Size = new System.Drawing.Size(75, 36);
            this.mRB_New.TabIndex = 10;
            this.mRB_New.Text = "Duyệt";
            this.mRB_New.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 71);
            this.panel4.TabIndex = 1;
            // 
            // materialListView1
            // 
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_Username,
            this.cH_UserPassword,
            this.cH_Fristname,
            this.cH_Lastname,
            this.cH_EmailAdress,
            this.cH_Dateofbirth,
            this.cH_Ngaydangky,
            this.cH_Tinhtrang});
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(0, 0);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1000, 444);
            this.materialListView1.TabIndex = 1;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // cH_Username
            // 
            this.cH_Username.Text = "Username";
            this.cH_Username.Width = 100;
            // 
            // cH_UserPassword
            // 
            this.cH_UserPassword.Text = "UserPassword";
            this.cH_UserPassword.Width = 109;
            // 
            // cH_Fristname
            // 
            this.cH_Fristname.Text = "Frist name";
            this.cH_Fristname.Width = 90;
            // 
            // cH_Lastname
            // 
            this.cH_Lastname.Text = "Last name";
            this.cH_Lastname.Width = 80;
            // 
            // cH_EmailAdress
            // 
            this.cH_EmailAdress.Text = "Địa chỉ email";
            this.cH_EmailAdress.Width = 80;
            // 
            // cH_Dateofbirth
            // 
            this.cH_Dateofbirth.Text = "Năm sinh";
            this.cH_Dateofbirth.Width = 134;
            // 
            // cH_Ngaydangky
            // 
            this.cH_Ngaydangky.Text = "Ngày đăng ký";
            this.cH_Ngaydangky.Width = 113;
            // 
            // cH_Tinhtrang
            // 
            this.cH_Tinhtrang.Text = "Tình trạng";
            this.cH_Tinhtrang.Width = 97;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 580);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.materialListView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1000, 444);
            this.panel5.TabIndex = 0;
            // 
            // BrowseJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.panel1);
            this.Name = "BrowseJob";
            this.Text = "BrowseJob";
            this.Load += new System.EventHandler(this.BrowseJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbE_Select.Properties)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.ComboBoxEdit cbE_Select;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton ibtRefesh;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton mRB_Save;
        private MaterialSkin.Controls.MaterialRaisedButton mRB_New;
        private System.Windows.Forms.Panel panel4;
        public MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader cH_Username;
        private System.Windows.Forms.ColumnHeader cH_UserPassword;
        private System.Windows.Forms.ColumnHeader cH_Fristname;
        private System.Windows.Forms.ColumnHeader cH_Lastname;
        private System.Windows.Forms.ColumnHeader cH_EmailAdress;
        private System.Windows.Forms.ColumnHeader cH_Dateofbirth;
        private System.Windows.Forms.ColumnHeader cH_Ngaydangky;
        private System.Windows.Forms.ColumnHeader cH_Tinhtrang;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
    }
}