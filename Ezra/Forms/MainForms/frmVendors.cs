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
    public partial class frmVendors : Form
    {
        public frmVendors()
        {
            InitializeComponent();
        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ezraDataSet);

        }

        private void frmVendors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ezraDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.ezraDataSet.Vendors);

        }
    }
}
