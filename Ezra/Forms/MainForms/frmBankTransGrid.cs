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
    public partial class frmBankTransGrid : Form
    {
        public frmBankTransGrid()
        {
            InitializeComponent();
        }

        private void frmReconcile_Load(object sender, EventArgs e)
        {
            taBankTrans.FillByNotLinked(dsEzra.BankTrans);
        }

        private void bankTransBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            bndsBankTrans.EndEdit();
            taManager.UpdateAll(dsEzra);
        }
    }
}
