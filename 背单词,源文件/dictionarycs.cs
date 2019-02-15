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
    public partial class dictionarycs : Form
    {
        public dictionarycs()
        {
            InitializeComponent();
        }

        private void 查询_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            MySqlCommand cmd = new MySqlCommand("select * from  words where words.word=@wd", conn);
            cmd.Parameters.AddWithValue("@wd", textBox1.Text);
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MySqlCommand chcmd = new MySqlCommand("select chinese from rewords.words where word='" + textBox1.Text + "'", conn);
                //这里需要注意没有在words前面加表名,一直出错，后来在sql语言中不断试才找出
                string ch = chcmd.ExecuteScalar().ToString();
                label1.Text = "中文：" + ch + "";
            }
            else if (textBox1.Text == "")
            {
                label1.Text = "请输入要查找的单词";
            }
            else
            {
                label1.Text = "很遗憾，词库中没有找到这个词。。。";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
