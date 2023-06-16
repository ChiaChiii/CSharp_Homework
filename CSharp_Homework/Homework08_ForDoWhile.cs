using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CSharp_Homework
{
    public partial class Homework08_ForDoWhile : Form
    {
        public Homework08_ForDoWhile()
        {
            InitializeComponent();
        }

        int[] arr0711 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] names = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "MotherFacker" };

        private void btnOddOrEven_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtNum1.Text, out number))
            {
                string result = (number % 2 == 0) ? "偶數" : "奇數";
                labShowResult.Text = $"輸入的數 {txtNum1.Text} 為 {result}。";
            }
            else
            {
                MessageBox.Show("請輸入整數數字。");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "結果";
        }

        private void btnTimesTable_Click(object sender, EventArgs e)
        {
            string result = "九九乘法表\n";

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 2; b <= 9; b++)
                {
                    if (b * a < 10) //針對個位數結果把十位數位置改為空格
                    {
                        result += " " + b + "  x" + a + "=  " + b * a + "| ";
                    }
                    else
                    {
                        result += " " + b + "  x" + a + "=" + b * a + "| ";
                    }

                };
                result += "\n";
            }

            labShowResult.Text = result;
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRow.Text, out int row))
            {
                string result = "";
                for (int i = 1; i <= row; i++)
                {
                    result += new string('*', i) + "\n";
                }
                labShowResult.Text = result;
            }
            else
            {
                MessageBox.Show("請輸入整數!");
            }

        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            string binary = Convert.ToString(100, 2);
            labShowResult.Text = binary;
        }

        private void btnLotto_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            List<int> numbers = new List<int>();

            while (numbers.Count < 6)
            {
                int number = random.Next(1, 50);
                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                }
            }

            labShowResult.Text = string.Join(", ", numbers);
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int max = arr0711.Max();
            int min = arr0711.Min();
            labShowResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                                 $"最大值為{max}\n" +
                                 $"最小值為{min}";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int max = arr0711.Max();
            labShowResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                                 $"最大值為{max}\n";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = arr0711.Min();
            labShowResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                                 $"最小值為{min}\n";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = arr0711.Sum();
            labShowResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                                 $"加總為{sum}\n";
        }

        private void btnOddAndEven_Click(object sender, EventArgs e)
        {
            int oddCount = 0;
            int evenCount = 0;

            foreach (int num in arr0711)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            labShowResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                                 $"奇數共{oddCount}\n偶數共{evenCount}";
        }

        private void btnLongestName_Click(object sender, EventArgs e)
        {
            string longestName = "";

            foreach (string name in names)
            {
                if (name.Length > longestName.Length)
                {
                    longestName = name;
                }
            }

            labShowResult.Text = "陣列arr0711_Str[ mother張, emma, 迪克, J40, Candy, Cindy, Coconut, MotherFacker ]\n" +
                                  $"最長的名名字為{longestName}";
        }

        private void btnHowMuchC_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (string name in names)
            {
                if (name.Contains("c") || name.Contains("C"))
                {
                    count++;
                }
            }

            labShowResult.Text = "陣列arr0711_Str[ mother張, emma, 迪克, J40, Candy, Cindy, Coconut, MotherFacker ]\n" +
                                  $"有c及C名字共有{count}個";
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n = 100;
            int n2 = 200;

            void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Swap(ref n, ref n2);
            labShowResult.Text = $"換位前n1=100 , n2=200\n" +
                                 $"換位後n1={n} , n2={n2}";
        }

        private void btnArray10_Click(object sender, EventArgs e)
        {
            int[,] array = new int[10, 10];

            // 設置外圈為 1
            for (int i = 0; i < 10; i++)
            {
                array[i, 0] = 1;
                array[i, 9] = 1;
                array[0, i] = 1;
                array[9, i] = 1;
            }

            // 設置內部為0
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    array[i, j] = 0;
                }
            }

            string result = "";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += array[i, j] + " ";
                }

                result += "\n";
            }

            labShowResult.Text = result;
        }

        private void btnArray01_Click(object sender, EventArgs e)
        {
            int[,] array = new int[10, 10];

            // 設置外圈為0
            for (int i = 0; i < 10; i++)
            {
                array[i, 0] = 0;
                array[i, 9] = 0;
                array[0, i] = 0;
                array[9, i] = 0;
            }

            // 設置內部為1
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    array[i, j] = 1;
                }
            }

            string result = "";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += array[i, j] + " ";
                }

                result += "\n";
            }

            labShowResult.Text = result;
        }

        private void btnArray101010_Click(object sender, EventArgs e)
        {
            int[,] array = new int[10, 10];
            
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    if (row % 2 == 0) //是否偶數列
                    {
                        array[row, col] = col % 2;
                    }
                    else 
                    {
                        array[row, col] = (col + 1) % 2;
                    }
                }
            }

            string result = "";

           
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    result += array[row, col];
                }

                result += "\n";
            }

            labShowResult.Text = result;
        }

    }
}
