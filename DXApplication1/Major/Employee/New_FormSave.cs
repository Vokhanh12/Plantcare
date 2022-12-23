using DevExpress.XtraEditors;
using DXApplication1.FolderNV;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.FolderMajor
{
    public partial class New_FormSave : DevExpress.XtraEditors.XtraForm
    {
       // fsEdit Edit = new fsEdit();
        public TextBox txt0, txt1, txt2, txt3, txt4, txt5, txt6,txt7,txt8;
        public  DateEdit dtNgaysinh;
        public static New_FormSave instance;
       // public int caseChange;
        public New_FormSave()
        {
            
            InitializeComponent();

            instance = this;

            txt0 = txt_MANV;
            txt1 = txt_TENNV;
            txt2 = txt_LUONG;
            txt3 = txt_THUONG;
            txt4 = txt_GIOITINH;
            dtNgaysinh = dateEdit_NGAYSINH;
            txt6 = txt_SDT;
            txt7 = txt_SOTHICH;
            txt8 = txt_DIACHI;
            
            
            
        }
       
    

        private void New_FormSave_Load(object sender, EventArgs e)
        {
            /* string specifier;
             CultureInfo culture;

             var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
             try{
                 txt_MANV.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[0].ToString().Replace(" ", ""));
                 txt_TENNV.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[1].ToString());

                 //Lương
                 txt_LUONG.Text = String.Format(info, "{0:c}", Convert.ToDecimal(Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[2].ToString())) / 10000);

                 //Thưởng = %
                 specifier = "P";
                 culture = CultureInfo.InvariantCulture;
                 txt_THUONG.Text = (Convert.ToDouble(Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[3].ToString())) / 100).ToString(specifier, culture);
                 // Displays:    #.00 %

                 txt_GIOITINH.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[4].ToString().Replace(" ", ""));
                 dateEdit_NGAYSINH.DateTime = Convert.ToDateTime(((((frmNhanVien.instance.mLV.SelectedItems[0].SubItems[5].ToString()).Substring(17)).Replace("{", "")).Replace("}", "")));

                 //txt5.Text = Edit.deleteCharacter(frmNhanVien.instance.materialListView1.SelectedItems[0].SubItems[5].ToString());
                 txt_SDT.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[6].ToString());
                 txt_SOTHICH.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[7].ToString());
                 txt_DIACHI.Text = Edit.deleteCharacter(frmNhanVien.instance.mLV.SelectedItems[0].SubItems[8].ToString());

             }
             catch(Exception ex)
             {
                 MessageBox.Show("Nhap click vao ban de chinh sua");
                 this.Close();
             }
            */





        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}