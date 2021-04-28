using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Sql;
namespace QQ_server
{
    /// <summary>
    /// 数据库查询及检索
    /// </summary>
    public partial class user : Form
    {
        SqlConnection conn;
        DataContext linq;//声明了linq对象
        string server = @"Server=localhost\SQLEXPRESS01;Database=DB_QQ_Server;Trusted_Connection=True;";
        public user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userID.Text == "")
            {
                Bindinfo_all();
            }
            //创建一个自定义函数用于加载数据
            else 
            {
                Bindinfo();
            }
        }
        void Bindinfo() 
        {
            linq = new DataContext(server);//这就连上了
            int ID = Convert.ToInt32(userID.Text.Trim());
            var result = from user in linq.QQ_userInfo
                         where user.ID == ID
                         select new
                         {
                             UserId = user.ID,
                             UserName = user.userName,
                             friendId = user.FriendId,
                         };
            dataGridView1.DataSource = result;
        }
        void Bindinfo_all()
        {
            linq = new DataContext(server);//这就连上了
            var result = from user in linq.QQ_userInfo
                         select new
                         {
                             UserId = user.ID,
                             UserName = user.userName,
                             friendId = user.FriendId,
                         };
            dataGridView1.DataSource = result;
        }
    }
}
