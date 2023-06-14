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
    
    public partial class Homework03_POS : Form
    {
        // Menu items
        DrinkMenu beer;
        DrinkMenu tequila;
        DrinkMenu whisky;
        DrinkMenu wine;

        public Homework03_POS()
        {
            InitializeComponent();
            InitializeMenuItems();// Initialize menu items
        }

        int totalPrice;
        // Initialize menu items
        private void InitializeMenuItems()
        {
            beer = new DrinkMenu
            {
                Name = "啤酒Beer",
                Count = 0,
                UnitPrice = 120
            };

            tequila = new DrinkMenu
            {
                Name = "龍舌蘭Tequila",
                Count = 0,
                UnitPrice = 180
            };

            whisky = new DrinkMenu
            {
                Name = "威士忌Whisky",
                Count = 0,
                UnitPrice = 350
            };

            wine = new DrinkMenu
            {
                Name = "紅酒Wine",
                Count = 0,
                UnitPrice = 320
            };
        }

        public class DrinkMenu
        {
            public string Name { get; set; }
            public int Count { get; set; }
            public int UnitPrice { get; set; }
        }


        private void btnBeer_Click(object sender, EventArgs e)
        {
            beer.Count++;
            ShoppingListUpdate();
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            tequila.Count++;
            ShoppingListUpdate();
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            whisky.Count++;
            ShoppingListUpdate();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            wine.Count++;
            ShoppingListUpdate();
        }

        public void ShoppingListUpdate()
        {
            totalPrice = 0;
            string labShoppingListText = "";// 儲存購物清單內容的臨時字串變數

            if (beer.Count > 0)
            {
                totalPrice += beer.Count * beer.UnitPrice;
                labShoppingListText += $"{beer.Name} x {beer.Count}, 共NT$ {beer.Count * beer.UnitPrice}元\r\n";
            }
            if (tequila.Count > 0)
            {
                totalPrice += tequila.Count * tequila.UnitPrice;
                labShoppingListText += $"{tequila.Name} x {tequila.Count}, 共NT$ {tequila.Count * tequila.UnitPrice}元\r\n";
            }
            if (whisky.Count > 0)
            {
                totalPrice += whisky.Count * whisky.UnitPrice;
                labShoppingListText += $"{whisky.Name} x {whisky.Count}, 共NT$ {whisky.Count * whisky.UnitPrice}元\r\n";
            }
            if (wine.Count > 0)
            {
                totalPrice += wine.Count * wine.UnitPrice;
                labShoppingListText += $"{wine.Name} x {wine.Count}, 共NT$ {wine.Count * wine.UnitPrice}元\r\n";
            }
            if (totalPrice == 0)
            {
                labShoppingListText = "尚未點餐";
            }
            labShoppingList.Text = labShoppingListText; // 將購物清單內容指派給 labShoppingList 的 Text 屬性
            labTotalPrice.Text = $"NT${totalPrice}";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            beer.Count = 0;
            tequila.Count = 0;
            whisky.Count = 0;
            wine.Count = 0;
            ShoppingListUpdate();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (totalPrice == 0)
            {
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"總金額：NT$ {totalPrice}", "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            if (totalPrice == 0)
            {
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"總金額：NT$ {totalPrice}\n折扣後金額：NT${totalPrice*0.9}", "確認付款", MessageBoxButtons.OKCancel);
            }
        }
    }
}
