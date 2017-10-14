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
    public partial class frmBankTransToDoDetail : Form
    {
        public frmBankTransToDoDetail()
        {
            InitializeComponent();
        }

        private void cKCUCheckingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bndsCKCUChecking.EndEdit();
            this.taManager.UpdateAll(this.dsEzra);

        }

        private void frmBankTransToDoDetail_Load(object sender, EventArgs e)
        {
            taBankTrans.FillByNotLinked(dsEzra.BankTrans);
            taVendors.Fill(dsEzra.Vendors);
            taCategories.Fill(dsEzra.Categories);
            taCKCUChecking.Fill(dsEzra.CKCUChecking);
        }
    }
}
