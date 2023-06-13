namespace Lab_Homework
{
    partial class Lab_Homework02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_Homework02));
            this.Loan = new System.Windows.Forms.Label();
            this.textLoan = new System.Windows.Forms.TextBox();
            this.RepayTerm = new System.Windows.Forms.Label();
            this.textRepayTerm = new System.Windows.Forms.TextBox();
            this.Interrest_Rate = new System.Windows.Forms.Label();
            this.textInterrest_Rate = new System.Windows.Forms.TextBox();
            this.DownPayment = new System.Windows.Forms.Label();
            this.textDownPayment = new System.Windows.Forms.TextBox();
            this.MonthPay = new System.Windows.Forms.Button();
            this.TotalPay = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Loan
            // 
            this.Loan.AutoSize = true;
            this.Loan.BackColor = System.Drawing.Color.Gold;
            this.Loan.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Loan.Location = new System.Drawing.Point(44, 79);
            this.Loan.Name = "Loan";
            this.Loan.Size = new System.Drawing.Size(120, 27);
            this.Loan.TabIndex = 0;
            this.Loan.Text = "貸款金額";
            // 
            // textLoan
            // 
            this.textLoan.BackColor = System.Drawing.Color.Cornsilk;
            this.textLoan.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textLoan.Location = new System.Drawing.Point(187, 79);
            this.textLoan.Name = "textLoan";
            this.textLoan.Size = new System.Drawing.Size(100, 34);
            this.textLoan.TabIndex = 1;
            this.textLoan.TextChanged += new System.EventHandler(this.textLoan_TextChanged);
            // 
            // RepayTerm
            // 
            this.RepayTerm.AutoSize = true;
            this.RepayTerm.BackColor = System.Drawing.Color.Gold;
            this.RepayTerm.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RepayTerm.Location = new System.Drawing.Point(44, 137);
            this.RepayTerm.Name = "RepayTerm";
            this.RepayTerm.Size = new System.Drawing.Size(121, 27);
            this.RepayTerm.TabIndex = 2;
            this.RepayTerm.Text = "期限(年)";
            // 
            // textRepayTerm
            // 
            this.textRepayTerm.BackColor = System.Drawing.Color.Cornsilk;
            this.textRepayTerm.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textRepayTerm.Location = new System.Drawing.Point(187, 134);
            this.textRepayTerm.Name = "textRepayTerm";
            this.textRepayTerm.Size = new System.Drawing.Size(100, 34);
            this.textRepayTerm.TabIndex = 3;
            // 
            // Interrest_Rate
            // 
            this.Interrest_Rate.AutoSize = true;
            this.Interrest_Rate.BackColor = System.Drawing.Color.Gold;
            this.Interrest_Rate.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Interrest_Rate.Location = new System.Drawing.Point(44, 194);
            this.Interrest_Rate.Name = "Interrest_Rate";
            this.Interrest_Rate.Size = new System.Drawing.Size(107, 27);
            this.Interrest_Rate.TabIndex = 4;
            this.Interrest_Rate.Text = "年利率%";
            // 
            // textInterrest_Rate
            // 
            this.textInterrest_Rate.BackColor = System.Drawing.Color.Cornsilk;
            this.textInterrest_Rate.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textInterrest_Rate.Location = new System.Drawing.Point(187, 194);
            this.textInterrest_Rate.Name = "textInterrest_Rate";
            this.textInterrest_Rate.Size = new System.Drawing.Size(100, 34);
            this.textInterrest_Rate.TabIndex = 5;
            // 
            // DownPayment
            // 
            this.DownPayment.AutoSize = true;
            this.DownPayment.BackColor = System.Drawing.Color.Gold;
            this.DownPayment.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DownPayment.Location = new System.Drawing.Point(44, 250);
            this.DownPayment.Name = "DownPayment";
            this.DownPayment.Size = new System.Drawing.Size(93, 27);
            this.DownPayment.TabIndex = 6;
            this.DownPayment.Text = "頭期款";
            // 
            // textDownPayment
            // 
            this.textDownPayment.BackColor = System.Drawing.Color.Cornsilk;
            this.textDownPayment.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textDownPayment.Location = new System.Drawing.Point(187, 247);
            this.textDownPayment.Name = "textDownPayment";
            this.textDownPayment.Size = new System.Drawing.Size(100, 34);
            this.textDownPayment.TabIndex = 7;
            // 
            // MonthPay
            // 
            this.MonthPay.BackColor = System.Drawing.Color.Gold;
            this.MonthPay.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthPay.ForeColor = System.Drawing.Color.Black;
            this.MonthPay.Location = new System.Drawing.Point(135, 311);
            this.MonthPay.Name = "MonthPay";
            this.MonthPay.Size = new System.Drawing.Size(152, 44);
            this.MonthPay.TabIndex = 8;
            this.MonthPay.Text = "PMT(月付)";
            this.MonthPay.UseVisualStyleBackColor = false;
            this.MonthPay.Click += new System.EventHandler(this.MonthPay_Click);
            // 
            // TotalPay
            // 
            this.TotalPay.BackColor = System.Drawing.Color.Gold;
            this.TotalPay.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalPay.ForeColor = System.Drawing.Color.Black;
            this.TotalPay.Location = new System.Drawing.Point(293, 311);
            this.TotalPay.Name = "TotalPay";
            this.TotalPay.Size = new System.Drawing.Size(152, 44);
            this.TotalPay.TabIndex = 9;
            this.TotalPay.Text = "總付款";
            this.TotalPay.UseVisualStyleBackColor = false;
            this.TotalPay.Click += new System.EventHandler(this.TotalPay_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Gold;
            this.btnReport.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Location = new System.Drawing.Point(451, 311);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(152, 44);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Lab_Homework02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(755, 427);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.TotalPay);
            this.Controls.Add(this.MonthPay);
            this.Controls.Add(this.textDownPayment);
            this.Controls.Add(this.DownPayment);
            this.Controls.Add(this.textInterrest_Rate);
            this.Controls.Add(this.Interrest_Rate);
            this.Controls.Add(this.textRepayTerm);
            this.Controls.Add(this.RepayTerm);
            this.Controls.Add(this.textLoan);
            this.Controls.Add(this.Loan);
            this.Name = "Lab_Homework02";
            this.Text = "貸款金額試算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Loan;
        private System.Windows.Forms.TextBox textLoan;
        private System.Windows.Forms.Label RepayTerm;
        private System.Windows.Forms.TextBox textRepayTerm;
        private System.Windows.Forms.Label Interrest_Rate;
        private System.Windows.Forms.TextBox textInterrest_Rate;
        private System.Windows.Forms.Label DownPayment;
        private System.Windows.Forms.TextBox textDownPayment;
        private System.Windows.Forms.Button MonthPay;
        private System.Windows.Forms.Button TotalPay;
        private System.Windows.Forms.Button btnReport;
    }
}