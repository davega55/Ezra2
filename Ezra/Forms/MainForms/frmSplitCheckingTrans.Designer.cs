namespace Ezra.Forms.MainForms
{
    partial class frmSplitCheckingTrans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplitCheckingTrans));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.spContMain = new System.Windows.Forms.SplitContainer();
            this.dgvCKCUChecking = new System.Windows.Forms.DataGridView();
            this.dgvTxtChkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bndsVendors = new System.Windows.Forms.BindingSource(this.components);
            this.dsEzra = new Ezra.DataAccess.EzraDataSet();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bndsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtBankTransNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bndsCKCUChecking = new System.Windows.Forms.BindingSource(this.components);
            this.tsbChecking = new System.Windows.Forms.ToolStrip();
            this.tslDate = new System.Windows.Forms.ToolStripLabel();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbRecalc = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbAddFromTrans = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.dgvBankTrans = new System.Windows.Forms.DataGridView();
            this.dgvTxtTranNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtTranBankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtTransChkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsBankTrans = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiCopyTransNo = new System.Windows.Forms.ToolStripMenuItem();
            this.bndsBankTrans = new System.Windows.Forms.BindingSource(this.components);
            this.taCKCUChecking = new Ezra.DataAccess.EzraDataSetTableAdapters.CKCUCheckingTableAdapter();
            this.taManager = new Ezra.DataAccess.EzraDataSetTableAdapters.TableAdapterManager();
            this.taBankTrans = new Ezra.DataAccess.EzraDataSetTableAdapters.BankTransTableAdapter();
            this.taVendors = new Ezra.DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter();
            this.taCategories = new Ezra.DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spContMain)).BeginInit();
            this.spContMain.Panel1.SuspendLayout();
            this.spContMain.Panel2.SuspendLayout();
            this.spContMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCKCUChecking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).BeginInit();
            this.tsbChecking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTrans)).BeginInit();
            this.cmsBankTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsBankTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // spContMain
            // 
            this.spContMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContMain.Location = new System.Drawing.Point(0, 0);
            this.spContMain.Name = "spContMain";
            this.spContMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContMain.Panel1
            // 
            this.spContMain.Panel1.AutoScroll = true;
            this.spContMain.Panel1.Controls.Add(this.dgvCKCUChecking);
            this.spContMain.Panel1.Controls.Add(this.tsbChecking);
            // 
            // spContMain.Panel2
            // 
            this.spContMain.Panel2.AutoScroll = true;
            this.spContMain.Panel2.Controls.Add(this.dgvBankTrans);
            this.spContMain.Size = new System.Drawing.Size(892, 447);
            this.spContMain.SplitterDistance = 289;
            this.spContMain.TabIndex = 0;
            // 
            // dgvCKCUChecking
            // 
            this.dgvCKCUChecking.AutoGenerateColumns = false;
            this.dgvCKCUChecking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCKCUChecking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtChkID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn12,
            this.dgvTxtBankTransNo,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn4});
            this.dgvCKCUChecking.DataSource = this.bndsCKCUChecking;
            this.dgvCKCUChecking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCKCUChecking.Location = new System.Drawing.Point(0, 25);
            this.dgvCKCUChecking.Name = "dgvCKCUChecking";
            this.dgvCKCUChecking.Size = new System.Drawing.Size(892, 264);
            this.dgvCKCUChecking.TabIndex = 1;
            this.dgvCKCUChecking.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCKCUChecking_RowEnter);
            this.dgvCKCUChecking.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCKCUChecking_RowLeave);
            // 
            // dgvTxtChkID
            // 
            this.dgvTxtChkID.DataPropertyName = "ChkID";
            this.dgvTxtChkID.HeaderText = "ChkID";
            this.dgvTxtChkID.Name = "dgvTxtChkID";
            this.dgvTxtChkID.ReadOnly = true;
            this.dgvTxtChkID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ChkDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ChkNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ChkVendID";
            this.dataGridViewTextBoxColumn11.DataSource = this.bndsVendors;
            this.dataGridViewTextBoxColumn11.DisplayMember = "VendName";
            this.dataGridViewTextBoxColumn11.HeaderText = "ChkVendID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn11.ValueMember = "VendID";
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
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NewCatID";
            this.dataGridViewTextBoxColumn10.DataSource = this.bndsCategories;
            this.dataGridViewTextBoxColumn10.DisplayMember = "CatName";
            this.dataGridViewTextBoxColumn10.HeaderText = "NewCatID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "CatID";
            // 
            // bndsCategories
            // 
            this.bndsCategories.DataMember = "Categories";
            this.bndsCategories.DataSource = this.dsEzra;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ChkPymt";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn5.HeaderText = "ChkPymt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ChkDep";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn6.HeaderText = "ChkDep";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ChkBalance";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn7.HeaderText = "ChkBalance";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ChkCat";
            this.dataGridViewTextBoxColumn8.HeaderText = "ChkCat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ChkRec";
            this.dataGridViewCheckBoxColumn1.HeaderText = "ChkRec";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ChkDepNo";
            this.dataGridViewTextBoxColumn12.HeaderText = "ChkDepNo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dgvTxtBankTransNo
            // 
            this.dgvTxtBankTransNo.DataPropertyName = "ChkBanTransNo";
            this.dgvTxtBankTransNo.HeaderText = "ChkBanTransNo";
            this.dgvTxtBankTransNo.Name = "dgvTxtBankTransNo";
            this.dgvTxtBankTransNo.Width = 130;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ChkMemo";
            this.dataGridViewTextBoxColumn9.HeaderText = "ChkMemo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
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
            // bndsCKCUChecking
            // 
            this.bndsCKCUChecking.DataMember = "CKCUChecking";
            this.bndsCKCUChecking.DataSource = this.dsEzra;
            // 
            // tsbChecking
            // 
            this.tsbChecking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslDate,
            this.tsbRefresh,
            this.tsbRecalc,
            this.tsbAdd,
            this.tsbAddFromTrans,
            this.tsbSave});
            this.tsbChecking.Location = new System.Drawing.Point(0, 0);
            this.tsbChecking.Name = "tsbChecking";
            this.tsbChecking.Size = new System.Drawing.Size(892, 25);
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
            this.tsbRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(84, 22);
            this.tsbRefresh.Text = "Refresh Data";
            // 
            // tsbRecalc
            // 
            this.tsbRecalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsbRecalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRecalc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbRecalc.ForeColor = System.Drawing.Color.White;
            this.tsbRecalc.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecalc.Image")));
            this.tsbRecalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecalc.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbRecalc.Name = "tsbRecalc";
            this.tsbRecalc.Size = new System.Drawing.Size(126, 22);
            this.tsbRecalc.Text = "Recalculate Balances";
            // 
            // tsbAdd
            // 
            this.tsbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbAdd.ForeColor = System.Drawing.Color.White;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(62, 22);
            this.tsbAdd.Text = "Add New";
            // 
            // tsbAddFromTrans
            // 
            this.tsbAddFromTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsbAddFromTrans.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddFromTrans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbAddFromTrans.ForeColor = System.Drawing.Color.White;
            this.tsbAddFromTrans.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddFromTrans.Image")));
            this.tsbAddFromTrans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddFromTrans.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbAddFromTrans.Name = "tsbAddFromTrans";
            this.tsbAddFromTrans.Size = new System.Drawing.Size(128, 22);
            this.tsbAddFromTrans.Text = "Add From Bank Trans";
            // 
            // tsbSave
            // 
            this.tsbSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbSave.ForeColor = System.Drawing.Color.White;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(38, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // dgvBankTrans
            // 
            this.dgvBankTrans.AutoGenerateColumns = false;
            this.dgvBankTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtTranNo,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dgvTxtTranBankID,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dgvTxtTransChkID});
            this.dgvBankTrans.ContextMenuStrip = this.cmsBankTrans;
            this.dgvBankTrans.DataSource = this.bndsBankTrans;
            this.dgvBankTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankTrans.Location = new System.Drawing.Point(0, 0);
            this.dgvBankTrans.Name = "dgvBankTrans";
            this.dgvBankTrans.Size = new System.Drawing.Size(892, 154);
            this.dgvBankTrans.TabIndex = 0;
            this.dgvBankTrans.DoubleClick += new System.EventHandler(this.dgvBankTrans_DoubleClick);
            // 
            // dgvTxtTranNo
            // 
            this.dgvTxtTranNo.DataPropertyName = "tranNo";
            this.dgvTxtTranNo.HeaderText = "tranNo";
            this.dgvTxtTranNo.Name = "dgvTxtTranNo";
            this.dgvTxtTranNo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "tranType";
            this.dataGridViewTextBoxColumn16.HeaderText = "tranType";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "tranDate";
            this.dataGridViewTextBoxColumn17.HeaderText = "tranDate";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "tranAmt";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn18.HeaderText = "tranAmt";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dgvTxtTranBankID
            // 
            this.dgvTxtTranBankID.DataPropertyName = "tranBankID";
            this.dgvTxtTranBankID.HeaderText = "tranBankID";
            this.dgvTxtTranBankID.Name = "dgvTxtTranBankID";
            this.dgvTxtTranBankID.Width = 130;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "tranCheckNo";
            this.dataGridViewTextBoxColumn20.HeaderText = "tranCheckNo";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "tranName";
            this.dataGridViewTextBoxColumn21.HeaderText = "tranName";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "tranMemo";
            this.dataGridViewTextBoxColumn22.HeaderText = "tranMemo";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 200;
            // 
            // dgvTxtTransChkID
            // 
            this.dgvTxtTransChkID.DataPropertyName = "tranChkID";
            this.dgvTxtTransChkID.HeaderText = "tranChkID";
            this.dgvTxtTransChkID.Name = "dgvTxtTransChkID";
            // 
            // cmsBankTrans
            // 
            this.cmsBankTrans.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCopyTransNo});
            this.cmsBankTrans.Name = "cmsBankTrans";
            this.cmsBankTrans.ShowImageMargin = false;
            this.cmsBankTrans.Size = new System.Drawing.Size(206, 26);
            // 
            // tsiCopyTransNo
            // 
            this.tsiCopyTransNo.Name = "tsiCopyTransNo";
            this.tsiCopyTransNo.Size = new System.Drawing.Size(205, 22);
            this.tsiCopyTransNo.Text = "Copy Trans Num to Checking";
            this.tsiCopyTransNo.Click += new System.EventHandler(this.tsiCopyTransNo_Click);
            // 
            // bndsBankTrans
            // 
            this.bndsBankTrans.DataMember = "BankTrans";
            this.bndsBankTrans.DataSource = this.dsEzra;
            // 
            // taCKCUChecking
            // 
            this.taCKCUChecking.ClearBeforeFill = true;
            // 
            // taManager
            // 
            this.taManager.BackupDataSetBeforeUpdate = false;
            this.taManager.BalancesTableAdapter = null;
            this.taManager.BankTransTableAdapter = this.taBankTrans;
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
            // taBankTrans
            // 
            this.taBankTrans.ClearBeforeFill = true;
            // 
            // taVendors
            // 
            this.taVendors.ClearBeforeFill = true;
            // 
            // taCategories
            // 
            this.taCategories.ClearBeforeFill = true;
            // 
            // frmSplitCheckingTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 447);
            this.Controls.Add(this.spContMain);
            this.Name = "frmSplitCheckingTrans";
            this.Text = "SplitCheckingTrans";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSplitCheckingTrans_FormClosing);
            this.Load += new System.EventHandler(this.SplitCheckingTrans_Load);
            this.spContMain.Panel1.ResumeLayout(false);
            this.spContMain.Panel1.PerformLayout();
            this.spContMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContMain)).EndInit();
            this.spContMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCKCUChecking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).EndInit();
            this.tsbChecking.ResumeLayout(false);
            this.tsbChecking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTrans)).EndInit();
            this.cmsBankTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bndsBankTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spContMain;
        private DataAccess.EzraDataSet dsEzra;
        private System.Windows.Forms.BindingSource bndsCKCUChecking;
        private DataAccess.EzraDataSetTableAdapters.CKCUCheckingTableAdapter taCKCUChecking;
        private DataAccess.EzraDataSetTableAdapters.TableAdapterManager taManager;
        private DataAccess.EzraDataSetTableAdapters.BankTransTableAdapter taBankTrans;
        private System.Windows.Forms.BindingSource bndsBankTrans;
        private System.Windows.Forms.DataGridView dgvBankTrans;
        private System.Windows.Forms.BindingSource bndsVendors;
        private DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter taVendors;
        private System.Windows.Forms.BindingSource bndsCategories;
        private DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter taCategories;
        private System.Windows.Forms.ContextMenuStrip cmsBankTrans;
        private System.Windows.Forms.ToolStripMenuItem tsiCopyTransNo;
        private System.Windows.Forms.ToolStrip tsbChecking;
        private System.Windows.Forms.ToolStripLabel tslDate;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.DataGridView dgvCKCUChecking;
        private System.Windows.Forms.ToolStripButton tsbRecalc;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbAddFromTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtChkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtBankTransNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtTranNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtTranBankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtTransChkID;
    }
}