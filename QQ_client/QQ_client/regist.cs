using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ_client
{
    /// <summary>
    /// 用户信息注册
    /// </summary>
    public partial class regist : Form
    {
        Socket socket;
        public regist()
        {
            InitializeComponent();
        }
        private void regist_btu_Click(object sender, EventArgs e)
        {
            int port = 5000;
            string ip_str = "192.168.227.1";
            string user_id = id_txt.Text.Trim();
            string user_name = name_txt.Text.Trim();
            string user_pwd = pwd_txt.Text;
            string user_repwd = repwd_txt.Text;
            if (id_txt.Text.Trim() == "" || name_txt.Text.Trim() == "" || pwd_txt.Text == "" || repwd_txt.Text == "")
            {
                MessageBox.Show("输入内容不能为空");
            }
            else 
            {
                if (pwd_txt.Text != repwd_txt.Text)
                {
                    MessageBox.Show("两次密码输入不一致！");
                }
                else 
                {
                    try {
                        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        IPAddress ip = IPAddress.Parse(ip_str);
                        IPEndPoint ip_port = new IPEndPoint(ip, 5000);
                        socket.Connect(ip_port);
                        SendInfo(user_id, user_name, user_pwd);
                    }
                    catch {
                        MessageBox.Show("连接服务器失败！");
                    }
                }
            }
        }
        void ShowMsg(string str) 
        {
            MessageBox.Show(str);
        }
        void SendInfo(string id, string name, string pwd) 
        {
            id = id + "|";
            name = name + "|";
            string all_msg = id + name + pwd;
            byte[] Msg = new byte[1024 * 1024 * 5];
            Msg = Encoding.UTF8.GetBytes("0"+all_msg);
            socket.Send(Msg);
            ShowMsg("注册信息已发送！");
        }
    }
}
