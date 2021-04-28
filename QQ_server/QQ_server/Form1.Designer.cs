namespace QQ_server
{
    partial class QQServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.IP_address = new System.Windows.Forms.TextBox();
            this.address_port = new System.Windows.Forms.TextBox();
            this.connect_socket = new System.Windows.Forms.Button();
            this.Msg_list = new System.Windows.Forms.RichTextBox();
            this.Send_list = new System.Windows.Forms.RichTextBox();
            this.login_Msg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regist_view = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.disconnect_btu = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // IP_address
            // 
            this.IP_address.Location = new System.Drawing.Point(45, 68);
            this.IP_address.Name = "IP_address";
            this.IP_address.Size = new System.Drawing.Size(317, 25);
            this.IP_address.TabIndex = 0;
            this.IP_address.Text = "192.168.227.1";
            // 
            // address_port
            // 
            this.address_port.Location = new System.Drawing.Point(422, 68);
            this.address_port.Name = "address_port";
            this.address_port.Size = new System.Drawing.Size(167, 25);
            this.address_port.TabIndex = 1;
            this.address_port.Text = "5000";
            // 
            // connect_socket
            // 
            this.connect_socket.Location = new System.Drawing.Point(653, 60);
            this.connect_socket.Name = "connect_socket";
            this.connect_socket.Size = new System.Drawing.Size(240, 33);
            this.connect_socket.TabIndex = 2;
            this.connect_socket.Text = "打开监听";
            this.connect_socket.UseVisualStyleBackColor = true;
            this.connect_socket.Click += new System.EventHandler(this.connect_socket_Click);
            // 
            // Msg_list
            // 
            this.Msg_list.Location = new System.Drawing.Point(45, 148);
            this.Msg_list.Name = "Msg_list";
            this.Msg_list.Size = new System.Drawing.Size(544, 188);
            this.Msg_list.TabIndex = 3;
            this.Msg_list.Text = "";
            // 
            // Send_list
            // 
            this.Send_list.Location = new System.Drawing.Point(45, 367);
            this.Send_list.Name = "Send_list";
            this.Send_list.Size = new System.Drawing.Size(544, 217);
            this.Send_list.TabIndex = 4;
            this.Send_list.Text = "";
            // 
            // login_Msg
            // 
            this.login_Msg.Location = new System.Drawing.Point(653, 134);
            this.login_Msg.Name = "login_Msg";
            this.login_Msg.Size = new System.Drawing.Size(240, 33);
            this.login_Msg.TabIndex = 5;
            this.login_Msg.Text = "发布订阅";
            this.login_Msg.UseVisualStyleBackColor = true;
            this.login_Msg.Click += new System.EventHandler(this.login_Msg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "端口号";
            // 
            // regist_view
            // 
            this.regist_view.Location = new System.Drawing.Point(653, 210);
            this.regist_view.Name = "regist_view";
            this.regist_view.Size = new System.Drawing.Size(240, 33);
            this.regist_view.TabIndex = 8;
            this.regist_view.Text = "查看注册";
            this.regist_view.UseVisualStyleBackColor = true;
            this.regist_view.Click += new System.EventHandler(this.regist_view_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "测试插入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(662, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "测试查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // disconnect_btu
            // 
            this.disconnect_btu.Location = new System.Drawing.Point(662, 452);
            this.disconnect_btu.Name = "disconnect_btu";
            this.disconnect_btu.Size = new System.Drawing.Size(231, 33);
            this.disconnect_btu.TabIndex = 11;
            this.disconnect_btu.Text = "关闭监听";
            this.disconnect_btu.UseVisualStyleBackColor = true;
            this.disconnect_btu.Click += new System.EventHandler(this.disconnect_btu_Click);
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(662, 528);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(231, 23);
            this.userList.TabIndex = 12;
            // 
            // QQServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 706);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.disconnect_btu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regist_view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_Msg);
            this.Controls.Add(this.Send_list);
            this.Controls.Add(this.Msg_list);
            this.Controls.Add(this.connect_socket);
            this.Controls.Add(this.address_port);
            this.Controls.Add(this.IP_address);
            this.Name = "QQServer";
            this.Text = "QQServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP_address;
        private System.Windows.Forms.TextBox address_port;
        private System.Windows.Forms.Button connect_socket;
        private System.Windows.Forms.RichTextBox Msg_list;
        private System.Windows.Forms.RichTextBox Send_list;
        private System.Windows.Forms.Button login_Msg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button regist_view;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button disconnect_btu;
        private System.Windows.Forms.ComboBox userList;
    }
}

