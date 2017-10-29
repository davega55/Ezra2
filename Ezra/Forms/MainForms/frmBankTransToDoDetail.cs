using System;
using System.Data;
using System.Windows.Forms;
using Ezra.DataAccess;

namespace Ezra.Forms.MainForms
{
    public partial class frmBankTransToDoDetail : Form
    {
        private int? _chkID;
        public frmBankTransToDoDetail(int? chkID = null)
        {
            _chkID = chkID;
            InitializeComponent();
        }

        private void cKCUCheckingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            bndsCKCUChecking.EndEdit();
            taManager.UpdateAll(this.dsEzra);
            decimal currChkID = GetCurrIdent();
            //MessageBox.Show(currChkID.ToString());

            DataRowView ckcuCurrRow = (DataRowView)bndsCKCUChecking.Current;
            int transNum = GetBankTransID(ckcuCurrRow["ChkBanTransNo"].ToString());
            //int checkID = (int)ckcuCurrRow["ChkId"];
            EzraDataSet.BankTransRow bankTransRow = dsEzra.BankTrans.FindBytranNo(transNum);
            if (bankTransRow != null)
            {
                bankTransRow.tranChkID = (int)currChkID;
                taBankTrans.Update(bankTransRow);
                taBankTrans.FillByNotLinked(dsEzra.BankTrans);
            }

        }

        private void frmBankTransToDoDetail_Load(object sender, EventArgs e)
        {
            if (_chkID == null)
            {
                taCKCUChecking.FillByUnlinked(dsEzra.CKCUChecking);
                taBankTrans.FillByNotLinked(dsEzra.BankTrans);
            }
            else
            {
                taCKCUChecking.FillByChkID(dsEzra.CKCUChecking, (int)_chkID);
                string bankTransNum = taCKCUChecking.GetBankTransNumByCheckID((int)_chkID);
                if (bankTransNum != string.Empty)
                {
                    long bankTNo = 0;
                    long.TryParse(bankTransNum, out bankTNo);
                    taBankTrans.FillByBankId(dsEzra.BankTrans, bankTNo);
                }
                else
                {
                    taBankTrans.FillByNotLinked(dsEzra.BankTrans);
                }
            }
            taVendors.Fill(dsEzra.Vendors);
            taCategories.Fill(dsEzra.Categories);
            bndsCKCUChecking.ResetBindings(false);
        }

        private void bankTransDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView test = (DataGridView)sender;
            if (test.SelectedRows.Count > 0 && txtChkBanTransNo.Text.Length == 0)
            {
                txtChkBanTransNo.Text = test.Rows[test.SelectedRows[0].Index].Cells[4].Value.ToString();
            }
            txtChkBanTransNo.Refresh();
        }

        private decimal GetNextIdent()
        {
            decimal currIdent = (decimal)taQueries.GetCurIdentCKCUChecking();
            decimal nextIdent = currIdent + 1;
            return nextIdent;
        }

        private decimal GetCurrIdent()
        {
            decimal currIdent = (decimal)taQueries.GetCurIdentCKCUChecking();
            return currIdent;
        }

        private int GetBankTransID(string bankTrans)
        {
            int bankTransID = (int)taQueries.GetBankTransID(bankTrans);
            return bankTransID;
        }

        private void tsbViewAllRecords_Click(object sender, EventArgs e)
        {
            taCKCUChecking.Fill(dsEzra.CKCUChecking);
            bndsCKCUChecking.ResetBindings(false);
        }

        private void tsbViewUnlinked_Click(object sender, EventArgs e)
        {
            taCKCUChecking.FillByUnlinked(dsEzra.CKCUChecking);
            bndsCKCUChecking.ResetBindings(false);
        }
    }
}
