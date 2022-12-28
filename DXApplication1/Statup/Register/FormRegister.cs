using Dapper;
using DXApplication1.BrowseJob;
using DXApplication1.Subject.Register;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class FormRegister : DevExpress.XtraEditors.XtraForm
    {

        public DateTime thisToday = DateTime.Today;
        
       
        public FormRegister()
        {
            InitializeComponent();
        }
    
 
        private void txtLastname_Register_MouseClick(object sender, MouseEventArgs e)
        {

            txtLastname_Register.Clear();
            txtLastname_Register.ForeColor = Color.FromArgb(78, 183, 206);
            pn2_Register.BackColor = Color.FromArgb(78, 184, 206);

            if (txtFristname_Register.Text == "" || txtFristname_Register.Text == "Fristname")
            {
                txtFristname_Register.Text = "Fristname";
                txtFristname_Register.ForeColor = Color.WhiteSmoke;
                pn1_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn1_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtFristname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtUsername_Register.Text == "" || txtUsername_Register.Text == "Username")
            {
                txtUsername_Register.Text = "Username";
                txtUsername_Register.ForeColor = Color.WhiteSmoke;
                pn3_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn3_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtUsername_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtPassword_Register.Text == "" || txtPassword_Register.Text == "Password")
            {
                txtPassword_Register.Text = "Password";
                txtPassword_Register.ForeColor = Color.WhiteSmoke;
                pn4_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn4_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtPassword_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtEmail_Register.Text == "" || txtEmail_Register.Text == "Email")
            {
                txtEmail_Register.Text = "Email";
                txtEmail_Register.ForeColor = Color.WhiteSmoke;
                pn5_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn5_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtEmail_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

        }

        private void txtUsername_Register_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername_Register.Clear();
            txtUsername_Register.ForeColor = Color.FromArgb(78, 183, 206);
            pn3_Register.BackColor = Color.FromArgb(78, 184, 206);

            if (txtLastname_Register.Text == "" || txtLastname_Register.Text == "Lastname")
            {
                txtLastname_Register.Text = "Lastname";
                txtLastname_Register.ForeColor = Color.WhiteSmoke;
                pn2_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn2_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtLastname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtFristname_Register.Text == "" || txtFristname_Register.Text == "Fristname")
            {
                txtFristname_Register.Text = "Fristname";
                txtFristname_Register.ForeColor = Color.WhiteSmoke;
                pn1_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn1_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtFristname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtPassword_Register.Text == "" || txtPassword_Register.Text == "Password")
            {
                txtPassword_Register.Text = "Password";
                txtPassword_Register.ForeColor = Color.WhiteSmoke;
                pn4_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn4_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtPassword_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtEmail_Register.Text == "" || txtEmail_Register.Text == "Email")
            {
                txtEmail_Register.Text = "Email";
                txtEmail_Register.ForeColor = Color.WhiteSmoke;
                pn5_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn5_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtEmail_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

        }

        private void txtFristname_Register_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtFristname_Register.Clear();
            txtFristname_Register.ForeColor = Color.FromArgb(78, 183, 206);
            pn1_Register.BackColor = Color.FromArgb(78, 184, 206);

            if (txtLastname_Register.Text == "" || txtLastname_Register.Text == "Lastname")
            {
                txtLastname_Register.Text = "Lastname";
                txtLastname_Register.ForeColor = Color.WhiteSmoke;
                pn2_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn2_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtLastname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtUsername_Register.Text == "" || txtUsername_Register.Text == "Username")
            {
                txtUsername_Register.Text = "Username";
                txtUsername_Register.ForeColor = Color.WhiteSmoke;
                pn3_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn3_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtUsername_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtPassword_Register.Text == "" || txtPassword_Register.Text == "Password")
            {
                txtPassword_Register.Text = "Password";
                txtPassword_Register.ForeColor = Color.WhiteSmoke;
                pn4_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn4_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtPassword_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtEmail_Register.Text == "" || txtEmail_Register.Text == "Email")
            {
                txtEmail_Register.Text = "Email";
                txtEmail_Register.ForeColor = Color.WhiteSmoke;
                pn5_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn5_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtEmail_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

        }

        private void txtPassword_Register_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword_Register.Clear();
            txtPassword_Register.ForeColor = Color.FromArgb(78, 183, 206);
            pn4_Register.BackColor = Color.FromArgb(78, 184, 206);

            if (txtLastname_Register.Text == "" || txtLastname_Register.Text == "Lastname")
            {
                txtLastname_Register.Text = "Lastname";
                txtLastname_Register.ForeColor = Color.WhiteSmoke;
                pn2_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn2_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtLastname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtUsername_Register.Text == "" || txtUsername_Register.Text == "Username")
            {
                txtUsername_Register.Text = "Username";
                txtUsername_Register.ForeColor = Color.WhiteSmoke;
                pn3_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn3_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtUsername_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtFristname_Register.Text == "" || txtFristname_Register.Text == "Fristname")
            {
                txtFristname_Register.Text = "Fristname";
                txtFristname_Register.ForeColor = Color.WhiteSmoke;
                pn1_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn4_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtFristname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtEmail_Register.Text == "" || txtEmail_Register.Text == "Email")
            {
                txtEmail_Register.Text = "Email";
                txtEmail_Register.ForeColor = Color.WhiteSmoke;
                pn5_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn5_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtEmail_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

        }

        private void txtEmail_Register_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail_Register.Clear();
            txtEmail_Register.ForeColor = Color.FromArgb(78, 183, 206);
            pn5_Register.BackColor = Color.FromArgb(78, 184, 206);

            if (txtLastname_Register.Text == "" || txtLastname_Register.Text == "Lastname")
            {
                txtLastname_Register.Text = "Lastname";
                txtLastname_Register.ForeColor = Color.WhiteSmoke;
                pn2_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn2_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtLastname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtUsername_Register.Text == "" || txtUsername_Register.Text == "Username")
            {
                txtUsername_Register.Text = "Username";
                txtUsername_Register.ForeColor = Color.WhiteSmoke;
                pn3_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn3_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtUsername_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtPassword_Register.Text == "" || txtPassword_Register.Text == "Password")
            {
                txtPassword_Register.Text = "Password";
                txtPassword_Register.ForeColor = Color.WhiteSmoke;
                pn4_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn4_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtPassword_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtFristname_Register.Text == "" || txtFristname_Register.Text == "Fristname")
            {
                txtFristname_Register.Text = "Fristname";
                txtFristname_Register.ForeColor = Color.WhiteSmoke;
                pn1_Register.BackColor = Color.WhiteSmoke;
            }
            else
            {
                pn1_Register.BackColor = Color.FromArgb(78, 184, 206);
                txtFristname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }
        }

        public void ProcessString(string s1)
        {
            if (s1 == null)
            {
                throw new ArgumentNullException(paramName: nameof(s1), message: "parameter can't be null.");
            }

         
        }

        public virtual void sendJobApplication()
        {
            int count = 0;

            string _Fristname = null;
            string _Lastname = null;
            string _Username = null;
            string _Userpassword = null;
            string _Emailadress = null;
            string _Birthday = null;

            try
            {
                     _Fristname = txtFristname_Register.Text;
                     _Lastname = txtLastname_Register.Text;
                     _Username = txtUsername_Register.Text;
                     _Userpassword = txtPassword_Register.Text;
                     _Emailadress = txtEmail_Register.Text;
                     _Birthday = dE_Brithday.Text;

                    ProcessString(_Fristname);
                    ProcessString(_Lastname);
                    ProcessString(_Username);
                    ProcessString(_Userpassword);
                    ProcessString(_Emailadress);
                    ProcessString(_Birthday);


            } catch(Exception ex)
            {
                MessageBox.Show("code:" +ex);
            }

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();

                //Return a count of the table DATA_APPLICATION_REGISTER and column USERNAME
                var data = db.Query<RegisterDTO>("SELECT COUNT (UserName) as 'RETURN_COUNTCOLUMN' from DATA_APPLICATION_REGISTER ", commandType: CommandType.Text);
                //Select DATA OF APPLLCATION_REGISTER
                var data1 = db.Query<RegisterDTO>("SELECT UserName FROM DATA_APPLICATION_REGISTER", commandType: CommandType.Text);

                foreach (RegisterDTO p in data1)
                {
                    if (_Username == p.UserName)
                    {
                        MessageBox.Show("Đã có người đặt tên tài khoảng này.Vui lòng đặt tên khác");
                        break;
                    }

                    if (_Userpassword == p.UserPassword)
                    {
                        MessageBox.Show("Đã có người đặt mật khẩu này.Vui lòng đặt mật khẩu khác");
                        break;
                    }

                    if (_Emailadress == p.EmailAdress)
                    {
                        MessageBox.Show("Email này đã có rồi.Vui lòng chọn Email khác");
                        break;
                    }

                    count++;

                }

                foreach (RegisterDTO p in data)
                {
                    if (count == p.RETURN_COUNTCOLUMN)
                    {
                        try
                        {
                            var dataAdd = db.ExecuteAsync($"INSERT INTO DATA_APPLICATION_REGISTER VALUES('{_Username}',PWDENCRYPT('{_Userpassword}'),'{_Fristname}','{_Lastname}','{_Emailadress}','{_Birthday}','{thisToday.ToString("d")}',null,'{"CHUA DUYET"}')");
                            MessageBox.Show("Tạo tài khoảng thành công.Vui lòng liên hệ");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERRO: FORM REGISTER code:" + ex);
                        }

                    }
                }









            }

        }

        private void hyperlinkLabelControl3_MouseClick(object sender, MouseEventArgs e)
        {
            //Display
            this.Hide();
            using (FormLogin frmLogin= new FormLogin())
            {
                
                frmLogin.ShowDialog();
                
            }
            
           
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            tmChColor_checkedit.Start();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (chlb_Register.Checked == true)
            {
                sendJobApplication();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn chấp nhận những điều khoảng");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void txtUsername_Register_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmChColor_checkedit_Tick(object sender, EventArgs e)
        {
            if (cE_Male.Checked == true)
            {
                cE_Famale.Checked = false;
                cE_Famale.ForeColor = Color.White;

                cE_Male.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (cE_Famale.Checked == true)
            {
                    cE_Male.Checked = false;
                    cE_Male.ForeColor = Color.White;

                    cE_Famale.ForeColor = Color.FromArgb(78, 184, 206);
            }

            
           
        }








        /* private void timer1_Tick(object sender, EventArgs e)
          {
              frmLogin.Left += 18;
              if (frmLogin.Left >= 1100)
              {
                  timer1.Stop();
                  this.TopMost = false;
                  frmLogin.TopMost = true;
                  timer2.Start();
              }
          }

          private void timer2_Tick(object sender, EventArgs e)
          {
              frmLogin.Left -= 18;
              if (frmLogin.Left <= 700)
              {
                  timer2.Stop();
              }
          }
       
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        */
    }
}
