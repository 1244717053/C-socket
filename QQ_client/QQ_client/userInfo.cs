using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace QQ_client
{
    /// <summary>
    ///静态类用于存储数据，方便窗体间的值传递
    /// </summary>
    class userInfo
    {
        public static string UserName;
        public static Socket socket;
    }
}
