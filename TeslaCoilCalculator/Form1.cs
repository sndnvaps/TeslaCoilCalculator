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
 * 计算球形的电容
 * Sphere Capacitance = 2.83915 *(Sphere Diameter / 2) 
 * Sphere Diameter 为球形的直径,单位为 Inch 
 * 
 * 使用厘米为单位时计算公式为 
 *  Sphere Capacitance = 2.83915 * ( Sphere Diameter/ (2*2.54)) 
 * 
 * 
 */

namespace TeslaCoilCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form2 NewForm2; //新建一个窗口，用于计算次级线圈参数
        private Form3 NewForm3; //新建一个窗口,用于计算顶端电容
        private Form5 NewForm5; //用于计算初始线圈的参数 
        private SparkLength NewSpartLength; //用于估算功率与电弧长度

        private void Form1_Load(object sender, EventArgs e)
        {

        }

         private void NewForm_Click(object sender, EventArgs e)
        {
            NewForm2 = new Form2();
            NewForm2.ShowDialog(); //显示一个新窗口，在父窗口之上
        }

        private void TopCap_Click(object sender, EventArgs e)
        {
            NewForm3 = new Form3();
            NewForm3.Show();// 显示一个窗口,在父窗口之上
        }

        private void PrimaryCoilButton_Click(object sender, EventArgs e)
        {
            NewForm5 = new Form5();
            NewForm5.Show(); //显示一个窗口,在父窗口之上
        }

        private void CloseForm1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);   //退出进程
        }

        private void SparkLength_Click(object sender, EventArgs e) //用于估算电弧的长度
        {
            NewSpartLength = new SparkLength();
            NewSpartLength.Show();

        }

    

     

    }
}
