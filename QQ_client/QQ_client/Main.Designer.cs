namespace QQ_client
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Msg_send = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.friendList = new System.Windows.Forms.ComboBox();
            this.get_friend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msg_send
            // 
            this.Msg_send.Location = new System.Drawing.Point(595, 54);
            this.Msg_send.Name = "Msg_send";
            this.Msg_send.Size = new System.Drawing.Size(108, 49);
            this.Msg_send.TabIndex = 0;
            this.Msg_send.Text = "信息发送";
            this.Msg_send.UseVisualStyleBackColor = true;
            this.Msg_send.Click += new System.EventHandler(this.Msg_send_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(75, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(473, 219);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(75, 338);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(473, 219);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // friendList
            // 
            this.friendList.FormattingEnabled = true;
            this.friendList.Location = new System.Drawing.Point(595, 230);
            this.friendList.Name = "friendList";
            this.friendList.Size = new System.Drawing.Size(108, 23);
            this.friendList.TabIndex = 3;
            // 
            // get_friend
            // 
            this.get_friend.Location = new System.Drawing.Point(595, 146);
            this.get_friend.Name = "get_friend";
            this.get_friend.Size = new System.Drawing.Size(108, 49);
            this.get_friend.TabIndex = 4;
            this.get_friend.Text = "在线刷新";
            this.get_friend.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 651);
            this.Controls.Add(this.get_friend);
            this.Controls.Add(this.friendList);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Msg_send);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Msg_send;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox friendList;
        private System.Windows.Forms.Button get_friend;
    }
}