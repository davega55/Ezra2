using System;
using System.Globalization;
using System.Windows.Forms;
using Ezra.Forms.MainForms;

namespace Ezra
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] years = Utility.GetAvailableYears();
            cmbYear.Items.AddRange(years);
            string[] months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            cmbMonth.Items.AddRange(months);
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

        
        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImport import = new frmImport();
            import.Show();
        }

        private void btnBankRec_Click(object sender, EventArgs e)
        {
            frmReconcile rec = new frmReconcile();
            rec.Show();
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            frmSavings sav = new frmSavings();
            sav.Show();
        }

        private void btnTransGrid_Click(object sender, EventArgs e)
        {
            frmBankTransGrid trans = new frmBankTransGrid();
            trans.Show();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            frmVendors vendors = new frmVendors();
            vendors.Show();
        }

        private void btnCats_Click(object sender, EventArgs e)
        {
            frmCategories cats = new frmCategories();
            cats.Show();
        }
    }
}
