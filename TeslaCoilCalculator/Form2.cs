using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Math;



/*
 * 计算次级线圈的寄生电容
 * 计算次级线圈的箍数
 * Secondary Capacitance = (0.29* Secondary Wire Winding Height) + (0.41 * (Secondary Form Diameter/2)) + (1.94 * sqrt(((Secondary Form Diameter/2)^3)/Secondary Wire Winding Height))
 *  绕线高度 Height = Coil Turns * Magnet Wire Diameter 
 *  Secondary coil Turns = (1/(Magnet Wire Diameter + 0.000001)) * Secondary Wire Winding Height * 0.97
 *  次级线圈电感 μH 
 *  Secondary Inductance = ((((Secondary Coil Turns ^2) * ((Secondary Form Diameter/2)^2))/((9 * (Secondary Form Diameter / 2)) + (10 * Secondary Wire Winding Height))) * 0.001) * Secondary Inductance Adjust 
 *                       = (((System.Math.Pow(Secondary Coil Turns,2.0) * (System.Math.Pow(Secondary Form Diameter/2,2.0))/(( 9 * (Secondary Form Diameter/2))) + (10 * Secondary Wire Winding Height))) * 0.001) * Secondary Inductance Adjust 
 *    
 * 
 *  0.27mm = 0.01063 inch 
 *  0.25mm = 0.00984 inch 
 *  0.32mm = 0.0125984 inch 
 *  1mm = 0.0393701 inch 
 *  1cm = 1/2.54 = 0.3937008 inch 
 *  
 *  绕线线管的直径 FormDiameter 
 *  
 * 
 * 
 * 
 * 
 * 
 */

namespace TeslaCoilCalculator
{
    public partial class Form2 : Form
    {
        public double  Output;
        private double MagnetWireDiameter = 0.01063; // 次级线径 0.27mm 
        private double FormDiameter; //管径 输入为厘米 
        private double FormHeight; //绕线的高度
        private double OutputSecCap; //用于输出次级寄生电容 
        private double OutputSecInduct; //用于输出次级电感 μH
        private double OutputResonant; //用于输出谐振频率 Hz 

        //1H=1000000μH,1μH=0.0000001H

        //1F=10^6uF=10^12pF
        //1F=10^12pF
       // ((((Secondary Coil Turns ^2) * ((Secondary Form Diameter/2)^2))/((9 * (Secondary Form Diameter / 2)) + (10 * Secondary Wire Winding Height)))); 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void NewFormTest_Click(object sender, EventArgs e)
        {
            //Secondary coil Turns = (1/(Magnet Wire Diameter + 0.000001)) * Secondary Wire Winding Height * 0.97
            Output = (1 / (MagnetWireDiameter + 0.000001)) * FormHeight * 0.97;
            //Secondary Capacitance = (0.29* Secondary Wire Winding Height) + (0.41 * (Secondary Form Diameter/2)) + (1.94 * sqrt(((Secondary Form Diameter/2)^3)/Secondary Wire Winding Height))
            OutputSecCap = (0.29 * FormHeight) + (0.41 * (FormDiameter / 2)) + (1.94 * System.Math.Sqrt(((System.Math.Pow((FormDiameter / 2) , 3.0)) / FormHeight)));
             //  *  次级线圈电感 μH 
            //= (((System.Math.Pow(Secondary Coil Turns,2.0) * (System.Math.Pow(Secondary Form Diameter/2,2.0))/(( 9 * (Secondary Form Diameter/2))) + (10 * Secondary Wire Winding Height))) * 0.001) * Secondary Inductance Adjust 
            //((((System.Math.Pow(Secondary Coil Turns,2.0) * ((System.Math.Pow(Secondary Form Diameter/2,2.0))/((9* (Secondary Form Diameter/2)) + (10 * Secondary Wire Winding Height)))) 

            OutputSecInduct = ((((System.Math.Pow(Output, 2.0)) * (System.Math.Pow(FormDiameter / 2.0, 2)))) / ((9 * (FormDiameter / 2)) + (10 * FormHeight)));// * 0.001 * 13.72; //miss Secondary Induct Adjust 
            
            //1/(2*pi*sqrt(L*C)) 
            OutputResonant = 1 / (2 * System.Math.PI * System.Math.Sqrt((OutputSecCap * System.Math.Pow(10, -12.0)) *
                OutputSecInduct * System.Math.Pow(10, -6.0)));
            
            CoilTurns.Text = Output.ToString();
            SecCap.Text = OutputSecCap.ToString();
            TextBox_SecInduct.Text = OutputSecInduct.ToString();
            TextBoxResonant.Text = OutputResonant.ToString();

            SecCap.Update();
            CoilTurns.Update();
            TextBox_SecInduct.Update();
            TextBoxResonant.Update();
        }

        private void Height_TextChanged(object sender, EventArgs e) //绕线的高度，输入为厘米
        {
            FormHeight = Convert.ToDouble(IHeight.Text) * (1 / 2.54); //将厘米转换成 英寸
        }

        private void WireDiameter_TextChanged(object sender, EventArgs e)
        {
            MagnetWireDiameter = Convert.ToDouble(WireDiameter.Text) * (1 / 25.4); //将毫米转换成 英寸
        }

        private void SecCap_TextChanged(object sender, EventArgs e)  //次级寄生电容
        {

        }

        private void IFormDiameter_TextChanged(object sender, EventArgs e) //次级线圈直径50mm 
        {
            FormDiameter = Convert.ToDouble(IFormDiameter.Text) * (1 / 25.4); //将毫米转换成英寸 
        }

        private void TextBox_SecInduct_TextChanged(object sender, EventArgs e) //计算得到次级线圈的电感

        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxResonant_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
