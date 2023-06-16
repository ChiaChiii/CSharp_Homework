namespace CSharp_Homework
{
    partial class Homework02_Loan
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
            this.bntReport = new System.Windows.Forms.Button();
            this.bntTotal = new System.Windows.Forms.Button();
            this.btnPMT = new System.Windows.Forms.Button();
            this.labDownPayment = new System.Windows.Forms.Label();
            this.labRates = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labLaon = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtRates = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.textLoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntReport
            // 
            this.bntReport.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntReport.Location = new System.Drawing.Point(291, 357);
            this.bntReport.Name = "bntReport";
            this.bntReport.Size = new System.Drawing.Size(110, 62);
            this.bntReport.TabIndex = 21;
            this.bntReport.Text = "Report";
            this.bntReport.UseVisualStyleBackColor = true;
            this.bntReport.Click += new System.EventHandler(this.bntReport_Click);
            // 
            // bntTotal
            // 
            this.bntTotal.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntTotal.Location = new System.Drawing.Point(160, 357);
            this.bntTotal.Name = "bntTotal";
            this.bntTotal.Size = new System.Drawing.Size(110, 62);
            this.bntTotal.TabIndex = 20;
            this.bntTotal.Text = "總付款";
            this.bntTotal.UseVisualStyleBackColor = true;
            this.bntTotal.Click += new System.EventHandler(this.bntTotal_Click);
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(38, 357);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(110, 62);
            this.btnPMT.TabIndex = 19;
            this.btnPMT.Text = "月付(PMT)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // labDownPayment
            // 
            this.labDownPayment.AutoSize = true;
            this.labDownPayment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPayment.Location = new System.Drawing.Point(238, 65);
            this.labDownPayment.Name = "labDownPayment";
            this.labDownPayment.Size = new System.Drawing.Size(67, 24);
            this.labDownPayment.TabIndex = 18;
            this.labDownPayment.Text = "頭期款";
            // 
            // labRates
            // 
            this.labRates.AutoSize = true;
            this.labRates.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRates.Location = new System.Drawing.Point(237, 13);
            this.labRates.Name = "labRates";
            this.labRates.Size = new System.Drawing.Size(79, 24);
            this.labRates.TabIndex = 17;
            this.labRates.Text = "利率(%)";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.Location = new System.Drawing.Point(22, 67);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(81, 24);
            this.labYear.TabIndex = 16;
            this.labYear.Text = "期限(年)";
            // 
            // labLaon
            // 
            this.labLaon.AutoSize = true;
            this.labLaon.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLaon.Location = new System.Drawing.Point(22, 13);
            this.labLaon.Name = "labLaon";
            this.labLaon.Size = new System.Drawing.Size(86, 24);
            this.labLaon.TabIndex = 15;
            this.labLaon.Text = "貸款金額";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPayment.Location = new System.Drawing.Point(322, 62);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(103, 33);
            this.txtDownPayment.TabIndex = 14;
            this.txtDownPayment.Text = "0";
            // 
            // txtRates
            // 
            this.txtRates.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRates.Location = new System.Drawing.Point(322, 12);
            this.txtRates.Name = "txtRates";
            this.txtRates.Size = new System.Drawing.Size(103, 33);
            this.txtRates.TabIndex = 13;
            this.txtRates.Text = "10";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(109, 61);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 33);
            this.txtYear.TabIndex = 12;
            this.txtYear.Text = "2";
            // 
            // textLoan
            // 
            this.textLoan.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textLoan.Location = new System.Drawing.Point(109, 10);
            this.textLoan.Name = "textLoan";
            this.textLoan.Size = new System.Drawing.Size(100, 33);
            this.textLoan.TabIndex = 11;
            this.textLoan.Text = "100000";
            // 
            // Homework02_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharp_Homework.Properties.Resources.porco017;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(437, 436);
            this.Controls.Add(this.bntReport);
            this.Controls.Add(this.bntTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.labDownPayment);
            this.Controls.Add(this.labRates);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labLaon);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtRates);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.textLoan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homework02_Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntReport;
        private System.Windows.Forms.Button bntTotal;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Label labDownPayment;
        private System.Windows.Forms.Label labRates;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labLaon;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtRates;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox textLoan;
    }
}