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
    public partial class changepassword : Form
    {
        public changepassword()
        {
            InitializeComponent();
        }

        private void 修改_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            conn.Open();
            MySqlCommand insertcmd = new MySqlCommand("update user set password='" + again.Text + "'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = insertcmd;
            DataSet set = new DataSet();
            if (input.Text == string.Empty || again.Text == string.Empty)
            {
                MessageBox.Show("不得留空");
            }
            else if (input.Text != again.Text)
            {
                MessageBox.Show("密码不一致");
            }
            else
            {
                da.Fill(set);
                MessageBox.Show("修改成功");
                conn.Close();
                register form = new register();
                this.Close();
            }
        }
    }
}
