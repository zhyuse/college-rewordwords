namespace 背单词
{
    partial class review
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.返回 = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.显示计时 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.timer_emtion = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // 返回
            // 
            this.返回.Location = new System.Drawing.Point(77, 340);
            this.返回.Name = "返回";
            this.返回.Size = new System.Drawing.Size(75, 23);
            this.返回.TabIndex = 22;
            this.返回.Text = "返回";
            this.返回.UseVisualStyleBackColor = true;
            this.返回.Click += new System.EventHandler(this.返回_Click);
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.Transparent;
            this.D.FlatAppearance.BorderSize = 0;
            this.D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.D.Location = new System.Drawing.Point(122, 272);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(109, 23);
            this.D.TabIndex = 21;
            this.D.Text = "button6";
            this.D.UseVisualStyleBackColor = false;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.Transparent;
            this.C.FlatAppearance.BorderSize = 0;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.C.Location = new System.Drawing.Point(122, 227);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(109, 23);
            this.C.TabIndex = 20;
            this.C.Text = "button5";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.Transparent;
            this.B.FlatAppearance.BorderSize = 0;
            this.B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.B.Location = new System.Drawing.Point(122, 183);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(109, 23);
            this.B.TabIndex = 19;
            this.B.Text = "button4";
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.Transparent;
            this.A.FlatAppearance.BorderSize = 0;
            this.A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.A.Location = new System.Drawing.Point(122, 140);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(109, 23);
            this.A.TabIndex = 18;
            this.A.Text = "button3";
            this.A.UseVisualStyleBackColor = false;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "跳过";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "计时";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 显示计时
            // 
            this.显示计时.Enabled = true;
            this.显示计时.Interval = 1000;
            this.显示计时.Tick += new System.EventHandler(this.显示计时_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(307, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "计时";
            // 
            // timer_emtion
            // 
            this.timer_emtion.Enabled = true;
            this.timer_emtion.Interval = 3000;
            this.timer_emtion.Tick += new System.EventHandler(this.timer_emtion_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = " ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 405);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(523, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.返回);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "review";
            this.Text = "review";
            this.Load += new System.EventHandler(this.review_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 返回;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer 显示计时;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer_emtion;
        private System.Windows.Forms.Label label1;
    }
}