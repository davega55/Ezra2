using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Ezra.DataAccess;

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
            bool trans = false;
            TransRec tr = new TransRec();
            taBankTrans.Fill(DSEzra.BankTrans);
            int counter = 0;

            if (txtFileName.Text.Trim().Length > 0)
            {
                string line = string.Empty;

                StreamReader file = new StreamReader(txtFileName.Text);
                while((line = file.ReadLine()) != null)
                {
                    txtDisplay.AppendText(line + "\n");
                    if (line.Contains("<STMTTRN>"))
                    {
                        trans = true;
                        continue;
                    }

                    if (trans)
                    {
                        counter += ParseLine(line, tr);
                    }

                    if (line.Contains("</STMTTRN>"))
                    {
                        trans = false;
                        tr.Clear();
                    }
                }

                taBankTrans.Update(DSEzra);
                MessageBox.Show(counter.ToString() + " Records added");
                
            }
            else
            {
                MessageBox.Show("You must select a file before loading");
            }
        }

        private int ParseLine(string lineIn, TransRec tr)
        {
            string[] line = lineIn.Split('>');
            int counter = 0;

            switch (line[0].Substring(1))
            {
                case "TRNTYPE" :
                    {
                        tr.TransType = line[1];
                        break;
                    }
                case "DTPOSTED":
                    {
                        tr.TransDate = DateTime.ParseExact(line[1].Substring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture);
                        break;
                    }
                case "TRNAMT":
                    {
                        decimal tmpOut = 0;
                        decimal.TryParse(line[1], out tmpOut);
                        tr.TransAmount = tmpOut;
                        break;
                    }
                case "FITID":
                    {
                        long fitIDOut = 0;
                        long.TryParse(line[1], out fitIDOut);
                        tr.TransFitId = fitIDOut;
                        break;
                    }
                case "CHECKNUM":
                    {
                        tr.TransChkNum = line[1];
                        break;
                    }
                case "NAME":
                    {
                        tr.TransName = line[1];
                        break;
                    }
                case "MEMO":
                    {
                        tr.TransMemo = line[1];
                        break;
                    }
                case "/STMTTRN":
                    {
                        int result = bndsBankTrans.Find("tranBankID", tr.TransFitId);
                        if(result < 0)
                        {
                            EzraDataSet.BankTransRow btRow = DSEzra.BankTrans.NewBankTransRow();
                            btRow.tranType = tr.TransType;
                            btRow.tranDate = tr.TransDate;
                            btRow.tranAmt = tr.TransAmount;
                            btRow.tranBankID = tr.TransFitId;
                            btRow.tranCheckNo = tr.TransChkNum;
                            btRow.tranName = tr.TransName;
                            btRow.tranMemo = tr.TransMemo;
                            DSEzra.BankTrans.Rows.Add(btRow);
                            counter++;
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Could not parse " + line[0] + " - " + line[1]);
                        break;
                    }
            }
            return counter;
        }
    }

    public class TransRec
    {
        public TransRec()
        {

        }
        public string TransType { get; set; }
        public DateTime TransDate { get; set; }
        public decimal TransAmount { get; set; }
        public long TransFitId { get; set; }
        public string TransChkNum { get; set; }
        public string TransName { get; set; }
        public string TransMemo { get; set; }

        public void Clear()
        {
            TransType = string.Empty;
            TransDate = DateTime.MinValue;
            TransAmount = 0;
            TransFitId = 0;
            TransChkNum = string.Empty;
            TransName = string.Empty;
            TransMemo = string.Empty;
        }
    }
}
