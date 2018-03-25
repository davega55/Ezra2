using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezra.Forms.MainForms
{
    public partial class frmReconcile : Form
    {
        public frmReconcile()
        {
            InitializeComponent();
        }

        private void cKCUCheckingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bndsCKCUChecking.EndEdit();
            this.taManager.UpdateAll(this.dsEzra);

        }

        private void frmReconcile_Load(object sender, EventArgs e)
        {
            taVendors.Fill(dsEzra.Vendors);
            taCategories.Fill(dsEzra.Categories);
            taCKCUChecking.FillByNotRecByDate(dsEzra.CKCUChecking, DateTime.Today.AddYears(-3));
        }

        private void SaveRecords()
        {
            Validate();
            bndsCKCUChecking.EndEdit();
            taManager.UpdateAll(this.dsEzra);
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            SaveRecords();
            taCKCUChecking.FillByNotRecByDate(dsEzra.CKCUChecking, DateTime.Today.AddYears(-3));
            dgvCKCUChecking.Refresh();
        }
    }
}
