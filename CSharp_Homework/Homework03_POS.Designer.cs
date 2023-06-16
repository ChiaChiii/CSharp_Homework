namespace CSharp_Homework
{
    partial class Homework03_POS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homework03_POS));
            this.groupBox_ShoppingList = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.labShoppingList = new System.Windows.Forms.Label();
            this.groupBoxPaymethod = new System.Windows.Forms.GroupBox();
            this.labDiscount = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.groupBox_TotalPrice = new System.Windows.Forms.GroupBox();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.groupBox_Menu = new System.Windows.Forms.GroupBox();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.groupBox_ShoppingList.SuspendLayout();
            this.groupBoxPaymethod.SuspendLayout();
            this.groupBox_TotalPrice.SuspendLayout();
            this.groupBox_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ShoppingList
            // 
            this.groupBox_ShoppingList.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_ShoppingList.Controls.Add(this.btnRemove);
            this.groupBox_ShoppingList.Controls.Add(this.labShoppingList);
            this.groupBox_ShoppingList.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_ShoppingList.Location = new System.Drawing.Point(545, 10);
            this.groupBox_ShoppingList.Name = "groupBox_ShoppingList";
            this.groupBox_ShoppingList.Size = new System.Drawing.Size(241, 410);
            this.groupBox_ShoppingList.TabIndex = 7;
            this.groupBox_ShoppingList.TabStop = false;
            this.groupBox_ShoppingList.Text = "購物清單List";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(122, 365);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(113, 39);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "移除清單";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // labShoppingList
            // 
            this.labShoppingList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labShoppingList.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShoppingList.Location = new System.Drawing.Point(6, 40);
            this.labShoppingList.Name = "labShoppingList";
            this.labShoppingList.Size = new System.Drawing.Size(229, 322);
            this.labShoppingList.TabIndex = 0;
            this.labShoppingList.Text = "尚未點餐";
            this.labShoppingList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxPaymethod
            // 
            this.groupBoxPaymethod.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPaymethod.Controls.Add(this.labDiscount);
            this.groupBoxPaymethod.Controls.Add(this.btnCash);
            this.groupBoxPaymethod.Controls.Add(this.btnCreditCard);
            this.groupBoxPaymethod.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxPaymethod.Location = new System.Drawing.Point(281, 170);
            this.groupBoxPaymethod.Name = "groupBoxPaymethod";
            this.groupBoxPaymethod.Size = new System.Drawing.Size(241, 133);
            this.groupBoxPaymethod.TabIndex = 6;
            this.groupBoxPaymethod.TabStop = false;
            this.groupBoxPaymethod.Text = "付款方式";
            // 
            // labDiscount
            // 
            this.labDiscount.AutoSize = true;
            this.labDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labDiscount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDiscount.Location = new System.Drawing.Point(119, 91);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(116, 23);
            this.labDiscount.TabIndex = 2;
            this.labDiscount.Text = "信用卡享九折!";
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(9, 32);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(110, 43);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(125, 32);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(110, 43);
            this.btnCreditCard.TabIndex = 0;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // groupBox_TotalPrice
            // 
            this.groupBox_TotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_TotalPrice.Controls.Add(this.labTotalPrice);
            this.groupBox_TotalPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_TotalPrice.Location = new System.Drawing.Point(281, 10);
            this.groupBox_TotalPrice.Name = "groupBox_TotalPrice";
            this.groupBox_TotalPrice.Size = new System.Drawing.Size(241, 115);
            this.groupBox_TotalPrice.TabIndex = 5;
            this.groupBox_TotalPrice.TabStop = false;
            this.groupBox_TotalPrice.Text = "總金額Total Price";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTotalPrice.Location = new System.Drawing.Point(39, 50);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(194, 35);
            this.labTotalPrice.TabIndex = 0;
            this.labTotalPrice.Text = "NT$0";
            this.labTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox_Menu
            // 
            this.groupBox_Menu.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Menu.Controls.Add(this.btnWine);
            this.groupBox_Menu.Controls.Add(this.btnWhisky);
            this.groupBox_Menu.Controls.Add(this.btnTequila);
            this.groupBox_Menu.Controls.Add(this.btnBeer);
            this.groupBox_Menu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Menu.Location = new System.Drawing.Point(10, 10);
            this.groupBox_Menu.Name = "groupBox_Menu";
            this.groupBox_Menu.Size = new System.Drawing.Size(246, 426);
            this.groupBox_Menu.TabIndex = 4;
            this.groupBox_Menu.TabStop = false;
            this.groupBox_Menu.Text = "菜單 Menu";
            // 
            // btnWine
            // 
            this.btnWine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWine.BackgroundImage")));
            this.btnWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWine.ForeColor = System.Drawing.Color.Black;
            this.btnWine.Location = new System.Drawing.Point(127, 225);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(101, 185);
            this.btnWine.TabIndex = 3;
            this.btnWine.Text = "紅酒\r\nWine\r\n\r\n\r\n\r\nNT320";
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWhisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhisky.BackgroundImage")));
            this.btnWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhisky.ForeColor = System.Drawing.Color.Black;
            this.btnWhisky.Location = new System.Drawing.Point(20, 225);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(101, 185);
            this.btnWhisky.TabIndex = 2;
            this.btnWhisky.Text = "威士忌\r\nWhisky\r\n\r\n\r\n\r\nNT350\r\n";
            this.btnWhisky.UseVisualStyleBackColor = false;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTequila.BackgroundImage")));
            this.btnTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTequila.ForeColor = System.Drawing.Color.Black;
            this.btnTequila.Location = new System.Drawing.Point(127, 34);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(101, 185);
            this.btnTequila.TabIndex = 1;
            this.btnTequila.Text = "龍舌蘭\r\nTequila\r\n\r\n\r\n\r\nNT180\r\n";
            this.btnTequila.UseVisualStyleBackColor = false;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeer.BackgroundImage")));
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeer.ForeColor = System.Drawing.Color.Black;
            this.btnBeer.Location = new System.Drawing.Point(20, 34);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(101, 185);
            this.btnBeer.TabIndex = 0;
            this.btnBeer.Text = "啤酒\r\nBeer\r\n\r\n\r\n\r\nNT120\r\n";
            this.btnBeer.UseVisualStyleBackColor = false;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // Homework03_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharp_Homework.Properties.Resources.Spirited_Away_Wallpaper_4K_PC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 440);
            this.Controls.Add(this.groupBox_ShoppingList);
            this.Controls.Add(this.groupBoxPaymethod);
            this.Controls.Add(this.groupBox_TotalPrice);
            this.Controls.Add(this.groupBox_Menu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Homework03_POS";
            this.Text = "Bar_POS";
            this.groupBox_ShoppingList.ResumeLayout(false);
            this.groupBoxPaymethod.ResumeLayout(false);
            this.groupBoxPaymethod.PerformLayout();
            this.groupBox_TotalPrice.ResumeLayout(false);
            this.groupBox_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ShoppingList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label labShoppingList;
        private System.Windows.Forms.GroupBox groupBoxPaymethod;
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.GroupBox groupBox_TotalPrice;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.GroupBox groupBox_Menu;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnBeer;
    }
}