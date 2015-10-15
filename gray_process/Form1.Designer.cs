namespace gray_process
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选择图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.灰度处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对比度处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图片分割ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(32, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 227);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(419, 77);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 227);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(98, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "处理前图片";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(500, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "处理后图片";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择图片ToolStripMenuItem,
            this.灰度处理ToolStripMenuItem,
            this.对比度处理ToolStripMenuItem,
            this.图片分割ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 29);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选择图片ToolStripMenuItem
            // 
            this.选择图片ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.选择图片ToolStripMenuItem.Name = "选择图片ToolStripMenuItem";
            this.选择图片ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.选择图片ToolStripMenuItem.Text = "选择图片";
            this.选择图片ToolStripMenuItem.Click += new System.EventHandler(this.选择图片ToolStripMenuItem_Click);
            // 
            // 灰度处理ToolStripMenuItem
            // 
            this.灰度处理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.灰度处理ToolStripMenuItem.Name = "灰度处理ToolStripMenuItem";
            this.灰度处理ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.灰度处理ToolStripMenuItem.Text = "灰度处理";
            this.灰度处理ToolStripMenuItem.Click += new System.EventHandler(this.灰度处理ToolStripMenuItem_Click);
            // 
            // 对比度处理ToolStripMenuItem
            // 
            this.对比度处理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.对比度处理ToolStripMenuItem.Name = "对比度处理ToolStripMenuItem";
            this.对比度处理ToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.对比度处理ToolStripMenuItem.Text = "对比度处理";
            this.对比度处理ToolStripMenuItem.Click += new System.EventHandler(this.对比度处理ToolStripMenuItem_Click);
            // 
            // 图片分割ToolStripMenuItem
            // 
            this.图片分割ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.图片分割ToolStripMenuItem.Name = "图片分割ToolStripMenuItem";
            this.图片分割ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.图片分割ToolStripMenuItem.Text = "图片分割";
            this.图片分割ToolStripMenuItem.Click += new System.EventHandler(this.图片分割ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数字媒体作业";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选择图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 灰度处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 对比度处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图片分割ToolStripMenuItem;
    }
}

