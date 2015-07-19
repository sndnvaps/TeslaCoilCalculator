namespace TeslaCoilCalculator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.NewFormTest = new System.Windows.Forms.Button();
            this.IHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WireDiameter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CoilTurns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IFormDiameter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SecCap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_SecInduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxResonant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewFormTest
            // 
            this.NewFormTest.Location = new System.Drawing.Point(18, 150);
            this.NewFormTest.Name = "NewFormTest";
            this.NewFormTest.Size = new System.Drawing.Size(75, 23);
            this.NewFormTest.TabIndex = 0;
            this.NewFormTest.Text = "计算";
            this.NewFormTest.UseVisualStyleBackColor = true;
            this.NewFormTest.Click += new System.EventHandler(this.NewFormTest_Click);
            // 
            // IHeight
            // 
            this.IHeight.Location = new System.Drawing.Point(155, 23);
            this.IHeight.Name = "IHeight";
            this.IHeight.Size = new System.Drawing.Size(100, 21);
            this.IHeight.TabIndex = 1;
            this.IHeight.TextChanged += new System.EventHandler(this.Height_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "输入绕线高度(cm)";
            // 
            // WireDiameter
            // 
            this.WireDiameter.Location = new System.Drawing.Point(155, 70);
            this.WireDiameter.Name = "WireDiameter";
            this.WireDiameter.Size = new System.Drawing.Size(100, 21);
            this.WireDiameter.TabIndex = 3;
            this.WireDiameter.TextChanged += new System.EventHandler(this.WireDiameter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "输入次级线线径(mm)";
            // 
            // CoilTurns
            // 
            this.CoilTurns.Location = new System.Drawing.Point(227, 173);
            this.CoilTurns.Name = "CoilTurns";
            this.CoilTurns.Size = new System.Drawing.Size(100, 21);
            this.CoilTurns.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "次级箍数";
            // 
            // IFormDiameter
            // 
            this.IFormDiameter.Location = new System.Drawing.Point(155, 105);
            this.IFormDiameter.Name = "IFormDiameter";
            this.IFormDiameter.Size = new System.Drawing.Size(100, 21);
            this.IFormDiameter.TabIndex = 7;
            this.IFormDiameter.TextChanged += new System.EventHandler(this.IFormDiameter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "输入次级直径(mm)";
            // 
            // SecCap
            // 
            this.SecCap.Location = new System.Drawing.Point(227, 259);
            this.SecCap.Name = "SecCap";
            this.SecCap.Size = new System.Drawing.Size(100, 21);
            this.SecCap.TabIndex = 9;
            this.SecCap.TextChanged += new System.EventHandler(this.SecCap_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "次级寄生电容(pf)";
            // 
            // TextBox_SecInduct
            // 
            this.TextBox_SecInduct.Location = new System.Drawing.Point(227, 215);
            this.TextBox_SecInduct.Name = "TextBox_SecInduct";
            this.TextBox_SecInduct.Size = new System.Drawing.Size(100, 21);
            this.TextBox_SecInduct.TabIndex = 11;
            this.TextBox_SecInduct.TextChanged += new System.EventHandler(this.TextBox_SecInduct_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "次级电感(μH)";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(12, 251);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "关闭";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "不加顶端的谐振频率(Hz)";
            // 
            // TextBoxResonant
            // 
            this.TextBoxResonant.Location = new System.Drawing.Point(272, 313);
            this.TextBoxResonant.Name = "TextBoxResonant";
            this.TextBoxResonant.Size = new System.Drawing.Size(100, 21);
            this.TextBoxResonant.TabIndex = 15;
            this.TextBoxResonant.TextChanged += new System.EventHandler(this.TextBoxResonant_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 406);
            this.Controls.Add(this.TextBoxResonant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBox_SecInduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SecCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IFormDiameter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CoilTurns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WireDiameter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IHeight);
            this.Controls.Add(this.NewFormTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "计算次级线圈电感";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewFormTest;
        private System.Windows.Forms.TextBox IHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WireDiameter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CoilTurns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IFormDiameter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SecCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_SecInduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxResonant;
    }
}