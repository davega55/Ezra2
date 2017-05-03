namespace Ezra
{
    partial class frmMonthly
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bndsTmpCatAmounts = new System.Windows.Forms.BindingSource(this.components);
            this.dsEzra = new Ezra.DataAccess.EzraDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bndsMonthlyNumbers = new System.Windows.Forms.BindingSource(this.components);
            this.taMonthlyNumbers = new Ezra.DataAccess.EzraDataSetTableAdapters.MonthlyNumbersTableAdapter();
            this.taManager = new Ezra.DataAccess.EzraDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bndsTmpCatAmounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsMonthlyNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // bndsTmpCatAmounts
            // 
            this.bndsTmpCatAmounts.DataMember = "tmpCatAmounts";
            this.bndsTmpCatAmounts.DataSource = this.dsEzra;
            // 
            // dsEzra
            // 
            this.dsEzra.DataSetName = "EzraDataSet";
            this.dsEzra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "MonthlyDS";
            reportDataSource3.Value = this.bndsTmpCatAmounts;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ezra.Reports.MonthlyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(856, 485);
            this.reportViewer1.TabIndex = 0;
            // 
            // bndsMonthlyNumbers
            // 
            this.bndsMonthlyNumbers.DataMember = "MonthlyNumbers";
            this.bndsMonthlyNumbers.DataSource = this.dsEzra;
            // 
            // taMonthlyNumbers
            // 
            this.taMonthlyNumbers.ClearBeforeFill = true;
            // 
            // taManager
            // 
            this.taManager.BackupDataSetBeforeUpdate = false;
            this.taManager.BalancesTableAdapter = null;
            this.taManager.BankTransTableAdapter = null;
            this.taManager.BudgetTableAdapter = null;
            this.taManager.CategoriesTableAdapter = null;
            this.taManager.CKCUCheckingTableAdapter = null;
            this.taManager.CKCUSavingsTableAdapter = null;
            this.taManager.Connection = null;
            this.taManager.ContributionsTableAdapter = null;
            this.taManager.ContributorsTableAdapter = null;
            this.taManager.ControlTableAdapter = null;
            this.taManager.CreditCardTableAdapter = null;
            this.taManager.EmployeePayDatesTableAdapter = null;
            this.taManager.EmployeePayDedTableAdapter = null;
            this.taManager.EmployeesTableAdapter = null;
            this.taManager.FundsTableAdapter = null;
            this.taManager.FundTransactionsTableAdapter = null;
            this.taManager.GroupsTableAdapter = null;
            this.taManager.PeoplesCheckingTableAdapter = null;
            this.taManager.TypeTableAdapter = null;
            this.taManager.UpdateOrder = Ezra.DataAccess.EzraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.taManager.VendorsTableAdapter = null;
            // 
            // frmMonthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 485);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMonthly";
            this.Text = "Monthly Report";
            this.Load += new System.EventHandler(this.frmMonthly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bndsTmpCatAmounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsMonthlyNumbers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bndsTmpCatAmounts;
        private DataAccess.EzraDataSet dsEzra;
        private System.Windows.Forms.BindingSource bndsMonthlyNumbers;
        private DataAccess.EzraDataSetTableAdapters.MonthlyNumbersTableAdapter taMonthlyNumbers;
        private DataAccess.EzraDataSetTableAdapters.TableAdapterManager taManager;
    }
}