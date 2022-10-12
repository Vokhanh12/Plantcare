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




        /*   private void textBox1_Click(object sender, EventArgs e)
           {

               txtFristname_Register.Clear();

               picUsername.Image = Properties.Resources.userlogo_before;
               panel1.ForeColor = Color.FromArgb(78, 184, 206);
               txtFristname_Register.ForeColor = Color.FromArgb(78, 184, 206);

               if (txtPassword.Text == "" || txtPassword.Text == "Password")
               {
                   txtPassword.Text = "Password";
                   picPassword.Image = Properties.Resources.private_icon1;
                   panel2.ForeColor = Color.WhiteSmoke;
                   txtPassword.ForeColor = Color.WhiteSmoke;
               }
               else
               {
                   picPassword.Image = Properties.Resources.private_icon_before;
                   panel2.ForeColor = Color.FromArgb(78, 184, 206);
                   txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

               }


           }

           private void textBox2_Click(object sender, EventArgs e)
           {
               txtPassword.Clear();

               picPassword.Image = Properties.Resources.private_icon_before;
               panel2.ForeColor = Color.FromArgb(78, 184, 206);
               txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

               if (txtFristname_Register.Text == "" || txtFristname_Register.Text == "Username")
               {
                   txtFristname_Register.Text = "Username";
                   picUsername.Image = Properties.Resources.userlogo;
                   panel1.ForeColor = Color.WhiteSmoke;
                   txtFristname_Register.ForeColor = Color.WhiteSmoke;
               }
               else
               {
                   picPassword.Image = Properties.Resources.private_icon_before;
                   panel1.ForeColor = Color.FromArgb(78, 184, 206);
                   txtFristname_Register.ForeColor = Color.FromArgb(78, 184, 206);

               }

           }
        */

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtFristname_Register_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
       

            txtFristname_Register.Clear();
            txtFristname_Register.ForeColor = Color.FromArgb(78, 183, 206);
            pn1_Register.BackColor = Color.FromArgb(78, 184, 206);

            if (txtLastname_Register.Text == "Lastname")
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
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        public System.Windows.Forms.TextBox[] FristTextBox = { a };
       

    

        private void button1_Click(object sender, EventArgs e)
        {

           
        }
    }
}
