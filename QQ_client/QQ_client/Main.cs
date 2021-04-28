using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ_client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        Socket socket;
        private void Main_Load(object sender, EventArgs e)
        {
            //socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket = userInfo.socket;
            string name = userInfo.UserName;
            //IPAddress ip_add = IPAddress.Parse("192.168.227.1");
            //IPEndPoint ip_port = new IPEndPoint(ip_add, 5000);
            try
            {
                Show_msg("服务器连接成功！欢迎你："+socket.RemoteEndPoint.ToString()+":"+name);
                // 开始持续获取服务器发送的信息
                Thread th = new Thread(Receive_msg);
                th.IsBackground = true;
                th.Start(socket);
            }
            catch { }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void Show_msg(string Str) 
        {
            richTextBox2.AppendText(Str+"\r\n");
        }

        private void Msg_send_Click(object sender, EventArgs e)
        {
            string Str = richTextBox1.Text;
            Send_Msg(Str);
        }
        void Send_Msg(string send) 
        {
            try {
                byte[] send_buffer = new byte[1024 * 1024 * 2];
                send_buffer = Encoding.UTF8.GetBytes(send);
                socket.Send(send_buffer);
            }
            catch (Exception ex){
                Show_msg("服务器连接异常！");
            }
        }
        void Receive_msg(object o) 
        {
            Socket socket = o as Socket;
            while (true) 
            {
                byte[] buffer = new byte[1024 * 1024 * 2];
                int r = socket.Receive(buffer);
                if (r != 0)
                {
                    string Receive_msg = Encoding.UTF8.GetString(buffer, 0, r);
                    Show_msg(Receive_msg);
                }
                else 
                {
                    Show_msg("获取的数据为空！");
                }
            }
        }
    }
}
