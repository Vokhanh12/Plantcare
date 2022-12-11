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

namespace DXApplication1.FolderNV
{
    public partial class frmNhanVien : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        fsEdit Edit = new fsEdit();

        public MaterialListView mLV;

        public static frmNhanVien instance;
        


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
            using(IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var Count = db.ExecuteAsync("Insert into NHANVIEN(MANV,TENNV,LUONG,THUONG,GIOITINH,NGAYSINH,SDT_EMPLOYEE,SOTHICH,DIACHI) values ('NV22','TRAN VAN SANG',7200000,0.03,'NAM','5/31/1998','01246469289','NGHE NHAC','TIEN GIANG');",commandType:CommandType.Text);
                MessageBox.Show($"Them thanh cong {Count} rows.");
            }

        }

        public void RemoveEmployeeSql()
        {
          
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var Count = db.ExecuteAsync($"DELETE FROM NHANVIEN WHERE MANV=''",commandType: CommandType.Text);
                materialListView1.Items.Remove(materialListView1.SelectedItems[0]);
                MessageBox.Show($"Xoa thanh cong");
            }
         
          
        }
        public void editEmployee()
        {
            var MANV = New_FormSave.instance.txt0.Text;

            var TENNV = New_FormSave.instance.txt1.Text;
            var LUONG = Convert.ToDecimal((((New_FormSave.instance.txt2.Text).Replace(" ₫","")).Replace(".","")).Replace(",",""));
            var THUONG = Convert.ToDecimal((New_FormSave.instance.txt3.Text).Replace(" %",""))/100;      
            var GIOITINH = New_FormSave.instance.txt4.Text;
            var NGAYSINH = New_FormSave.instance.dtNgaysinh.Text;
            var SDT = New_FormSave.instance.txt6.Text;
            var SOTHICH = New_FormSave.instance.txt7.Text;
            var DIACHI =New_FormSave.instance.txt8.Text;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                // var Count = db.ExecuteAsync($"UPDATE NHANVIEN SET MANV = '{MANV}',TENNV='{TENNV}',LUONG={LUONG},THUONG={THUONG},GIOITINH='{GIOITINH}',NGAYSINH='{NGAYSINH}',SDT_EMPLOYEE='{SDT}',SOTHICH='{SOTHICH}',DIACHI='{DIACHI}' WHERE MANV='{MANV}'");
                var Count = db.ExecuteAsync($"UPDATE NHANVIEN SET MANV = '{MANV}',TENNV='{TENNV}',LUONG={LUONG},THUONG={THUONG},GIOITINH='{GIOITINH}',NGAYSINH='{NGAYSINH}',SDT_EMPLOYEE='{SDT}',SOTHICH='{SOTHICH}',DIACHI='{DIACHI}' WHERE MANV='{MANV}'");
                MessageBox.Show($"Edit succes {Count} rows.");
            }
        }

      

        public void  Design_frmNV()
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

            instance = this;

            //Design MarterialListview
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue900, Accent.Blue200, TextShade.BLACK);


            materialListView1.Columns[0].Width = 140;
            materialListView1.Columns[1].Width = 140;
            materialListView1.Columns[2].Width = 110;
            materialListView1.Columns[3].Width = 90;
            materialListView1.Columns[4].Width = 100;
            materialListView1.Columns[5].Width = 130;
            materialListView1.Columns[6].Width = 130;
            materialListView1.Columns[7].Width = 120;
            materialListView1.Columns[8].Width = 150;

            mLV = materialListView1;

            OpenSql();



        }

       

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {

            
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            editEmployee();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            New_FormSave frmSave = new New_FormSave();
            frmSave.Show();
            
            
            

            
            







        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dateTimeChartRangeControlClient1_CustomizeSeries(object sender, ClientDataSourceProviderCustomizeSeriesEventArgs e)
        {

        }
    }
}
