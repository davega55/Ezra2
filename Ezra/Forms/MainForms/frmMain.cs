﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace Ezra
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChecking_Click(object sender, EventArgs e)
        {
            frmChecking ckcu = new frmChecking();
            ckcu.Show();
        }

        private void btnTransReport_Click(object sender, EventArgs e)
        {
            frmTransactionReport transReport = new frmTransactionReport();
            transReport.Show();
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedItem == null)
            {
                MessageBox.Show("You must select a month");
                return;
            }

            if (cmbYear.SelectedItem == null)
            {
                MessageBox.Show("You must select a year");
                return;
            }
            frmMonthly monthly = new frmMonthly(cmbYear.SelectedItem.ToString(), cmbMonth.SelectedItem.ToString());
            monthly.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] years = Utility.GetAvailableYears();
            cmbYear.Items.AddRange(years);
            string[] months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            cmbMonth.Items.AddRange(months);
        }
    }
}