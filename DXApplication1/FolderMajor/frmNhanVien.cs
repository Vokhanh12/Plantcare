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

namespace DXApplication1.FolderNV
{
    public partial class frmNhanVien : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        public string deleteCharacter(string delete)
        {
            //ListViewItem:{need}
            
            string ItemLength = delete.Substring(13);
            string character = "ABCDFGHJKLQWERTYUIOPZXCVBNM0123456789 ";


            string ItemChanged = "";
            for(int i = 0; i < ItemLength.Length; i++)
            {
                for(int j = 0; j < character.Length; j++)
                {
                    if(character[j] == ItemLength[i])
                    {
                        ItemChanged += character[j];
                        break;
                    }
                }
            }
            return ItemChanged;
          
        }
        public void OpenSql()
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
                    item.SubItems.Add(p.MONEY.ToString());
                    item.SubItems.Add(p.THUONG.ToString());
                    item.SubItems.Add(p.GIOITINH.ToString());
                    item.SubItems.Add(p.NGAYSINH);
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

        public void RemoveEmplyeeSql()
        {
            var MANV = deleteCharacter(materialListView1.SelectedItems[0].ToString());
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var Count = db.ExecuteAsync($"DELETE FROM NHANVIEN WHERE MANV='{MANV.Replace(" ","")}'",commandType: CommandType.Text);
                materialListView1.Items.Remove(materialListView1.SelectedItems[0]);
                MessageBox.Show($"Xoa thanh cong");
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

     

            OpenSql();
            
        }
        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {

            
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            RemoveEmplyeeSql();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (materialListView1.Items.Count > 0)
                {
                    materialListView1.Items.Remove(materialListView1.SelectedItems[0]);
                }
                else MessageBox.Show("The Items haven't been activited in the table ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phease choose click in the table");
            }
           
        }
    }
}
