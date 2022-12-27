using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Major.Dashboard
{
    class DashBoardClass
    {
        public static void Permission(string Chucvu,ToolStripMenuItem menuItem, ToolStripMenuItem menuItem1)
        {
            

            MessageBox.Show("Đăng nhập thành công " + Chucvu);
            switch (Chucvu)
            {
                case "ADMIN":
                    MessageBox.Show("Đăng nhập thành công");
                    break;
                case "MANAGER":
                    MessageBox.Show("Đăng nhập thành công");
                    menuItem.Visible = false; //hide Manager_ToolStripMenu 
                    break;
                case "EMPLOYEE":
                    MessageBox.Show("Đăng nhập thành công");
                    menuItem.Visible = false;//hide Manager_ToolStripMenu 
                    menuItem1.Visible = false;//hide Employee_ToolStripMenu 
                    break;
            }
            
        }
    }
}
