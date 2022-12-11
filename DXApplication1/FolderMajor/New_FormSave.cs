using DevExpress.XtraEditors;
using DXApplication1.FolderNV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.FolderMajor
{
    public partial class New_FormSave : DevExpress.XtraEditors.XtraForm
    {

      
        public New_FormSave()
        {
            frmNhanVien frmNV = new frmNhanVien();
            InitializeComponent();
            this.Close();
            frmNV.Show(this);
            
        }
        public New_FormSave(frmNhanVien frm)
        {
            frmNhanVien frmNV = new frmNhanVien();
            InitializeComponent();
            frmNV = frm;

        }
    

        private void New_FormSave_Load(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            txt_MANV.Text = frmNV.materialListView1.SelectedItems[0].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}