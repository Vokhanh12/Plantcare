using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.BrowseJob
{
    public partial class newFormSave : DevExpress.XtraEditors.XtraForm
    {
        public static newFormSave instance;

        public ComboBoxEdit cbBrowse_A; 

        public TextBox txtID_A, txtUsercode_A, txtNameUser_A, txtFristName_A, txtLastName_A, txtUsername_A, txtUserpassword_A, txtSDT_A, txtDOB_A, txtEmail_A, txtNDK_A;

        private void txtNameUser_Click(object sender, EventArgs e)
        {
            txtNameUser.Text = "";

        }

        private void txtUsercode_Click(object sender, EventArgs e)
        {
            txtUsercode.Text = "";

        }

        public sqlOpen sql = new sqlOpen();
      

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "ID")
                MessageBox.Show("Vui lòng nhập ID");
            else if (txtUsercode.Text == "UserCode")
                MessageBox.Show("Vui lòng nhập UserCode");
            else if (txtNameUser.Text == "NameUser")
                MessageBox.Show("Vui lòng nhập UserName");
            else { sql.jobAccept(frmBrowseJob.instance.materialListView1); }

        }

        public newFormSave()
        {
            InitializeComponent();

            instance = this;

            //Textbox
            txtID_A = txtID;
            txtUsercode_A = txtUsercode;
            txtNameUser_A = txtNameUser;
            txtFristName_A = txtFristname;
            txtLastName_A = txtLastname;
            txtUsername_A = txtUsername;
            txtUserpassword_A = txtUserpassword;
            txtSDT_A = txtSDT;
            txtDOB_A = txtDOB;
            txtNDK_A = txtNDK;
            txtEmail_A = txtEmail;

            //ComboboxEdit
            cbBrowse_A = cbBrowse;

        }

        private void txtID_Click(object sender, EventArgs e)
        {
            txtID.Text = "";


        }

        private void newFormSave_Load(object sender, EventArgs e)
        {
            cbBrowse.Properties.Items.Add("MANAGER");
            cbBrowse.Properties.Items.Add("EMPLOYEE");
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {

        }
    }
}