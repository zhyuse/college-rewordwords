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
    public partial class review : Form
    {
        int num = 1;
        int correctnumber, oldmaxnum;
        string realen, realch;
        int time = 10;
        public review()
        {
            InitializeComponent();
        }

        private void A_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            显示计时.Stop();
            timer1.Enabled = false;
            if (correctnumber == 1)
            {
                // player.SoundLocation = Application.StartupPath + @"\答对.wav";
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答对.wav";
                label3.Text = "恭喜答对";
                update(0);
                paint1();
            }
            else
            {
                //player.SoundLocation = Application.StartupPath + @"\答错.wav";
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答错.wav";
                label3.Text = "答错了，它的意思为：" + realch + "";
                paint2();
            }
            player.Load();
            player.Play();
            if (oldmaxnum < num)
            {
                MessageBox.Show("你已经复习完了所学的单词，nice");
                this.Hide();
            }
            else
                time = 10;
        }

        private void B_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            显示计时.Stop();
            timer1.Enabled = false;
            if (correctnumber == 2)
            {
                // player.SoundLocation = Application.StartupPath + @"\答对.wav";
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答对.wav";
                label3.Text = "恭喜答对";
                update(0);
                paint1();
            }
            else
            {
                //player.SoundLocation = Application.StartupPath + @"\答错.wav";
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答错.wav";
                label3.Text = "答错了，它的意思为：" + realch + "";
                paint2();
            }
            player.Load();
            player.Play();
            if (oldmaxnum < num)
            {
                MessageBox.Show("你已经复习完了所学的单词，nice");
                this.Hide();
            }
            else         
                time = 10;
        }

        private void C_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            显示计时.Stop();
            timer1.Enabled = false;
            if (correctnumber == 3)
            {
                // player.SoundLocation = Application.StartupPath + @"\答对.wav";
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答对.wav";
                label3.Text = "恭喜答对";
                update(0);
                paint1();
            }
            else
            {
                //player.SoundLocation = Application.StartupPath + @"\答错.wav";
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答错.wav";
                label3.Text = "答错了，它的意思为：" + realch + "";
                paint2();
            }
            player.Load();
            player.Play();
            if (oldmaxnum < num)
            {
                MessageBox.Show("你已经复习完了所学的单词，nice");
                this.Hide();
            }
            else
                time = 10;
        }

        private void D_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            显示计时.Stop();
            timer1.Enabled = false;
            if (correctnumber == 4)
            {
                // player.SoundLocation = Application.StartupPath + @"\答对.wav";
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答对.wav";
                label3.Text = "恭喜答对";
                update(0);
                paint1();
            }
            else
            {
                //player.SoundLocation = Application.StartupPath + @"\答错.wav";
                player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答错.wav";
                label3.Text = "答错了，它的意思为：" + realch + "";
                paint2();
            }
            player.Load();
            player.Play();
            if (oldmaxnum < num)
            {
                MessageBox.Show("你已经复习完了所学的单词，nice");
                this.Hide();
            }
            else
                time = 10;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void 返回_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            显示计时.Stop();
            timer1.Enabled = false;
            update(0);
            if (oldmaxnum < num)
            {
                MessageBox.Show("你已经复习完了所学的单词，nice");
                this.Hide();
            }
            else
            {
                randshow();
                time = 10;
                显示计时.Start();
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            显示计时.Stop();
            update(1);
            timer1.Enabled = false;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = Application.StartupPath + @"\答错.wav";
            player.SoundLocation = @"C:\Users\Administrator\Desktop\新建文件夹\答错.wav";
            player.Load();
            player.Play();
            label3.Text = "时间到，它的意思为：" + realch + "";
            paint2();
            time = 10;
        }

        private void 显示计时_Tick(object sender, EventArgs e)
        {
            if (time > 0)
                time -= 1;
            label3.Text = "倒计时：" + time.ToString() + "";
        }

        private void timer_emtion_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            button2.Enabled = true;
            if (oldmaxnum < num)
            {
                timer_emtion.Enabled = false;
                timer_emtion.Stop();
                MessageBox.Show("你已经复习完了今天所学的单词，nice");
                this.Hide();
            }
            else
            {
                randshow();
                显示计时.Start();
                timer1.Enabled = true;
            }       
        }

        private void review_Load(object sender, EventArgs e)
        {
            randshow();
        }
        public void randshow()
        {
            timer_emtion.Stop();
            //思路：跟背词一样，先从题库中随机选4个,标记一个选项为正确的，然后从oldwords中随机选一个id符合的词替换正确的那个
            string date = DateTime.Now.ToShortDateString();
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            conn.Open();
            MySqlCommand max = new MySqlCommand("select number from rewords.oldwords where id=" + loginpage.id + " and date='" + date + "' order by number desc", conn);
            oldmaxnum = Convert.ToInt32(max.ExecuteScalar().ToString());
            Random ran = new Random();
            int ran1 = ran.Next(1, 7000);
            int ran2 = ran.Next(1, 7000);
            int ran3 = ran.Next(1, 7000);
            int ran4 = ran.Next(1, 7000);
            if (ran1 == ran2 || ran1 == ran3 || ran1 == ran4)
                ran1 = ran.Next(1, 7000);
            if (ran2 == ran3 || ran2 == ran4)
                ran2 = ran.Next(1, 7000);
            if (ran3 == ran4)
                ran3 = ran.Next(1, 7000);
            correctnumber = ran.Next(1, 5);
            MySqlCommand ch1 = new MySqlCommand("select chinese from  rewords.words where words.number=" + ran1 + "", conn);
            MySqlCommand en1 = new MySqlCommand("select word from  rewords.words where words.number=" + ran1 + "", conn);
            MySqlCommand ch2 = new MySqlCommand("select chinese from  rewords.words where words.number=" + ran2 + "", conn);
            MySqlCommand en2 = new MySqlCommand("select word from  rewords.words where words.number=" + ran2 + "", conn);
            MySqlCommand ch3 = new MySqlCommand("select chinese from  rewords.words where words.number=" + ran3 + "", conn);
            MySqlCommand en3 = new MySqlCommand("select word from  rewords.words where words.number=" + ran3 + "", conn);
            MySqlCommand ch4 = new MySqlCommand("select chinese from  rewords.words where words.number=" + ran4 + "", conn);
            MySqlCommand en4 = new MySqlCommand("select word from  rewords.words where words.number=" + ran4 + "", conn);
            A.Text = "A." + ch1.ExecuteScalar().ToString() + "";
            B.Text = "B." + ch2.ExecuteScalar().ToString() + "";
            C.Text = "C." + ch3.ExecuteScalar().ToString() + "";
            D.Text = "D." + ch4.ExecuteScalar().ToString() + "";
           // label1.Text = correctnumber.ToString();
            MySqlCommand realchcmd = new MySqlCommand("select chinese from rewords.oldwords where number=" + num + " and id=" + loginpage.id + "  and date='" + date + "'", conn);
            MySqlCommand realencmd = new MySqlCommand("select word from rewords.oldwords where number=" + num + " and id=" + loginpage.id + "  and date='" + date + "'", conn);
            switch (correctnumber)
            {
                case 1:
                    realch = realchcmd.ExecuteScalar().ToString();
                    realen = realencmd.ExecuteScalar().ToString();
                    A.Text = "A." + realch + "";
                    label2.Text = realen;
                    break;
                case 2:
                    realch = realchcmd.ExecuteScalar().ToString();
                    realen = realencmd.ExecuteScalar().ToString();
                    B.Text = "B." + realch + "";
                    label2.Text = realen;
                    break;
                case 3:
                    realch = realchcmd.ExecuteScalar().ToString();
                    realen = realencmd.ExecuteScalar().ToString();
                    C.Text = "C." + realch + "";
                    label2.Text = realen;
                    break;
                default:
                    realch = realchcmd.ExecuteScalar().ToString();
                    realen = realencmd.ExecuteScalar().ToString();
                    D.Text = "D." + realch + "";
                    label2.Text = realen;
                    break;
            }
            num++;
        }
        public void update(int x)
        {
            MySqlConnection conn = new MySqlConnection(loginpage.path);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update oldwords set wrong=" + x + " where id=" + loginpage.id + " and number=" + num + "", conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet set = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(set);
        }
        public void paint1()//笑脸出现
        {
            timer_emtion.Start();
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            button2.Enabled = false;
            Graphics p = this.pictureBox1.CreateGraphics();
            p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen blue = new Pen(Color.Blue, 3);
            SolidBrush brush = new SolidBrush(Color.Yellow);
            p.FillEllipse(brush, 350, 85 + 45 * correctnumber, 50, 50);//350,130
            p.DrawArc(blue, 366, 105 + 45 * correctnumber, 20, 20, 10, 160);
            p.DrawArc(blue, 360, 100 + 45 * correctnumber, 7, 7, 180, 180);
            p.DrawArc(blue, 382, 100 + 45 * correctnumber, 7, 7, 180, 180);
        }
        public void paint2()//哭脸出现
        {
            timer_emtion.Start();
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            button2.Enabled = false;
            Graphics p = this.pictureBox1.CreateGraphics();
            p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen blue = new Pen(Color.Blue, 3);
            SolidBrush brush1 = new SolidBrush(Color.Yellow);
            SolidBrush brush2 = new SolidBrush(Color.Blue);
            p.FillEllipse(brush1, 350, 85 + 45 * correctnumber, 50, 50);//350,130
            p.FillEllipse(brush2, 360, 95 + 45 * correctnumber, 8, 8);
            p.FillEllipse(brush2, 380, 95 + 45 * correctnumber, 8, 8);
            p.DrawLine(blue, 363, 120 + 45 * correctnumber, 388, 120 + 45 * correctnumber);
        }
    }
}
