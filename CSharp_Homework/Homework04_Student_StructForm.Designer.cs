namespace CSharp_Homework
{
    partial class Homework04_Student_StructForm
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
            this.groupBox_Score = new System.Windows.Forms.GroupBox();
            this.btn_HighestandLowest = new System.Windows.Forms.Button();
            this.lab_HighestandLowest = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.labEng = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.groupBox_Score.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Score
            // 
            this.groupBox_Score.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Score.Controls.Add(this.btn_HighestandLowest);
            this.groupBox_Score.Controls.Add(this.lab_HighestandLowest);
            this.groupBox_Score.Controls.Add(this.labScore);
            this.groupBox_Score.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Score.Location = new System.Drawing.Point(51, 365);
            this.groupBox_Score.Name = "groupBox_Score";
            this.groupBox_Score.Size = new System.Drawing.Size(547, 210);
            this.groupBox_Score.TabIndex = 21;
            this.groupBox_Score.TabStop = false;
            this.groupBox_Score.Text = "成績";
            // 
            // btn_HighestandLowest
            // 
            this.btn_HighestandLowest.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_HighestandLowest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_HighestandLowest.Location = new System.Drawing.Point(289, -5);
            this.btn_HighestandLowest.Name = "btn_HighestandLowest";
            this.btn_HighestandLowest.Size = new System.Drawing.Size(218, 36);
            this.btn_HighestandLowest.TabIndex = 2;
            this.btn_HighestandLowest.Text = "最高分/最低分科目";
            this.btn_HighestandLowest.UseVisualStyleBackColor = true;
            this.btn_HighestandLowest.Click += new System.EventHandler(this.btn_HighestandLowest_Click);
            // 
            // lab_HighestandLowest
            // 
            this.lab_HighestandLowest.BackColor = System.Drawing.Color.AliceBlue;
            this.lab_HighestandLowest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_HighestandLowest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_HighestandLowest.Location = new System.Drawing.Point(272, 34);
            this.lab_HighestandLowest.Name = "lab_HighestandLowest";
            this.lab_HighestandLowest.Size = new System.Drawing.Size(260, 168);
            this.lab_HighestandLowest.TabIndex = 1;
            // 
            // labScore
            // 
            this.labScore.BackColor = System.Drawing.Color.AliceBlue;
            this.labScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labScore.Location = new System.Drawing.Point(6, 32);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(260, 168);
            this.labScore.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(445, 66);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(117, 50);
            this.btnShow.TabIndex = 20;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSave.Location = new System.Drawing.Point(445, 7);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 50);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "儲存";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(278, 76);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 32);
            this.txtMath.TabIndex = 18;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(278, 27);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(100, 32);
            this.txtEng.TabIndex = 17;
            this.txtEng.Text = "0";
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(92, 75);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(100, 32);
            this.txtChi.TabIndex = 16;
            this.txtChi.Text = "0";
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(92, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 32);
            this.txtName.TabIndex = 15;
            this.txtName.Text = "0";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(210, 80);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(53, 24);
            this.labMath.TabIndex = 14;
            this.labMath.Text = "數學:";
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(210, 33);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(53, 24);
            this.labEng.TabIndex = 13;
            this.labEng.Text = "英文:";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(27, 81);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(53, 24);
            this.labChi.TabIndex = 12;
            this.labChi.Text = "國文:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(27, 35);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(53, 24);
            this.labName.TabIndex = 11;
            this.labName.Text = "姓名:";
            // 
            // Homework04_Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::CSharp_Homework.Properties.Resources.mimi037;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(625, 587);
            this.Controls.Add(this.groupBox_Score);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.labName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homework04_Student_StructForm";
            this.Text = "Homework04_Student_StructForm";
            this.groupBox_Score.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Score;
        private System.Windows.Forms.Button btn_HighestandLowest;
        private System.Windows.Forms.Label lab_HighestandLowest;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labName;
    }
}