namespace TeslaCoilCalculator
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
            this.Cal = new System.Windows.Forms.Button();
            this.CB_Inch = new System.Windows.Forms.CheckBox();
            this.CB_Cm = new System.Windows.Forms.CheckBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cal
            // 
            this.Cal.Location = new System.Drawing.Point(25, 94);
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(75, 23);
            this.Cal.TabIndex = 0;
            this.Cal.Text = "计算";
            this.Cal.UseVisualStyleBackColor = true;
            this.Cal.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_Inch
            // 
            this.CB_Inch.AutoSize = true;
            this.CB_Inch.Location = new System.Drawing.Point(15, 23);
            this.CB_Inch.Name = "CB_Inch";
            this.CB_Inch.Size = new System.Drawing.Size(48, 16);
            this.CB_Inch.TabIndex = 1;
            this.CB_Inch.Text = "英寸";
            this.CB_Inch.UseVisualStyleBackColor = true;
            this.CB_Inch.CheckedChanged += new System.EventHandler(this.CB_Inch_CheckedChanged);
            // 
            // CB_Cm
            // 
            this.CB_Cm.AutoSize = true;
            this.CB_Cm.Checked = true;
            this.CB_Cm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Cm.Location = new System.Drawing.Point(15, 45);
            this.CB_Cm.Name = "CB_Cm";
            this.CB_Cm.Size = new System.Drawing.Size(48, 16);
            this.CB_Cm.TabIndex = 2;
            this.CB_Cm.Text = "厘米";
            this.CB_Cm.UseVisualStyleBackColor = true;
            this.CB_Cm.CheckedChanged += new System.EventHandler(this.CB_Cm_CheckedChanged);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(71, 21);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(62, 21);
            this.InputBox.TabIndex = 3;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "球形直径";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(155, 119);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(100, 21);
            this.OutputBox.TabIndex = 6;
            this.OutputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "计算结果(pf)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_Inch);
            this.groupBox1.Controls.Add(this.CB_Cm);
            this.groupBox1.Location = new System.Drawing.Point(169, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择计算单位";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NewForm
            // 
            this.NewForm.Location = new System.Drawing.Point(25, 172);
            this.NewForm.Name = "NewForm";
            this.NewForm.Size = new System.Drawing.Size(75, 23);
            this.NewForm.TabIndex = 9;
            this.NewForm.Text = "计算次级箍数";
            this.NewForm.UseVisualStyleBackColor = true;
            this.NewForm.Click += new System.EventHandler(this.NewForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 270);
            this.Controls.Add(this.NewForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.Cal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputBox);
            this.Name = "Form1";
            this.Text = "计算球形的电容";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cal;
        private System.Windows.Forms.CheckBox CB_Inch;
        private System.Windows.Forms.CheckBox CB_Cm;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NewForm;
    }
}

