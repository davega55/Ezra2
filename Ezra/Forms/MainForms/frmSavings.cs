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
    public partial class frmSavings : Form
    {
        public frmSavings()
        {
            InitializeComponent();
        }

        private void cKCUSavingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cKCUSavingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ezraDataSet);

        }

        private void frmSavings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ezraDataSet.CKCUSavings' table. You can move, or remove it, as needed.
            this.cKCUSavingsTableAdapter.Fill(this.ezraDataSet.CKCUSavings);

        }
    }
}
