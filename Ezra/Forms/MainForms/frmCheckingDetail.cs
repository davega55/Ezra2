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
    public partial class frmCheckingDetail : Form
    {
        private string inputForm;
        public frmCheckingDetail(string inForm)
        {
            inputForm = inForm;
            InitializeComponent();
        }

        private void frmCheckingDetail_Load(object sender, EventArgs e)
        {
            if (inputForm == "Checking")
            {
                taCKCUChecking.Fill(dsEzra.CKCUChecking);
                taBankTrans.Fill(dsEzra.BankTrans);
                bndnBankTrans.Visible = false;
                bndnCKCUChecking.Visible = true;
            }
            else if (inputForm == "Transactions")
            {
                taBankTrans.FillByNotLinked(dsEzra.BankTrans);
                bndnBankTrans.Visible = true;
                bndnCKCUChecking.Visible = false;
            }
            else
            {
                MessageBox.Show("Cannot determine input form");
            }
            
            taVendors.Fill(dsEzra.Vendors);
            taCategories.Fill(dsEzra.Categories);
            
        }

        private void cKCUCheckingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            bndsCKCUChecking.EndEdit();
            taManager.UpdateAll(dsEzra);

        }

        private void bndsCKCUChecking_PositionChanged(object sender, EventArgs e)
        {
            if (inputForm == "Checking")
            {
                BindingSource bnds = (BindingSource)sender;
                DataRowView drv = (DataRowView)bnds.Current;
                string currID = drv["chkBanTransNo"].ToString();
                if (currID.Length > 0)
                {
                    int bndsIdx = bndsBankTrans.Find("tranBankID", currID);
                    bndsBankTrans.Position = bndsIdx;
                }
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            chkBanTransNoTextBox.Text = tranBankIDTextBox.Text;
            bndsCKCUChecking.AddNew();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Validate();
            bndsCKCUChecking.EndEdit();
            taManager.UpdateAll(dsEzra);
        }
    }
}
