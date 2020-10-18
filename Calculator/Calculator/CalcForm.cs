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
            if (displayX.Text == "")
            {
                MessageBox.Show("Введите число");
            }
            if (displayY.Text == "")
            {
                MessageBox.Show("Введите число");
            }

            double x = double.Parse(displayX.Text);
            double y = double.Parse(displayY.Text); ;

            CalcFinction s = new CalcFinction();

            double result = s.Summ(x, y);

            displayAnswer.Clear();

            displayAnswer.Text = result.ToString();

            displayX.Clear(); displayY.Clear();
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
    }
}
