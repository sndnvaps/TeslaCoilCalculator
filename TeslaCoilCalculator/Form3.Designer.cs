namespace TeslaCoilCalculator
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Cal = new System.Windows.Forms.Button();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CloseForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cal
            // 
            this.Cal.Location = new System.Drawing.Point(5, 103);
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(75, 23);
            this.Cal.TabIndex = 0;
            this.Cal.Text = "计算";
            this.Cal.UseVisualStyleBackColor = true;
            this.Cal.Click += new System.EventHandler(this.Cal_Click);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(120, 43);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(100, 21);
            this.TextBoxInput.TabIndex = 1;
            this.TextBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "输入球形直径(cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "电容(pf)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CloseForm3
            // 
            this.CloseForm3.Location = new System.Drawing.Point(5, 147);
            this.CloseForm3.Name = "CloseForm3";
            this.CloseForm3.Size = new System.Drawing.Size(75, 23);
            this.CloseForm3.TabIndex = 5;
            this.CloseForm3.Text = "完成";
            this.CloseForm3.UseVisualStyleBackColor = true;
            this.CloseForm3.Click += new System.EventHandler(this.CloseForm3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.CloseForm3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.Cal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "顶端电容";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cal;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CloseForm3;
    }
}