namespace TeslaCoilCalculator
{
    partial class SparkLength
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SparkLength));
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbInch = new System.Windows.Forms.CheckBox();
            this.cbCM = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(12, 123);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "计算";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(111, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "电弧长度(L)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "电源输入功率(P)(瓦特)";
            // 
            // cbInch
            // 
            this.cbInch.AutoSize = true;
            this.cbInch.Location = new System.Drawing.Point(179, 23);
            this.cbInch.Name = "cbInch";
            this.cbInch.Size = new System.Drawing.Size(48, 16);
            this.cbInch.TabIndex = 6;
            this.cbInch.Text = "英寸";
            this.cbInch.UseVisualStyleBackColor = true;
            this.cbInch.CheckedChanged += new System.EventHandler(this.cbInch_CheckedChanged);
            // 
            // cbCM
            // 
            this.cbCM.AutoSize = true;
            this.cbCM.Checked = true;
            this.cbCM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCM.Location = new System.Drawing.Point(179, 45);
            this.cbCM.Name = "cbCM";
            this.cbCM.Size = new System.Drawing.Size(48, 16);
            this.cbCM.TabIndex = 7;
            this.cbCM.Text = "厘米";
            this.cbCM.UseVisualStyleBackColor = true;
            this.cbCM.CheckedChanged += new System.EventHandler(this.cbCM_CheckedChanged);
            // 
            // SparkLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cbCM);
            this.Controls.Add(this.cbInch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SparkLength";
            this.Text = "估算电弧长度";
            this.Load += new System.EventHandler(this.SparkLength_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbInch;
        private System.Windows.Forms.CheckBox cbCM;
    }
}