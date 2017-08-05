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

        private void frmReconcile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEzra.BankTrans' table. You can move, or remove it, as needed.
            this.taBankTrans.Fill(this.dsEzra.BankTrans);
            // TODO: This line of code loads data into the 'ezraDataSet.Vendors' table. You can move, or remove it, as needed.
            this.taVendors.Fill(this.dsEzra.Vendors);
            // TODO: This line of code loads data into the 'ezraDataSet.Categories' table. You can move, or remove it, as needed.
            this.taCategories.Fill(this.dsEzra.Categories);
            // TODO: This line of code loads data into the 'ezraDataSet.CKCUChecking' table. You can move, or remove it, as needed.
            this.taCKCUChecking.Fill(this.dsEzra.CKCUChecking);

        }
    }
}
