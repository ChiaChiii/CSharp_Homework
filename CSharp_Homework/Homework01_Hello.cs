using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp_Homework
{
    public partial class Homework01_Hello : Form
    {
        public Homework01_Hello()
        {
            InitializeComponent();
        }
        void DisplayMessage(string greeting)
        {
            string namechi = txtName.Text;
            string nameeng = txtEngName.Text;
            string sex = txtSex.Text;
            string sign = txtSign.Text;
            string message = $"{greeting},我是{namechi},\n英文名字是{nameeng},\n性別是{sex},\n星座是{sign},\n很高興認識你。";

            MessageBox.Show(message);
        }
        private void btn_Hello_Click(object sender, EventArgs e)
        {
            DisplayMessage("Hello");
        }

        private void btn_Hi_Click(object sender, EventArgs e)
        {
            DisplayMessage("Hi");
        }
    }
}
