using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace 背单词
{
    public partial class register : Form
    {
        string path = "user id=root;password=7885211;database=rewords";
        public register()
        {
            InitializeComponent();
        }

        private void zhuce_Click(object sender, EventArgs e)
        {
            //连接数据库进行注册功能
            string date = DateTime.Now.ToShortDateString();//注意这里获取的是系统时间，如果系统时间跟数据库格式不一样会出错
            MySqlConnection conn = new MySqlConnection(path);
            conn.Open();
            MySqlCommand insertcmd = new MySqlCommand("insert into user(id,name,password,registerdate) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + date + "')", conn);
            MySqlCommand checkcmd = new MySqlCommand("select * from  user where user.id=" + textBox1.Text + "", conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            MySqlDataAdapter da2 = new MySqlDataAdapter();
            da1.SelectCommand = insertcmd;
            da2.SelectCommand = checkcmd;
            DataSet set = new DataSet();
            DataTable table = new DataTable();
            da2.Fill(table);
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty)
            {
                MessageBox.Show("不得留空");
            }
            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("密码不一致");
            }
            else if (table.Rows.Count > 0)
            {
                MessageBox.Show("已经被注册了");
            }
            else
            {
                da1.Fill(set);
                MessageBox.Show("注册成功，回到登录页面");
                conn.Close();
                register form = new register();
                this.Close();
            }
        }                       
        private void register_Load(object sender, EventArgs e)
        {
       
        }
    }
}
