using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApplication2udp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e) //CLIENT
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(textBox_ip.Text, Convert.ToInt16(textBox_port.Text));
            Byte[] senddata = Encoding.ASCII.GetBytes(textBox_message.Text);
            udpClient.Send(senddata, senddata.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        public void serverThread() //SERVER
        {
            UdpClient udpClient = new UdpClient(8080);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                
                this.Invoke(new MethodInvoker(delegate()
                {
                    
                    listBox_received.Items.Add(RemoteIpEndPoint.Address.ToString() + " : " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " : " + returnData.ToString());
                    listBox_received.SelectedIndex = listBox_received.Items.Count - 1;
                    listBox_received.SelectedIndex = -1;

                }));
            }
        }

        // DISABLE X BUTTON
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
