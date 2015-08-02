using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


// 用于计算电弧的长度和功率 
/* 电弧长度 L : 英寸 
 * 功率     P : 瓦特
 * 关系: 
 *  L = 1.7 * sqrt(P) = 1.7 * Math.Sqrt(P)  
 *  P = (L/1.7)^2     = Math.Pow((L/1.7),2.0) 
 * 
 * -------------------------------------------
 * 
 * 
 * 
 * 
 */
namespace TeslaCoilCalculator
{
    public partial class SparkLength : Form
    {

        private double SpartLength; // 电弧长度  
        private bool IsInch = false; //判断当前单位是否为英寸,默认为厘米
        public SparkLength()
        {
            InitializeComponent();
        }

        private void SparkLength_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = null;
            this.textBox2.Text = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //关闭当前窗口
        }

        private void btnCal_Click(object sender, EventArgs e) //用于计算
        {
            //当textBox1.Text 不为空时,表示输入的为 长度,
            //但分为两种状态,一种为inch,一种为cm 
            double power;

                        
              power = CalculatePower(this.SpartLength);
              textBox2.Text = power.ToString();
              textBox2.Update();             

        }

        private void cbInch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInch.Checked.Equals(true))
            {
                cbCM.Checked = false;
                this.IsInch = true;
                cbCM.Update();
            }
        }

        private void cbCM_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCM.Checked.Equals(true))
            {
                cbInch.Checked = false;
                this.IsInch = false;
                cbInch.Update();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                this.SpartLength = Convert.ToDouble(textBox1.Text);
              
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private double CalculatePower(double Length)
        {            
            //P = Math.Pow((L/1.7),2.0) : 此用到的L为英寸
            //P = Math.Pow(L/(1.7*2.54),2.0)) :此用到的L为厘米

            double output = 0.0;
            if (this.IsInch.Equals(true))
            {
                output = Math.Pow(Length / 1.7, 2.0);
            }
            else
            {
                output = Math.Pow(Length / (1.7 * 2.54), 2.0); 

            }
            

            return output;
        }


        private double CalculateLength(double Power)
        {
            double output = 0.0;
            //L = 1.7 * Math.Sqrt(P); 得到结果为英寸
            //L = 1.7 * Math.Sqrt(P) * 2.54 ; 得到结果为厘米
            if (this.IsInch.Equals(true))
            {
                output = 1.7 * Math.Sqrt(Power);

            }
            else
            {
                output = 1.7 * 2.54 * Math.Sqrt(Power);
            }
            return output; 
        }
    }
}
