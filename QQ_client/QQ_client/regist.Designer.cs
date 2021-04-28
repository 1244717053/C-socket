namespace QQ_client
{
    partial class regist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.pwd_txt = new System.Windows.Forms.TextBox();
            this.repwd_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regist_btu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(95, 50);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(163, 25);
            this.id_txt.TabIndex = 2;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(95, 113);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(163, 25);
            this.name_txt.TabIndex = 3;
            // 
            // pwd_txt
            // 
            this.pwd_txt.Location = new System.Drawing.Point(95, 181);
            this.pwd_txt.Name = "pwd_txt";
            this.pwd_txt.PasswordChar = '*';
            this.pwd_txt.Size = new System.Drawing.Size(163, 25);
            this.pwd_txt.TabIndex = 4;
            // 
            // repwd_txt
            // 
            this.repwd_txt.Location = new System.Drawing.Point(95, 253);
            this.repwd_txt.Name = "repwd_txt";
            this.repwd_txt.PasswordChar = '*';
            this.repwd_txt.Size = new System.Drawing.Size(163, 25);
            this.repwd_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "pwd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "repwd";
            // 
            // regist_btu
            // 
            this.regist_btu.Location = new System.Drawing.Point(43, 338);
            this.regist_btu.Name = "regist_btu";
            this.regist_btu.Size = new System.Drawing.Size(175, 66);
            this.regist_btu.TabIndex = 8;
            this.regist_btu.Text = "注册";
            this.regist_btu.UseVisualStyleBackColor = true;
            this.regist_btu.Click += new System.EventHandler(this.regist_btu_Click);
            // 
            // regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 492);
            this.Controls.Add(this.regist_btu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repwd_txt);
            this.Controls.Add(this.pwd_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "regist";
            this.Text = "regist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox pwd_txt;
        private System.Windows.Forms.TextBox repwd_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button regist_btu;
    }
}