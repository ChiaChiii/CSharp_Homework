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
    public partial class Homework02_Loan : Form
    {
        public Homework02_Loan()
        {
            InitializeComponent();
        }
        private void GetInputValues
            (out decimal loanAmount, out int loanTerm, out decimal interestRate, out decimal downPayment,
            out decimal monthlyInterestRate, out decimal monthlyPayment)
        {
            loanAmount = decimal.Parse(textLoan.Text) - decimal.Parse(txtDownPayment.Text); //=貸款金額(扣頭期款)=X
            loanTerm = int.Parse(txtYear.Text) * 12; //月數
            interestRate = decimal.Parse(txtRates.Text) / 100 / 12; //=月利率
            downPayment = decimal.Parse(txtDownPayment.Text); //=頭期款

            //每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}        
            monthlyInterestRate = ((decimal)Math.Pow((double)(1 + interestRate), loanTerm) * interestRate)
                                    /
                                    ((decimal)Math.Pow((double)(1 + interestRate), loanTerm) - 1);//C
            monthlyPayment = Convert.ToInt32(loanAmount * monthlyInterestRate);//PMC=X*C,四捨五入到整數
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            GetInputValues(out decimal loanAmount, out int loanTerm, out decimal interestRate, out decimal downPayment,
            out decimal monthlyInterestRate, out decimal monthlyPayment);
            //抓取參數並且使用            
            MessageBox.Show("月付額:" + monthlyPayment + "元");
        }

        private void bntTotal_Click(object sender, EventArgs e)
        {
            GetInputValues(out decimal loanAmount, out int loanTerm, out decimal interestRate, out decimal downPayment,
           out decimal monthlyInterestRate, out decimal monthlyPayment);
            //抓取參數並且使用
            MessageBox.Show("總付款:" + monthlyPayment * loanTerm + "元");
        }

        private void bntReport_Click(object sender, EventArgs e)
        {
            GetInputValues(out decimal loanAmount, out int loanTerm, out decimal interestRate, out decimal downPayment,
           out decimal monthlyInterestRate, out decimal monthlyPayment);
            //抓取參數並且使用

            // 創建並打開報告表單            
            Homework02_LoanReport reportForm = new Homework02_LoanReport();
            reportForm.Label1Text = textLoan.Text;
            reportForm.Label2Text = txtYear.Text;
            reportForm.Label3Text = txtRates.Text;
            reportForm.Label4Text = monthlyPayment.ToString();
            reportForm.Label5Text = (monthlyPayment * loanTerm).ToString();
            reportForm.Show();
        }
    }
}
