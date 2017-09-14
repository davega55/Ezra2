namespace Ezra
{
    partial class frmChecking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChecking));
            this.dgvCKCUChecking = new System.Windows.Forms.DataGridView();
            this.dgvTxtChkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtChkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtChkNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkVendID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bndsVendors = new System.Windows.Forms.BindingSource(this.components);
            this.dsEzra = new Ezra.DataAccess.EzraDataSet();
            this.NewCatID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bndsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTxtChkPymt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtChkDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvTxtChkBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCkbChkRec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvTxtChkDepNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtChkMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bndsCKCUChecking = new System.Windows.Forms.BindingSource(this.components);
            this.tsbChecking = new System.Windows.Forms.ToolStrip();
            this.tslDate = new System.Windows.Forms.ToolStripLabel();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbRecalc = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbAddFromTrans = new System.Windows.Forms.ToolStripButton();
            this.taCKCUChecking = new Ezra.DataAccess.EzraDataSetTableAdapters.CKCUCheckingTableAdapter();
            this.taManager = new Ezra.DataAccess.EzraDataSetTableAdapters.TableAdapterManager();
            this.taCategories = new Ezra.DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter();
            this.taVendors = new Ezra.DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCKCUChecking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).BeginInit();
            this.tsbChecking.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCKCUChecking
            // 
            this.dgvCKCUChecking.AutoGenerateColumns = false;
            this.dgvCKCUChecking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCKCUChecking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtChkId,
            this.dgvTxtChkDate,
            this.dgvTxtChkNo,
            this.ChkVendID,
            this.NewCatID,
            this.dgvTxtChkPymt,
            this.dgvTxtChkDep,
            this.DgvTxtChkBalance,
            this.dgvCkbChkRec,
            this.dgvTxtChkDepNo,
            this.dgvTxtChkMemo,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8});
            this.dgvCKCUChecking.DataSource = this.bndsCKCUChecking;
            this.dgvCKCUChecking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCKCUChecking.Location = new System.Drawing.Point(0, 25);
            this.dgvCKCUChecking.Name = "dgvCKCUChecking";
            this.dgvCKCUChecking.Size = new System.Drawing.Size(928, 521);
            this.dgvCKCUChecking.TabIndex = 1;
            this.dgvCKCUChecking.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCKCUChecking_CellContentDoubleClick);
            this.dgvCKCUChecking.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCKCUChecking_DataError);
            this.dgvCKCUChecking.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCKCUChecking_RowLeave);
            // 
            // dgvTxtChkId
            // 
            this.dgvTxtChkId.DataPropertyName = "ChkID";
            this.dgvTxtChkId.HeaderText = "ChkID";
            this.dgvTxtChkId.Name = "dgvTxtChkId";
            this.dgvTxtChkId.ReadOnly = true;
            this.dgvTxtChkId.Visible = false;
            // 
            // dgvTxtChkDate
            // 
            this.dgvTxtChkDate.DataPropertyName = "ChkDate";
            this.dgvTxtChkDate.HeaderText = "Date";
            this.dgvTxtChkDate.Name = "dgvTxtChkDate";
            // 
            // dgvTxtChkNo
            // 
            this.dgvTxtChkNo.DataPropertyName = "ChkNo";
            this.dgvTxtChkNo.HeaderText = "Number";
            this.dgvTxtChkNo.Name = "dgvTxtChkNo";
            // 
            // ChkVendID
            // 
            this.ChkVendID.DataPropertyName = "ChkVendID";
            this.ChkVendID.DataSource = this.bndsVendors;
            this.ChkVendID.DisplayMember = "VendName";
            this.ChkVendID.HeaderText = "ChkVendID";
            this.ChkVendID.Name = "ChkVendID";
            this.ChkVendID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChkVendID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChkVendID.ValueMember = "VendID";
            // 
            // bndsVendors
            // 
            this.bndsVendors.DataMember = "Vendors";
            this.bndsVendors.DataSource = this.dsEzra;
            // 
            // dsEzra
            // 
            this.dsEzra.DataSetName = "EzraDataSet";
            this.dsEzra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NewCatID
            // 
            this.NewCatID.DataPropertyName = "NewCatID";
            this.NewCatID.DataSource = this.bndsCategories;
            this.NewCatID.DisplayMember = "CatName";
            this.NewCatID.HeaderText = "NewCatID";
            this.NewCatID.Name = "NewCatID";
            this.NewCatID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NewCatID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NewCatID.ValueMember = "CatID";
            // 
            // bndsCategories
            // 
            this.bndsCategories.DataMember = "Categories";
            this.bndsCategories.DataSource = this.dsEzra;
            // 
            // dgvTxtChkPymt
            // 
            this.dgvTxtChkPymt.DataPropertyName = "ChkPymt";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvTxtChkPymt.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTxtChkPymt.HeaderText = "Payment";
            this.dgvTxtChkPymt.Name = "dgvTxtChkPymt";
            // 
            // dgvTxtChkDep
            // 
            this.dgvTxtChkDep.DataPropertyName = "ChkDep";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvTxtChkDep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTxtChkDep.HeaderText = "Deposit";
            this.dgvTxtChkDep.Name = "dgvTxtChkDep";
            // 
            // DgvTxtChkBalance
            // 
            this.DgvTxtChkBalance.DataPropertyName = "ChkBalance";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.DgvTxtChkBalance.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvTxtChkBalance.HeaderText = "Balance";
            this.DgvTxtChkBalance.Name = "DgvTxtChkBalance";
            // 
            // dgvCkbChkRec
            // 
            this.dgvCkbChkRec.DataPropertyName = "ChkRec";
            this.dgvCkbChkRec.HeaderText = "Rec";
            this.dgvCkbChkRec.Name = "dgvCkbChkRec";
            this.dgvCkbChkRec.Width = 40;
            // 
            // dgvTxtChkDepNo
            // 
            this.dgvTxtChkDepNo.DataPropertyName = "ChkDepNo";
            this.dgvTxtChkDepNo.HeaderText = "DepNo";
            this.dgvTxtChkDepNo.Name = "dgvTxtChkDepNo";
            this.dgvTxtChkDepNo.Width = 40;
            // 
            // dgvTxtChkMemo
            // 
            this.dgvTxtChkMemo.DataPropertyName = "ChkMemo";
            this.dgvTxtChkMemo.HeaderText = "Memo";
            this.dgvTxtChkMemo.Name = "dgvTxtChkMemo";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ChkDepImage";
            this.dataGridViewTextBoxColumn14.HeaderText = "ChkDepImage";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ChkDesc";
            this.dataGridViewTextBoxColumn4.HeaderText = "ChkDesc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ChkCat";
            this.dataGridViewTextBoxColumn8.HeaderText = "ChkCat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // bndsCKCUChecking
            // 
            this.bndsCKCUChecking.DataMember = "CKCUChecking";
            this.bndsCKCUChecking.DataSource = this.dsEzra;
            this.bndsCKCUChecking.Sort = "";
            // 
            // tsbChecking
            // 
            this.tsbChecking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslDate,
            this.tsbRefresh,
            this.tsbRecalc,
            this.tsbAdd,
            this.tsbAddFromTrans});
            this.tsbChecking.Location = new System.Drawing.Point(0, 0);
            this.tsbChecking.Name = "tsbChecking";
            this.tsbChecking.Size = new System.Drawing.Size(928, 25);
            this.tsbChecking.TabIndex = 2;
            this.tsbChecking.Text = "toolStrip1";
            // 
            // tslDate
            // 
            this.tslDate.Name = "tslDate";
            this.tslDate.Size = new System.Drawing.Size(64, 22);
            this.tslDate.Text = "Begin Date";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(84, 22);
            this.tsbRefresh.Text = "Refresh Data";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbRecalc
            // 
            this.tsbRecalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsbRecalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRecalc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbRecalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsbRecalc.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecalc.Image")));
            this.tsbRecalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecalc.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbRecalc.Name = "tsbRecalc";
            this.tsbRecalc.Size = new System.Drawing.Size(126, 22);
            this.tsbRecalc.Text = "Recalculate Balances";
            this.tsbRecalc.Click += new System.EventHandler(this.tsbRecalc_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(62, 22);
            this.tsbAdd.Text = "Add New";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbAddFromTrans
            // 
            this.tsbAddFromTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsbAddFromTrans.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddFromTrans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbAddFromTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsbAddFromTrans.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddFromTrans.Image")));
            this.tsbAddFromTrans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddFromTrans.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbAddFromTrans.Name = "tsbAddFromTrans";
            this.tsbAddFromTrans.Size = new System.Drawing.Size(128, 22);
            this.tsbAddFromTrans.Text = "Add From Bank Trans";
            // 
            // taCKCUChecking
            // 
            this.taCKCUChecking.ClearBeforeFill = true;
            // 
            // taManager
            // 
            this.taManager.BackupDataSetBeforeUpdate = false;
            this.taManager.BalancesTableAdapter = null;
            this.taManager.BankTransTableAdapter = null;
            this.taManager.BudgetTableAdapter = null;
            this.taManager.CategoriesTableAdapter = null;
            this.taManager.CKCUCheckingTableAdapter = this.taCKCUChecking;
            this.taManager.CKCUSavingsTableAdapter = null;
            this.taManager.ContributionsTableAdapter = null;
            this.taManager.ContributorsTableAdapter = null;
            this.taManager.ControlTableAdapter = null;
            this.taManager.CreditCardTableAdapter = null;
            this.taManager.EmployeePayDatesTableAdapter = null;
            this.taManager.EmployeePayDedTableAdapter = null;
            this.taManager.EmployeesTableAdapter = null;
            this.taManager.FundsTableAdapter = null;
            this.taManager.FundTransactionsTableAdapter = null;
            this.taManager.GroupsTableAdapter = null;
            this.taManager.PeoplesCheckingTableAdapter = null;
            this.taManager.TypeTableAdapter = null;
            this.taManager.UpdateOrder = Ezra.DataAccess.EzraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.taManager.VendorsTableAdapter = null;
            // 
            // taCategories
            // 
            this.taCategories.ClearBeforeFill = true;
            // 
            // taVendors
            // 
            this.taVendors.ClearBeforeFill = true;
            // 
            // frmChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(928, 546);
            this.Controls.Add(this.dgvCKCUChecking);
            this.Controls.Add(this.tsbChecking);
            this.Name = "frmChecking";
            this.Text = "CKCU Checking";
            this.Load += new System.EventHandler(this.frmChecking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCKCUChecking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).EndInit();
            this.tsbChecking.ResumeLayout(false);
            this.tsbChecking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataAccess.EzraDataSet dsEzra;
        private System.Windows.Forms.BindingSource bndsCKCUChecking;
        private DataAccess.EzraDataSetTableAdapters.CKCUCheckingTableAdapter taCKCUChecking;
        private DataAccess.EzraDataSetTableAdapters.TableAdapterManager taManager;
        private System.Windows.Forms.DataGridView dgvCKCUChecking;
        private System.Windows.Forms.BindingSource bndsCategories;
        private DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter taCategories;
        private System.Windows.Forms.BindingSource bndsVendors;
        private DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter taVendors;
        private System.Windows.Forms.ToolStrip tsbChecking;
        private System.Windows.Forms.ToolStripLabel tslDate;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbRecalc;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbAddFromTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtChkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtChkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtChkNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn ChkVendID;
        private System.Windows.Forms.DataGridViewComboBoxColumn NewCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtChkPymt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtChkDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvTxtChkBalance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvCkbChkRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtChkDepNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtChkMemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}