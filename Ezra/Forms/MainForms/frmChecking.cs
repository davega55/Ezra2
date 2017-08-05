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
            taVendors.Fill(this.dsEzra.Vendors);
            taCategories.Fill(this.dsEzra.Categories);
            taCKCUChecking.Fill(dsEzra.CKCUChecking);
            LoadToolbar();
        }

        private void LoadToolbar()
        {
            var tsDatePicker = new ToolStripControlHost(new DateTimePicker());
            var dateLabel = new ToolStripLabel();
            var seperate = new ToolStripSeparator();
            var refreshButton = new ToolStripButton();
            refreshButton.Text = "Refresh";
            refreshButton.Click += new EventHandler(refreshButton_Click);
            dateLabel.Text = "Begin Date";
            dateLabel.Name = "tsbLabel";
            ((DateTimePicker)tsDatePicker.Control).Format = DateTimePickerFormat.Short;
            tsDatePicker.Width = 100;
            tsDatePicker.Name = "beginDate";
            
            tsbChecking.Items.Add(dateLabel);
            tsbChecking.Items.Add(tsDatePicker);
            tsbChecking.Items.Add(seperate);
            tsbChecking.Items.Add(refreshButton);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ToolStripControlHost date = (ToolStripControlHost)tsbChecking.Items["beginDate"];
            DateTime beginDate = ((DateTimePicker)date.Control).Value;
            DateTime endDate = DateTime.MaxValue;
            taCKCUChecking.FillByDate(dsEzra.CKCUChecking, beginDate, endDate);
        }
    }
}
