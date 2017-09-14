using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezra.Forms.MainForms
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void cKCUCheckingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bndsCKCUChecking.EndEdit();
            this.taManager.UpdateAll(this.dsEzra);

        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            taCKCUChecking.Fill(dsEzra.CKCUChecking);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = taCKCUChecking.Adapter;

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
                cKCUCheckingDataGridView.CurrentRow.Cells["NewBalance"].Value = newbal;
                bndsCKCUChecking.MoveNext();
            }
            
        }
    }
}
