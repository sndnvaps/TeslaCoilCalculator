using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * 盘丝初级线圈电感计算公式 
 * L = ((N^2)* (A^2))/(30*A - 11*D1)
 * A = (D1 + N*(W + S))/2
 * constA 
 * ---------------
 * L = ((Math.Pow(N,2.0) * (Math.Pow(A,2.0))/(30*A  - 11*D1)
 *   = ((Math.Pow(CoilInerDiameter,2.0) * (Math.Pow(ConstA,2.0))/(30 * ConstA - 11 * CoilInerDiameter)
 * 
 * 
 * 
 */




namespace TeslaCoilCalculator
{
    public partial class Form4 : Form
    {
        private double CoilInerDiameter; //用于获取线圈管直径  -> TextBox1.Text 
        private double CoilTurns; //用于获取线圈的匝数     -> TextBox2.Text 
        private double MagnetWireDiameter; //获取铜管的直径 -> TextBox3.Text 
        private double CoilSpace; //用于获取 S 的值,   -> TextBox4.Text 
        private double ConstA; // A = (D1 + N*(W +S))/2 --> (CoilInerDiameter + CoilTurns *(MagnetWireDiameter + CoilSpace))/2 
        private double Output; //用于显示计算结果 

        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CoilInerDiameter = Convert.ToDouble(textBox1.Text) * (1 / 25.4); //毫米转换成英寸
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CoilTurns = Convert.ToDouble(textBox2.Text); //获取线圈匝数
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MagnetWireDiameter = Convert.ToDouble(textBox3.Text) * (1 / 25.4); //获取线径
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CoilSpace = Convert.ToDouble(textBox4.Text) * (1 / 25.4); //获取匝间距,单位使用厘米
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            // A = (D1 + N*(W +S))/2 --> (CoilInerDiameter + CoilTurns *(MagnetWireDiameter + CoilSpace))/2 
            ConstA = (CoilInerDiameter + CoilTurns * (MagnetWireDiameter + CoilSpace)) / 2;
            //L = ((Math.Pow(CoilTurns,2.0) * (Math.Pow(ConstA,2.0))/(30 * ConstA - 11 * CoilInerDiameter)
            Output = ((Math.Pow(CoilTurns, 2.0)) * (Math.Pow(ConstA, 2.0))) / (30 * ConstA - 11 * CoilInerDiameter);
            textBox5.Text = Output.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //关闭当前窗口
        }

       
    }
}
