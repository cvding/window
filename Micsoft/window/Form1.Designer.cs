namespace window
{
    partial class winMain
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
            this.components = new System.ComponentModel.Container();
            this.bntReadImgs = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoPath = new System.Windows.Forms.RadioButton();
            this.rdoFile = new System.Windows.Forms.RadioButton();
            this.tmShow = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupGraph = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPen = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.btnLineWidth = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntReadImgs
            // 
            this.bntReadImgs.Location = new System.Drawing.Point(245, 12);
            this.bntReadImgs.Name = "bntReadImgs";
            this.bntReadImgs.Size = new System.Drawing.Size(96, 47);
            this.bntReadImgs.TabIndex = 0;
            this.bntReadImgs.Text = "打开图像";
            this.bntReadImgs.UseVisualStyleBackColor = true;
            this.bntReadImgs.Click += new System.EventHandler(this.bntReadImgs_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 66);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(569, 25);
            this.txtPath.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPath);
            this.groupBox1.Controls.Add(this.rdoFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件类型";
            // 
            // rdoPath
            // 
            this.rdoPath.AutoSize = true;
            this.rdoPath.Location = new System.Drawing.Point(71, 21);
            this.rdoPath.Name = "rdoPath";
            this.rdoPath.Size = new System.Drawing.Size(73, 19);
            this.rdoPath.TabIndex = 1;
            this.rdoPath.Text = "文件夹";
            this.rdoPath.UseVisualStyleBackColor = true;
            // 
            // rdoFile
            // 
            this.rdoFile.AutoSize = true;
            this.rdoFile.Checked = true;
            this.rdoFile.Location = new System.Drawing.Point(7, 21);
            this.rdoFile.Name = "rdoFile";
            this.rdoFile.Size = new System.Drawing.Size(58, 19);
            this.rdoFile.TabIndex = 0;
            this.rdoFile.TabStop = true;
            this.rdoFile.Text = "文件";
            this.rdoFile.UseVisualStyleBackColor = true;
            // 
            // tmShow
            // 
            this.tmShow.Enabled = true;
            this.tmShow.Interval = 2000;
            this.tmShow.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupGraph
            // 
            this.groupGraph.Controls.Add(this.radioButton5);
            this.groupGraph.Controls.Add(this.radioButton4);
            this.groupGraph.Controls.Add(this.radioButton3);
            this.groupGraph.Controls.Add(this.radioButton2);
            this.groupGraph.Controls.Add(this.radioButton1);
            this.groupGraph.Location = new System.Drawing.Point(12, 96);
            this.groupGraph.Name = "groupGraph";
            this.groupGraph.Size = new System.Drawing.Size(320, 63);
            this.groupGraph.TabIndex = 4;
            this.groupGraph.TabStop = false;
            this.groupGraph.Text = "标定形状";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(169, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "矩形";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(120, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "圆";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(56, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "直线";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "点";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(467, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 25);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPen
            // 
            this.btnPen.Location = new System.Drawing.Point(504, 106);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(77, 23);
            this.btnPen.TabIndex = 7;
            this.btnPen.Text = "画笔颜色";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(233, 25);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(73, 19);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "多边形";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // btnLineWidth
            // 
            this.btnLineWidth.Location = new System.Drawing.Point(339, 106);
            this.btnLineWidth.Name = "btnLineWidth";
            this.btnLineWidth.Size = new System.Drawing.Size(122, 23);
            this.btnLineWidth.TabIndex = 8;
            this.btnLineWidth.Text = "设置画笔粗细";
            this.btnLineWidth.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "生成区域";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "清空区域";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "设置区域";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(12, 164);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(569, 318);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "点数据：";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(347, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 47);
            this.button4.TabIndex = 13;
            this.button4.Text = "读取信息";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(476, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 47);
            this.button5.TabIndex = 14;
            this.button5.Text = "保存信息";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(162, 33);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(58, 19);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "列表";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // winMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 494);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLineWidth);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupGraph);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.bntReadImgs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "winMain";
            this.Text = "标记";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupGraph.ResumeLayout(false);
            this.groupGraph.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntReadImgs;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPath;
        private System.Windows.Forms.RadioButton rdoFile;
        private System.Windows.Forms.Timer tmShow;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupGraph;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button btnLineWidth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}

