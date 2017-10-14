namespace Ezra.Forms.MainForms
{
    partial class frmCheckingDetail
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
            System.Windows.Forms.Label lblChkID;
            System.Windows.Forms.Label lblChkDate;
            System.Windows.Forms.Label lblChkNo;
            System.Windows.Forms.Label lblChkPymt;
            System.Windows.Forms.Label lblChkDep;
            System.Windows.Forms.Label lblChkBalance;
            System.Windows.Forms.Label lblChkRec;
            System.Windows.Forms.Label lblChkMemo;
            System.Windows.Forms.Label lblNewCatID;
            System.Windows.Forms.Label lblChkVendID;
            System.Windows.Forms.Label lblChkDepNo;
            System.Windows.Forms.Label lblTranNo;
            System.Windows.Forms.Label lblTranType;
            System.Windows.Forms.Label lblTranDate;
            System.Windows.Forms.Label lblTranAmt;
            System.Windows.Forms.Label lblTranCheckNo;
            System.Windows.Forms.Label lblTranName;
            System.Windows.Forms.Label lblTranMemo;
            System.Windows.Forms.Label lblTranChkID;
            System.Windows.Forms.Label lblTranBankID;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckingDetail));
            System.Windows.Forms.Label chkBanTransNoLabel;
            this.dsEzra = new Ezra.DataAccess.EzraDataSet();
            this.bndsCKCUChecking = new System.Windows.Forms.BindingSource(this.components);
            this.taCKCUChecking = new Ezra.DataAccess.EzraDataSetTableAdapters.CKCUCheckingTableAdapter();
            this.taManager = new Ezra.DataAccess.EzraDataSetTableAdapters.TableAdapterManager();
            this.taBankTrans = new Ezra.DataAccess.EzraDataSetTableAdapters.BankTransTableAdapter();
            this.taCategories = new Ezra.DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter();
            this.taVendors = new Ezra.DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter();
            this.bndnCKCUChecking = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cKCUCheckingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.chkIDTextBox = new System.Windows.Forms.TextBox();
            this.chkDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chkNoTextBox = new System.Windows.Forms.TextBox();
            this.chkPymtTextBox = new System.Windows.Forms.TextBox();
            this.chkDepTextBox = new System.Windows.Forms.TextBox();
            this.chkBalanceTextBox = new System.Windows.Forms.TextBox();
            this.chkRecCheckBox = new System.Windows.Forms.CheckBox();
            this.chkMemoTextBox = new System.Windows.Forms.TextBox();
            this.newCatIDComboBox = new System.Windows.Forms.ComboBox();
            this.bndsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.chkVendIDComboBox = new System.Windows.Forms.ComboBox();
            this.bndsVendors = new System.Windows.Forms.BindingSource(this.components);
            this.chkDepNoTextBox = new System.Windows.Forms.TextBox();
            this.grpCKCUCheck = new System.Windows.Forms.GroupBox();
            this.bndsBankTrans = new System.Windows.Forms.BindingSource(this.components);
            this.tranNoTextBox = new System.Windows.Forms.TextBox();
            this.tranTypeTextBox = new System.Windows.Forms.TextBox();
            this.tranDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tranAmtTextBox = new System.Windows.Forms.TextBox();
            this.tranCheckNoTextBox = new System.Windows.Forms.TextBox();
            this.tranNameTextBox = new System.Windows.Forms.TextBox();
            this.tranMemoTextBox = new System.Windows.Forms.TextBox();
            this.tranChkIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bndnBankTrans = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tranBankIDTextBox = new System.Windows.Forms.TextBox();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.chkBanTransNoTextBox = new System.Windows.Forms.TextBox();
            lblChkID = new System.Windows.Forms.Label();
            lblChkDate = new System.Windows.Forms.Label();
            lblChkNo = new System.Windows.Forms.Label();
            lblChkPymt = new System.Windows.Forms.Label();
            lblChkDep = new System.Windows.Forms.Label();
            lblChkBalance = new System.Windows.Forms.Label();
            lblChkRec = new System.Windows.Forms.Label();
            lblChkMemo = new System.Windows.Forms.Label();
            lblNewCatID = new System.Windows.Forms.Label();
            lblChkVendID = new System.Windows.Forms.Label();
            lblChkDepNo = new System.Windows.Forms.Label();
            lblTranNo = new System.Windows.Forms.Label();
            lblTranType = new System.Windows.Forms.Label();
            lblTranDate = new System.Windows.Forms.Label();
            lblTranAmt = new System.Windows.Forms.Label();
            lblTranCheckNo = new System.Windows.Forms.Label();
            lblTranName = new System.Windows.Forms.Label();
            lblTranMemo = new System.Windows.Forms.Label();
            lblTranChkID = new System.Windows.Forms.Label();
            lblTranBankID = new System.Windows.Forms.Label();
            chkBanTransNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnCKCUChecking)).BeginInit();
            this.bndnCKCUChecking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).BeginInit();
            this.grpCKCUCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsBankTrans)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndnBankTrans)).BeginInit();
            this.bndnBankTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChkID
            // 
            lblChkID.AutoSize = true;
            lblChkID.Location = new System.Drawing.Point(23, 58);
            lblChkID.Name = "lblChkID";
            lblChkID.Size = new System.Drawing.Size(21, 13);
            lblChkID.TabIndex = 1;
            lblChkID.Text = "ID:";
            // 
            // lblChkDate
            // 
            lblChkDate.AutoSize = true;
            lblChkDate.Location = new System.Drawing.Point(142, 58);
            lblChkDate.Name = "lblChkDate";
            lblChkDate.Size = new System.Drawing.Size(67, 13);
            lblChkDate.TabIndex = 3;
            lblChkDate.Text = "Check Date:";
            // 
            // lblChkNo
            // 
            lblChkNo.AutoSize = true;
            lblChkNo.Location = new System.Drawing.Point(345, 58);
            lblChkNo.Name = "lblChkNo";
            lblChkNo.Size = new System.Drawing.Size(66, 13);
            lblChkNo.TabIndex = 5;
            lblChkNo.Text = "Check Num:";
            // 
            // lblChkPymt
            // 
            lblChkPymt.AutoSize = true;
            lblChkPymt.Location = new System.Drawing.Point(12, 131);
            lblChkPymt.Name = "lblChkPymt";
            lblChkPymt.Size = new System.Drawing.Size(72, 13);
            lblChkPymt.TabIndex = 9;
            lblChkPymt.Text = "Payment Amt:";
            // 
            // lblChkDep
            // 
            lblChkDep.AutoSize = true;
            lblChkDep.Location = new System.Drawing.Point(233, 131);
            lblChkDep.Name = "lblChkDep";
            lblChkDep.Size = new System.Drawing.Size(67, 13);
            lblChkDep.TabIndex = 11;
            lblChkDep.Text = "Deposit Amt:";
            // 
            // lblChkBalance
            // 
            lblChkBalance.AutoSize = true;
            lblChkBalance.Location = new System.Drawing.Point(432, 131);
            lblChkBalance.Name = "lblChkBalance";
            lblChkBalance.Size = new System.Drawing.Size(49, 13);
            lblChkBalance.TabIndex = 13;
            lblChkBalance.Text = "Balance:";
            // 
            // lblChkRec
            // 
            lblChkRec.AutoSize = true;
            lblChkRec.Location = new System.Drawing.Point(12, 169);
            lblChkRec.Name = "lblChkRec";
            lblChkRec.Size = new System.Drawing.Size(64, 13);
            lblChkRec.TabIndex = 17;
            lblChkRec.Text = "Reconciled:";
            // 
            // lblChkMemo
            // 
            lblChkMemo.AutoSize = true;
            lblChkMemo.Location = new System.Drawing.Point(10, 196);
            lblChkMemo.Name = "lblChkMemo";
            lblChkMemo.Size = new System.Drawing.Size(39, 13);
            lblChkMemo.TabIndex = 19;
            lblChkMemo.Text = "Memo:";
            // 
            // lblNewCatID
            // 
            lblNewCatID.AutoSize = true;
            lblNewCatID.Location = new System.Drawing.Point(14, 95);
            lblNewCatID.Name = "lblNewCatID";
            lblNewCatID.Size = new System.Drawing.Size(52, 13);
            lblNewCatID.TabIndex = 21;
            lblNewCatID.Text = "Category:";
            // 
            // lblChkVendID
            // 
            lblChkVendID.AutoSize = true;
            lblChkVendID.Location = new System.Drawing.Point(317, 94);
            lblChkVendID.Name = "lblChkVendID";
            lblChkVendID.Size = new System.Drawing.Size(44, 13);
            lblChkVendID.TabIndex = 23;
            lblChkVendID.Text = "Pay To:";
            // 
            // lblChkDepNo
            // 
            lblChkDepNo.AutoSize = true;
            lblChkDepNo.Location = new System.Drawing.Point(132, 169);
            lblChkDepNo.Name = "lblChkDepNo";
            lblChkDepNo.Size = new System.Drawing.Size(71, 13);
            lblChkDepNo.TabIndex = 25;
            lblChkDepNo.Text = "Deposit Num:";
            // 
            // lblTranNo
            // 
            lblTranNo.AutoSize = true;
            lblTranNo.Location = new System.Drawing.Point(30, 61);
            lblTranNo.Name = "lblTranNo";
            lblTranNo.Size = new System.Drawing.Size(21, 13);
            lblTranNo.TabIndex = 29;
            lblTranNo.Text = "ID:";
            // 
            // lblTranType
            // 
            lblTranType.AutoSize = true;
            lblTranType.Location = new System.Drawing.Point(150, 61);
            lblTranType.Name = "lblTranType";
            lblTranType.Size = new System.Drawing.Size(34, 13);
            lblTranType.TabIndex = 31;
            lblTranType.Text = "Type:";
            // 
            // lblTranDate
            // 
            lblTranDate.AutoSize = true;
            lblTranDate.Location = new System.Drawing.Point(311, 59);
            lblTranDate.Name = "lblTranDate";
            lblTranDate.Size = new System.Drawing.Size(33, 13);
            lblTranDate.TabIndex = 33;
            lblTranDate.Text = "Date:";
            // 
            // lblTranAmt
            // 
            lblTranAmt.AutoSize = true;
            lblTranAmt.Location = new System.Drawing.Point(23, 94);
            lblTranAmt.Name = "lblTranAmt";
            lblTranAmt.Size = new System.Drawing.Size(28, 13);
            lblTranAmt.TabIndex = 35;
            lblTranAmt.Text = "Amt:";
            // 
            // lblTranCheckNo
            // 
            lblTranCheckNo.AutoSize = true;
            lblTranCheckNo.Location = new System.Drawing.Point(466, 94);
            lblTranCheckNo.Name = "lblTranCheckNo";
            lblTranCheckNo.Size = new System.Drawing.Size(58, 13);
            lblTranCheckNo.TabIndex = 39;
            lblTranCheckNo.Text = "Check No:";
            // 
            // lblTranName
            // 
            lblTranName.AutoSize = true;
            lblTranName.Location = new System.Drawing.Point(13, 126);
            lblTranName.Name = "lblTranName";
            lblTranName.Size = new System.Drawing.Size(38, 13);
            lblTranName.TabIndex = 41;
            lblTranName.Text = "Name:";
            // 
            // lblTranMemo
            // 
            lblTranMemo.AutoSize = true;
            lblTranMemo.Location = new System.Drawing.Point(283, 126);
            lblTranMemo.Name = "lblTranMemo";
            lblTranMemo.Size = new System.Drawing.Size(39, 13);
            lblTranMemo.TabIndex = 43;
            lblTranMemo.Text = "Memo:";
            // 
            // lblTranChkID
            // 
            lblTranChkID.AutoSize = true;
            lblTranChkID.Location = new System.Drawing.Point(8, 158);
            lblTranChkID.Name = "lblTranChkID";
            lblTranChkID.Size = new System.Drawing.Size(43, 13);
            lblTranChkID.TabIndex = 45;
            lblTranChkID.Text = "Chk ID:";
            // 
            // lblTranBankID
            // 
            lblTranBankID.AutoSize = true;
            lblTranBankID.Location = new System.Drawing.Point(194, 94);
            lblTranBankID.Name = "lblTranBankID";
            lblTranBankID.Size = new System.Drawing.Size(49, 13);
            lblTranBankID.TabIndex = 46;
            lblTranBankID.Text = "Bank ID:";
            // 
            // dsEzra
            // 
            this.dsEzra.DataSetName = "EzraDataSet";
            this.dsEzra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bndsCKCUChecking
            // 
            this.bndsCKCUChecking.DataMember = "CKCUChecking";
            this.bndsCKCUChecking.DataSource = this.dsEzra;
            this.bndsCKCUChecking.PositionChanged += new System.EventHandler(this.bndsCKCUChecking_PositionChanged);
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
            this.taManager.CategoriesTableAdapter = this.taCategories;
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
            this.taManager.VendorsTableAdapter = this.taVendors;
            // 
            // taBankTrans
            // 
            this.taBankTrans.ClearBeforeFill = true;
            // 
            // taCategories
            // 
            this.taCategories.ClearBeforeFill = true;
            // 
            // taVendors
            // 
            this.taVendors.ClearBeforeFill = true;
            // 
            // bndnCKCUChecking
            // 
            this.bndnCKCUChecking.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bndnCKCUChecking.BindingSource = this.bndsCKCUChecking;
            this.bndnCKCUChecking.CountItem = this.bindingNavigatorCountItem;
            this.bndnCKCUChecking.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bndnCKCUChecking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cKCUCheckingBindingNavigatorSaveItem});
            this.bndnCKCUChecking.Location = new System.Drawing.Point(3, 16);
            this.bndnCKCUChecking.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndnCKCUChecking.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndnCKCUChecking.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndnCKCUChecking.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndnCKCUChecking.Name = "bndnCKCUChecking";
            this.bndnCKCUChecking.PositionItem = this.bindingNavigatorPositionItem;
            this.bndnCKCUChecking.Size = new System.Drawing.Size(666, 25);
            this.bndnCKCUChecking.TabIndex = 0;
            this.bndnCKCUChecking.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cKCUCheckingBindingNavigatorSaveItem
            // 
            this.cKCUCheckingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cKCUCheckingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cKCUCheckingBindingNavigatorSaveItem.Image")));
            this.cKCUCheckingBindingNavigatorSaveItem.Name = "cKCUCheckingBindingNavigatorSaveItem";
            this.cKCUCheckingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cKCUCheckingBindingNavigatorSaveItem.Text = "Save Data";
            this.cKCUCheckingBindingNavigatorSaveItem.Click += new System.EventHandler(this.cKCUCheckingBindingNavigatorSaveItem_Click);
            // 
            // chkIDTextBox
            // 
            this.chkIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkID", true));
            this.chkIDTextBox.Enabled = false;
            this.chkIDTextBox.Location = new System.Drawing.Point(50, 55);
            this.chkIDTextBox.Name = "chkIDTextBox";
            this.chkIDTextBox.Size = new System.Drawing.Size(55, 20);
            this.chkIDTextBox.TabIndex = 2;
            // 
            // chkDateDateTimePicker
            // 
            this.chkDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bndsCKCUChecking, "ChkDate", true));
            this.chkDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.chkDateDateTimePicker.Location = new System.Drawing.Point(215, 55);
            this.chkDateDateTimePicker.Name = "chkDateDateTimePicker";
            this.chkDateDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.chkDateDateTimePicker.TabIndex = 4;
            // 
            // chkNoTextBox
            // 
            this.chkNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkNo", true));
            this.chkNoTextBox.Location = new System.Drawing.Point(417, 55);
            this.chkNoTextBox.Name = "chkNoTextBox";
            this.chkNoTextBox.Size = new System.Drawing.Size(97, 20);
            this.chkNoTextBox.TabIndex = 6;
            // 
            // chkPymtTextBox
            // 
            this.chkPymtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkPymt", true));
            this.chkPymtTextBox.Location = new System.Drawing.Point(90, 127);
            this.chkPymtTextBox.Name = "chkPymtTextBox";
            this.chkPymtTextBox.Size = new System.Drawing.Size(97, 20);
            this.chkPymtTextBox.TabIndex = 10;
            // 
            // chkDepTextBox
            // 
            this.chkDepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkDep", true));
            this.chkDepTextBox.Location = new System.Drawing.Point(306, 127);
            this.chkDepTextBox.Name = "chkDepTextBox";
            this.chkDepTextBox.Size = new System.Drawing.Size(97, 20);
            this.chkDepTextBox.TabIndex = 12;
            // 
            // chkBalanceTextBox
            // 
            this.chkBalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkBalance", true));
            this.chkBalanceTextBox.Location = new System.Drawing.Point(487, 127);
            this.chkBalanceTextBox.Name = "chkBalanceTextBox";
            this.chkBalanceTextBox.Size = new System.Drawing.Size(97, 20);
            this.chkBalanceTextBox.TabIndex = 14;
            // 
            // chkRecCheckBox
            // 
            this.chkRecCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bndsCKCUChecking, "ChkRec", true));
            this.chkRecCheckBox.Location = new System.Drawing.Point(82, 163);
            this.chkRecCheckBox.Name = "chkRecCheckBox";
            this.chkRecCheckBox.Size = new System.Drawing.Size(31, 24);
            this.chkRecCheckBox.TabIndex = 18;
            this.chkRecCheckBox.UseVisualStyleBackColor = true;
            // 
            // chkMemoTextBox
            // 
            this.chkMemoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkMemo", true));
            this.chkMemoTextBox.Location = new System.Drawing.Point(75, 193);
            this.chkMemoTextBox.Multiline = true;
            this.chkMemoTextBox.Name = "chkMemoTextBox";
            this.chkMemoTextBox.Size = new System.Drawing.Size(542, 54);
            this.chkMemoTextBox.TabIndex = 20;
            // 
            // newCatIDComboBox
            // 
            this.newCatIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bndsCKCUChecking, "NewCatID", true));
            this.newCatIDComboBox.DataSource = this.bndsCategories;
            this.newCatIDComboBox.DisplayMember = "CatName";
            this.newCatIDComboBox.FormattingEnabled = true;
            this.newCatIDComboBox.Location = new System.Drawing.Point(69, 91);
            this.newCatIDComboBox.Name = "newCatIDComboBox";
            this.newCatIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.newCatIDComboBox.TabIndex = 22;
            this.newCatIDComboBox.ValueMember = "CatID";
            // 
            // bndsCategories
            // 
            this.bndsCategories.DataMember = "Categories";
            this.bndsCategories.DataSource = this.dsEzra;
            // 
            // chkVendIDComboBox
            // 
            this.chkVendIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bndsCKCUChecking, "ChkVendID", true));
            this.chkVendIDComboBox.DataSource = this.bndsVendors;
            this.chkVendIDComboBox.DisplayMember = "VendName";
            this.chkVendIDComboBox.FormattingEnabled = true;
            this.chkVendIDComboBox.Location = new System.Drawing.Point(378, 91);
            this.chkVendIDComboBox.Name = "chkVendIDComboBox";
            this.chkVendIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.chkVendIDComboBox.TabIndex = 24;
            this.chkVendIDComboBox.ValueMember = "VendID";
            // 
            // bndsVendors
            // 
            this.bndsVendors.DataMember = "Vendors";
            this.bndsVendors.DataSource = this.dsEzra;
            // 
            // chkDepNoTextBox
            // 
            this.chkDepNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkDepNo", true));
            this.chkDepNoTextBox.Location = new System.Drawing.Point(236, 165);
            this.chkDepNoTextBox.Name = "chkDepNoTextBox";
            this.chkDepNoTextBox.Size = new System.Drawing.Size(35, 20);
            this.chkDepNoTextBox.TabIndex = 26;
            // 
            // grpCKCUCheck
            // 
            this.grpCKCUCheck.Controls.Add(chkBanTransNoLabel);
            this.grpCKCUCheck.Controls.Add(this.chkBanTransNoTextBox);
            this.grpCKCUCheck.Controls.Add(this.chkIDTextBox);
            this.grpCKCUCheck.Controls.Add(lblChkBalance);
            this.grpCKCUCheck.Controls.Add(this.bndnCKCUChecking);
            this.grpCKCUCheck.Controls.Add(lblChkPymt);
            this.grpCKCUCheck.Controls.Add(this.chkBalanceTextBox);
            this.grpCKCUCheck.Controls.Add(lblChkNo);
            this.grpCKCUCheck.Controls.Add(lblChkRec);
            this.grpCKCUCheck.Controls.Add(this.chkPymtTextBox);
            this.grpCKCUCheck.Controls.Add(this.chkRecCheckBox);
            this.grpCKCUCheck.Controls.Add(lblChkDate);
            this.grpCKCUCheck.Controls.Add(lblChkMemo);
            this.grpCKCUCheck.Controls.Add(lblChkDep);
            this.grpCKCUCheck.Controls.Add(this.chkMemoTextBox);
            this.grpCKCUCheck.Controls.Add(lblChkDepNo);
            this.grpCKCUCheck.Controls.Add(lblChkID);
            this.grpCKCUCheck.Controls.Add(this.chkDepNoTextBox);
            this.grpCKCUCheck.Controls.Add(this.chkDepTextBox);
            this.grpCKCUCheck.Controls.Add(this.chkDateDateTimePicker);
            this.grpCKCUCheck.Controls.Add(this.chkNoTextBox);
            this.grpCKCUCheck.Controls.Add(this.newCatIDComboBox);
            this.grpCKCUCheck.Controls.Add(this.chkVendIDComboBox);
            this.grpCKCUCheck.Controls.Add(lblChkVendID);
            this.grpCKCUCheck.Controls.Add(lblNewCatID);
            this.grpCKCUCheck.Location = new System.Drawing.Point(12, 28);
            this.grpCKCUCheck.Name = "grpCKCUCheck";
            this.grpCKCUCheck.Size = new System.Drawing.Size(672, 267);
            this.grpCKCUCheck.TabIndex = 29;
            this.grpCKCUCheck.TabStop = false;
            this.grpCKCUCheck.Text = "Check Record";
            // 
            // bndsBankTrans
            // 
            this.bndsBankTrans.DataMember = "BankTrans";
            this.bndsBankTrans.DataSource = this.dsEzra;
            // 
            // tranNoTextBox
            // 
            this.tranNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranNo", true));
            this.tranNoTextBox.Enabled = false;
            this.tranNoTextBox.Location = new System.Drawing.Point(53, 58);
            this.tranNoTextBox.Name = "tranNoTextBox";
            this.tranNoTextBox.Size = new System.Drawing.Size(65, 20);
            this.tranNoTextBox.TabIndex = 30;
            // 
            // tranTypeTextBox
            // 
            this.tranTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranType", true));
            this.tranTypeTextBox.Enabled = false;
            this.tranTypeTextBox.Location = new System.Drawing.Point(186, 58);
            this.tranTypeTextBox.Name = "tranTypeTextBox";
            this.tranTypeTextBox.Size = new System.Drawing.Size(84, 20);
            this.tranTypeTextBox.TabIndex = 32;
            // 
            // tranDateDateTimePicker
            // 
            this.tranDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bndsBankTrans, "tranDate", true));
            this.tranDateDateTimePicker.Enabled = false;
            this.tranDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tranDateDateTimePicker.Location = new System.Drawing.Point(346, 55);
            this.tranDateDateTimePicker.Name = "tranDateDateTimePicker";
            this.tranDateDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.tranDateDateTimePicker.TabIndex = 34;
            // 
            // tranAmtTextBox
            // 
            this.tranAmtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranAmt", true));
            this.tranAmtTextBox.Enabled = false;
            this.tranAmtTextBox.Location = new System.Drawing.Point(53, 91);
            this.tranAmtTextBox.Name = "tranAmtTextBox";
            this.tranAmtTextBox.Size = new System.Drawing.Size(106, 20);
            this.tranAmtTextBox.TabIndex = 36;
            // 
            // tranCheckNoTextBox
            // 
            this.tranCheckNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranCheckNo", true));
            this.tranCheckNoTextBox.Enabled = false;
            this.tranCheckNoTextBox.Location = new System.Drawing.Point(526, 91);
            this.tranCheckNoTextBox.Name = "tranCheckNoTextBox";
            this.tranCheckNoTextBox.Size = new System.Drawing.Size(84, 20);
            this.tranCheckNoTextBox.TabIndex = 40;
            // 
            // tranNameTextBox
            // 
            this.tranNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranName", true));
            this.tranNameTextBox.Enabled = false;
            this.tranNameTextBox.Location = new System.Drawing.Point(53, 123);
            this.tranNameTextBox.Name = "tranNameTextBox";
            this.tranNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.tranNameTextBox.TabIndex = 42;
            // 
            // tranMemoTextBox
            // 
            this.tranMemoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranMemo", true));
            this.tranMemoTextBox.Enabled = false;
            this.tranMemoTextBox.Location = new System.Drawing.Point(324, 123);
            this.tranMemoTextBox.Name = "tranMemoTextBox";
            this.tranMemoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tranMemoTextBox.TabIndex = 44;
            // 
            // tranChkIDTextBox
            // 
            this.tranChkIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranChkID", true));
            this.tranChkIDTextBox.Enabled = false;
            this.tranChkIDTextBox.Location = new System.Drawing.Point(53, 155);
            this.tranChkIDTextBox.Name = "tranChkIDTextBox";
            this.tranChkIDTextBox.Size = new System.Drawing.Size(65, 20);
            this.tranChkIDTextBox.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bndnBankTrans);
            this.groupBox1.Controls.Add(lblTranBankID);
            this.groupBox1.Controls.Add(this.tranBankIDTextBox);
            this.groupBox1.Controls.Add(this.tranNoTextBox);
            this.groupBox1.Controls.Add(lblTranNo);
            this.groupBox1.Controls.Add(this.tranChkIDTextBox);
            this.groupBox1.Controls.Add(lblTranChkID);
            this.groupBox1.Controls.Add(lblTranType);
            this.groupBox1.Controls.Add(this.tranMemoTextBox);
            this.groupBox1.Controls.Add(this.tranTypeTextBox);
            this.groupBox1.Controls.Add(lblTranMemo);
            this.groupBox1.Controls.Add(lblTranDate);
            this.groupBox1.Controls.Add(this.tranNameTextBox);
            this.groupBox1.Controls.Add(this.tranDateDateTimePicker);
            this.groupBox1.Controls.Add(lblTranName);
            this.groupBox1.Controls.Add(lblTranAmt);
            this.groupBox1.Controls.Add(this.tranCheckNoTextBox);
            this.groupBox1.Controls.Add(this.tranAmtTextBox);
            this.groupBox1.Controls.Add(lblTranCheckNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 210);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Transaction";
            // 
            // bndnBankTrans
            // 
            this.bndnBankTrans.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bndnBankTrans.BindingSource = this.bndsBankTrans;
            this.bndnBankTrans.CountItem = this.bindingNavigatorCountItem1;
            this.bndnBankTrans.DeleteItem = null;
            this.bndnBankTrans.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.toolStripSeparator1});
            this.bndnBankTrans.Location = new System.Drawing.Point(3, 16);
            this.bndnBankTrans.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bndnBankTrans.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bndnBankTrans.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bndnBankTrans.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bndnBankTrans.Name = "bndnBankTrans";
            this.bndnBankTrans.PositionItem = this.bindingNavigatorPositionItem1;
            this.bndnBankTrans.Size = new System.Drawing.Size(645, 25);
            this.bndnBankTrans.TabIndex = 48;
            this.bndnBankTrans.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            this.bindingNavigatorAddNewItem1.Click += new System.EventHandler(this.bindingNavigatorAddNewItem1_Click);
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tranBankIDTextBox
            // 
            this.tranBankIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranBankID", true));
            this.tranBankIDTextBox.Enabled = false;
            this.tranBankIDTextBox.Location = new System.Drawing.Point(249, 91);
            this.tranBankIDTextBox.Name = "tranBankIDTextBox";
            this.tranBankIDTextBox.Size = new System.Drawing.Size(203, 20);
            this.tranBankIDTextBox.TabIndex = 47;
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // chkBanTransNoLabel
            // 
            chkBanTransNoLabel.AutoSize = true;
            chkBanTransNoLabel.Location = new System.Drawing.Point(317, 169);
            chkBanTransNoLabel.Name = "chkBanTransNoLabel";
            chkBanTransNoLabel.Size = new System.Drawing.Size(82, 13);
            chkBanTransNoLabel.TabIndex = 27;
            chkBanTransNoLabel.Text = "Bank Trans No:";
            // 
            // chkBanTransNoTextBox
            // 
            this.chkBanTransNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkBanTransNo", true));
            this.chkBanTransNoTextBox.Location = new System.Drawing.Point(421, 166);
            this.chkBanTransNoTextBox.Name = "chkBanTransNoTextBox";
            this.chkBanTransNoTextBox.Size = new System.Drawing.Size(189, 20);
            this.chkBanTransNoTextBox.TabIndex = 28;
            // 
            // frmCheckingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCKCUCheck);
            this.Name = "frmCheckingDetail";
            this.Text = "frmCheckingDetail";
            this.Load += new System.EventHandler(this.frmCheckingDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnCKCUChecking)).EndInit();
            this.bndnCKCUChecking.ResumeLayout(false);
            this.bndnCKCUChecking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).EndInit();
            this.grpCKCUCheck.ResumeLayout(false);
            this.grpCKCUCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsBankTrans)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndnBankTrans)).EndInit();
            this.bndnBankTrans.ResumeLayout(false);
            this.bndnBankTrans.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataAccess.EzraDataSet dsEzra;
        private System.Windows.Forms.BindingSource bndsCKCUChecking;
        private DataAccess.EzraDataSetTableAdapters.CKCUCheckingTableAdapter taCKCUChecking;
        private DataAccess.EzraDataSetTableAdapters.TableAdapterManager taManager;
        private System.Windows.Forms.BindingNavigator bndnCKCUChecking;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cKCUCheckingBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox chkIDTextBox;
        private System.Windows.Forms.DateTimePicker chkDateDateTimePicker;
        private System.Windows.Forms.TextBox chkNoTextBox;
        private System.Windows.Forms.TextBox chkPymtTextBox;
        private System.Windows.Forms.TextBox chkDepTextBox;
        private System.Windows.Forms.TextBox chkBalanceTextBox;
        private System.Windows.Forms.CheckBox chkRecCheckBox;
        private System.Windows.Forms.TextBox chkMemoTextBox;
        private System.Windows.Forms.ComboBox newCatIDComboBox;
        private System.Windows.Forms.ComboBox chkVendIDComboBox;
        private System.Windows.Forms.TextBox chkDepNoTextBox;
        private DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter taCategories;
        private System.Windows.Forms.BindingSource bndsCategories;
        private DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter taVendors;
        private System.Windows.Forms.BindingSource bndsVendors;
        private System.Windows.Forms.GroupBox grpCKCUCheck;
        private DataAccess.EzraDataSetTableAdapters.BankTransTableAdapter taBankTrans;
        private System.Windows.Forms.BindingSource bndsBankTrans;
        private System.Windows.Forms.TextBox tranNoTextBox;
        private System.Windows.Forms.TextBox tranTypeTextBox;
        private System.Windows.Forms.DateTimePicker tranDateDateTimePicker;
        private System.Windows.Forms.TextBox tranAmtTextBox;
        private System.Windows.Forms.TextBox tranCheckNoTextBox;
        private System.Windows.Forms.TextBox tranNameTextBox;
        private System.Windows.Forms.TextBox tranMemoTextBox;
        private System.Windows.Forms.TextBox tranChkIDTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tranBankIDTextBox;
        private System.Windows.Forms.BindingNavigator bndnBankTrans;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox chkBanTransNoTextBox;
    }
}