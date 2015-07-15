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
            this.NewForm = new System.Windows.Forms.Button();
            this.TopCap = new System.Windows.Forms.Button();
            this.CloseForm1 = new System.Windows.Forms.Button();
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
            this.CloseForm1.Location = new System.Drawing.Point(89, 224);
            this.CloseForm1.Name = "CloseForm1";
            this.CloseForm1.Size = new System.Drawing.Size(75, 23);
            this.CloseForm1.TabIndex = 11;
            this.CloseForm1.Text = "关闭";
            this.CloseForm1.UseVisualStyleBackColor = true;
            this.CloseForm1.Click += new System.EventHandler(this.CloseForm1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 270);
            this.Controls.Add(this.CloseForm1);
            this.Controls.Add(this.TopCap);
            this.Controls.Add(this.NewForm);
            this.Name = "Form1";
            this.Text = "计算球形的电容";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewForm;
        private System.Windows.Forms.Button TopCap;
        private System.Windows.Forms.Button CloseForm1;
    }
}

