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
/// <summary>
/// 该服务器用于接受客户端消息，并为客户端发布信息（群发）,可以查看注册成功的人员信息
/// </summary>
namespace QQ_server
{
    public partial class QQServer : Form
    {
        public QQServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 全局变量
        /// </summary>
        Socket socket;
        Socket socket_acc;
        Dictionary<string, Socket> dictionary_list = new Dictionary<string, Socket>();
        private void connect_socket_Click(object sender, EventArgs e)
        {

            // 使用TCP协议
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // 创建端口号对象及套接字
            IPAddress ipaddress = IPAddress.Parse(IP_address.Text);
            IPEndPoint IP_port = new IPEndPoint(ipaddress, Convert.ToInt32(address_port.Text));
            socket.Bind(IP_port);
            // 创建监听上限
            socket.Listen(1000);
            ShowMsg("监听成功！");

            // 通过accept接受连接
            Thread th = new Thread(Accept_msg);
            th.IsBackground = true;
            th.Start();
            connect_socket.Text = "正在监听";
            connect_socket.Enabled = false;
        }

        void ShowMsg(string str) 
        {
            Msg_list.AppendText(str+"\r\n");
        }

        void Accept_msg() 
        {
            //这里要使用多线程，防止服务器挂掉
            while (true)
            {
                try {
                    socket_acc = socket.Accept();
                    ShowMsg(socket_acc.RemoteEndPoint.ToString() + ":" + "连接成功！");
                    dictionary_list.Add(socket_acc.RemoteEndPoint.ToString(), socket_acc);
                    userList.Items.Add(socket_acc.RemoteEndPoint.ToString());
                    Thread th = new Thread(Access_msg);
                    th.IsBackground = true;
                    th.Start(socket_acc);
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        /// <summary>
        /// 接受客户端发来的信息
        /// </summary>
        void Access_msg(object o) 
        {
            Socket socket = o as Socket;
                // 创建一个字节流用于接收消息
                try
                {
                    while (true) {
                        byte[] receive_msg = new byte[1024 * 1024 * 10];
                        int r = socket.Receive(receive_msg);
                        string str = Encoding.UTF8.GetString(receive_msg, 0, r);
                        int result = Received_msg_and_return_data_login(socket, str);
                    if (result == 0) 
                    {
                        string[] str_single = str.Split('|');
                        string str_id = str_single[0].Substring(1,str_single[0].Length-1);
                        ShowMsg("用户ID:"+ str_id + "用户名:" + str_single[1] + "密码:" + str_single[2]);
                        Regist(str_id, str_single[1], str_single[2]);
                    }
                    if (result == 1) 
                    {
                        string[] str_single = str.Split('|');
                        string str_name = str_single[0].Substring(1, str_single[0].Length-1);
                        ShowMsg("用户名:" + str_name + "密码:" + str_single[1]);
                        var return_log = login_return(str_name, str_single[1]);
                        if (return_log == 1)
                        {
                            Send_Msg(socket, "登陆成功！");
                        }
                        else 
                        {
                            Send_Msg(socket, "登陆失败！");
                        }
                    }
                    }
                }
            catch (Exception ex)
            {
               /*MessageBox.Show(ex.ToString());*/
            }
        }
        //服务器发送信息返回客户端
        public void Send_Msg(Socket socket, string Str) 
        {
            try
            {
                byte[] send_msg_buffer = new byte[1024 * 1024 * 1];
                send_msg_buffer = Encoding.UTF8.GetBytes(Str);
                socket.Send(send_msg_buffer);
            }
            catch {
            
            }
        }

        private void regist_view_Click(object sender, EventArgs e)
        {
            user newform = new user();
            newform.Show();
        }
        // 接收数据并进行返回
        private int Received_msg_and_return_data_login(Socket socket, string str) 
        {
            // 这里需要给str加上一个标志位
            if (str[0] == '0') {
                ShowMsg(socket.RemoteEndPoint.ToString() +"发来注册信息" +":" + str);
                return 0;
            }
            if (str[0] == '1') {
                ShowMsg(socket.RemoteEndPoint.ToString() + "发来登录信息" + ":" + str);
                return 1;
            }
            else {
                ShowMsg(socket.RemoteEndPoint.ToString() + "其他信息" + ":" + str);
                return 2;
            }
            return 2;
        }
        //服务器主机注册
        private void Regist(string id, string name, string pwd) 
        {
            DBHelper db = new DBHelper();
            int result = db.insert_into(id, name, pwd);
            if (result == 0)
            {
                ShowMsg("数据插入成功！");
            }
            else 
            {
                ShowMsg("数据插入失败！");
            }
        }
        // 服务器主机确认
        private int login_return(string name, string pwd) 
        {
            DBHelper db = new DBHelper();
            int result = db.select_single_ado(name, pwd);
            if (result == 0)
            {
                ShowMsg("登陆失败！");
            }
            else 
            {
                ShowMsg("登陆成功！");
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test_sql form = new test_sql();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "123123";
            string pwd = "123";
            login_return(name, pwd);
        }

        private void disconnect_btu_Click(object sender, EventArgs e)
        {
            connect_socket.Text = "打开监听";
            connect_socket.Enabled = true;
            Application.Exit();
        }

        private void login_Msg_Click(object sender, EventArgs e)
        {
            string send_msg = Send_list.Text;
            if (userList.SelectedItem != null)
            {
                string item = userList.SelectedItem.ToString();
                ShowMsg(item);
                Send_Msg(dictionary_list[item], send_msg);
            }
            else 
            {
                ShowMsg("未选中发送目标，默认信息全部发布！");
                foreach (string item in userList.Items) 
                {
                    Send_Msg(dictionary_list[item], send_msg);
                }
            }
        }
    }
}
