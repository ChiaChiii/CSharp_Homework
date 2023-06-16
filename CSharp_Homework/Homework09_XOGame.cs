using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Homework
{
    public partial class Homework09_XOGame : Form
    {
        private Button[] btnTControls; // 放置井字遊戲按鍵
        private bool isGameOver; // 有連線成功則結束
        private bool isO; // 點選是 O 還是 X

        
        //連線成功的組合
        static private int[,] winGroup = new int[8, 3]
        {
            {0,1,2},//橫向
            {3,4,5},//橫向
            {6,7,8},//橫向
            {0,3,6},//直向
            {1,4,7},//直向
            {2,5,8},//直向
            {0,4,8},//斜向
            {2,4,6} //斜向
        };

        public Homework09_XOGame()
        {
            InitializeComponent();
            //井字遊戲的 9 個按鍵
            btnTControls = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            InitButtons();
            // 為每個按鈕設定 Click 事件
            foreach (Button button in btnTControls)
            {
                button.Click += Buttons_Click;
            }

            KeyDown += new KeyEventHandler(Homework09_XOGame_Keydown);// 綁定 KeyDown 事件
        }

        
        private void Homework09_XOGame_Load(object sender, EventArgs e)
        {
            InitButtons();
        }
        private void InitButtons()
        {
            isGameOver = false;
            isO = true;
            foreach (Button button in btnTControls)
            {
                button.Text = "";                
            }
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isGameOver || button.Text != "")     //如果達到遊戲結束或是已經被點過就不能再點
            {
                return;
            }
            
            button.Text = isO ? "O" : "X";
            isO = !isO;

            bool[] GameStatus = CheckWinGroup(btnTControls);
            isGameOver = GameStatus[1];

            //有人獲勝
            if (GameStatus[0])
            {
                MessageBox.Show($"{button.Text} 手獲勝!", "完局");
                InitButtons();
                return;
            }
            //和局
            if (GameStatus[1])
            {
                MessageBox.Show("平手!", "完局");
                InitButtons();
            }
            
        }
        //檢查是否OX連線成功
        private bool[] CheckWinGroup(Button[] myControls)
        {
            //gameWinOver {是否有人獲勝, 是否遊戲結束(或是平局)}
            bool[] gameWinOver = new bool[2] { false, false };
            int btnIsUse = 1;
            for (int i = 0; i < 8; i++)
            {
                int a = winGroup[i, 0];
                int b = winGroup[i, 1];
                int c = winGroup[i, 2];
                Button b1 = myControls[a];
                Button b2 = myControls[b];
                Button b3 = myControls[c];

                //沒有連線就繼續
                if (b1.Text == "" || b2.Text == "" || b3.Text == "")
                    continue;

                //連線成功，遊戲結束
                if (b1.Text == b2.Text && b2.Text == b3.Text)
                {                   
                    gameWinOver = new bool[2] { true, true };
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitButtons();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Homework09_XOGame_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                btnReset_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnExit_Click(sender, e);
            }
        }
    }
}
