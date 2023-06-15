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
    public partial class Homework10_ScreenSaver : Form       

    {
        int stepX = 7, stepY = 7;
        public Homework10_ScreenSaver()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Homework10_ScreenSaver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //水平方向
            if ((pictureBox1.Location.X + pictureBox1.Width) > this.ClientSize.Width || pictureBox1.Location.X < 0)
            {
                stepX =  - stepX;
            }

            //垂直方向
            if ((pictureBox1.Location.Y + pictureBox1.Height) > this.ClientSize.Height || pictureBox1.Location.Y < 0)
            {
                stepY =  - stepY;
            }
            pictureBox1.Location = new Point(pictureBox1.Location.X + stepX, pictureBox1.Location.Y + stepY);
        }
            
        private void Homework10_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
