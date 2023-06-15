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
    public partial class Homework09_XOGame : Form
    {
        Button[] btnTControls = new Button[9];//放置井字遊戲按鍵
        Boolean isGameOver = false;     //有連線成功則結束
        Boolean isO = true;     //點選是 O 還是 X

        public Homework09_XOGame()
        {
            InitializeComponent();
            //井字遊戲的 9 個按鍵
            btnTControls = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            initButtons();
            // 為每個按鈕設定 Click 事件
            for (int i = 0; i < btnTControls.Length; i++)
            {
                btnTControls[i].Click += buttons_Click;
            }
        }
        //設定遊戲開始的按鍵文字
        private void initButtons()
        {
            isGameOver = false;
            isO = true;
            for (int i = 0; i < btnTControls.Length; i++)
            {
                btnTControls[i].Text = "";                
            }
        }

        private void Homework09_XOGame_Load(object sender, EventArgs e)
        {
            initButtons();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isGameOver)
            {
                return;
            }
            if (tmpButton.Text != "")
            {                
                return;
            }
            if (isO)
            {
                tmpButton.Text = "O";
                tmpButton.BackColor = Color.LightGreen;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.BackColor = Color.LightYellow;
            }
            isO = !isO;

            bool[] GameStatus = CheckWinGroup(btnTControls);
            

            //有人獲勝
            if (GameStatus[0])
            {
                MessageBox.Show($"{tmpButton.Text}手獲勝!", "完局!", MessageBoxButtons.OK);
                initButtons();
            }
            //和局
            if (GameStatus[1])
            {
                MessageBox.Show("平手!按下確定重新開始", "完局", MessageBoxButtons.OK);
                initButtons();
            }
        }

        //連線成功的組合
        static private int[,] WinGroup = new int[8, 3]
        {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };


        //檢查是否OX連線成功
        private bool[] CheckWinGroup(Button[] myControls)
        {
            //gameWinOver {是否有人獲勝, 是否遊戲結束(或是平局)}
            bool[] gameWinOver = new bool[2] { false, false };
            int btnIsUse = 1;
            for (int i = 0; i < 8; i++)
            {
                int a = WinGroup[i, 0];
                int b = WinGroup[i, 1];
                int c = WinGroup[i, 2];
                Button b1 = myControls[a];
                Button b2 = myControls[b];
                Button b3 = myControls[c];

                //沒有連線就繼續
                if (b1.Text == "" || b2.Text == "" || b3.Text == "")
                    continue;

                //連線成功，遊戲結束
                if (b1.Text == b2.Text && b2.Text == b3.Text)
                {
                    gameWinOver[0] = true;
                    break;
                }

                //九格填完，顯示結束
                if (myControls[i].Text != "")
                {
                    btnIsUse++;
                    if (btnIsUse == 9)
                        gameWinOver[1] = true;
                }
            }
            return gameWinOver;
        }
    }
}
