using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Dapper;
using DXApplication1.Subject.Login;

namespace DXApplication1
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        FormRegister frmRegister = new FormRegister();
        XtraForm1 Dashbroad = new XtraForm1();
        public FormLogin()
        {
            InitializeComponent();

        }

        public virtual void OpenSql()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<LoginDTO>("SELECT * FROM APLLICATION_USER", commandType: CommandType.Text);
                var resultReturn = db.Query<LoginDTO>("SELECT * FROM APLLICATION_USER ", commandType: CommandType.Text);
                foreach (LoginDTO p in data)
                {

                    if (txtUsername_Login.Text == p.Username)
                    {
                        if (txtPassword_Login.Text == p.UserPassword)
                        {
                            Dashbroad.Show();
                        }
                        else MessageBox.Show("Mat khau khong dong vui long nhap lai");
                    }
                    else MessageBox.Show("Ten tai khoang khong dung vui long nhap lai");
                   
                    

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
        //END
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
