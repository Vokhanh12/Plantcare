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
        public static void Permission(string Chucvu,ToolStripMenuItem thisMenuItem)
        {
            

            MessageBox.Show("Đăng nhập thành công " + Chucvu);
            switch (Chucvu)
            {
                case "ADMIN":
                    MessageBox.Show("Đăng nhập thành công");
                    break;
                case "MANAGER":
                    MessageBox.Show("Đăng nhập thành công");
                    break;
                case "EMPLOYEE":
                    MessageBox.Show("Đăng nhập thành công");
                    thisMenuItem.Visible = false;
                    break;
            }
            
        }
    }
}
