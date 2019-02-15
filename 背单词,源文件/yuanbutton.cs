using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 背单词
{
    public partial class yuanbutton : UserControl
    {//具有自定义属性Color，sizetest（label的大小）,locationlabel(label的位置),coloryuan(圆的颜色),BtnClick;(按钮点击事件)
        public yuanbutton()
        {
            InitializeComponent();
        }

        private void yuanbutton_Load(object sender, EventArgs e)
        {
            Graphics p = this.CreateGraphics();
            p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(Color.Yellow);
            p.FillEllipse(brush, 0, 0, this.Width, this.Height);
        }
        public string Buttontext
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public Color Color
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Size sizetest
        {
            get { return label1.Size; }
            set { label1.Size = value; }
        }
        public Point locationlabel
        {
            get { return label1.Location; }
            set { label1.Location = value; }
        }
        Color x = Color.Yellow;//默认颜色黄色
        public Color coloryuan
        {
            get { return x; }
            set
            {
                x = value;
                pain(value);
                label1.BackColor = value;
            }
        }

        private void yuanbutton_Paint(object sender, PaintEventArgs e)
        {
            Graphics p = e.Graphics;
            p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(x);
            p.FillEllipse(brush, 0, 0, this.Width, this.Height);
        }
        public void pain(Color x)//pain函数改变圆的大小
        {
            Graphics p = this.CreateGraphics();
            p.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(x);
            p.FillEllipse(brush, 0, 0, this.Width, this.Height);
        }
        public event EventHandler BtnClick;

        private void yuanbutton_MouseClick(object sender, MouseEventArgs e)//圆区域的判定
        {
            double x1, x2, y1, y2;
            x1 = (double)e.X;
            x2 = (double)this.Width;
            y1 = (double)e.Y;
            y2 = (double)this.Height;
            if (4 * (x1 - 0.5 * x2) * (x1 - 0.5 * x2) / (x2 * x2) + 4 * (y1 - 0.5 * y2) * (y1 - 0.5 * y2) / (y2 * y2) <= 1)//转换为double类型再运算
            {
                if (BtnClick != null)
                {
                    BtnClick(sender, e);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)//如果不加这个当点击label的时候会没反应
        {
            if (BtnClick != null)
            {
                BtnClick(sender, e);
            }
        }
    }
}
