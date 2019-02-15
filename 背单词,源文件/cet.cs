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
    public partial class cet : Form
    {
        string realch, realen;
        int oldnumber;//对应oldwords数据库的编号
        int mark;//标记判断wrong是0还是1
        int correctnumber;
        int time = 10;
        public cet()
        {
            InitializeComponent();
        }

        private void A_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //重置计时器计时和time1计时
            显示计时.Stop();
            timer1.Enabled = false;
            int num = 1;
            if (num == correctnumber)
            {
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答对.wav";
                label3.Text = "恭喜答对";
                mark = 0;
                paint1();
            }
            else
            {
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答错.wav";
                label3.Text = "答错了，它的意思为：" + realch + "";
                mark = 1;
                paint2();
            }
            player.Load();
            player.Play();
            addoldword();
            time = 10;
        }

        private void B_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            显示计时.Stop();
            timer1.Enabled = false;
            int num = 2;
            if (num == correctnumber)
            {
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答对.wav";
                label3.Text = "恭喜答对";
                mark = 0;
                paint1();
            }
            else
            {
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答错.wav";
                label3.Text = "答错了，它的意思为：" + realch + "";
                mark = 1;
                paint2();
            }
            player.Load();
            player.Play();
            addoldword();
            time = 10;
        }

        private void C_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            显示计时.Stop();
            timer1.Enabled = false;
            int num = 3;
            if (num == correctnumber)
            {
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答对.wav";
                label3.Text = "恭喜答对";
                mark = 0;
                paint1();
            }
            else
            {
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答错.wav";
                label3.Text = "答错了，它的意思为：" + realch + "";
                mark = 1;
                paint2();
            }
            player.Load();
            player.Play();
            addoldword();
            time = 10;
        }

        private void D_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            显示计时.Stop();
            timer1.Enabled = false;
            int num = 4;
            if (num == correctnumber)
            {
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答对.wav";
                label3.Text = "恭喜答对";
                mark = 0;
                paint1();
            }
            else
            {
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答错.wav";
                label3.Text = "答错了，它的意思为：" + realch + "";
                mark = 1;
                paint2();
            }
            player.Load();
            player.Play();
            addoldword();
            time = 10;
        }

        private void 返回_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer_emtiong.Enabled = false;
            timer1.Enabled = false;
        }

        private void next_Click(object sender, EventArgs e)
        {
            显示计时.Stop();
            timer1.Enabled = false;
            mark = 0;
            addoldword();
            randshow();
            time = 10;
            显示计时.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            显示计时.Stop();
            mark = 1;
            timer1.Enabled = false;
            label3.Text = "时间到，它的意思为：" + realch + "";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答错.wav";
            player.Load();
            player.Play();
            paint2();
            addoldword();
            time = 10;
        }

        private void 显示计时_Tick(object sender, EventArgs e)
        {
            if (time > 0)
                time -= 1;
            label3.Text = "倒计时：" + time.ToString() + "";
        }

        private void timer_emtiong_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            next.Enabled = true;
            randshow();
            显示计时.Start();
            timer1.Enabled = true;
        }

        private void cet_Load(object sender, EventArgs e)
        {
            randshow();
        }
        public void randshow()
        {
            timer_emtiong.Stop();
            //先随机抽四个数据给四个button，要注意对应 控件编号，然后从1—4随机取一个数字作为正确的选项，并把对应的命令编号的单词中文填入label，即可实现随机抽题进行选择的功能
            //计时方面，点击选项后，会出现表情，停止选项的计时，开始表情出现的计时，等表情时间过后，重置选项的计时，随机生成新单词。如此循环
            Random ran = new Random();
            int ran1 = ran.Next(1, 2089);
            int ran2 = ran.Next(1, 2089);
            int ran3 = ran.Next(1, 2089);
            int ran4 = ran.Next(1, 2089);
            correctnumber = ran.Next(1, 5);
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            MySqlCommand ch1 = new MySqlCommand("select chinese from  rewords.cet6 where cet6.number=" + ran1 + "", conn);
            MySqlCommand en1 = new MySqlCommand("select word from  rewords.cet6 where cet6.number=" + ran1 + "", conn);
            MySqlCommand ch2 = new MySqlCommand("select chinese from  rewords.cet6 where cet6.number=" + ran2 + "", conn);
            MySqlCommand en2 = new MySqlCommand("select word from  rewords.cet6 where cet6.number=" + ran2 + "", conn);
            MySqlCommand ch3 = new MySqlCommand("select chinese from  rewords.cet6 where cet6.number=" + ran3 + "", conn);
            MySqlCommand en3 = new MySqlCommand("select word from  rewords.cet6 where cet6.number=" + ran3 + "", conn);
            MySqlCommand ch4 = new MySqlCommand("select chinese from  rewords.cet6 where cet6.number=" + ran4 + "", conn);
            MySqlCommand en4 = new MySqlCommand("select word from  rewords.cet6 where cet6.number=" + ran4 + "", conn);
            conn.Open();
            A.Text = "A." + ch1.ExecuteScalar().ToString() + "";
            B.Text = "B." + ch2.ExecuteScalar().ToString() + "";
            C.Text = "C." + ch3.ExecuteScalar().ToString() + "";
            D.Text = "D." + ch4.ExecuteScalar().ToString() + "";
            //label2.Text = correctnumber.ToString();
            switch (correctnumber)
            {
                case 1:
                    realen = en1.ExecuteScalar().ToString();
                    realch = ch1.ExecuteScalar().ToString();
                    break;
                case 2:
                    realen = en2.ExecuteScalar().ToString();
                    realch = ch2.ExecuteScalar().ToString();
                    break;
                case 3:
                    realen = en3.ExecuteScalar().ToString();
                    realch = ch3.ExecuteScalar().ToString();
                    break;
                default:
                    realen = en4.ExecuteScalar().ToString();
                    realch = ch4.ExecuteScalar().ToString();
                    break;
            }
            label1.Text = realen;
        }
        public void addoldword()
        {
            string m;
            string date = DateTime.Now.ToShortDateString();
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            conn.Open();
            MySqlCommand panduan = new MySqlCommand("select id from rewords.oldwords where id=" + loginpage.id + " and date='" + date + "'", conn);
            object pd = panduan.ExecuteScalar();
            if (pd == DBNull.Value)//判断是否之前学过.oldwords中有没有对应oldnumber
                pd = null;
            if (pd == null)
            {
                oldnumber = 0;
            }
            else
            {
                MySqlCommand getoldnumber = new MySqlCommand("select number from rewords.oldwords where id=" + loginpage.id + " and date='" + date + "' order by number desc", conn);
                m = getoldnumber.ExecuteScalar().ToString();//转换为int
                oldnumber = Convert.ToInt32(m);
            }
            oldnumber++;
            MySqlCommand addold = new MySqlCommand("insert into rewords.oldwords values('" + loginpage.id + "','" + oldnumber + "','" + realen + "','" + realch + "','" + date + "','" + mark + "')", conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = addold;
            DataSet set = new DataSet();
            da.Fill(set);
            oldnumber++;
        }
        public void paint1()//笑脸出现
        {
            timer_emtiong.Start();
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            next.Enabled = false;
            Graphics p = this.pictureBox1.CreateGraphics();
            p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen blue = new Pen(Color.Blue, 3);
            SolidBrush brush = new SolidBrush(Color.Yellow);
            p.FillEllipse(brush, 270, 85 + 45 * correctnumber, 50, 50);//350,130
            p.DrawArc(blue, 286, 105 + 45 * correctnumber, 20, 20, 10, 160);
            p.DrawArc(blue, 280, 100 + 45 * correctnumber, 7, 7, 180, 180);
            p.DrawArc(blue, 302, 100 + 45 * correctnumber, 7, 7, 180, 180);
        }
        public void paint2()//哭脸出现
        {
            timer_emtiong.Start();
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            next.Enabled = false;
            Graphics p = this.pictureBox1.CreateGraphics();
            p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen blue = new Pen(Color.Blue, 3);
            SolidBrush brush1 = new SolidBrush(Color.Yellow);
            SolidBrush brush2 = new SolidBrush(Color.Blue);
            p.FillEllipse(brush1, 270, 85 + 45 * correctnumber, 50, 50);//350,130
            p.FillEllipse(brush2, 280, 95 + 45 * correctnumber, 8, 8);
            p.FillEllipse(brush2, 300, 95 + 45 * correctnumber, 8, 8);
            p.DrawLine(blue, 283, 120 + 45 * correctnumber, 308, 120 + 45 * correctnumber);
        }
    }
}
