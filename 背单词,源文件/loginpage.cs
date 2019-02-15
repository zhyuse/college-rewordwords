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
    public partial class loginpage : Form
    {
        public static string id;
        public static string encourageword;
        public static string registerdate;
        public static string path = "user id=root;password=7885211;database=rewords";
        public loginpage()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//keychar 是ascii码,enter对应为13
                denglu.PerformClick();
        }

        private void loginpage_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loginpage_Load(object sender, EventArgs e)
        {
           
        }

        private void zhuce_Click_1(object sender, EventArgs e)
        {
            register form2 = new register();
            //this.Hide();//打开注册页面
            form2.Show();
        }

        private void denglu_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(path);
            try
            {
                string sql = "select * from  user where user.id=" + textBox1.Text + " and user.password=" + textBox2.Text + "";//判断账户密码
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@username", textBox1.Text);
                //cmd.Parameters.AddWithValue("@pwd", textBox2.Text);
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                {
                    MessageBox.Show("请输入用户名或密码");
                }
                else
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        id = textBox1.Text;
                        MySqlCommand namecmd = new MySqlCommand("select name from user where id=" + textBox1.Text + "", conn);
                        MySqlCommand encouragecmd = new MySqlCommand("select encourageword from user where id=" + textBox1.Text + "", conn);
                        MySqlCommand registerdatecmd = new MySqlCommand("select registerdate from user where id=" + textBox1.Text + "", conn);
                        string name = namecmd.ExecuteScalar().ToString();
                        encourageword = encouragecmd.ExecuteScalar().ToString();
                        registerdate = ((DateTime)registerdatecmd.ExecuteScalar()).ToString("yyyy-MM-dd");//MM要大写
                        mainpage form2 = new mainpage();
                        this.Hide();//打开第二个窗口
                        form2.Show();
                        MessageBox.Show("欢迎回来," + name + "\n" + encourageword + "");
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loginpage_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
    
}
