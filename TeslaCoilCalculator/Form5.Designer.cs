namespace TeslaCoilCalculator
{
    partial class Form5
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(42, 24);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 63);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "盘丝状";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnHex
            // 
            this.btnHex.Location = new System.Drawing.Point(42, 102);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(90, 63);
            this.btnHex.TabIndex = 1;
            this.btnHex.Text = "螺旋形";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 210);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btn1);
            this.Name = "Form5";
            this.Text = "初级类型";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnHex;
    }
}