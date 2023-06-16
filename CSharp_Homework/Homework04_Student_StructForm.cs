using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Homework
{
    public struct ScoreData
    {
        public string name;
        public double chi;
        public double eng;
        public double math;
    }

    public partial class Homework04_Student_StructForm : Form
    {
        private ScoreData student; // 將結構體實例變數聲明為成員變數

        public Homework04_Student_StructForm()
        {
            InitializeComponent();
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 讀取輸入資料
            string name = txtName.Text;

            double chi, eng, math;
            // 驗證輸入的數字
            if (!double.TryParse(txtChi.Text, out chi) || chi < 0 || chi > 100)
            {
                MessageBox.Show("請輸入有效成績（0~100）");
                return;
            }

            if (!double.TryParse(txtEng.Text, out eng) || eng < 0 || eng > 100)
            {
                MessageBox.Show("請輸入有效成績（0~100）");
                return;
            }

            if (!double.TryParse(txtMath.Text, out math) || math < 0 || math > 100)
            {
                MessageBox.Show("請輸入有效成績（0~100）");
                return;
            }
            // 更新結構的值
            student.name = name;
            student.chi = chi;
            student.eng = eng;
            student.math = math;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            labScore.Text = $"姓名: {student.name}\n國文: {student.chi}\n英文: {student.eng}\n數學: {student.math}";
        }

        private void btn_HighestandLowest_Click(object sender, EventArgs e)
        {
            double chi = student.chi;
            double eng = student.eng;
            double math = student.math;

            string highestSubject = "";
            string lowestSubject = "";

            if (chi == eng && eng == math)
            {
                lab_HighestandLowest.Text = "三科分數相同";
                return;
            }

            double[] scores = { chi, eng, math };
            double highestScore = scores.Max();
            double lowestScore = scores.Min();

            if (chi == highestScore)
                highestSubject += "國文 ";
            if (eng == highestScore)
                highestSubject += "英文 ";
            if (math == highestScore)
                highestSubject += "數學 ";

            if (chi == lowestScore)
                lowestSubject += "國文 ";
            if (eng == lowestScore)
                lowestSubject += "英文 ";
            if (math == lowestScore)
                lowestSubject += "數學 ";

            lab_HighestandLowest.Text = $"最高科目成績為: {highestSubject}{highestScore} 分\n最低科目成績為: {lowestSubject}{lowestScore} 分";
        }

    }
}
