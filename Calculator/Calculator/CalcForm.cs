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
            CalcFinction s = new CalcFinction();
            displayX.Text = Convert.ToString(s.Summ(Convert.ToDouble(displayX.Text),
                Convert.ToDouble(displayY.Text)));
            displayY.Clear();
        }

        private void DisplayX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
            (!string.IsNullOrEmpty(displayX.Text) && e.KeyChar == ','))
            {
                return;
            }
            if(e.KeyChar == (char)8)
            {
                return;
            }

            e.Handled = true;
        }

        private void DisplayY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
          (!string.IsNullOrEmpty(displayX.Text) && e.KeyChar == ','))
            {
                return;
            }
            if (e.KeyChar == (char)8)
            {
                return;
            }

            e.Handled = true;
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            CalcFinction s = new CalcFinction();
            displayX.Text = Convert.ToString(s.Sub(Convert.ToDouble(displayX.Text),
                Convert.ToDouble(displayY.Text)));
            displayY.Clear();
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            CalcFinction s = new CalcFinction();
            displayX.Text = Convert.ToString(s.Mult(Convert.ToDouble(displayX.Text),
                Convert.ToDouble(displayY.Text)));
            displayY.Clear();
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            CalcFinction s = new CalcFinction();
            displayX.Text = Convert.ToString(s.Div(Convert.ToDouble(displayX.Text),
                Convert.ToDouble(displayY.Text)));
            displayY.Clear();
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            CalcFinction s = new CalcFinction();
            displayX.Text = Convert.ToString(s.Sqrt(Convert.ToDouble(displayX.Text)));
            displayY.Clear();
        }

        private void FactotialButton_Click(object sender, EventArgs e)
        {
            CalcFinction s = new CalcFinction();
            displayX.Text = Convert.ToString(s.Factorial(Convert.ToInt32(displayX.Text)));
            displayY.Clear();
        }

        private void ExpButton_Click(object sender, EventArgs e)
        {
            CalcFinction s = new CalcFinction();
            displayX.Text = Convert.ToString(s.Exp(Convert.ToDouble(displayX.Text),
                Convert.ToInt32(displayY.Text)));
            displayY.Clear();
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            CalcFinction s = new CalcFinction();
            displayX.Text = Convert.ToString(s.Log(Convert.ToDouble(displayX.Text),
                Convert.ToDouble(displayY.Text)));
            displayY.Clear();
        }

        private void Log10Button_Click(object sender, EventArgs e)
        {
            CalcFinction s = new CalcFinction();
            displayX.Text = Convert.ToString(s.Log10(Convert.ToInt32(displayX.Text)));
            displayY.Clear();
        }
    }
}
