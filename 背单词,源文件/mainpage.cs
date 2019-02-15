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
using System.Runtime.InteropServices;
namespace 背单词
{
    public partial class mainpage : Form
    {
        [DllImport("user32")]
        public static extern int SetParent(int hWndChild, int hWndNewParent);
        public static string nowdate;
        public static string encouragewords;
        public mainpage()
        {
            InitializeComponent();
        }

        private void 我的资料ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 用户名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你的用户名为：" + loginpage.id + "");
        }

        private void 励志铭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encourageword form = new encourageword();
            form.Show();
        }

        private void 注册时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你注册于" + loginpage.registerdate + "");
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepassword form = new changepassword();
            form.Show();
        }

        private void 注销账户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginpage form = new loginpage();
            this.Hide();
            form.Show();
        }

        private void 我的错题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wrongwords form = new wrongwords();
            form.Show();
        }

        private void 词典ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dictionarycs form = new dictionarycs();
            form.Show();
        }

        private void 关于作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("计算机科学学院\n信息管理与信息系统专业\n41612234\n钟雨森", "作者介绍");
        }

        private void 软件介绍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, helpProvider1.HelpNamespace); 
            Help.ShowHelp(this, Application.StartupPath + @"\帮助文档.chm");//打包成安装包的需要
        }
        static TimeSpan day;
        private void mainpage_Load(object sender, EventArgs e)
        {
            encourage.Text = loginpage.encourageword;
            DateTime date1, date2;
            date1 = DateTime.Parse(loginpage.registerdate);
            date2 = DateTime.Parse(DateTime.Now.ToShortDateString());
            day = date2 - date1;//这里得到的是int类型的day
            //HP.SetShowHelp(this, true);
        } 

        private void mainpage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show("确认退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                e.Cancel = true;
            }
            else
            {
                //Application.Exit(),如果用app.exit，会再次调用窗口关闭，则会弹出两次提示框
            }
        }
        private void mainpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void update_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToShortDateString();
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            conn.Open();
            MySqlCommand update1 = new MySqlCommand("select encourageword from rewords.user where id=" + loginpage.id + "", conn);
            MySqlCommand update2 = new MySqlCommand("select count(*) from rewords.oldwords where id=" + loginpage.id + " and date='" + date + "'", conn);
            encourage.Text = update1.ExecuteScalar().ToString();
            dayslabel.Text = "你已经学习了" + day.Days + "天,\n今天学习了" + update2.ExecuteScalar().ToString() + "个新单词^_^";
            conn.Close();
        }   

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yuanbutton1_BtnClick(object sender, EventArgs e)
        {
            cet4 form = new cet4();
            form.MdiParent = this;
            form.Parent = panel1;
            form.Dock = DockStyle.Fill;
            form.Show();
            SetParent((int)form.Handle, (int)this.Handle);
        }

        private void yuanbutton2_BtnClick(object sender, EventArgs e)
        {
            cet form = new cet();
            form.MdiParent = this;
            form.Parent = panel1;
            form.Dock = DockStyle.Fill;
            form.Show();
            SetParent((int)form.Handle, (int)this.Handle);
        }

        private void yuanbutton3_BtnClick(object sender, EventArgs e)
        {
            //DateTime dt = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            conn.Open();
            MySqlCommand panduan = new MySqlCommand("select number from rewords.oldwords where id=" + loginpage.id + " and date='" + DateTime.Now.ToShortDateString() + "' ", conn);
            object pd = panduan.ExecuteScalar();
            if (pd == DBNull.Value)
                pd = null;
            if (pd == null)
                MessageBox.Show("你今天还没有学习新单词");
            else
            {
                review form = new review();
                form.MdiParent = this;
                form.Parent = panel1;
                form.Dock = DockStyle.Fill;
                form.Show();
                SetParent((int)form.Handle, (int)this.Handle);
            }
        }

        private void yuanbutton4_BtnClick(object sender, EventArgs e)
        {
            wordsfill form = new wordsfill();
            form.MdiParent = this;
            form.Parent = panel1;
            form.Dock = DockStyle.Fill;
            form.Show();
            SetParent((int)form.Handle, (int)this.Handle);
        }
    }
}
