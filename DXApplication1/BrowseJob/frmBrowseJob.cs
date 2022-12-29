using Dapper;
using DevExpress.XtraEditors;
using DXApplication1.FolderMajor;
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

namespace DXApplication1.BrowseJob
{
    public partial class frmBrowseJob : MaterialSkin.Controls.MaterialForm
    {

        public static frmBrowseJob instance;

        public sqlOpen sql = new sqlOpen();

        public frmBrowseJob()
        {
            InitializeComponent();

            
            

            instance = this;


        }

        public void openSQL()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<BrowseJobDTO>("SELECT * FROM DATA_APPLICATION_REGISTER", commandType: CommandType.Text);
                materialListView1.Items.Clear();
                foreach (BrowseJobDTO p in data)
                {

                    ListViewItem item = new ListViewItem(p.UserName);

                    item.SubItems.Add("●●●●●●●●");//item.SubItem.Add(p.UserPassword);
                    
                    item.SubItems.Add(p.FristName);
                    item.SubItems.Add(p.LastName);
                    item.SubItems.Add(p.EmailAdress);
                    item.SubItems.Add(p.Date_of_birth.ToString());
                    item.SubItems.Add(p.NGAY_DANG_KY.ToString());
                    item.SubItems.Add(p.TAI_KHOANG);
                    item.SubItems.Add(p.TINH_TRANG);
                    materialListView1.Items.Add(item);

                }


                db.Close();
            }
        }

        public void sqlDelete()
        {

        }

        private void BrowseJob_Load(object sender, EventArgs e)
        {
            materialListView1.Columns[0].Width = 170;
            materialListView1.Columns[1].Width = 170;
            materialListView1.Columns[2].Width = 130;
            materialListView1.Columns[3].Width = 110;
            materialListView1.Columns[4].Width = 150;
            materialListView1.Columns[5].Width = 180;
            materialListView1.Columns[6].Width = 180;
            materialListView1.Columns[7].Width = 120;
            materialListView1.Columns[8].Width = 120;


            sql.Select(materialListView1);


        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mRB_Save_Click(object sender, EventArgs e)
        {

        }

        private void mRB_New_Click(object sender, EventArgs e)
        {
            /* newFormSave newfrmSave = new newFormSave();
             newfrmSave.Show();

             fsEdit edit = new fsEdit();

             try
             {
                 //newFormSave.instance.txtID_A.Text = materialListView1.SelectedItems[0].SubItems[0].ToString();
                 // newFormSave.instance.txtUsercode_A.Text = materialListView1.SelectedItems[0].SubItems[0].ToString();
                 //newFormSave.instance.txtNameUser_A.Text = materialListView1.SelectedItems[0].SubItems[1].ToString();

                 newFormSave.instance.txtUsername_A.Text = edit.deleteCharacter1(materialListView1.SelectedItems[0].SubItems[0].ToString());
                 newFormSave.instance.txtUserpassword_A.Text = "********";
                 //newFormSave.instance.txtUserpassword_A.Text = materialListView1.SelectedItems[0].SubItems[1].ToString();

                 newFormSave.instance.txtFristName_A.Text = edit.deleteCharacter1(materialListView1.SelectedItems[0].SubItems[2].ToString());
                 newFormSave.instance.txtLastName_A.Text = edit.deleteCharacter1(materialListView1.SelectedItems[0].SubItems[3].ToString());
                 newFormSave.instance.txtEmail_A.Text = edit.deleteCharacter1(materialListView1.SelectedItems[0].SubItems[4].ToString());
                 newFormSave.instance.txtDOB_A.Text = edit.deleteCharacter1(materialListView1.SelectedItems[0].SubItems[5].ToString());
                 newFormSave.instance.txtNDK_A.Text = edit.deleteCharacter1(materialListView1.SelectedItems[0].SubItems[6].ToString());

                 newFormSave.instance.txtSDT_A.Text = "+84";


             }
             catch (Exception ex)
             {
                 MessageBox.Show("Nhap click vao ban de chinh sua");
             }
            */

            sql.jobAccept(materialListView1);





        }
    }
}