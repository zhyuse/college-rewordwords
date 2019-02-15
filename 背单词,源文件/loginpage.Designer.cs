namespace 背单词
{
    partial class loginpage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginpage));
            this.密码 = new System.Windows.Forms.Label();
            this.用户名 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zhuce = new System.Windows.Forms.Button();
            this.denglu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 密码
            // 
            this.密码.AutoSize = true;
            this.密码.BackColor = System.Drawing.Color.Transparent;
            this.密码.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.密码.Location = new System.Drawing.Point(85, 193);
            this.密码.Name = "密码";
            this.密码.Size = new System.Drawing.Size(62, 25);
            this.密码.TabIndex = 8;
            this.密码.Text = "密码";
            // 
            // 用户名
            // 
            this.用户名.AutoSize = true;
            this.用户名.BackColor = System.Drawing.Color.Transparent;
            this.用户名.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户名.Location = new System.Drawing.Point(85, 118);
            this.用户名.Name = "用户名";
            this.用户名.Size = new System.Drawing.Size(87, 25);
            this.用户名.TabIndex = 7;
            this.用户名.Text = "用户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(441, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "new";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(210, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 36);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(207, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 38);
            this.textBox1.TabIndex = 12;
            // 
            // zhuce
            // 
            this.zhuce.FlatAppearance.BorderSize = 0;
            this.zhuce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zhuce.Location = new System.Drawing.Point(478, 118);
            this.zhuce.Name = "zhuce";
            this.zhuce.Size = new System.Drawing.Size(93, 23);
            this.zhuce.TabIndex = 14;
            this.zhuce.Text = "新用户注册";
            this.zhuce.UseVisualStyleBackColor = true;
            this.zhuce.Click += new System.EventHandler(this.zhuce_Click_1);
            // 
            // denglu
            // 
            this.denglu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.denglu.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.denglu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.denglu.Location = new System.Drawing.Point(188, 249);
            this.denglu.Name = "denglu";
            this.denglu.Size = new System.Drawing.Size(206, 49);
            this.denglu.TabIndex = 15;
            this.denglu.Text = "登录";
            this.denglu.UseVisualStyleBackColor = false;
            this.denglu.Click += new System.EventHandler(this.denglu_Click);
            // 
            // loginpage
            // 
            this.AcceptButton = this.denglu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::背单词.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 454);
            this.Controls.Add(this.zhuce);
            this.Controls.Add(this.denglu);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.密码);
            this.Controls.Add(this.用户名);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "loginpage";
            this.Text = "钟氏单词";
            this.Load += new System.EventHandler(this.loginpage_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpage_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginpage_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 密码;
        private System.Windows.Forms.Label 用户名;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button zhuce;
        private System.Windows.Forms.Button denglu;
    }
}

