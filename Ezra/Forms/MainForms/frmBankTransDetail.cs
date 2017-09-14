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
    public partial class frmBankTransDetail : Form
    {
        private long _tranNum;
        public frmBankTransDetail(long tranNo)
        {
            _tranNum = tranNo;
            InitializeComponent();
        }

        private void bankTransBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            bndsBankTrans.EndEdit();
            taManager.UpdateAll(this.dsEzra);

        }

        private void frmBankTransDetail_Load(object sender, EventArgs e)
        {
            if (_tranNum != 0)
            {
                taBankTrans.FillByBankId(this.dsEzra.BankTrans, _tranNum);
                this.Text = "Transaction Detail for " + _tranNum;
            }
            else
            {
                taBankTrans.Fill(dsEzra.BankTrans);
            }
            decimal decAmount;
            decimal.TryParse(txtTranAmt.Text, out decAmount);
            txtTranAmt.Text = decAmount.ToString("C2");
        }
    }
}
