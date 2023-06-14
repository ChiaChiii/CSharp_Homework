using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Homework
{
    public partial class Homework02_LoanReport : Form
    {
        public Homework02_LoanReport()
        {
            InitializeComponent();
        }
        public string Label1Text
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string Label2Text
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public string Label3Text
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }

        public string Label4Text
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }

        public string Label5Text
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }

    }
}
