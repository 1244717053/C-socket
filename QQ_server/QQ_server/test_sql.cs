using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ_server
{
    public partial class test_sql : Form
    {
        public test_sql()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            string pwd = textBox3.Text.Trim();
            DBHelper db = new DBHelper();
            int result = db.insert_into(id, name, pwd);
            MessageBox.Show(Convert.ToString(result));
        }
    }
}
