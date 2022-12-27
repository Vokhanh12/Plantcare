using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Dapper;
using DXApplication1.Subject.Login;
using DXApplication1.Subject.Dashboard;
using System.Linq;
using DXApplication1.Statup.Information_user;
using DXApplication1.Major.Dashboard;

namespace DXApplication1
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormRegister frmRegister = new FormRegister();

        public watchInformation wIF = new watchInformation();

        public static FormLogin instance;

        public static string Checkcall { get; set; }

        public FormLogin()
        {
            InitializeComponent();

            instance = this;

            //SELECT ncc.ID,ncc.UserName,ncc.UserPassword,mcc.MaQL,mcc.TenQL,mcc.TAI_KHOANG FROM APPLICATION_USER ncc,DATA_APPLICATION_FOR_MANAGER mcc WHERE mcc.UserName='khanh1803' and ncc.Username='khanh1803'

        }

        //this the function used get informations in the watchInformation form
        public void checkSytem_sendInfomation(string Check,string ChucVu,string Username)
        {
            XtraForm1 dashboard = new XtraForm1();
            
            if (Check == "Login Successfully")
            {

                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
                {


                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    var dataAD = db.Query<LoginDTO>($"SELECT ncc.ID,ncc.UserName,ncc.UserPassword,mcc.MaAD,mcc.TenAD,mcc.TAI_KHOANG,mcc.NGAY_DANG_KY FROM DATA_APPLICATION_USER ncc,DATA_APPLICATION_FOR_ADMIN mcc WHERE mcc.UserName='{Username}' and ncc.Username='{Username}'", commandType: CommandType.Text);
                    var dataQL = db.Query<LoginDTO>($"SELECT ncc.ID,ncc.UserName,ncc.UserPassword,mcc.MaQL,mcc.TenQL,mcc.TAI_KHOANG,mcc.NGAY_DANG_KY FROM DATA_APPLICATION_USER ncc,DATA_APPLICATION_FOR_MANAGER mcc WHERE mcc.UserName='{Username}' and ncc.Username='{Username}'", commandType: CommandType.Text);
                    var dataNV = db.Query<LoginDTO>($"SELECT ncc.ID,ncc.UserName,ncc.UserPassword,mcc.MaNV,mcc.TenNV,mcc.TAI_KHOANG,mcc.NGAY_DANG_KY FROM DATA_APPLICATION_USER ncc,DATA_APPLICATION_FOR_EMPLOYEE mcc WHERE mcc.UserName='{Username}' and ncc.Username='{Username}'", commandType: CommandType.Text);

                    switch (ChucVu)
                    {
                        case "ADMIN":
                            foreach (LoginDTO p in dataAD)
                            {
                                //Send data to XtraForm
                                XtraForm1.instance.btnAccount_DB.Text = p.TenAD;
                                
                                //Send data to watchInformation
                                watchInformation.instance.mlbID_AT.Text = p.ID.ToString();
                                watchInformation.instance.mlbTK_AT.Text = p.UserName;

                                // watchInformation.instance.mlbMK_AT.Text = p.UserPassword;
                                watchInformation.instance.mlbMK_AT.Text = "●●●●●●●●";

                                watchInformation.instance.mlbTTK_AT.Text = p.TenAD;
                                watchInformation.instance.mlbMTK_AT.Text = p.MaAD;
                                watchInformation.instance.mlbLTK_AT.Text = p.TAI_KHOANG;
                                watchInformation.instance.mlbDC_AT.Text = "ADMIN";
                                watchInformation.instance.mlbNDK_AT.Text = (p.NGAY_DANG_KY).ToString();

                                Checkcall = "ADMIN";
                               
                            }
                            break;
                        case "MANAGER":
                            foreach (LoginDTO p in dataQL)
                            {
                                //Send data to XtraForm
                                XtraForm1.instance.btnAccount_DB.Text = p.TenQL;

                                //Send data to watchInformation
                                watchInformation.instance.mlbID_AT.Text = p.ID.ToString();
                                watchInformation.instance.mlbTK_AT.Text = p.UserName;

                                // watchInformation.instance.mlbMK_AT.Text = p.UserPassword;
                                  watchInformation.instance.mlbMK_AT.Text = "●●●●●●●●";
                                
                               watchInformation.instance.mlbTTK_AT.Text = p.TenQL;
                               watchInformation.instance.mlbMTK_AT.Text = p.MaQL;
                               watchInformation.instance.mlbLTK_AT.Text = p.TAI_KHOANG;
                               watchInformation.instance.mlbDC_AT.Text = "ADMIN";
                               watchInformation.instance.mlbNDK_AT.Text = (p.NGAY_DANG_KY).ToString();

                                Checkcall = "MANAGER";
                                
                            }
                            break;
                        case"EMPLOYEE":
                            foreach (LoginDTO p in dataNV)
                            {
                                //Send data to XtraForm
                                XtraForm1.instance.btnAccount_DB.Text = p.TenNV;
                                

                                //Send data to watchInformation
                                watchInformation.instance.mlbID_AT.Text = p.ID.ToString();
                                watchInformation.instance.mlbTK_AT.Text = p.UserName;

                                // watchInformation.instance.mlbMK_AT.Text = p.UserPassword;
                                watchInformation.instance.mlbMK_AT.Text = "●●●●●●●●";

                                watchInformation.instance.mlbTTK_AT.Text = p.TenNV;
                                watchInformation.instance.mlbMTK_AT.Text = p.MaNV;
                                watchInformation.instance.mlbLTK_AT.Text = p.TAI_KHOANG;
                                watchInformation.instance.mlbDC_AT.Text = "ADMIN";
                                watchInformation.instance.mlbNDK_AT.Text = (p.NGAY_DANG_KY).ToString();

                                Checkcall = "EMPLOYEE";

                            }
                            break;

                        default:MessageBox.Show("Khong co ten nhan vien nay erro:01");
                            break;
                            
                    }

                  db.Close();
                }
                this.Hide();
               
                dashboard.Show();

                

                wIF.Show();

                wIF.Hide();


            }
            else MessageBox.Show("Incorrect login attempt.");

        }
        public virtual void OpenSql(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<LoginDTO>($"IF EXISTS(SELECT 1 FROM dbo.DATA_APPLICATION_USER WHERE UserName = '{txtUsername_Login.Text}' AND PWDCOMPARE('{txtPassword_Login.Text}',UserPassword)=1) BEGIN SELECT 'Login Successfully' as 'SYSTEM',TAI_KHOANG,UserName FROM dbo.DATA_APPLICATION_USER WHERE UserName = '{txtUsername_Login.Text}' END ELSE BEGIN SELECT 'Incorrect login attempt.' as 'SYSTEM' END", commandType: CommandType.Text);

                LoginDTO loginDTO = new LoginDTO();

                foreach (LoginDTO p in data)
                {
                    checkSytem_sendInfomation(p.SYSTEM, p.TAI_KHOANG,p.UserName);
                }

                db.Close();
            }

            

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.HOR_NEGATIVE);

          
        }
        private void textBox1_Click(object sender, EventArgs e)
        {

            txtUsername_Login.Clear();

            picUsername.Image = Properties.Resources.userlogo_before;
            panel1.ForeColor = Color.FromArgb(78, 184, 206);
            txtUsername_Login.ForeColor = Color.FromArgb(78, 184, 206);

            if (txtPassword_Login.Text == "" || txtPassword_Login.Text == "Password")
            {
                txtPassword_Login.Text = "Password";
                picPassword.Image = Properties.Resources.private_icon1;
                panel2.ForeColor = Color.WhiteSmoke;
                txtPassword_Login.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                picPassword.Image = Properties.Resources.private_icon_before;
                panel2.ForeColor = Color.FromArgb(78, 184, 206);
                txtPassword_Login.ForeColor = Color.FromArgb(78, 184, 206);

            }


        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtPassword_Login.Clear();

            picPassword.Image = Properties.Resources.private_icon_before;
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword_Login.ForeColor = Color.FromArgb(78, 184, 206);

            if (txtUsername_Login.Text == "" || txtUsername_Login.Text == "Username")
            {
                txtUsername_Login.Text = "Username";
                picUsername.Image = Properties.Resources.userlogo;
                panel1.ForeColor = Color.WhiteSmoke;
                txtUsername_Login.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                picPassword.Image = Properties.Resources.private_icon_before;
                panel1.ForeColor = Color.FromArgb(78, 184, 206);
                txtUsername_Login.ForeColor = Color.FromArgb(78, 184, 206);

            }

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            OpenSql(sender,e);
        }


        //DESIGN FORM LOGIN
        //START
        private void btRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister.Show();
            this.Show();

            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmRegister.Left += 18;
            if (frmRegister.Left >= 1100)
            {
                timer1.Stop();
                this.TopMost = false;
                frmRegister.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frmRegister.Left -= 18;
            if (frmRegister.Left <= 700)
            {
                timer2.Stop();
                timer4.Stop();
                //hide Display FormLogin
                this.Hide();
            }
            
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
            frmRegister.Left += 18;
            if (frmRegister.Left >= 1100)
            {
                timer1.Stop();
                this.TopMost = false;
                frmRegister.TopMost = true;
                timer2.Start();
            }
            else
            {
                this.Close();
                frmRegister.Show();
            }


           
        }

        private void txtUsername_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btLogin_Click(sender, e);
            }
        }

        private void txtPassword_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btLogin_Click(sender, e);
            }
        }
        //END
    }
}
