using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeslaCoilCalculator
{
    public partial class Form3 : Form
    {



        private double InputText;
        private double OutputText;
        private double cm2inch   = 5.08; // cm / 2.54  -> 2*2.54 
        private const double Mask = 2.83915;
        public Form3()
        {
            InitializeComponent();
        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e) //input
        {
               try
            {


                InputText = Convert.ToDouble(TextBoxInput.Text); //将输入修改为double 
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //output
        {

        }

        private void Cal_Click(object sender, EventArgs e) //计算
        {
            OutputText = Mask * (InputText / cm2inch); //default is cm 
            textBox1.Text = OutputText.ToString();
        }

        private void CloseForm3_Click(object sender, EventArgs e) //退出当前进程,即关闭当前窗口
        {
         this.Close();
        }
    }
}
