﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp_Homework
{
    public partial class Homework07_MyClac : Form
    {
        public Homework07_MyClac()
        {
            InitializeComponent();
        }

        
        private bool CheckTextBoxValues()
        {
            if (string.IsNullOrEmpty(txtNum1.Text) || string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("請輸入數值。");
                return false;
            }
            int number1, number2;

            if (!int.TryParse(txtNum1.Text, out number1) || !int.TryParse(txtNum2.Text, out number2))
            {
                MessageBox.Show("請輸入數值。");
                return false;
            }
            return true;
        }
        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxValues())
            {
                int number1 = int.Parse(txtNum1.Text);
                int number2 = int.Parse(txtNum2.Text);
                labShowAnswer.Text = (number1 + number2).ToString();
            }


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxValues())
            {
                int number1 = int.Parse(txtNum1.Text);
                int number2 = int.Parse(txtNum2.Text);
                labShowAnswer.Text = (number1 - number2).ToString();
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxValues())
            {
                int number1 = int.Parse(txtNum1.Text);
                int number2 = int.Parse(txtNum2.Text);
                labShowAnswer.Text = (number1 * number2).ToString();
            }
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxValues())
            {
                int number1 = int.Parse(txtNum1.Text);
                int number2 = int.Parse(txtNum2.Text);
                if (int.Parse(txtNum2.Text) == 0)
                {
                    labShowAnswer.Text = "∞";
                }
                else
                {
                    labShowAnswer.Text = (number1 / number2).ToString();
                }
                
            }
        }
    }
}
