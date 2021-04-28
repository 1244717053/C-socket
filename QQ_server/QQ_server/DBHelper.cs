using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
namespace QQ_server
{
    class DBHelper
    {
        DataContext linq;//声明了linq对象
        string server = @"Server=localhost\SQLEXPRESS01;Database=DB_QQ_Server;Trusted_Connection=True;";
        /// <summary>
        /// 返回值为0时，插入成功，返回值为1时，插入失败
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int insert_into(string id, string name, string pwd) { 
            try
            {
                linq = new DataContext(server);//这就连上了;
                QQ_userInfo user = new QQ_userInfo();
                user.ID = Convert.ToInt32(id);
                user.userName = name;
                user.Pwd = pwd;
                user.Login = 0;
                linq.QQ_userInfo.InsertOnSubmit(user);
                linq.SubmitChanges();
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public object select_single(string name, string pwd)
        {
            linq = new DataContext(server);// linq对象连接数据库
            var result = from user in linq.QQ_userInfo
                         where user.userName == name && user.Pwd == pwd
                         select new
                         {
                             UserId = user.ID,
                             UserName = user.userName,
                             friendId = user.FriendId,
                             login_status = user.Login
                         };
            return result;
        }

        public int select_single_ado(string name, string pwd) 
        {
            //这里的sql语句写的有问题。先暂时这么用吧
            string str = @"Server=localhost\SQLEXPRESS01;Database= DB_QQ_Server;Trusted_Connection=True;"; 
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = @"select COUNT(1) from [dbo].[QQ_userInfo] where[userName] = '"+name+"';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = (int)cmd.ExecuteScalar();
            conn.Close();
            return result;
        }
        
    }
}
