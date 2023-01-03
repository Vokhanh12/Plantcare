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


        public void delaceData(IDbConnection db)
        {
             var dataEmployee = db.ExecuteAsync($" SET IDENTITY_INSERT dbo.DATA_APPLICATION_FOR_MANAGER ON " +
             " INSERT INTO dbo.DATA_APPLICATION_FOR_MANAGER (ID,MaQL,TenQL,UserName,UserPassword,FristName,LastName,EmailAdress,SDT_MANAGER,TAI_KHOANG,NGAY_DANG_KY) " +
             " OUTPUT inserted.ID, inserted.MaQL, inserted.UserName,inserted.UserPassword,inserted.FristName,inserted.LastName,inserted.FristName,inserted.SDT_MANAGER,inserted.TAI_KHOANG,inserted.NGAY_DANG_KY " +
           " SELECT DATA_APPLICATION_USER.ID,'QL03','NGUYEN TRUNG KHANH', DATA_APPLICATION_USER.UserName, DATA_APPLICATION_USER.UserPassword,'NGUYEN','KHANH','KHANH2002@gmail.com','0909090909',DATA_APPLICATION_USER.TAI_KHOANG,'12/21/2022' FROM dbo.DATA_APPLICATION_REGISTER,dbo.DATA_APPLICATION_USER WHERE DATA_APPLICATION_USER.ID=9 AND DATA_APPLICATION_REGISTER.UserName='rongchoi9'", commandType: CommandType.Text);
             MessageBox.Show("Duyệt thành công");
        }

        public void Delete(MaterialListView frmListview,string txtName)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.ExecuteAsync($"DELETE DATA_APPLICAION_REGISTER WHERE Username='{txtName}'", commandType: CommandType.Text);

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
                //newFormSave.instance.txtUserpassword_A.Text = "********";
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



            string _ID = newFormSave.instance.txtID_A.Text;
            string _Usercode = newFormSave.instance.txtUsercode_A.Text;
            string _Nameuser = newFormSave.instance.txtNameUser_A.Text;
            string _Username = newFormSave.instance.txtUsername_A.Text;
            string _Userpassword = newFormSave.instance.txtUserpassword_A.Text;
            string _Fristname = newFormSave.instance.txtFristName_A.Text;
            string _Lastname = newFormSave.instance.txtLastName_A.Text;
            string _EmailAdress = newFormSave.instance.txtEmail_A.Text;
            string _SDT_USER = newFormSave.instance.txtSDT_A.Text;
            string _DateofBirth = newFormSave.instance.txtDOB_A.Text;
            string _NGAY_DANG_KY = newFormSave.instance.txtNDK_A.Text;
            string _TAI_KHOANG = newFormSave.instance.cbBrowse_A.Text;




            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var data = db.Query<CheckDTO>("SELECT * FROM DATA_APPLICATION_USER", commandType: CommandType.Text);

                    var dataAP_USER = db.Execute($"SET IDENTITY_INSERT dbo.DATA_APPLICATION_USER ON INSERT INTO dbo.DATA_APPLICATION_USER(ID,UserName,UserPassword,TAI_KHOANG) SELECT '{_ID}','{_Username}',PWDENCRYPT('{_Userpassword}'),'{_TAI_KHOANG}' SET IDENTITY_INSERT dbo.DATA_APPLICATION_USER OFF UPDATE DATA_APPLICATION_REGISTER "
                            +" SET TINH_TRANG = 'DA DUYET' "
                            +$" WHERE UserName = '{_Username}' ", commandType: CommandType.Text);

                    //get item in DATA_APPLICATION_USER
                    foreach (CheckDTO p in data)
                    {
                        if (_Username == p.UserName)
                        {
                            MessageBox.Show("Đã có người đặt Username này\nVui lòng đặt Username lại");
                            break;
                        }
                        else if (_ID == p.ID)
                        {
                            MessageBox.Show("Đã có người đặt ID này\nVui lòng đặt ID lại ");
                            break;
                        }
                        else if (_TAI_KHOANG == "MANAGER")
                        {

                            var dataManager = db.ExecuteAsync($" SET IDENTITY_INSERT dbo.DATA_APPLICATION_FOR_MANAGER ON " +
        " INSERT INTO dbo.DATA_APPLICATION_FOR_MANAGER (ID,MaQL,TenQL,UserName,UserPassword,FristName,LastName,EmailAdress,SDT_MANAGER,TAI_KHOANG,NGAY_DANG_KY) " +
        " OUTPUT inserted.ID, inserted.MaQL, inserted.UserName,inserted.UserPassword,inserted.FristName,inserted.LastName,inserted.FristName,inserted.SDT_MANAGER,inserted.TAI_KHOANG,inserted.NGAY_DANG_KY " +
      $" SELECT DATA_APPLICATION_USER.ID,'{_Usercode}','{_Nameuser}', DATA_APPLICATION_USER.UserName, DATA_APPLICATION_USER.UserPassword,'{_Fristname}','{_Lastname}','{_EmailAdress}','{_SDT_USER}',DATA_APPLICATION_USER.TAI_KHOANG,'{_NGAY_DANG_KY}' FROM dbo.DATA_APPLICATION_REGISTER,dbo.DATA_APPLICATION_USER WHERE DATA_APPLICATION_USER.ID={_ID} AND DATA_APPLICATION_REGISTER.UserName='{_Username}'", commandType: CommandType.Text);
                            MessageBox.Show("Duyệt thành công Manager");
                            break;

                        }
                        else if (_TAI_KHOANG == "EMPLOYEE")
                        {
                            var dataEmployee = db.ExecuteAsync($" SET IDENTITY_INSERT dbo.DATA_APPLICATION_FOR_EMPLOYEE ON " +
        " INSERT INTO dbo.DATA_APPLICATION_FOR_EMPLOYEE (ID,MaNV,TenNV,UserName,UserPassword,FristName,LastName,EmailAdress,SDT_EMPLOYEE,TAI_KHOANG,NGAY_DANG_KY) " +
        " OUTPUT inserted.ID, inserted.MaNV, inserted.UserName,inserted.UserPassword,inserted.FristName,inserted.LastName,inserted.FristName,inserted.SDT_EMPLOYEE,inserted.TAI_KHOANG,inserted.NGAY_DANG_KY " +
        $" SELECT DATA_APPLICATION_USER.ID,'{_Usercode}','{_Nameuser}', DATA_APPLICATION_USER.UserName, DATA_APPLICATION_USER.UserPassword,'{_Fristname}','{_Lastname}','{_EmailAdress}','{_SDT_USER}',DATA_APPLICATION_USER.TAI_KHOANG,'{_NGAY_DANG_KY}' FROM dbo.DATA_APPLICATION_REGISTER,dbo.DATA_APPLICATION_USER WHERE DATA_APPLICATION_USER.ID={_ID} AND DATA_APPLICATION_REGISTER.UserName='{_Username}'", commandType: CommandType.Text);
                            MessageBox.Show("Duyệt thành công Employee");
                            break;
                         }   
                    }    
                }
                    catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                db.Close();
            }
        }


              
                





              //  var dataEmployee = db.ExecuteAsync($" SET IDENTITY_INSERT dbo.DATA_APPLICATION_FOR_MANAGER ON " +
              //  " INSERT INTO dbo.DATA_APPLICATION_FOR_MANAGER (ID,MaQL,TenQL,UserName,UserPassword,FristName,LastName,EmailAdress,SDT_MANAGER,TAI_KHOANG,NGAY_DANG_KY) " +
              //  " OUTPUT inserted.ID, inserted.MaQL, inserted.UserName,inserted.UserPassword,inserted.FristName,inserted.LastName,inserted.FristName,inserted.SDT_MANAGER,inserted.TAI_KHOANG,inserted.NGAY_DANG_KY " +
              //" SELECT DATA_APPLICATION_USER.ID,'QL03','NGUYEN TRUNG KHANH', DATA_APPLICATION_USER.UserName, DATA_APPLICATION_USER.UserPassword,'NGUYEN','KHANH','KHANH2002@gmail.com','0909090909',DATA_APPLICATION_USER.TAI_KHOANG,'12/21/2022' FROM dbo.DATA_APPLICATION_REGISTER,dbo.DATA_APPLICATION_USER WHERE DATA_APPLICATION_USER.ID=9 AND DATA_APPLICATION_REGISTER.UserName='rongchoi9'", commandType: CommandType.Text);
              //  MessageBox.Show("Duyệt thành công");
                

            
}

            //string conString = "Server=ServerName;Database=DBName;User Id=UserName;Password =********; ";
            //string sqlcmd = " INSERT INTO dbo.DATA_APPLICATION_FOR_MANAGER (ID,MaQL,TenQL,UserName,UserPassword,FristName,LastName,EmailAdress,SDT_MANAGER,TAI_KHOANG,NGAY_DANG_KY) "
            //              + " OUTPUT inserted.ID, inserted.Name, inserted.CreatedDate "
            //              + " SELECT TOP 10 [ID], [Name], [CreatedDate] FROM [TestDB].[dbo].[TempOrig] ";

            /*
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlcmd, con))
                {
                    con.Open();

                    // fill in the DataTable object
                    DataTable dt = new DataTable();
                    using (var insertedOutput = cmd.ExecuteReader())
                    {
                        dt.Load(insertedOutput);
                    }


                    // Read from DataTable object and print on the console
                    DataRow[] currentRows = dt.Select(null, null);

                    if (currentRows.Length < 1)
                        Console.WriteLine("No Current Rows Found");
                    else
                    {
                        foreach (DataColumn column in dt.Columns)
                            Console.Write("\t{0}", column.ColumnName);

                        Console.WriteLine("\t");

                        foreach (DataRow row in currentRows)
                        {
                            foreach (DataColumn column in dt.Columns)
                                Console.Write("\t{0}", row[column]);

                            Console.WriteLine("\t");
                        }
                    }
                    Console.ReadLine();
                }
            }
            */

}


   










   
