using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace MyApp
{
    public partial class LanChat : UserControl
    {

        Socket skt;
        EndPoint ePointL, ePointR;
        byte[] buffer;

   
        public LanChat()
        {
            InitializeComponent();
        }

        private void local2_Enter(object sender, EventArgs e)
        {

        }

        private void LanChat_Load(object sender, EventArgs e)
        {
            skt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            skt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            localIP.Text = GetLocalIP();
            remoteIP.Text = GetLocalIP();

        }

        private string GetLocalIP()
        {
            IPHostEntry  host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }

            }
            return "127.0.0.1";
        }

        private void connect_Click(object sender, EventArgs e)
        {

           

                ePointL = new IPEndPoint(IPAddress.Parse(localIP.Text), Convert.ToInt32(localPort.Text));
            skt.Bind(ePointL);

            ePointR = new IPEndPoint(IPAddress.Parse(remoteIP.Text), Convert.ToInt32(remotePort.Text));
            skt.Connect(ePointR);

            buffer = new byte[1500];
            skt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ePointR, new AsyncCallback(MessageCallBack), buffer);
      
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                listMsg.Items.Add("Friend:" + receivedMessage);

                buffer = new byte[1500];
                skt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ePointR, new AsyncCallback(MessageCallBack
                    ), buffer);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMSG = new byte[1500];
            sendingMSG = aEncoding.GetBytes(message.Text);
            skt.Send(sendingMSG);
            listMsg.Items.Add("Me:" + message.Text);
            message.Text = "";

        }

        private void local_Enter(object sender, EventArgs e)
        {

        }
    }
}
