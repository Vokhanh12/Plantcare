using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DXApplication1
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        FormRegister frmRegister = new FormRegister();
        Dashboard frmdb = new Dashboard();
        public FormLogin()
        {
            InitializeComponent();

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
            //Check Username Password 
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3EEP3M4;Initial Catalog=Database_Plantcare;Integrated Security=True");
            string query = "Select * From LoginDB Where Username_Login = '"+txtUsername_Login.Text.Trim()+"' and Password_Login = '"+txtPassword_Login.Text.Trim()+"'";
            SqlDataAdapter sqlDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb_LoginDB = new DataTable();
            sqlDA.Fill(dtb_LoginDB);
            if (dtb_LoginDB.Rows.Count == 1)
            {
                //Close Form_Login and Form_Register
                this.Hide();
                frmRegister.Hide();

               
                frmdb.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Xin vui lòng thử lại.");

                txtPassword_Login.ForeColor = Color.WhiteSmoke;
                txtUsername_Login.ForeColor = Color.WhiteSmoke;

                txtPassword_Login.Text = "Password";
                txtUsername_Login.Text = "Username";
              
                picUsername.Image = Properties.Resources.userlogo;
                picPassword.Image = Properties.Resources.private_icon1;
                
            }
        }

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

    }
}
