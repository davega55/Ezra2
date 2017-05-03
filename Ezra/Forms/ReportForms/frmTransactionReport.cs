using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.Reporting.WinForms;

namespace Ezra
{
    public partial class frmTransactionReport : Form
    {
        public frmTransactionReport()
        {
            InitializeComponent();
        }

        private void frmTransactionReport_Load(object sender, EventArgs e)
        {
            string[] years = Utility.GetAvailableYears();
            tsCmbYear.Items.AddRange(years);
            string[] months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            tsCmbMonth.Items.AddRange(months);
        }

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            if (tsCmbMonth.SelectedItem == null)
            {
                MessageBox.Show("You must select a month");
                return;
            }
            if (tsCmbYear.SelectedItem == null)
            {
                MessageBox.Show("You must select a year");
                return;
            }

            TransReportTableAdapter.FillTransByDate(EzraDataSet.TransReport,
                new DateTime(2015, 1, 1), new DateTime(2015, 1, 31));
            ReportParameter test1 = new ReportParameter("BeginBalance", "test");
            ReportParameter[] parms = new ReportParameter[] { test1 };
            rptvTransactions.LocalReport.SetParameters(new ReportParameter("BeginBalance", "test2"));
            rptvTransactions.RefreshReport();
        }
    }
}
