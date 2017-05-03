namespace Ezra
{
    partial class frmTransactionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionReport));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TransReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EzraDataSet = new Ezra.DataAccess.EzraDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsLblMonth = new System.Windows.Forms.ToolStripLabel();
            this.tsCmbMonth = new System.Windows.Forms.ToolStripComboBox();
            this.tsLblYear = new System.Windows.Forms.ToolStripLabel();
            this.tsCmbYear = new System.Windows.Forms.ToolStripComboBox();
            this.tsbLoad = new System.Windows.Forms.ToolStripButton();
            this.rptvTransactions = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TransReportTableAdapter = new Ezra.DataAccess.EzraDataSetTableAdapters.TransReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TransReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EzraDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransReportBindingSource
            // 
            this.TransReportBindingSource.DataMember = "TransReport";
            this.TransReportBindingSource.DataSource = this.EzraDataSet;
            // 
            // EzraDataSet
            // 
            this.EzraDataSet.DataSetName = "EzraDataSet";
            this.EzraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblMonth,
            this.tsCmbMonth,
            this.tsLblYear,
            this.tsCmbYear,
            this.tsbLoad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsLblMonth
            // 
            this.tsLblMonth.Name = "tsLblMonth";
            this.tsLblMonth.Size = new System.Drawing.Size(52, 24);
            this.tsLblMonth.Text = "Month:  ";
            // 
            // tsCmbMonth
            // 
            this.tsCmbMonth.Name = "tsCmbMonth";
            this.tsCmbMonth.Size = new System.Drawing.Size(121, 27);
            // 
            // tsLblYear
            // 
            this.tsLblYear.Name = "tsLblYear";
            this.tsLblYear.Size = new System.Drawing.Size(38, 24);
            this.tsLblYear.Text = "Year:  ";
            // 
            // tsCmbYear
            // 
            this.tsCmbYear.Name = "tsCmbYear";
            this.tsCmbYear.Size = new System.Drawing.Size(100, 27);
            // 
            // tsbLoad
            // 
            this.tsbLoad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsbLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLoad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsbLoad.ForeColor = System.Drawing.Color.Black;
            this.tsbLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoad.Image")));
            this.tsbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoad.Name = "tsbLoad";
            this.tsbLoad.Size = new System.Drawing.Size(63, 24);
            this.tsbLoad.Text = "  Load  ";
            this.tsbLoad.Click += new System.EventHandler(this.tsbLoad_Click);
            // 
            // rptvTransactions
            // 
            this.rptvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Transactions";
            reportDataSource1.Value = this.TransReportBindingSource;
            this.rptvTransactions.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvTransactions.LocalReport.ReportEmbeddedResource = "Ezra.Reports.Transactions.rdlc";
            this.rptvTransactions.Location = new System.Drawing.Point(0, 27);
            this.rptvTransactions.Name = "rptvTransactions";
            this.rptvTransactions.Size = new System.Drawing.Size(887, 460);
            this.rptvTransactions.TabIndex = 1;
            // 
            // TransReportTableAdapter
            // 
            this.TransReportTableAdapter.ClearBeforeFill = true;
            // 
            // frmTransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 487);
            this.Controls.Add(this.rptvTransactions);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmTransactionReport";
            this.Text = "frmTransactionReport";
            this.Load += new System.EventHandler(this.frmTransactionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EzraDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private Microsoft.Reporting.WinForms.ReportViewer rptvTransactions;
        private System.Windows.Forms.BindingSource TransReportBindingSource;
        private DataAccess.EzraDataSet EzraDataSet;
        private DataAccess.EzraDataSetTableAdapters.TransReportTableAdapter TransReportTableAdapter;
        private System.Windows.Forms.ToolStripLabel tsLblMonth;
        private System.Windows.Forms.ToolStripComboBox tsCmbMonth;
        private System.Windows.Forms.ToolStripLabel tsLblYear;
        private System.Windows.Forms.ToolStripComboBox tsCmbYear;
        private System.Windows.Forms.ToolStripButton tsbLoad;
    }
}