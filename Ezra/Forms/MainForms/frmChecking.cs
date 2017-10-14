using System;
using System.Data;
using System.Windows.Forms;
using Ezra.Forms.MainForms;

namespace Ezra
{
    public partial class frmChecking : Form
    {
        public frmChecking()
        {
            InitializeComponent();
        }

        private void Save()
        {
            Validate();
            bndsCKCUChecking.EndEdit();
            taCKCUChecking.Update(dsEzra.CKCUChecking);
        }

        private void frmChecking_Load(object sender, EventArgs e)
        {
            bankTransTableAdapter.Fill(dsEzra.BankTrans);
            taVendors.Fill(dsEzra.Vendors);
            taCategories.Fill(dsEzra.Categories);
            taCKCUChecking.FillBySorted(dsEzra.CKCUChecking);
            LoadToolbar();
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

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            ToolStripControlHost date = (ToolStripControlHost)tsbChecking.Items["beginDate"];
            DateTime beginDate = ((DateTimePicker)date.Control).Value;
            DateTime endDate = DateTime.MaxValue;
            taCKCUChecking.FillByDate(dsEzra.CKCUChecking, beginDate, endDate);
        }

        private void tsbRecalc_Click(object sender, EventArgs e)
        {
            decimal prebal = 0;
            decimal pymt, dep, bal, newbal;
            bndsCKCUChecking.MoveFirst();
            for (int i = 1; i < bndsCKCUChecking.Count + 1; i++)
            {
                DataRowView row = (DataRowView)bndsCKCUChecking.Current;
                pymt = (decimal)row["ChkPymt"];
                dep = (decimal)row["ChkDep"];
                bal = (decimal)row["ChkBalance"];
                newbal = prebal + dep - pymt;
                prebal = newbal;
                dgvCKCUChecking.CurrentRow.Cells["dgvTxtChkBalance"].Value = newbal;
                bndsCKCUChecking.MoveNext();
            }

            taCKCUChecking.Update(dsEzra.CKCUChecking);
            MessageBox.Show("Finished");
        }

        private void dgvCKCUChecking_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataGridViewCell cell = dgv.CurrentCell;
            long cellVal;
            long.TryParse(cell.Value.ToString(), out cellVal);
            frmBankTransDetail rec = new frmBankTransDetail(cellVal);
            rec.Show();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmCheckingDetail detail = new frmCheckingDetail("Checking");
            detail.Show();
        }

        private void dgvCKCUChecking_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCKCUChecking.IsCurrentRowDirty)
            {
                ////MessageBox.Show("Current row is dirty");
                Save();
            }
        }

        private void dgvCKCUChecking_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Data Error on column " + e.ColumnIndex.ToString() + " and row " +
                e.RowIndex.ToString());
            MessageBox.Show(dgvCKCUChecking[1, e.RowIndex].Value.ToString());
            MessageBox.Show(dgvCKCUChecking[2, e.RowIndex].Value.ToString());
            MessageBox.Show(dgvCKCUChecking[3, e.RowIndex].Value.ToString());
            MessageBox.Show(dgvCKCUChecking[e.ColumnIndex, e.RowIndex].Value.ToString());
            
        }

        private void tsbAddFromTrans_Click(object sender, EventArgs e)
        {
            frmCheckingDetail detail = new frmCheckingDetail("Transactions");
            detail.Show();
        }
    }
}
