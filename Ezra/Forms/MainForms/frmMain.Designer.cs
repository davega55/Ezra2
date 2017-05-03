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
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnTransReport = new System.Windows.Forms.Button();
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
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(63, 61);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(92, 21);
            this.cmbYear.TabIndex = 7;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(63, 34);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(107, 21);
            this.cmbMonth.TabIndex = 6;
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
            this.btnMonthly.Location = new System.Drawing.Point(20, 160);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(135, 23);
            this.btnMonthly.TabIndex = 3;
            this.btnMonthly.Text = "Monthly Report";
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnTransReport
            // 
            this.btnTransReport.Location = new System.Drawing.Point(20, 131);
            this.btnTransReport.Name = "btnTransReport";
            this.btnTransReport.Size = new System.Drawing.Size(135, 23);
            this.btnTransReport.TabIndex = 2;
            this.btnTransReport.Text = "Transaction Report";
            this.btnTransReport.UseVisualStyleBackColor = true;
            this.btnTransReport.Click += new System.EventHandler(this.btnTransReport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 483);
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
    }
}