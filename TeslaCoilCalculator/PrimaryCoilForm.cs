using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// 电感计算公式 
/* L = ((N^2) * (R^2))/(9*R + 10 * H) 
 * R = D/2 
 * H = (S+W) * N 
 * 
 * -----------------------------
 * L = ((Math.Pow(N,2.0) * (Math.Pow(D/2,2))/(9 * (D/2) + 10*((S+W)*N))) 
 * 
 * 
 * 
 * 
 * 
 * 
  */


namespace TeslaCoilCalculator
{
    public partial class PrimaryCoilForm : Form
    {


        private double CoilTurns; //用于获取线圈的匝数     -> TextBox2.Text 
        private double CoilDiameter; //用于获取线圈管直径  -> TextBox1.Text 
        private double CoilSpace; //用于获取 S + W 的值,   -> TextBox3.Text 
        private double Output; //用于显示计算结果 

        public PrimaryCoilForm()
        {
            InitializeComponent();
        }

        private void PrimaryCoilForm_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //关闭当前进程 
        }

    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CoilDiameter = Convert.ToDouble(textBox1.Text) * (1 / 2.54); //将厘米转换成英寸
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CoilTurns = Convert.ToDouble(textBox2.Text); //用于获取匝数 N
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CoilSpace = Convert.ToDouble(textBox3.Text) * (1 / 2.54); //将厘米转换成英寸 ,预算是使用6mm 铜管,即0.6cm 
        }

        private void tbOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e) //用于计算电感量 
        {
            //L = ((Math.Pow(N,2.0) * (Math.Pow(D/2,2))/(9 * (D/2) + 10*((S+W)*N))) 
            Output = ((Math.Pow(CoilTurns, 2) * (Math.Pow(CoilDiameter / 2.0, 2.0))) / (9 * (CoilDiameter / 2) + 10 * (CoilSpace * CoilTurns)));
            tbOutput.Text = Output.ToString();
            Console.Write("CoilTurns = {0}\n coilDiameter = {1}\n coilSapce = {2}", CoilTurns, CoilDiameter, CoilSpace);
            tbOutput.Update(); 
        }

     
    }
}
