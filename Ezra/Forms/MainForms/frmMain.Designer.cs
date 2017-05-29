namespace Ezra
{
    partial class frmMain
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
            this.btnChecking = new System.Windows.Forms.Button();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.btnBudgetRpt = new System.Windows.Forms.Button();
            this.btnYTD = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnTransReport = new System.Windows.Forms.Button();
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnFundTrans = new System.Windows.Forms.Button();
            this.btnCC = new System.Windows.Forms.Button();
            this.btnFundMaint = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnContributors = new System.Windows.Forms.Button();
            this.btnCats = new System.Windows.Forms.Button();
            this.btnDeposits = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnBankRec = new System.Windows.Forms.Button();
            this.btnCombined = new System.Windows.Forms.Button();
            this.btnBudget = new System.Windows.Forms.Button();
            this.grpReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChecking
            // 
            this.btnChecking.Location = new System.Drawing.Point(42, 50);
            this.btnChecking.Name = "btnChecking";
            this.btnChecking.Size = new System.Drawing.Size(126, 23);
            this.btnChecking.TabIndex = 0;
            this.btnChecking.Text = "CKCU Checking";
            this.btnChecking.UseVisualStyleBackColor = true;
            this.btnChecking.Click += new System.EventHandler(this.btnChecking_Click);
            // 
            // grpReports
            // 
            this.grpReports.Controls.Add(this.btnCombined);
            this.grpReports.Controls.Add(this.btnBudgetRpt);
            this.grpReports.Controls.Add(this.btnYTD);
            this.grpReports.Controls.Add(this.btnBalance);
            this.grpReports.Controls.Add(this.cmbYear);
            this.grpReports.Controls.Add(this.cmbMonth);
            this.grpReports.Controls.Add(this.lblYear);
            this.grpReports.Controls.Add(this.lblMonth);
            this.grpReports.Controls.Add(this.btnMonthly);
            this.grpReports.Controls.Add(this.btnTransReport);
            this.grpReports.Location = new System.Drawing.Point(507, 12);
            this.grpReports.Name = "grpReports";
            this.grpReports.Size = new System.Drawing.Size(222, 428);
            this.grpReports.TabIndex = 3;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            // 
            // btnBudgetRpt
            // 
            this.btnBudgetRpt.Location = new System.Drawing.Point(44, 247);
            this.btnBudgetRpt.Name = "btnBudgetRpt";
            this.btnBudgetRpt.Size = new System.Drawing.Size(135, 23);
            this.btnBudgetRpt.TabIndex = 17;
            this.btnBudgetRpt.Text = "Budget Report";
            this.btnBudgetRpt.UseVisualStyleBackColor = true;
            // 
            // btnYTD
            // 
            this.btnYTD.Location = new System.Drawing.Point(44, 160);
            this.btnYTD.Name = "btnYTD";
            this.btnYTD.Size = new System.Drawing.Size(135, 23);
            this.btnYTD.TabIndex = 14;
            this.btnYTD.Text = "Year to Date Report";
            this.btnYTD.UseVisualStyleBackColor = true;
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(44, 131);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(135, 23);
            this.btnBalance.TabIndex = 13;
            this.btnBalance.Text = "Balance Sheet";
            this.btnBalance.UseVisualStyleBackColor = true;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(63, 61);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(92, 21);
            this.cmbYear.TabIndex = 12;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(63, 34);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(107, 21);
            this.cmbMonth.TabIndex = 11;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(25, 64);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(6, 37);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 13);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "Month:";
            // 
            // btnMonthly
            // 
            this.btnMonthly.Location = new System.Drawing.Point(44, 189);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(135, 23);
            this.btnMonthly.TabIndex = 15;
            this.btnMonthly.Text = "Monthly Report";
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnTransReport
            // 
            this.btnTransReport.Location = new System.Drawing.Point(44, 218);
            this.btnTransReport.Name = "btnTransReport";
            this.btnTransReport.Size = new System.Drawing.Size(135, 23);
            this.btnTransReport.TabIndex = 16;
            this.btnTransReport.Text = "Transaction Report";
            this.btnTransReport.UseVisualStyleBackColor = true;
            this.btnTransReport.Click += new System.EventHandler(this.btnTransReport_Click);
            // 
            // btnSavings
            // 
            this.btnSavings.Location = new System.Drawing.Point(42, 230);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(126, 23);
            this.btnSavings.TabIndex = 6;
            this.btnSavings.Text = "CKCU Savings";
            this.btnSavings.UseVisualStyleBackColor = true;
            // 
            // btnFundTrans
            // 
            this.btnFundTrans.Location = new System.Drawing.Point(42, 200);
            this.btnFundTrans.Name = "btnFundTrans";
            this.btnFundTrans.Size = new System.Drawing.Size(126, 23);
            this.btnFundTrans.TabIndex = 5;
            this.btnFundTrans.Text = "Fund Transactions";
            this.btnFundTrans.UseVisualStyleBackColor = true;
            // 
            // btnCC
            // 
            this.btnCC.Location = new System.Drawing.Point(42, 170);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(126, 23);
            this.btnCC.TabIndex = 4;
            this.btnCC.Text = "Credit Card";
            this.btnCC.UseVisualStyleBackColor = true;
            // 
            // btnFundMaint
            // 
            this.btnFundMaint.Location = new System.Drawing.Point(217, 50);
            this.btnFundMaint.Name = "btnFundMaint";
            this.btnFundMaint.Size = new System.Drawing.Size(126, 23);
            this.btnFundMaint.TabIndex = 7;
            this.btnFundMaint.Text = "Fund Maintenenace";
            this.btnFundMaint.UseVisualStyleBackColor = true;
            // 
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(217, 110);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(126, 23);
            this.btnVendors.TabIndex = 9;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = true;
            // 
            // btnContributors
            // 
            this.btnContributors.Location = new System.Drawing.Point(217, 140);
            this.btnContributors.Name = "btnContributors";
            this.btnContributors.Size = new System.Drawing.Size(126, 23);
            this.btnContributors.TabIndex = 10;
            this.btnContributors.Text = "Contributors";
            this.btnContributors.UseVisualStyleBackColor = true;
            // 
            // btnCats
            // 
            this.btnCats.Location = new System.Drawing.Point(217, 80);
            this.btnCats.Name = "btnCats";
            this.btnCats.Size = new System.Drawing.Size(126, 23);
            this.btnCats.TabIndex = 8;
            this.btnCats.Text = "Categories";
            this.btnCats.UseVisualStyleBackColor = true;
            // 
            // btnDeposits
            // 
            this.btnDeposits.Location = new System.Drawing.Point(42, 80);
            this.btnDeposits.Name = "btnDeposits";
            this.btnDeposits.Size = new System.Drawing.Size(126, 23);
            this.btnDeposits.TabIndex = 1;
            this.btnDeposits.Text = "Deposits";
            this.btnDeposits.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(42, 110);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(126, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnBankRec
            // 
            this.btnBankRec.Location = new System.Drawing.Point(42, 140);
            this.btnBankRec.Name = "btnBankRec";
            this.btnBankRec.Size = new System.Drawing.Size(126, 23);
            this.btnBankRec.TabIndex = 3;
            this.btnBankRec.Text = "Bank Reconcile";
            this.btnBankRec.UseVisualStyleBackColor = true;
            // 
            // btnCombined
            // 
            this.btnCombined.Location = new System.Drawing.Point(44, 317);
            this.btnCombined.Name = "btnCombined";
            this.btnCombined.Size = new System.Drawing.Size(135, 37);
            this.btnCombined.TabIndex = 18;
            this.btnCombined.Text = "Combined Month/YTD Report";
            this.btnCombined.UseVisualStyleBackColor = true;
            // 
            // btnBudget
            // 
            this.btnBudget.Location = new System.Drawing.Point(217, 170);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(126, 23);
            this.btnBudget.TabIndex = 11;
            this.btnBudget.Text = "Budgets";
            this.btnBudget.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 483);
            this.Controls.Add(this.btnBudget);
            this.Controls.Add(this.btnBankRec);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnDeposits);
            this.Controls.Add(this.btnCats);
            this.Controls.Add(this.btnContributors);
            this.Controls.Add(this.btnVendors);
            this.Controls.Add(this.btnFundMaint);
            this.Controls.Add(this.btnCC);
            this.Controls.Add(this.btnFundTrans);
            this.Controls.Add(this.btnSavings);
            this.Controls.Add(this.grpReports);
            this.Controls.Add(this.btnChecking);
            this.Name = "frmMain";
            this.Text = "Ezra";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpReports.ResumeLayout(false);
            this.grpReports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChecking;
        private System.Windows.Forms.GroupBox grpReports;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnTransReport;
        private System.Windows.Forms.Button btnBudgetRpt;
        private System.Windows.Forms.Button btnYTD;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.Button btnFundTrans;
        private System.Windows.Forms.Button btnCC;
        private System.Windows.Forms.Button btnFundMaint;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnContributors;
        private System.Windows.Forms.Button btnCats;
        private System.Windows.Forms.Button btnDeposits;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnBankRec;
        private System.Windows.Forms.Button btnCombined;
        private System.Windows.Forms.Button btnBudget;
    }
}