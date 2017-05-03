using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Ezra
{
    public partial class frmChecking : Form
    {
        public frmChecking()
        {
            InitializeComponent();
        }

        private void cKCUCheckingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            bndsCKCUChecking.EndEdit();
            taManager.UpdateAll(dsEzra);
        }

        private void frmChecking_Load(object sender, EventArgs e)
        {
            string[] years = Utility.GetAvailableYears();
            tsCmbYear.Items.AddRange(years);
            string[] months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            tsCmbMonth.Items.AddRange(months);
            taCKCUChecking.Fill(dsEzra.CKCUChecking);
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
            int monthValue = tsCmbMonth.SelectedIndex + 1;
            int yearValue = int.Parse(tsCmbYear.SelectedItem.ToString());
            DateTime beginDate = new DateTime(yearValue, monthValue, 1);
            DateTime endDate = beginDate.AddMonths(1).AddDays(-1);
            MessageBox.Show(beginDate.ToShortDateString());
            MessageBox.Show(endDate.ToShortDateString());
            taCKCUChecking.FillByDate(dsEzra.CKCUChecking, beginDate, endDate);
        }
    }
}
