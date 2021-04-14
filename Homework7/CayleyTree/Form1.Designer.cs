
namespace CayleyTree
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.th1 = new System.Windows.Forms.NumericUpDown();
            this.th2 = new System.Windows.Forms.NumericUpDown();
            this.per2 = new System.Windows.Forms.NumericUpDown();
            this.per1 = new System.Windows.Forms.NumericUpDown();
            this.len = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.drawpanel = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.th1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.len)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "递归深度";
            // 
            // depth
            // 
            this.depth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depth.Location = new System.Drawing.Point(157, 23);
            this.depth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(111, 23);
            this.depth.TabIndex = 4;
            this.depth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(25, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 27);
            this.label10.TabIndex = 3;
            this.label10.Text = "主干长度";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(5, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 27);
            this.label11.TabIndex = 4;
            this.label11.Text = "右分支长度比";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(5, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 27);
            this.label12.TabIndex = 5;
            this.label12.Text = "左分支长度比";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(15, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 27);
            this.label13.TabIndex = 6;
            this.label13.Text = "右分支角度";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(15, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 27);
            this.label14.TabIndex = 7;
            this.label14.Text = "左分支角度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "递归深度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "递归深度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "递归深度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "递归深度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "递归深度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "递归深度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "递归深度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "递归深度";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.th1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.th2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.per2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.per1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.len, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.depth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 467);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // th1
            // 
            this.th1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.th1.DecimalPlaces = 2;
            this.th1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.th1.Location = new System.Drawing.Point(157, 303);
            this.th1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.th1.Name = "th1";
            this.th1.Size = new System.Drawing.Size(111, 23);
            this.th1.TabIndex = 8;
            this.th1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // th2
            // 
            this.th2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.th2.DecimalPlaces = 2;
            this.th2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.th2.Location = new System.Drawing.Point(157, 373);
            this.th2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.th2.Name = "th2";
            this.th2.Size = new System.Drawing.Size(111, 23);
            this.th2.TabIndex = 9;
            this.th2.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
            // 
            // per2
            // 
            this.per2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.per2.DecimalPlaces = 2;
            this.per2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.per2.Location = new System.Drawing.Point(157, 233);
            this.per2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.per2.Name = "per2";
            this.per2.Size = new System.Drawing.Size(111, 23);
            this.per2.TabIndex = 7;
            this.per2.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // per1
            // 
            this.per1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.per1.DecimalPlaces = 2;
            this.per1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.per1.Location = new System.Drawing.Point(157, 163);
            this.per1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.per1.Name = "per1";
            this.per1.Size = new System.Drawing.Size(111, 23);
            this.per1.TabIndex = 6;
            this.per1.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // len
            // 
            this.len.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.len.Location = new System.Drawing.Point(157, 93);
            this.len.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.len.Name = "len";
            this.len.Size = new System.Drawing.Size(111, 23);
            this.len.TabIndex = 5;
            this.len.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(145, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "绘图";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(3, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "修改颜色";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(284, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 467);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // drawpanel
            // 
            this.drawpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawpanel.Location = new System.Drawing.Point(287, 0);
            this.drawpanel.Name = "drawpanel";
            this.drawpanel.Size = new System.Drawing.Size(568, 467);
            this.drawpanel.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Location = new System.Drawing.Point(15, 432);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(111, 23);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 467);
            this.Controls.Add(this.drawpanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.th1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.len)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel drawpanel;
        private System.Windows.Forms.NumericUpDown th1;
        private System.Windows.Forms.NumericUpDown per2;
        private System.Windows.Forms.NumericUpDown per1;
        private System.Windows.Forms.NumericUpDown len;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown th2;
    }
}

