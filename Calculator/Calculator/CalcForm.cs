using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SummButton_Click(object sender, EventArgs e)
        {
            double x = double.Parse(displayX.Text);
            double y = double.Parse(displayY.Text);

            CalcFinction s = new CalcFinction();

            double result = s.Summ(x, y);

            displayAnswer.Text = result.ToString();
        }
    }
}
