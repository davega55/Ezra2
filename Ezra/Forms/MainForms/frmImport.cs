using System;
using System.IO;
using System.Windows.Forms;

namespace Ezra.Forms.MainForms
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(ofdImport.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = ofdImport.FileName;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim().Length > 0)
            {
                string line = string.Empty;

                StreamReader file = new StreamReader(txtFileName.Text);
                while((line = file.ReadLine()) != null)
                {
                    txtDisplay.AppendText(line + "\n");
                }
                
            }
            else
            {
                MessageBox.Show("You must select a file before loading");
            }
        }
    }
}
