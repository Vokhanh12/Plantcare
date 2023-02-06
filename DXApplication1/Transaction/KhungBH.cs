using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Transaction
{
    
 

    class KhungBH:Panel
    {
        //SP+ID
       ThongTinSanPham SP1 = new ThongTinSanPham("B01", "BUOI", "TRAICAY", 1, 20000);

        Panel pnTop = new Panel();
        Panel pnBotton= new Panel();

        Panel pnBottonName = new Panel();
        Panel pnBottonPrice = new Panel();

        Label lbName = new Label();
        Label lbPrice = new Label();

     
       public KhungBH()
       {
            settingPanel();
            settingKhungBH();





       }

        public void settingPanel()
        {
            //panel TOP
            pnTop.Width = 333; pnTop.Height = 237;
            pnTop.Dock = DockStyle.Top;
            pnTop.BackColor = Color.Red;

            //Panel Botton
            pnBotton.Width = 333; pnBotton.Height = 60;
            pnBotton.Dock = DockStyle.Bottom;
            pnBotton.BackColor = Color.Blue;
            pnBotton.Controls.Add(pnBottonName);
            pnBotton.Controls.Add(pnBottonPrice);

            //SettinginPanel
            settinginPanel();

        }

        //the contructor used to worked items in settingpanel
        public void settinginPanel()
        {
            //set for pannel botton of items Name and Price
            pnBottonName.Width = 331; pnBottonName.Height = 27;
            pnBottonName.Dock = DockStyle.Top;
            pnBottonName.Controls.Add(lbName);

            pnBottonPrice.Width = 331; pnBottonPrice.Height = 30;
            pnBottonPrice.Dock = DockStyle.Bottom;
            pnBottonPrice.Controls.Add(lbPrice);

            //set label in this panel
            lbName.Text = "ABCD";
            lbName.Location = new Point(pnBottonName.Width / 2 - lbName.Width / 2, lbName.Location.Y);
            lbPrice.Text = "30000";
            lbPrice.Location = new Point(pnBottonName.Width / 2 - lbName.Width / 2, lbName.Location.Y);

            


        }

        public void settingKhungBH()
        {
            this.Width = 295; this.Height = 304;
            this.BackColor = Color.Black;



            this.Controls.Add(pnTop);
            this.Controls.Add(pnBotton);



        }

    }




}
