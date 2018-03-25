using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cKCUCheckingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cKCUCheckingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ezraDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'church_FinancesDataSet.CKCUChecking' table. You can move, or remove it, as needed.
            this.cKCUCheckingTableAdapter1.Fill(this.church_FinancesDataSet.CKCUChecking);
            // TODO: This line of code loads data into the 'church_FinancesDataSet.CKCUChecking' table. You can move, or remove it, as needed.
            this.cKCUCheckingTableAdapter1.Fill(this.church_FinancesDataSet.CKCUChecking);
            // TODO: This line of code loads data into the 'ezraDataSet.CKCUChecking' table. You can move, or remove it, as needed.
            this.cKCUCheckingTableAdapter.Fill(this.ezraDataSet.CKCUChecking);

        }
    }
}
