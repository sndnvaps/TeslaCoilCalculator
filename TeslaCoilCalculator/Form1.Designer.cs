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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NewForm = new System.Windows.Forms.Button();
            this.TopCap = new System.Windows.Forms.Button();
            this.CloseForm1 = new System.Windows.Forms.Button();
            this.PrimaryCoilButton = new System.Windows.Forms.Button();
            this.SparkLength = new System.Windows.Forms.Button();
            this.btnTCCDC = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewForm
            // 
            this.NewForm.Location = new System.Drawing.Point(12, 28);
            this.NewForm.Name = "NewForm";
            this.NewForm.Size = new System.Drawing.Size(90, 53);
            this.NewForm.TabIndex = 9;
            this.NewForm.Text = "计算次级参数";
            this.NewForm.UseVisualStyleBackColor = true;
            this.NewForm.Click += new System.EventHandler(this.NewForm_Click);
            // 
            // TopCap
            // 
            this.TopCap.Location = new System.Drawing.Point(139, 29);
            this.TopCap.Name = "TopCap";
            this.TopCap.Size = new System.Drawing.Size(90, 51);
            this.TopCap.TabIndex = 10;
            this.TopCap.Text = "计算顶端电容";
            this.TopCap.UseVisualStyleBackColor = true;
            this.TopCap.Click += new System.EventHandler(this.TopCap_Click);
            // 
            // CloseForm1
            // 
            this.CloseForm1.Location = new System.Drawing.Point(12, 287);
            this.CloseForm1.Name = "CloseForm1";
            this.CloseForm1.Size = new System.Drawing.Size(75, 23);
            this.CloseForm1.TabIndex = 11;
            this.CloseForm1.Text = "关闭";
            this.CloseForm1.UseVisualStyleBackColor = true;
            this.CloseForm1.Click += new System.EventHandler(this.CloseForm1_Click);
            // 
            // PrimaryCoilButton
            // 
            this.PrimaryCoilButton.Location = new System.Drawing.Point(12, 103);
            this.PrimaryCoilButton.Name = "PrimaryCoilButton";
            this.PrimaryCoilButton.Size = new System.Drawing.Size(90, 51);
            this.PrimaryCoilButton.TabIndex = 12;
            this.PrimaryCoilButton.Text = "计算初级参数";
            this.PrimaryCoilButton.UseVisualStyleBackColor = true;
            this.PrimaryCoilButton.Click += new System.EventHandler(this.PrimaryCoilButton_Click);
            // 
            // SparkLength
            // 
            this.SparkLength.Location = new System.Drawing.Point(139, 103);
            this.SparkLength.Name = "SparkLength";
            this.SparkLength.Size = new System.Drawing.Size(90, 51);
            this.SparkLength.TabIndex = 13;
            this.SparkLength.Text = "估算电弧长度";
            this.SparkLength.UseVisualStyleBackColor = true;
            this.SparkLength.Click += new System.EventHandler(this.SparkLength_Click);
            // 
            // btnTCCDC
            // 
            this.btnTCCDC.Location = new System.Drawing.Point(12, 186);
            this.btnTCCDC.Name = "btnTCCDC";
            this.btnTCCDC.Size = new System.Drawing.Size(90, 51);
            this.btnTCCDC.TabIndex = 14;
            this.btnTCCDC.Text = "初级和次级耦合度计算";
            this.btnTCCDC.UseVisualStyleBackColor = true;
            this.btnTCCDC.Click += new System.EventHandler(this.btnTCCDC_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(139, 287);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 15;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 339);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnTCCDC);
            this.Controls.Add(this.SparkLength);
            this.Controls.Add(this.PrimaryCoilButton);
            this.Controls.Add(this.CloseForm1);
            this.Controls.Add(this.TopCap);
            this.Controls.Add(this.NewForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "特斯拉线圈计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewForm;
        private System.Windows.Forms.Button TopCap;
        private System.Windows.Forms.Button CloseForm1;
        private System.Windows.Forms.Button PrimaryCoilButton;
        private System.Windows.Forms.Button SparkLength;
        private System.Windows.Forms.Button btnTCCDC;
        private System.Windows.Forms.Button btnAbout;
    }
}

