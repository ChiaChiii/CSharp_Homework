namespace CSharp_Homework
{
    partial class Homework08_ForDoWhile
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
            this.labNumber = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnOddOrEven = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.labShowResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnOddAndEven = new System.Windows.Forms.Button();
            this.btnLongestName = new System.Windows.Forms.Button();
            this.btnHowMuchC = new System.Windows.Forms.Button();
            this.btnArray10 = new System.Windows.Forms.Button();
            this.btnArray01 = new System.Windows.Forms.Button();
            this.btnArray101010 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.labRow = new System.Windows.Forms.Label();
            this.btnTree = new System.Windows.Forms.Button();
            this.btnTimesTable = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnLotto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labMurMur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumber.Location = new System.Drawing.Point(8, 11);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(76, 20);
            this.labNumber.TabIndex = 12;
            this.labNumber.Text = "Number:";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum1.Location = new System.Drawing.Point(90, 8);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 29);
            this.txtNum1.TabIndex = 17;
            // 
            // btnOddOrEven
            // 
            this.btnOddOrEven.BackColor = System.Drawing.Color.Thistle;
            this.btnOddOrEven.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOddOrEven.Location = new System.Drawing.Point(207, 3);
            this.btnOddOrEven.Name = "btnOddOrEven";
            this.btnOddOrEven.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOddOrEven.Size = new System.Drawing.Size(161, 37);
            this.btnOddOrEven.TabIndex = 19;
            this.btnOddOrEven.Text = "輸入的數為奇數或偶數?";
            this.btnOddOrEven.UseVisualStyleBackColor = false;
            this.btnOddOrEven.Click += new System.EventHandler(this.btnOddOrEven_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(296, 256);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(59, 20);
            this.labResult.TabIndex = 20;
            this.labResult.Text = "Result:";
            // 
            // labShowResult
            // 
            this.labShowResult.AutoSize = true;
            this.labShowResult.BackColor = System.Drawing.Color.MistyRose;
            this.labShowResult.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowResult.Location = new System.Drawing.Point(300, 285);
            this.labShowResult.Name = "labShowResult";
            this.labShowResult.Size = new System.Drawing.Size(39, 19);
            this.labShowResult.TabIndex = 21;
            this.labShowResult.Text = "結果";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(12, 473);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClear.Size = new System.Drawing.Size(79, 29);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "清空結果欄";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.BackColor = System.Drawing.Color.Linen;
            this.btnMaxMin.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaxMin.Location = new System.Drawing.Point(9, 67);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMaxMin.Size = new System.Drawing.Size(193, 37);
            this.btnMaxMin.TabIndex = 24;
            this.btnMaxMin.Text = "陣列arr0711[]最大/最小值";
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnOddAndEven
            // 
            this.btnOddAndEven.BackColor = System.Drawing.Color.Linen;
            this.btnOddAndEven.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOddAndEven.Location = new System.Drawing.Point(9, 110);
            this.btnOddAndEven.Name = "btnOddAndEven";
            this.btnOddAndEven.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOddAndEven.Size = new System.Drawing.Size(193, 37);
            this.btnOddAndEven.TabIndex = 25;
            this.btnOddAndEven.Text = "陣列arr0711[]統計奇數偶數";
            this.btnOddAndEven.UseVisualStyleBackColor = false;
            this.btnOddAndEven.Click += new System.EventHandler(this.btnOddAndEven_Click);
            // 
            // btnLongestName
            // 
            this.btnLongestName.BackColor = System.Drawing.Color.Linen;
            this.btnLongestName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLongestName.Location = new System.Drawing.Point(9, 153);
            this.btnLongestName.Name = "btnLongestName";
            this.btnLongestName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLongestName.Size = new System.Drawing.Size(193, 37);
            this.btnLongestName.TabIndex = 26;
            this.btnLongestName.Text = "陣列arr0711[]str最長的名字";
            this.btnLongestName.UseVisualStyleBackColor = false;
            this.btnLongestName.Click += new System.EventHandler(this.btnLongestName_Click);
            // 
            // btnHowMuchC
            // 
            this.btnHowMuchC.BackColor = System.Drawing.Color.Linen;
            this.btnHowMuchC.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHowMuchC.Location = new System.Drawing.Point(9, 196);
            this.btnHowMuchC.Name = "btnHowMuchC";
            this.btnHowMuchC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHowMuchC.Size = new System.Drawing.Size(193, 37);
            this.btnHowMuchC.TabIndex = 27;
            this.btnHowMuchC.Text = "陣列arr0711[]str C or c的字樣\r\n";
            this.btnHowMuchC.UseVisualStyleBackColor = false;
            this.btnHowMuchC.Click += new System.EventHandler(this.btnHowMuchC_Click);
            // 
            // btnArray10
            // 
            this.btnArray10.BackColor = System.Drawing.Color.Linen;
            this.btnArray10.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArray10.Location = new System.Drawing.Point(440, 67);
            this.btnArray10.Name = "btnArray10";
            this.btnArray10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnArray10.Size = new System.Drawing.Size(193, 37);
            this.btnArray10.TabIndex = 29;
            this.btnArray10.Text = "[10,10]二維陣列-邊1,內0";
            this.btnArray10.UseVisualStyleBackColor = false;
            this.btnArray10.Click += new System.EventHandler(this.btnArray10_Click);
            // 
            // btnArray01
            // 
            this.btnArray01.BackColor = System.Drawing.Color.Linen;
            this.btnArray01.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArray01.Location = new System.Drawing.Point(440, 110);
            this.btnArray01.Name = "btnArray01";
            this.btnArray01.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnArray01.Size = new System.Drawing.Size(193, 37);
            this.btnArray01.TabIndex = 30;
            this.btnArray01.Text = "[10,10]二維陣列-邊0,內1";
            this.btnArray01.UseVisualStyleBackColor = false;
            this.btnArray01.Click += new System.EventHandler(this.btnArray01_Click);
            // 
            // btnArray101010
            // 
            this.btnArray101010.BackColor = System.Drawing.Color.Linen;
            this.btnArray101010.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArray101010.Location = new System.Drawing.Point(440, 153);
            this.btnArray101010.Name = "btnArray101010";
            this.btnArray101010.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnArray101010.Size = new System.Drawing.Size(193, 80);
            this.btnArray101010.TabIndex = 31;
            this.btnArray101010.Text = "[10,10]二維陣列\r\n101010\r\n010101\r\n...\r\n";
            this.btnArray101010.UseVisualStyleBackColor = false;
            this.btnArray101010.Click += new System.EventHandler(this.btnArray101010_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.Color.Linen;
            this.btnSwap.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwap.Location = new System.Drawing.Point(222, 67);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSwap.Size = new System.Drawing.Size(193, 37);
            this.btnSwap.TabIndex = 32;
            this.btnSwap.Text = "Swap[int,int]";
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.Linen;
            this.btnSum.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSum.Location = new System.Drawing.Point(222, 110);
            this.btnSum.Name = "btnSum";
            this.btnSum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSum.Size = new System.Drawing.Size(193, 37);
            this.btnSum.TabIndex = 33;
            this.btnSum.Text = "Sum(陣列arr0711[])\r\n";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Linen;
            this.btnMax.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMax.Location = new System.Drawing.Point(222, 153);
            this.btnMax.Name = "btnMax";
            this.btnMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMax.Size = new System.Drawing.Size(193, 37);
            this.btnMax.TabIndex = 34;
            this.btnMax.Text = "Max(陣列arr0711[])\r\n";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Linen;
            this.btnMin.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMin.Location = new System.Drawing.Point(222, 196);
            this.btnMin.Name = "btnMin";
            this.btnMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMin.Size = new System.Drawing.Size(193, 37);
            this.btnMin.TabIndex = 34;
            this.btnMin.Text = "Min(陣列arr0711[])\r\n";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // txtRow
            // 
            this.txtRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRow.Location = new System.Drawing.Point(66, 260);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(100, 29);
            this.txtRow.TabIndex = 35;
            // 
            // labRow
            // 
            this.labRow.AutoSize = true;
            this.labRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRow.Location = new System.Drawing.Point(8, 263);
            this.labRow.Name = "labRow";
            this.labRow.Size = new System.Drawing.Size(52, 20);
            this.labRow.TabIndex = 36;
            this.labRow.Text = "Rows:";
            // 
            // btnTree
            // 
            this.btnTree.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTree.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTree.Location = new System.Drawing.Point(172, 256);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(91, 37);
            this.btnTree.TabIndex = 37;
            this.btnTree.Text = "直角聖誕樹";
            this.btnTree.UseVisualStyleBackColor = false;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // btnTimesTable
            // 
            this.btnTimesTable.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTimesTable.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTimesTable.Location = new System.Drawing.Point(9, 313);
            this.btnTimesTable.Name = "btnTimesTable";
            this.btnTimesTable.Size = new System.Drawing.Size(106, 37);
            this.btnTimesTable.TabIndex = 38;
            this.btnTimesTable.Text = "九九乘法表";
            this.btnTimesTable.UseVisualStyleBackColor = false;
            this.btnTimesTable.Click += new System.EventHandler(this.btnTimesTable_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBinary.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBinary.Location = new System.Drawing.Point(121, 313);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(106, 37);
            this.btnBinary.TabIndex = 38;
            this.btnBinary.Text = "100的二進位?";
            this.btnBinary.UseVisualStyleBackColor = false;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnLotto
            // 
            this.btnLotto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLotto.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLotto.Location = new System.Drawing.Point(9, 356);
            this.btnLotto.Name = "btnLotto";
            this.btnLotto.Size = new System.Drawing.Size(144, 37);
            this.btnLotto.TabIndex = 38;
            this.btnLotto.Text = "樂透int[]號碼不重複";
            this.btnLotto.UseVisualStyleBackColor = false;
            this.btnLotto.Click += new System.EventHandler(this.btnLotto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(8, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "--------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "--------------------------------";
            // 
            // labMurMur
            // 
            this.labMurMur.AutoSize = true;
            this.labMurMur.BackColor = System.Drawing.Color.Transparent;
            this.labMurMur.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMurMur.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labMurMur.Location = new System.Drawing.Point(702, 485);
            this.labMurMur.Name = "labMurMur";
            this.labMurMur.Size = new System.Drawing.Size(191, 20);
            this.labMurMur.TabIndex = 39;
            this.labMurMur.Text = "這題跟霍爾浴室一樣亂XD";
            // 
            // Homework08_ForDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::CSharp_Homework.Properties.Resources.howl020;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 514);
            this.Controls.Add(this.labMurMur);
            this.Controls.Add(this.btnLotto);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.btnTimesTable);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.labRow);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnArray101010);
            this.Controls.Add(this.btnArray01);
            this.Controls.Add(this.btnArray10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHowMuchC);
            this.Controls.Add(this.btnLongestName);
            this.Controls.Add(this.btnOddAndEven);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labShowResult);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnOddOrEven);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.labNumber);
            this.Name = "Homework08_ForDoWhile";
            this.Text = "Homework08_ForDoWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnOddOrEven;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label labShowResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnOddAndEven;
        private System.Windows.Forms.Button btnLongestName;
        private System.Windows.Forms.Button btnHowMuchC;
        private System.Windows.Forms.Button btnArray10;
        private System.Windows.Forms.Button btnArray01;
        private System.Windows.Forms.Button btnArray101010;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label labRow;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Button btnTimesTable;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnLotto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labMurMur;
    }
}