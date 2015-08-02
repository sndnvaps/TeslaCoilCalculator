using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




/*  用于计算特斯拉线圈的互感系统及耦合系数 
 *  //MutualInductance = (LForward - LReverse)/4 
 *  //CouplingDegree =  MutualInductance / sqrt (L1*L2) 
 *  //源代码参考自 http://bbs.kechuang.org/read-kc-tid-58673-1-1.html
 * 
 * 
 * 
 * 
 * 
 */

namespace TeslaCoilCalculator
{
    public partial class TCCDC : Form
    {

        public TCCDC()
        {
            InitializeComponent();
        }

        private void tbForward_TextChanged(object sender, EventArgs e)
        {
            LForward = Convert.ToDouble(tbForward.Text);
        }

        private void tbReverse_TextChanged(object sender, EventArgs e)
        {
            LReverse = Convert.ToDouble(tbReverse.Text);
        }

        private void tbL1_TextChanged(object sender, EventArgs e)
        {
            L1 = Convert.ToDouble(tbL1.Text);
        }

        private void tbL2_TextChanged(object sender, EventArgs e)
        {
            L2 = Convert.ToDouble(tbL2.Text);
        }

        private void tbMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e) //计算结果,并更新相应的 textBox 
        {
            double DM;
            double CD;
            DM = GetMutualInductance(this.LForward, this.LReverse);
            CD = GetCouplingDegree(this.LForward, this.LReverse, this.L1, this.L2);
            tbMI.Text = DM.ToString();
            tbMI.Update();
            tbCD.Text = CD.ToString();
            tbCD.Update();

        }

        private double GetMutualInductance(double dLForward, double dLReverse) //用于获取互感系数M
        {
            this.MutualInductance = 0.0;
            MutualInductance = (dLForward - dLReverse)/4.0;
            return this.MutualInductance;
        }
        private double GetCouplingDegree(double dLForward, double dLReverse, double dL1, double dL2) //用于计算线圈的耦合系数K
        {
            this.CouplingDegree = 0.0;
            double dCouplingDegree;
            double dM;
            dM = GetMutualInductance(dLForward, dLReverse);
            dCouplingDegree = dM / System.Math.Sqrt(dL1 * dL2);
            CouplingDegree = dCouplingDegree;
            return this.CouplingDegree;
        }

        private double MutualInductance;
        private double CouplingDegree;
        private double LForward;
        private double LReverse;
        private double L1;
        private double L2;
    }
}
