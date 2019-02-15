namespace 背单词
{
    partial class cet4
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.返回 = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.显示计时 = new System.Windows.Forms.Timer(this.components);
            this.timer_emtiong = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(273, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "计时";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(250, 345);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 27;
            this.next.Text = "跳过";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = " ";
            // 
            // 返回
            // 
            this.返回.Location = new System.Drawing.Point(45, 345);
            this.返回.Name = "返回";
            this.返回.Size = new System.Drawing.Size(75, 23);
            this.返回.TabIndex = 25;
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
            this.D.Location = new System.Drawing.Point(118, 285);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(138, 23);
            this.D.TabIndex = 24;
            this.D.Text = "button4";
            this.D.UseVisualStyleBackColor = false;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.Transparent;
            this.C.FlatAppearance.BorderSize = 0;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.C.Location = new System.Drawing.Point(118, 235);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(138, 23);
            this.C.TabIndex = 23;
            this.C.Text = "button3";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.Transparent;
            this.B.FlatAppearance.BorderSize = 0;
            this.B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.B.Location = new System.Drawing.Point(118, 184);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(138, 23);
            this.B.TabIndex = 22;
            this.B.Text = "button2";
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.Transparent;
            this.A.FlatAppearance.BorderSize = 0;
            this.A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.A.Location = new System.Drawing.Point(118, 139);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(138, 23);
            this.A.TabIndex = 21;
            this.A.Text = "button1";
            this.A.UseVisualStyleBackColor = false;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // 显示计时
            // 
            this.显示计时.Enabled = true;
            this.显示计时.Interval = 1000;
            this.显示计时.Tick += new System.EventHandler(this.显示计时_Tick);
            // 
            // timer_emtiong
            // 
            this.timer_emtiong.Enabled = true;
            this.timer_emtiong.Interval = 3000;
            this.timer_emtiong.Tick += new System.EventHandler(this.timer_emtiong_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 410);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // cet4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(598, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.next);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.返回);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cet4";
            this.Text = "cet4";
            this.Load += new System.EventHandler(this.cet4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 返回;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer 显示计时;
        private System.Windows.Forms.Timer timer_emtiong;
    }
}