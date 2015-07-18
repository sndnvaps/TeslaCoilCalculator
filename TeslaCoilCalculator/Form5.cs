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
    public partial class Form5 : Form
    {
        private PrimaryCoilForm NewPrimaryCoilForm; //螺旋形初级
        private Form4 NewForm4;  //盘丝状初级
        public Form5()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NewForm4 = new Form4();
            NewForm4.Show();
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            NewPrimaryCoilForm = new PrimaryCoilForm();
            NewPrimaryCoilForm.Show();
        }
    }
}
