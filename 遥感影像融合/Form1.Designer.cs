namespace 遥感影像融合
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.遥感图像读入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.遥感图像融合ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.比值变换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.乘积变换融合ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加权融合ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.融合效果评价ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平均梯度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.偏差指数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.遥感图像读入ToolStripMenuItem,
            this.遥感图像融合ToolStripMenuItem,
            this.融合效果评价ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 遥感图像读入ToolStripMenuItem
            // 
            this.遥感图像读入ToolStripMenuItem.Name = "遥感图像读入ToolStripMenuItem";
            this.遥感图像读入ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.遥感图像读入ToolStripMenuItem.Text = "遥感图像读入";
            this.遥感图像读入ToolStripMenuItem.Click += new System.EventHandler(this.遥感图像读入ToolStripMenuItem_Click);
            // 
            // 遥感图像融合ToolStripMenuItem
            // 
            this.遥感图像融合ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.比值变换ToolStripMenuItem,
            this.乘积变换融合ToolStripMenuItem,
            this.加权融合ToolStripMenuItem});
            this.遥感图像融合ToolStripMenuItem.Name = "遥感图像融合ToolStripMenuItem";
            this.遥感图像融合ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.遥感图像融合ToolStripMenuItem.Text = "遥感图像融合";
            // 
            // 比值变换ToolStripMenuItem
            // 
            this.比值变换ToolStripMenuItem.Name = "比值变换ToolStripMenuItem";
            this.比值变换ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.比值变换ToolStripMenuItem.Text = "比值变换融合";
            this.比值变换ToolStripMenuItem.Click += new System.EventHandler(this.比值变换ToolStripMenuItem_Click);
            // 
            // 乘积变换融合ToolStripMenuItem
            // 
            this.乘积变换融合ToolStripMenuItem.Name = "乘积变换融合ToolStripMenuItem";
            this.乘积变换融合ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.乘积变换融合ToolStripMenuItem.Text = "乘积变换融合";
            this.乘积变换融合ToolStripMenuItem.Click += new System.EventHandler(this.乘积变换融合ToolStripMenuItem_Click);
            // 
            // 加权融合ToolStripMenuItem
            // 
            this.加权融合ToolStripMenuItem.Name = "加权融合ToolStripMenuItem";
            this.加权融合ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.加权融合ToolStripMenuItem.Text = "加权融合";
            this.加权融合ToolStripMenuItem.Click += new System.EventHandler(this.加权融合ToolStripMenuItem_Click);
            // 
            // 融合效果评价ToolStripMenuItem
            // 
            this.融合效果评价ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.平均梯度ToolStripMenuItem,
            this.偏差指数ToolStripMenuItem});
            this.融合效果评价ToolStripMenuItem.Name = "融合效果评价ToolStripMenuItem";
            this.融合效果评价ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.融合效果评价ToolStripMenuItem.Text = "融合效果评价";
            // 
            // 平均梯度ToolStripMenuItem
            // 
            this.平均梯度ToolStripMenuItem.Name = "平均梯度ToolStripMenuItem";
            this.平均梯度ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.平均梯度ToolStripMenuItem.Text = "平均梯度";
            this.平均梯度ToolStripMenuItem.Click += new System.EventHandler(this.平均梯度ToolStripMenuItem_Click);
            // 
            // 偏差指数ToolStripMenuItem
            // 
            this.偏差指数ToolStripMenuItem.Name = "偏差指数ToolStripMenuItem";
            this.偏差指数ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.偏差指数ToolStripMenuItem.Text = "偏差指数";
            this.偏差指数ToolStripMenuItem.Click += new System.EventHandler(this.偏差指数ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "全色影像";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "多光谱影像";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(444, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(393, 426);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 500);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "遥感影像融合";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 遥感图像读入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 遥感图像融合ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 比值变换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 乘积变换融合ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加权融合ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 融合效果评价ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平均梯度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 偏差指数ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

