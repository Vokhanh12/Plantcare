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


        public void Delete(MaterialListView frmListview, TextBox txtName)
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
                    frmListview.Items.Add(item);

                }

                db.Close();
            }
        }

        public void jobAccept(MaterialListView frmListview)
        {

            fsEdit edit = new fsEdit();

            try
            {
                //newFormSave.instance.txtID_A.Text = materialListView1.SelectedItems[0].SubItems[0].ToString();
                // newFormSave.instance.txtUsercode_A.Text = materialListView1.SelectedItems[0].SubItems[0].ToString();
                //newFormSave.instance.txtNameUser_A.Text = materialListView1.SelectedItems[0].SubItems[1].ToString();

                newFormSave.instance.txtUsername_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.mlvBrowse_A.SelectedItems[0].SubItems[0].ToString());
                newFormSave.instance.txtUserpassword_A.Text = "********";
                //newFormSave.instance.txtUserpassword_A.Text = materialListView1.SelectedItems[0].SubItems[1].ToString();

                newFormSave.instance.txtFristName_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.mlvBrowse_A.SelectedItems[0].SubItems[2].ToString());
                newFormSave.instance.txtLastName_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.mlvBrowse_A.SelectedItems[0].SubItems[3].ToString());
                newFormSave.instance.txtEmail_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.mlvBrowse_A.SelectedItems[0].SubItems[4].ToString());
                newFormSave.instance.txtDOB_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.mlvBrowse_A.SelectedItems[0].SubItems[5].ToString());
                newFormSave.instance.txtNDK_A.Text = edit.deleteCharacter1(frmBrowseJob.instance.mlvBrowse_A.SelectedItems[0].SubItems[6].ToString());

                newFormSave.instance.txtSDT_A.Text = "+84";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap click vao ban de chinh sua");
            }



            string ID = newFormSave.instance.txtID_A.Text;
            string Usercode = newFormSave.instance.txtUsercode_A.Text;
            string Nameuser = newFormSave.instance.txtNameUser_A.Text;
            string Username = newFormSave.instance.txtUsername_A.Text;
            string Userpassword = newFormSave.instance.txtUserpassword_A.Text;
            string Fristname = newFormSave.instance.txtFristName_A.Text;
            string Lastname = newFormSave.instance.txtLastName_A.Text;
            string EmailAdress = newFormSave.instance.txtEmail_A.Text;
            string SDT_USER = newFormSave.instance.txtSDT_A.Text;
            string DateofBirth = newFormSave.instance.txtDOB_A.Text;
            string NGAY_DANG_KY = newFormSave.instance.txtNDK_A.Text;
            string TAI_KHOANG = newFormSave.instance.cbBrowse_A.Text;




            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();

                // get item in DATA_APPLICATION_USER
                var dataAP_USER = db.ExecuteAsync($"SET IDENTITY_INSERT dbo.DATA_APPLICATION_USER ON INSERT INTO dbo.DATA_APPLICATION_USER(ID,UserName,UserPassword,TAI_KHOANG) SELECT '{ID}','{Username}','{Userpassword}','{TAI_KHOANG}' SET IDENTITY_INSERT dbo.DATA_APPLICATION_USER OFF", commandType: CommandType.Text);

                /* var DataUsername = db.Query<BrowseJobDTO>("SELECT ncc.ID,mcc.UserName FROM DATA_APPLICATION_REGISTER mcc,DATA_APPLICATION_USER ncc WHERE ncc.UserName=mcc.UserName", commandType: CommandType.Text);

                 foreach (BrowseJobDTO p in DataUsername)
                 {
                     if (Username == p.UserName)
                     {
                         MessageBox.Show("Đã có người đặt Username này");
                         break;
                     }
                     else if (ID == p.ID)
                     {
                         MessageBox.Show("Đã có người đặt ID này");
                         break;
                     }
                     else if (TAI_KHOANG == "Manager")
                     {
                         var dataManager = db.ExecuteAsync($"SET IDENTITY_INSERT dbo.DATA_APPLICATION_FOR_EMPLOYEE ON INSERT INTO dbo.DATA_APPLICATION_FOR_EMPLOYEE (ID,MaNV,TenNV,UserName,UserPassword,FristName,LastName,EmailAdress,SDT_EMPLOYEE,TAI_KHOANG,NGAY_DANG_KY) SELECT DATA_APPLICATION_USER.ID,'{Usercode}','{Nameuser}', DATA_APPLICATION_USER.UserName, DATA_APPLICATION_USER.UserPassword,'{Fristname}','{Lastname}','{EmailAdress}','{SDT_USER}',DATA_APPLICATION_USER.TAI_KHOANG,'{NGAY_DANG_KY}' FROM DATA_APPLICATION_USER WHERE DATA_APPLICATION_USER.ID={ID} and DATA_APPLICATION_USER.UserName='{Username}'; SET IDENTITY_INSERT dbo.DATA_APPLICATION_FOR_EMPLOYE OFF ", commandType: CommandType.Text);
                         MessageBox.Show("Duyệt thành công");
                         break;
                     }
                     else if (TAI_KHOANG == "Employee")
                     {
                         var dataEmployee = db.ExecuteAsync($"SET IDENTITY_INSERT dbo.DATA_APPLICATION_FOR_MANAGER ON INSERT INTO dbo.DATA_APPLICATION_FOR_MANAGER (ID,MaQL,TenQL,UserName,UserPassword,FristName,LastName,EmailAdress,SDT_MANAGER,TAI_KHOANG,NGAY_DANG_KY) SELECT DATA_APPLICATION_USER.ID,'{Usercode}','{Nameuser}', DATA_APPLICATION_USER.UserName, DATA_APPLICATION_USER.UserPassword,'{Fristname}','{Lastname}','{EmailAdress}','{SDT_USER}',DATA_APPLICATION_USER.TAI_KHOANG,'{NGAY_DANG_KY}' FROM DATA_APPLICATION_USER WHERE DATA_APPLICATION_USER.ID={ID} and DATA_APPLICATION_USER.UserName='{Username}'; SET IDENTITY_INSERT dbo.DATA_APPLICATION_FOR_EMPLOYE OFF ", commandType: CommandType.Text);
                         MessageBox.Show("Duyệt thành công");
                         break;
                     }



                 }
                */

                var dataManager = db.ExecuteAsync($"SET IDENTITY_INSERT dbo.DATA_APPLICATION_FOR_EMPLOYEE ON INSERT INTO dbo.DATA_APPLICATION_FOR_EMPLOYEE (ID,MaNV,TenNV,UserName,UserPassword,FristName,LastName,EmailAdress,SDT_EMPLOYEE,TAI_KHOANG,NGAY_DANG_KY) SELECT DATA_APPLICATION_USER.ID,'{Usercode}','{Nameuser}', DATA_APPLICATION_USER.UserName, DATA_APPLICATION_USER.UserPassword,'{Fristname}','{Lastname}','{EmailAdress}','{SDT_USER}',DATA_APPLICATION_USER.TAI_KHOANG,'{NGAY_DANG_KY}' FROM DATA_APPLICATION_USER WHERE DATA_APPLICATION_USER.ID={ID} and DATA_APPLICATION_USER.UserName='{Username}'", commandType: CommandType.Text);
                MessageBox.Show("Duyệt thành công");



                db.Close();

            }
        }

    }
}







   
