using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Transaction
{
    class LabelBH : Label
    {
      public LabelBH()
            {
            this.Size = new Size(120, 25);
            this.Font = new Font("Calibri", 12);
            this.ForeColor = Color.White;
        }
    }
 

    class KhungBH:Panel
    {
        private string tenSP;
        private decimal giaSP;

        //SP+ID
        Panel pnTop = new Panel();
        Panel pnBotton= new Panel();

        Panel pnBottonName = new Panel();
        Panel pnBottonPrice = new Panel();

        LabelBH lbName = new LabelBH();
        LabelBH lbPrice = new LabelBH();

     
       public KhungBH(string tenSP,decimal giaSP)
       {
            this.tenSP = tenSP;
            this.giaSP = giaSP;

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
            lbName.Text = ""+tenSP;
            lbName.Location = new Point(pnBottonName.Width / 2 - lbName.Width / 2, lbName.Location.Y);
            lbPrice.Text = ""+giaSP;
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
