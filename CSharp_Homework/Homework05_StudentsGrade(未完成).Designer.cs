namespace CSharp_Homework
{
    partial class Homework05_StudentsGrade
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
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.labEng = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnAddRandom = new System.Windows.Forms.Button();
            this.btnAVG = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandomAdd20 = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.labSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(85, 157);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 32);
            this.txtMath.TabIndex = 26;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(85, 108);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(100, 32);
            this.txtEng.TabIndex = 25;
            this.txtEng.Text = "0";
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(85, 59);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(100, 32);
            this.txtChi.TabIndex = 24;
            this.txtChi.Text = "0";
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(85, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 32);
            this.txtName.TabIndex = 23;
            this.txtName.Text = "0";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(20, 160);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(53, 24);
            this.labMath.TabIndex = 22;
            this.labMath.Text = "數學:";
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(20, 113);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(53, 24);
            this.labEng.TabIndex = 21;
            this.labEng.Text = "英文:";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(20, 65);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(53, 24);
            this.labChi.TabIndex = 20;
            this.labChi.Text = "國文:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(20, 19);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(53, 24);
            this.labName.TabIndex = 19;
            this.labName.Text = "姓名:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnAdd.Location = new System.Drawing.Point(24, 210);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(161, 30);
            this.BtnAdd.TabIndex = 27;
            this.BtnAdd.Text = "加入學生資料";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddRandom
            // 
            this.btnAddRandom.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddRandom.Location = new System.Drawing.Point(24, 250);
            this.btnAddRandom.Name = "btnAddRandom";
            this.btnAddRandom.Size = new System.Drawing.Size(161, 30);
            this.btnAddRandom.TabIndex = 27;
            this.btnAddRandom.Text = "隨機儲存資料";
            this.btnAddRandom.UseVisualStyleBackColor = true;
            // 
            // btnAVG
            // 
            this.btnAVG.Enabled = false;
            this.btnAVG.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAVG.Location = new System.Drawing.Point(24, 290);
            this.btnAVG.Name = "btnAVG";
            this.btnAVG.Size = new System.Drawing.Size(161, 30);
            this.btnAVG.TabIndex = 27;
            this.btnAVG.Text = "各科統計";
            this.btnAVG.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(24, 330);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 30);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnRandomAdd20
            // 
            this.btnRandomAdd20.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandomAdd20.Location = new System.Drawing.Point(24, 370);
            this.btnRandomAdd20.Name = "btnRandomAdd20";
            this.btnRandomAdd20.Size = new System.Drawing.Size(161, 30);
            this.btnRandomAdd20.TabIndex = 27;
            this.btnRandomAdd20.Text = "隨機加入20筆";
            this.btnRandomAdd20.UseVisualStyleBackColor = true;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(191, 9);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(360, 238);
            this.txtSummary.TabIndex = 28;
            // 
            // labSummary
            // 
            this.labSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labSummary.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSummary.Location = new System.Drawing.Point(191, 250);
            this.labSummary.Name = "labSummary";
            this.labSummary.Size = new System.Drawing.Size(360, 150);
            this.labSummary.TabIndex = 29;
            // 
            // Homework05_StudentsGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 415);
            this.Controls.Add(this.labSummary);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btnRandomAdd20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAVG);
            this.Controls.Add(this.btnAddRandom);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.labName);
            this.Name = "Homework05_StudentsGrade";
            this.Text = "Homework05_StudentsGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnAddRandom;
        private System.Windows.Forms.Button btnAVG;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandomAdd20;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label labSummary;
    }
}