using Dapper;
using DXApplication1.FolderMajor;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.BrowseJob
{
   public class sqlOpen
    {
        public string nameAction;

        public string TINH_TRANG;


        public void Delete(MaterialListView frmListview,TextBox txtName)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.ExecuteAsync($"DELETE DATA_APPLICAION_REGISTER WHERE Username='{txtName.Text}'", commandType: CommandType.Text);
                
                db.Close();
            }
        }

        public void Select(MaterialListView frmListview)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<BrowseJobDTO>("SELECT * FROM DATA_APPLICATION_REGISTER", commandType: CommandType.Text);

                foreach(BrowseJobDTO p in data)
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
                    frmListview.Items.Add(item);

                    TINH_TRANG = p.TINH_TRANG;

                }

                db.Close();
            }
        }

        public void jobAccept(MaterialListView frmListview)
        {

             newFormSave newfrmSave = new newFormSave();
             newfrmSave.Show();

             fsEdit edit = new fsEdit();

             try
             {
                 //newFormSave.instance.txtID_A.Text = materialListView1.SelectedItems[0].SubItems[0].ToString();
                 // newFormSave.instance.txtUsercode_A.Text = materialListView1.SelectedItems[0].SubItems[0].ToString();
                 //newFormSave.instance.txtNameUser_A.Text = materialListView1.SelectedItems[0].SubItems[1].ToString();

                 newFormSave.instance.txtUsername_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.materialListView1.SelectedItems[0].SubItems[0].ToString());
                 newFormSave.instance.txtUserpassword_A.Text = "********";
                 //newFormSave.instance.txtUserpassword_A.Text = materialListView1.SelectedItems[0].SubItems[1].ToString();

                 newFormSave.instance.txtFristName_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.materialListView1.SelectedItems[0].SubItems[2].ToString());
                 newFormSave.instance.txtLastName_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.materialListView1.SelectedItems[0].SubItems[3].ToString());
                 newFormSave.instance.txtEmail_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.materialListView1.SelectedItems[0].SubItems[4].ToString());
                 newFormSave.instance.txtDOB_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.materialListView1.SelectedItems[0].SubItems[5].ToString());
                 newFormSave.instance.txtNDK_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.materialListView1.SelectedItems[0].SubItems[6].ToString());

                 newFormSave.instance.txtSDT_A.Text = "+84";


             }
             catch (Exception ex)
             {
                 MessageBox.Show("Nhap click vao ban de chinh sua");
             }


            try
            {
                    var ID= newFormSave.instance.txtID_A.Text;
                    var Usercode = newFormSave.instance.txtUsercode_A.Text;
                    var Nameuser = newFormSave.instance.txtNameUser_A.Text;
                    var Username = newFormSave.instance.txtUsername_A.Text;
                    var Userpassword = newFormSave.instance.txtUserpassword_A.Text;
                    var Fristname = newFormSave.instance.txtFristName_A.Text;
                    var Lastname = newFormSave.instance.txtLastName_A.Text;
                    var EmailAdress = newFormSave.instance.txtEmail_A.Text;
                    var DateofBirth = newFormSave.instance.txtDOB_A.Text;
                    var NGAY_DANG_KY = newFormSave.instance.txtNDK_A.Text;
                    var TAI_KHOANG = newFormSave.instance.cbBrowse_A.Text;
                   



                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
                {
                    if (TINH_TRANG == "CHƯA DUYỆT")
                    {

                        if (db.State == ConnectionState.Closed)
                            db.Open();


                        if (TINH_TRANG == "Mannager")
                        {
                            var dataManager = db.Query<BrowseJobDTO>("INSERT INTO DATA_APPLICATION_FOR_MANAGER", commandType: CommandType.Text);

                        }

                        if (TINH_TRANG == "Employee")
                        {
                            var dataEmployee = db.Query<BrowseJobDTO>("INSERT INTO DATA_APPLICATION_FOR_EMPLOYEE", commandType: CommandType.Text);

                        }




                    }
                }
            }
            catch(Exception ex)
            {

            }
        }








    }
}
