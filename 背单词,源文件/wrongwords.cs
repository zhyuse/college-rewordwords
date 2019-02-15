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
    public partial class wrongwords : Form
    {
        public wrongwords()
        {
            InitializeComponent();
        }

        private void wrongwords_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select number,word,chinese,date from oldwords where id=" + loginpage.id + " and wrong=1 ", conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet set = new DataSet();
            da.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
        }
    }
}
