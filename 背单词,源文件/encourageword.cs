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
    public partial class encourageword : Form
    {
        public encourageword()
        {
            InitializeComponent();
        }

        private void 修改_Click(object sender, EventArgs e)
        {
            string changecmd = "update user set encourageword='" + textBox1.Text + "' where id='" + loginpage.id + "'";
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(changecmd, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet set = new DataSet();
            da.Fill(set);
            conn.Close();
            MessageBox.Show("修改成功！");
            this.Hide();
            encourageword form = new encourageword();
            form.Show();
        }

        private void encourageword_Load(object sender, EventArgs e)
        {
            string querycmd = "select * from user where id='" + loginpage.id + "'";
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(querycmd, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet set = new DataSet();
            da.Fill(set, "user");
            textBox1.DataBindings.Add("Text", set, "user.encourageword");
            conn.Close();
        }
    }
}
