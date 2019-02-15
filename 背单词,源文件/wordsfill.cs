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
    public partial class wordsfill : Form
    {
        static string thestr,theword;
        public wordsfill()
        {
            InitializeComponent();
        }

        private void wordsfill_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            generate();
        }
        public void generate()//生成单词并随机抽取一个字母
        {
            timer1.Stop();
            string thechinese, before, after;
            int length;
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            conn.Open();
            Random ran = new Random();
            int ran1 = ran.Next(1, 7721);
            MySqlCommand word = new MySqlCommand("select words.word from rewords.words where number=" + ran1 + "", conn);
            MySqlCommand chinese = new MySqlCommand("select words.chinese from rewords.words where number=" + ran1 + "", conn);
            theword = word.ExecuteScalar().ToString();
            thechinese = chinese.ExecuteScalar().ToString();
            length = theword.Length;
            int ran2 = ran.Next(1, length);//ran2缺少的字母的位置
            before = theword.Substring(0, ran2-1);
            thestr = theword.Substring(ran2 - 1, 1);
            after = theword.Substring(ran2, length - ran2);
            label1.Text = before;
            label2.Text = after;
            label3.Text = "中文："+thechinese+"";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void queding_Click(object sender, EventArgs e)
        {
            queding.Enabled = false;
            if (textBox1.Text == thestr)
            {
                pain1();
                label5.Text = "正确^_^";
            }
            else
            {
                paint2();
                label5.Text = "正确拼写是"+theword+"";
            }
            timer1.Start();
        }
        public void pain1()
        {
            Graphics p = this.CreateGraphics();
            p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen blue = new Pen(Color.Blue, 3);
            SolidBrush brush = new SolidBrush(Color.Yellow);
            p.FillEllipse(brush, 270, 300, 50, 50);//350,130
            p.DrawArc(blue, 286, 320, 20, 20, 10, 160);
            p.DrawArc(blue, 280, 315, 7, 7, 180, 180);
            p.DrawArc(blue, 302, 315, 7, 7, 180, 180);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            queding.Enabled = true;
            this.Refresh();
            generate();
            textBox1.Text = null;
            label5.Text = null;
            this.ActiveControl = textBox1;
        }

        private void wordsfill_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void wordsfill_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Enabled = false;
        }

        public void paint2()
        {
            Graphics p = this.CreateGraphics();
            p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen blue = new Pen(Color.Blue, 3);
            SolidBrush brush1 = new SolidBrush(Color.Yellow);
            SolidBrush brush2 = new SolidBrush(Color.Blue);
            p.FillEllipse(brush1, 270, 300, 50, 50);//350,130
            p.FillEllipse(brush2, 280,310, 8, 8);
            p.FillEllipse(brush2, 300, 310, 8, 8);
            p.DrawLine(blue, 283, 335, 308, 335);
        }
    }
}
