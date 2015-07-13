using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private double InputText;
        private double OutputText;
        private double cm2inch   = 5.08; // cm / 2.54  -> 2*2.54 
        private double inch2cm   = 2.0; // 2.54 * cm 
        private const double Mask = 2.83915; 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (CB_Cm.Checked.Equals(true))
            {
                OutputText = Mask * (InputText / cm2inch); //default is cm 
            }
            else if (CB_Inch.Checked.Equals(true))
            {
                OutputText = Mask * (InputText / inch2cm); //inch 
            }

             OutputBox.Text = OutputText.ToString();
             OutputBox.Update();

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //OutputBox
        {
         
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            InputText = Convert.ToDouble(InputBox.Text); //将输入修改为double 

        }

        private void CB_Inch_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Inch.Checked.Equals(true))
            {
                CB_Cm.Checked = false;
               
            }
        }

        private void CB_Cm_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Cm.Checked.Equals(true))
            {
                CB_Inch.Checked = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     

    }
}
