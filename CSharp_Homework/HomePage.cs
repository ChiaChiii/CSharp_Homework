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
    public partial class HomePage : Form
    {
        private Panel panelShow;
        private Form currentForm;// 儲存目前顯示的表單

        public HomePage()
        {
            InitializeComponent();
            panelShow = splitContainer2.Panel2;
            // 設定視窗狀態為最大化
            this.WindowState = FormWindowState.Maximized;
        }
        private void ShowForm(Form form)
        {
            // 關閉目前顯示的表單
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            // 設置表單的父容器為 panelShow
            form.TopLevel = false;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(form);

            // 顯示表單
            form.Show();

            // 更新目前顯示的表單
            currentForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homework01_Hello frm01= new Homework01_Hello();
            ShowForm(frm01);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homework02_Loan frm02 = new Homework02_Loan();
            ShowForm(frm02);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homework03_POS frm03 = new Homework03_POS();
            ShowForm(frm03);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homework04_Student_StructForm frm04 = new Homework04_Student_StructForm();
            ShowForm(frm04);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("嗚嗚還沒做好先跳過", "拍謝拍謝",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("嗚嗚還沒做好先跳過", "拍謝拍謝", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }    

        private void button7_Click(object sender, EventArgs e)
        {
            Homework07_MyClac frm07 = new Homework07_MyClac();
            ShowForm(frm07);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Homework08_ForDoWhile frm08 = new Homework08_ForDoWhile();
            ShowForm(frm08);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Homework09_XOGame frm09 =new Homework09_XOGame();
            ShowForm(frm09);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Homework10_ScreenSaver frm10 = new Homework10_ScreenSaver();
            // 關閉目前顯示的表單
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            // 顯示表單
            frm10.Show();
        }

        
    }
}
