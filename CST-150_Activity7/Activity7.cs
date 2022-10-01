using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity7
{
    public partial class piCalcFrm : Form
    {
        public piCalcFrm()
        {
            InitializeComponent();
        }

        private void inputTxt_TextChanged(object sender, EventArgs e)
        {
            //inputTxt.Text = numTermsTxt.Text;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double result = 0;
            double num = 0;
            double oddNum = 1;
            inputTxt.Text = numTermsTxt.Text;

            //calculate Pi sequence which is 4/(2i + 1).
            //Loop through the amount of terms user inputs
            for(int i = 0; i < Double.Parse(numTermsTxt.Text); i++)
            {
                // the sequence is 4 divided by an odd number
                // with every other digit being odd
                //Checking if i is odd or even
                //If i is even, 4 is divided by 1, if it is odd, -4 is divided by 1.
                if (i % 2 == 0)
                {
                    num = 4 / oddNum;
                }
                else { num = -4 / oddNum;  }
                oddNum += 2;
                result += num;
            }
            answerTxt.Text = result.ToString();
        }
    }
}
