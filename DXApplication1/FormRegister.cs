using System;
using System.Drawing;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class FormRegister : DevExpress.XtraEditors.XtraForm
    {

       

        public FormRegister()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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
                pn1_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn1_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtFristname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtUsername_Register.Text == "" || txtUsername_Register.Text == "Username")
            {
                txtUsername_Register.Text = "Username";
                txtUsername_Register.ForeColor = Color.WhiteSmoke;
                pn3_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn3_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtUsername_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtPassword_Register.Text == "" || txtPassword_Register.Text == "Password")
            {
                txtPassword_Register.Text = "Password";
                txtPassword_Register.ForeColor = Color.WhiteSmoke;
                pn4_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn4_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtPassword_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtEmail_Register.Text == "" || txtEmail_Register.Text == "Email")
            {
                txtEmail_Register.Text = "Email";
                txtEmail_Register.ForeColor = Color.WhiteSmoke;
                pn5_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn5_Register.ForeColor = Color.FromArgb(78, 184, 206);
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
                pn2_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn2_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtLastname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtFristname_Register.Text == "" || txtFristname_Register.Text == "Fristname")
            {
                txtFristname_Register.Text = "Fristname";
                txtFristname_Register.ForeColor = Color.WhiteSmoke;
                pn1_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn1_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtFristname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtPassword_Register.Text == "" || txtPassword_Register.Text == "Password")
            {
                txtPassword_Register.Text = "Password";
                txtPassword_Register.ForeColor = Color.WhiteSmoke;
                pn4_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn4_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtPassword_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtEmail_Register.Text == "" || txtEmail_Register.Text == "Email")
            {
                txtEmail_Register.Text = "Email";
                txtEmail_Register.ForeColor = Color.WhiteSmoke;
                pn5_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn5_Register.ForeColor = Color.FromArgb(78, 184, 206);
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
                pn2_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn2_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtLastname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtUsername_Register.Text == "" || txtUsername_Register.Text == "Username")
            {
                txtUsername_Register.Text = "Username";
                txtUsername_Register.ForeColor = Color.WhiteSmoke;
                pn3_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn3_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtUsername_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtPassword_Register.Text == "" || txtPassword_Register.Text == "Password")
            {
                txtPassword_Register.Text = "Password";
                txtPassword_Register.ForeColor = Color.WhiteSmoke;
                pn4_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn4_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtPassword_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtEmail_Register.Text == "" || txtEmail_Register.Text == "Email")
            {
                txtEmail_Register.Text = "Email";
                txtEmail_Register.ForeColor = Color.WhiteSmoke;
                pn5_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn5_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtEmail_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

        }

        private void txtPassword_Register_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword_Register.Clear();
            txtPassword_Register.ForeColor = Color.FromArgb(78, 183, 206);
            pn4_Register.BackColor = Color.FromArgb(78, 184, 206);

            if (txtLastname_Register.Text == "" || txtLastname_Register.Text == "Fristname")
            {
                txtLastname_Register.Text = "Fristname";
                txtLastname_Register.ForeColor = Color.WhiteSmoke;
                pn2_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn2_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtLastname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtUsername_Register.Text == "" || txtUsername_Register.Text == "Fristname")
            {
                txtUsername_Register.Text = "Username";
                txtUsername_Register.ForeColor = Color.WhiteSmoke;
                pn3_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn3_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtUsername_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtFristname_Register.Text == "" || txtFristname_Register.Text == "Fristname")
            {
                txtFristname_Register.Text = "Fristname";
                txtFristname_Register.ForeColor = Color.WhiteSmoke;
                pn1_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn4_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtFristname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtEmail_Register.Text == "" || txtEmail_Register.Text == "Email")
            {
                txtEmail_Register.Text = "Email";
                txtEmail_Register.ForeColor = Color.WhiteSmoke;
                pn5_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn5_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtEmail_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

        }

        private void txtEmail_Register_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail_Register.Clear();
            txtEmail_Register.ForeColor = Color.FromArgb(78, 183, 206);
            pn5_Register.BackColor = Color.FromArgb(78, 184, 206);

            if (txtLastname_Register.Text == "" || txtLastname_Register.Text == "Fristname")
            {
                txtLastname_Register.Text = "Fristname";
                txtLastname_Register.ForeColor = Color.WhiteSmoke;
                pn2_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn2_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtLastname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtUsername_Register.Text == "" || txtUsername_Register.Text == "Fristname")
            {
                txtUsername_Register.Text = "Username";
                txtUsername_Register.ForeColor = Color.WhiteSmoke;
                pn3_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn3_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtUsername_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtPassword_Register.Text == "" || txtPassword_Register.Text == "Fristname")
            {
                txtPassword_Register.Text = "Password";
                txtPassword_Register.ForeColor = Color.WhiteSmoke;
                pn4_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn4_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtPassword_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }

            if (txtFristname_Register.Text == "" || txtFristname_Register.Text == "Fristname")
            {
                txtFristname_Register.Text = "Fristname";
                txtFristname_Register.ForeColor = Color.WhiteSmoke;
                pn1_Register.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                pn1_Register.ForeColor = Color.FromArgb(78, 184, 206);
                txtFristname_Register.ForeColor = Color.FromArgb(78, 184, 206);

            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void txtLastname_Register_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
