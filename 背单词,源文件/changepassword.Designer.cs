namespace 背单词
{
    partial class changepassword
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
            this.修改 = new System.Windows.Forms.Button();
            this.again = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 修改
            // 
            this.修改.Location = new System.Drawing.Point(163, 203);
            this.修改.Name = "修改";
            this.修改.Size = new System.Drawing.Size(75, 23);
            this.修改.TabIndex = 5;
            this.修改.Text = "修改";
            this.修改.UseVisualStyleBackColor = true;
            this.修改.Click += new System.EventHandler(this.修改_Click);
            // 
            // again
            // 
            this.again.Location = new System.Drawing.Point(163, 144);
            this.again.Name = "again";
            this.again.Size = new System.Drawing.Size(100, 25);
            this.again.TabIndex = 4;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(163, 89);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 25);
            this.input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "输入密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "再次输入";
            // 
            // changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.修改);
            this.Controls.Add(this.again);
            this.Controls.Add(this.input);
            this.Name = "changepassword";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 修改;
        private System.Windows.Forms.TextBox again;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}