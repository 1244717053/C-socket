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
{/// <summary>
/// QQ 客户端
/// </summary>
    public partial class QQ_client : Form
    {
        Socket socket;
        public QQ_client()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string Name = userName.Text;
            string Pwd = userPwd.Text;

            int port = 5000;
            string ip_str = "192.168.227.1";
            if (Name.Trim() == "" || Pwd.Trim() == "")
            {
                MessageBox.Show("数据不能为空！");
            }
            else 
            {
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPAddress ip = IPAddress.Parse(ip_str);
                    IPEndPoint ip_port = new IPEndPoint(ip, port);
                    socket.Connect(ip_port);
                    SendMsg(Name, Pwd);
                    Access_data(socket);
                }
                catch {
                    MessageBox.Show("连接服务器失败！");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            regist newform = new regist();
            newform.Show();
        }

        void SendMsg(string Name, string Pwd) 
        {
            Name += "|";
            string Msg_str = Name + Pwd;
            byte[] msg = new byte[1024 * 1024 * 2];
            msg = Encoding.UTF8.GetBytes("1"+Msg_str);
            socket.Send(msg);
        }
        void Access_data(object o) 
        {
            Socket socket = o as Socket;
            byte[] data_buffer = new byte[1024 * 1024 * 2];
            string str;
            int r = socket.Receive(data_buffer);
            if (r == 0)
            {
                MessageBox.Show("状态信息：未查询到注册信息");
            }
            else
            {
                // 将数据保存至静态内存
                userInfo.UserName = userName.Text.Trim();
                userInfo.socket = socket;
                str = Encoding.UTF8.GetString(data_buffer, 0, r);
                MessageBox.Show("状态信息：" + str);
                Main newform = new Main();
                newform.Show();
                this.Hide();
            }
        }
    }
}
