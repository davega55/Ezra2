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
    public partial class frmSplitCheckingTrans : Form
    {
        public frmSplitCheckingTrans()
        {
            InitializeComponent();
        }

        private void SaveCKCUChecking()
        {
            Validate();
            bndsCKCUChecking.EndEdit();
            taCKCUChecking.Update(dsEzra.CKCUChecking);
        }

        void Save()
        {
            Validate();
            bndsCKCUChecking.EndEdit();
            bndsBankTrans.EndEdit();
            taManager.UpdateAll(dsEzra);
            taCKCUChecking.Fill(dsEzra.CKCUChecking);
            taBankTrans.FillByNotLinked(dsEzra.BankTrans);
        }

        private void SplitCheckingTrans_Load(object sender, EventArgs e)
        {
            taCategories.Fill(dsEzra.Categories);
            taVendors.Fill(dsEzra.Vendors);
            taCKCUChecking.Fill(dsEzra.CKCUChecking);
            LoadToolbar();
            WindowState = FormWindowState.Maximized;
        }

        private void dgvCKCUChecking_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv["dgvTxtBankTransNo", e.RowIndex].Value == null ||
                dgv["dgvTxtBankTransNo", e.RowIndex].Value.ToString() == string.Empty)
            {
                taBankTrans.FillByNotLinked(dsEzra.BankTrans);
            }
            else
            {
                string transID = dgv["dgvTxtBankTransNo", e.RowIndex].Value.ToString();
                taBankTrans.FillByBankId(dsEzra.BankTrans, transID);
            }
        }

        private void tsiCopyTransNo_Click(object sender, EventArgs e)
        {
            ////Save();
            ////bndsCKCUChecking.MovePrevious();
            ////bndsCKCUChecking.MoveNext();
            ////dgvCKCUChecking.Refresh();
            ////int checkId;
            ////int transId;
            ////int.TryParse(dgvCKCUChecking.CurrentRow.Cells["dgvTxtChkID"].Value.ToString(), out checkId);
            ////int.TryParse(dgvBankTrans.CurrentRow.Cells["dgvTxtTranNo"].Value.ToString(), out transId);
            ////string transBankNo = dgvBankTrans.CurrentRow.Cells["dgvTxtTranBankID"].Value.ToString();
            int index = dgvCKCUChecking.RowCount - 2;
            dgvCKCUChecking.FirstDisplayedScrollingRowIndex = index;
            dgvCKCUChecking.Rows[index].Selected = true;
            dgvCKCUChecking.CurrentRow.Cells["dgvTxtBankTransNo"].Value =
                dgvBankTrans.CurrentRow.Cells["dgvTxtTranBankID"].Value.ToString();
            dgvBankTrans.CurrentRow.Cells["dgvTxtTransChkID"].Value =
                dgvCKCUChecking.CurrentRow.Cells["dgvTxtChkID"].Value.ToString();

            ////MessageBox.Show("CheckId = " + checkId.ToString());
            ////MessageBox.Show("TransId = " + transId.ToString());
            ////MessageBox.Show("TransBankNo = " + transBankNo);
        }

        private void LoadToolbar()
        {
            var tsDatePicker = new ToolStripControlHost(new DateTimePicker());
            ((DateTimePicker)tsDatePicker.Control).Format = DateTimePickerFormat.Short;
            tsDatePicker.Width = 100;
            tsDatePicker.Name = "beginDate";

            tsbChecking.Items.Remove(tsbRefresh);
            tsbChecking.Items.Remove(tsbRecalc);
            tsbChecking.Items.Remove(tsbAdd);
            tsbChecking.Items.Remove(tsbAddFromTrans);
            tsbChecking.Items.Add(tsDatePicker);
            tsbChecking.Items.Add(tsbRefresh);
            tsbChecking.Items.Add(tsbRecalc);
            tsbChecking.Items.Add(tsbAdd);
            tsbChecking.Items.Add(tsbAddFromTrans);
        }

        private void dgvCKCUChecking_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCKCUChecking.IsCurrentRowDirty)
            {
                Save();
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmSplitCheckingTrans_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvCKCUChecking.IsCurrentRowDirty || dgvBankTrans.IsCurrentRowDirty)
            {
                MessageBox.Show("Save Needed");
            }
        }

        private void dgvBankTrans_DoubleClick(object sender, EventArgs e)
        {
            int checkId;
            int transId;
            int.TryParse(dgvCKCUChecking.CurrentRow.Cells["dgvTxtChkID"].Value.ToString(), out checkId);
            int.TryParse(dgvBankTrans.CurrentRow.Cells["dgvTxtTranNo"].Value.ToString(), out transId);
            string transBankNo = dgvBankTrans.CurrentRow.Cells["dgvTxtTranBankID"].Value.ToString();

            MessageBox.Show("CheckId = " + checkId.ToString());
            MessageBox.Show("TransId = " + transId.ToString());
            MessageBox.Show("TransBankNo = " + transBankNo);
        }
    }
}
