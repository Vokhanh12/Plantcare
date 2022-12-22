using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Dapper;
using DXApplication1.Subject.Login;
using DXApplication1.Subject.Dashboard;

namespace DXApplication1
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormRegister frmRegister = new FormRegister();

        public TextBox txt0;

        public static FormLogin instance;

        public string ChucVu;

        public FormLogin()
        {
            InitializeComponent();

            instance = this;

            

            //SELECT ncc.ID,ncc.UserName,ncc.UserPassword,mcc.MaQL,mcc.TenQL,mcc.TAI_KHOANG FROM APPLICATION_USER ncc,DATA_APPLICATION_FOR_MANAGER mcc WHERE mcc.UserName='khanh1803' and ncc.Username='khanh1803'

        }

        public void checkSytem(string Check)
        {
            XtraForm1 dashboard = new XtraForm1();
            if (Check == "Login Successfully")
                dashboard.Show();
           else MessageBox.Show("Incorrect login attempt.");



           

        }
        public virtual void OpenSql()
        {
            txt0 = txtUsername_Login;
            XtraForm1 dashboard =new XtraForm1();


            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<LoginDTO>($"IF EXISTS(SELECT 1 FROM dbo.APPLICATION_USER WHERE UserName = '{txtUsername_Login.Text}' AND PWDCOMPARE('{txtPassword_Login.Text}',UserPassword)=1) BEGIN SELECT 'Login Successfully' as 'SYSTEM',TAI_KHOANG,UserName FROM dbo.APPLICATION_USER WHERE UserName = '{txtUsername_Login.Text}' END ELSE BEGIN SELECT 'Incorrect login attempt.' as 'SYSTEM' END", commandType: CommandType.Text);
                

                foreach (LoginDTO p in data)
                {
                    checkSytem(p.SYSTEM);
                    break;
                    
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
            OpenSql();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //END
    }
}
