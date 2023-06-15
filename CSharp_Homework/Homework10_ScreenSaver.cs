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
            //DoubleBuffered = true;嗚嗚對於平滑pictureBox1的移動沒有很有效
            timer = new Timer();
            timer.Interval = 1000; // 設定計時器間隔，以毫秒為單位
            timer.Tick += Timer_Tick; // 設定計時器事件處理方法

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
        private Timer timer;        

        private Point lastMousePosition;

        private void Homework10_ScreenSaver_Load(object sender, EventArgs e)
        {
            timer.Start(); // 啟動計時器
            lastMousePosition = Cursor.Position; // 紀錄初始鼠標位置
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Cursor.Position != lastMousePosition)
            {
                this.Close(); // 如果鼠標位置改變，關閉表單
            }
        }
    }
}
