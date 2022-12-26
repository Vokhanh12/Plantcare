using DevExpress.XtraEditors;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DXApplication1.FolderMajor;
using MaterialSkin.Controls;
using System.Globalization;

namespace DXApplication1.FolderNV
{
    public partial class frmNhanVien : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        fsEdit Edit = new fsEdit();

        public MaterialListView mLV;

        public string casechange;

        public static frmNhanVien instance;

        public Button btn;


        public virtual void OpenListview(string str)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<NhanvienDTO>($"SELECT * FROM NHANVIEN WHERE {str}='{txtFind.Text}'", commandType: CommandType.Text);
                materialListView1.Items.Clear();
                foreach (NhanvienDTO p in data)
                {

                    ListViewItem item = new ListViewItem(p.MANV.ToString());
                    item.SubItems.Add(p.TENNV);
                    item.SubItems.Add(p.LUONG.ToString());
                    item.SubItems.Add(p.THUONG.ToString());
                    item.SubItems.Add(p.GIOITINH.ToString());
                    item.SubItems.Add(p.NGAYSINH.ToString());
                    item.SubItems.Add(p.SDT_EMPLOYEE);
                    item.SubItems.Add(p.SOTHICH);
                    item.SubItems.Add(p.DIACHI);
                    materialListView1.Items.Add(item);

                }
                db.Close();
            }
        }

        public virtual void OpenSql()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<NhanvienDTO>("SELECT * FROM NHANVIEN", commandType: CommandType.Text);
                materialListView1.Items.Clear();
                foreach (NhanvienDTO p in data)
                {

                    ListViewItem item = new ListViewItem(p.MANV.ToString());
                    item.SubItems.Add(p.TENNV);
                    item.SubItems.Add(p.LUONG.ToString());
                    item.SubItems.Add(p.THUONG.ToString());
                    item.SubItems.Add(p.GIOITINH.ToString());
                    item.SubItems.Add(p.NGAYSINH.ToString());
                    item.SubItems.Add(p.SDT_EMPLOYEE);
                    item.SubItems.Add(p.SOTHICH);
                    item.SubItems.Add(p.DIACHI);
                    materialListView1.Items.Add(item);

                }
                db.Close();
            }
        }

        public void AddEmployeSql()
        {
            int count = 0;

            try
            {
                var MANV = New_FormSave.instance.txt0.Text;
                var TENNV = New_FormSave.instance.txt1.Text;
                var LUONG = (Convert.ToDecimal((((New_FormSave.instance.txt2.Text).Replace(" ₫", "")).Replace(".", "")).Replace(",", ""))).ToString();
                var THUONG = (Convert.ToDecimal((New_FormSave.instance.txt3.Text).Replace(" %", "")) / 100).ToString();
                var GIOITINH = New_FormSave.instance.txt4.Text;
                var NGAYSINH = New_FormSave.instance.dtNgaysinh.Text;
                var SDT = New_FormSave.instance.txt6.Text;
                var SOTHICH = New_FormSave.instance.txt7.Text;
                var DIACHI = New_FormSave.instance.txt8.Text;
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();


                    for (var i = 0; i <= materialListView1.Items.Count - 1; i++)
                    {
                        //Check Listview had items in listView
                        if (MANV.ToString() == (Edit.deleteCharacter(materialListView1.Items[0].SubItems[0].ToString())).Replace(" ", ""))
                        {
                            MessageBox.Show($"Da co { (Edit.deleteCharacter(materialListView1.Items[0].SubItems[0].ToString())).Replace(" ", "")} vui long nhap 'MANV' khac");
                            break;
                        }
                        else
                        {

                            count++;

                            if (count == materialListView1.Items.Count)
                            {
                                db.ExecuteAsync($"Insert into NHANVIEN(MANV,TENNV,LUONG,THUONG,GIOITINH,NGAYSINH,SDT_EMPLOYEE,SOTHICH,DIACHI) values ('{MANV}','{TENNV}',{LUONG},{THUONG},'{GIOITINH}','{NGAYSINH}','{SDT}','{SOTHICH}','{DIACHI}');", commandType: CommandType.Text);
                                MessageBox.Show($"Add success");
                            }

                        };

                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro:{ex} ");
            }


        }

        public void RemoveEmployeeSql()
        {
            var MANV = materialListView1.SelectedItems[0].SubItems[0].Text;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var Count = db.ExecuteAsync($"DELETE FROM NHANVIEN WHERE MANV='{MANV}'", commandType: CommandType.Text);
                materialListView1.Items.Remove(materialListView1.SelectedItems[0]);
                MessageBox.Show($"Xoa thanh cong");
            }



        }
        public void editEmployee()
        {

            var MANV = New_FormSave.instance.txt0.Text;
            var TENNV = New_FormSave.instance.txt1.Text;
            var LUONG = (Convert.ToDecimal((((New_FormSave.instance.txt2.Text).Replace(" ₫", "")).Replace(".", "")).Replace(",", "")) / 100).ToString();
            var THUONG = (Convert.ToDecimal((New_FormSave.instance.txt3.Text).Replace(" %", "")) / 100).ToString();
            var GIOITINH = New_FormSave.instance.txt4.Text;
            var NGAYSINH = New_FormSave.instance.dtNgaysinh.Text;
            var SDT = New_FormSave.instance.txt6.Text;
            var SOTHICH = New_FormSave.instance.txt7.Text;
            var DIACHI = New_FormSave.instance.txt8.Text;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var Count = db.ExecuteAsync($"UPDATE NHANVIEN SET MANV = '{MANV}',TENNV='{TENNV}',LUONG={LUONG},THUONG={THUONG},GIOITINH='{GIOITINH}',NGAYSINH='{NGAYSINH}',SDT_EMPLOYEE='{SDT}',SOTHICH='{SOTHICH}',DIACHI='{DIACHI}' WHERE MANV='{MANV}'");
                MessageBox.Show($"Edit succes");
            }
        }


        //Design Form
        public void Design_frmNV()
        {
            materialListView1.Columns[0].Width = 140;
            materialListView1.Columns[1].Width = 140;
            materialListView1.Columns[2].Width = 110;
            materialListView1.Columns[3].Width = 90;
            materialListView1.Columns[4].Width = 100;
            materialListView1.Columns[5].Width = 130;
            materialListView1.Columns[6].Width = 130;
            materialListView1.Columns[7].Width = 120;
            materialListView1.Columns[8].Width = 150;
        }
        public frmNhanVien()
        {
            InitializeComponent();




            //Design MarterialListview
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo900, Primary.Indigo700, Accent.Indigo700, TextShade.WHITE);

            //Deign form size
            Design_frmNV();

            mLV = materialListView1;

            OpenSql();

        }


        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string specifier;
            CultureInfo culture;
            New_FormSave frmSave = new New_FormSave();
            casechange = "Add";

            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            frmSave.Show();



        }


        private void iconButton5_Click(object sender, EventArgs e)
        {
            New_FormSave frmSave = new New_FormSave();
            frmSave.Show();
            casechange = "Edit";
            string specifier;
            CultureInfo culture;

            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            try
            {
                New_FormSave.instance.txt0.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[0].ToString().Replace(" ", ""));
                New_FormSave.instance.txt1.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[1].ToString());

                //Lương
                New_FormSave.instance.txt2.Text = String.Format(info, "{0:c}", Convert.ToDecimal(Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[2].ToString())) / 10000);

                //Thưởng = %
                specifier = "P";
                culture = CultureInfo.InvariantCulture;
                New_FormSave.instance.txt3.Text = (Convert.ToDouble(Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[3].ToString())) / 100).ToString(specifier, culture);
                // Displays:    #.00 %

                New_FormSave.instance.txt4.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[4].ToString().Replace(" ", ""));
                New_FormSave.instance.dtNgaysinh.DateTime = Convert.ToDateTime(((((frmNhanVien.instance.mLV.SelectedItems[0].SubItems[5].ToString()).Substring(17)).Replace("{", "")).Replace("}", "")));

                //txt5.Text = Edit.deleteCharacter(frmNhanVien.instance.materialListView1.SelectedItems[0].SubItems[5].ToString());
                New_FormSave.instance.txt6.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[6].ToString());
                New_FormSave.instance.txt7.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[7].ToString());
                New_FormSave.instance.txt8.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[8].ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap click vao ban de chinh sua");
                this.Close();
            }


        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + materialListView1.Items.Count);
        }

        private void mRB_New_Click(object sender, EventArgs e)
        {
            string specifier;
            CultureInfo culture;
            New_FormSave frmSave = new New_FormSave();
            casechange = "Add";

            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            frmSave.Show();
        }

        private void mRB_Save_Click(object sender, EventArgs e)
        {
            switch (casechange)
            {
                case "Edit":
                    editEmployee();
                    break;
                case "Add":
                    AddEmployeSql();
                    break;

                default:
                    MessageBox.Show("Erro");
                    break;
            }
        }

        private void ibtDelete_Click(object sender, EventArgs e)
        {
            RemoveEmployeeSql();
        }

        private void ibtEdit_Click(object sender, EventArgs e)
        {
            New_FormSave frmSave = new New_FormSave();
            frmSave.Show();
            casechange = "Edit";
            string specifier;
            CultureInfo culture;

            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            try
            {
                New_FormSave.instance.txt0.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[0].ToString().Replace(" ", ""));
                New_FormSave.instance.txt1.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[1].ToString());

                //Lương
                New_FormSave.instance.txt2.Text = String.Format(info, "{0:c}", Convert.ToDecimal(Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[2].ToString())) / 10000);

                //Thưởng = %
                specifier = "P";
                culture = CultureInfo.InvariantCulture;
                New_FormSave.instance.txt3.Text = (Convert.ToDouble(Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[3].ToString())) / 100).ToString(specifier, culture);
                // Displays:    #.00 %

                New_FormSave.instance.txt4.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[4].ToString().Replace(" ", ""));
                New_FormSave.instance.dtNgaysinh.DateTime = Convert.ToDateTime(((((frmNhanVien.instance.mLV.SelectedItems[0].SubItems[5].ToString()).Substring(17)).Replace("{", "")).Replace("}", "")));

                //txt5.Text = Edit.deleteCharacter(frmNhanVien.instance.materialListView1.SelectedItems[0].SubItems[5].ToString());
                New_FormSave.instance.txt6.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[6].ToString());
                New_FormSave.instance.txt7.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[7].ToString());
                New_FormSave.instance.txt8.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[8].ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap click vao ban de chinh sua");
                this.Close();
            }
        }
       
        //Load form
        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            //Add Items for comboBox
            cbE_Select.Properties.Items.Add("MANV");
            cbE_Select.Properties.Items.Add("TENNV");
            cbE_Select.Properties.Items.Add("LUONG");
            cbE_Select.Properties.Items.Add("THUONG");
            cbE_Select.Properties.Items.Add("GIOITINH");
            cbE_Select.Properties.Items.Add("NGAYSINH");
            cbE_Select.Properties.Items.Add("SDT");
            cbE_Select.Properties.Items.Add("SOTHICH");
            cbE_Select.Properties.Items.Add("DIACHI");
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenListview(cbE_Select.SelectedItem.ToString());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // frmNhanVien newfrmNhanvien = new frmNhanVien();
            //if (string.Equals((sender as Button).Name, @"CloseButton"))
            
            
         // Then assume that X has been clicked and act accordingly.
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ibtRefesh_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbE_Select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimeChartRangeControlClient1_CustomizeSeries(object sender, ClientDataSourceProviderCustomizeSeriesEventArgs e)
        {

        }
    }
}
