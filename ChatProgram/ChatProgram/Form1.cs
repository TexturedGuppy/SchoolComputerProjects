using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Threading;

namespace ChatProgram
{
    public partial class frmMain : Form
    {
        UdpClient sendingClient;
        UdpClient receivingClient;
        int port = 1234;
        string user = "Anonymous";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //btnSend.Enabled = !string.IsNullOrWhiteSpace(txtUserName.Text);
            //btnSend.Enabled = !string.IsNullOrWhiteSpace(txtSend.Text);
            user = txtUserName.Text;
            byte[] msg = Encoding.ASCII.GetBytes(txtSend.Text);
            sendingClient.Send(msg, msg.Length);
            txtSend.Clear();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, port);
            sendingClient = new UdpClient();
            sendingClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            sendingClient.Connect(endPoint);

            receivingClient = new UdpClient();
            receivingClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            endPoint = new IPEndPoint(IPAddress.Any, port);
            receivingClient.Client.Bind(endPoint);
            Task.Factory.StartNew(() => Listen());
        }

        private async void Listen()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] buffer = receivingClient.Receive(ref endPoint);
                string msg = Encoding.ASCII.GetString(buffer);
                txtChat.AppendText(user + ": " + msg + "\n");
                await Task.Factory.StartNew(() => Listen());
            }
            catch(Exception e)
            {
                txtChat.AppendText("Error: " + e.Message + "\n");
            }
        }

        private void txtSend_TextChanged(object sender, EventArgs e)
        {
            sendButtonDisable();
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            sendButtonDisable();

        }

        private void sendButtonDisable()
        {
            if (!string.IsNullOrWhiteSpace(txtSend.Text) && !string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                btnSend.Enabled = true;
            }
            else
            {
                btnSend.Enabled = false;
            }
        }

    }
}
