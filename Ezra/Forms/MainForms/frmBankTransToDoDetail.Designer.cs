namespace Ezra.Forms.MainForms
{
    partial class frmBankTransToDoDetail
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
            System.Windows.Forms.Label chkIDLabel;
            System.Windows.Forms.Label chkDateLabel;
            System.Windows.Forms.Label chkNoLabel;
            System.Windows.Forms.Label chkPymtLabel;
            System.Windows.Forms.Label chkDepLabel;
            System.Windows.Forms.Label chkBalanceLabel;
            System.Windows.Forms.Label chkMemoLabel;
            System.Windows.Forms.Label newCatIDLabel;
            System.Windows.Forms.Label chkVendIDLabel;
            System.Windows.Forms.Label chkDepNoLabel;
            System.Windows.Forms.Label chkBanTransNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankTransToDoDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChkID = new System.Windows.Forms.TextBox();
            this.bndsCKCUChecking = new System.Windows.Forms.BindingSource(this.components);
            this.dsEzra = new Ezra.DataAccess.EzraDataSet();
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
            this.txtChkBanTransNo = new System.Windows.Forms.TextBox();
            this.taCKCUChecking = new Ezra.DataAccess.EzraDataSetTableAdapters.CKCUCheckingTableAdapter();
            this.taManager = new Ezra.DataAccess.EzraDataSetTableAdapters.TableAdapterManager();
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
            this.tsbViewAllRecords = new System.Windows.Forms.ToolStripButton();
            this.tsbViewUnlinked = new System.Windows.Forms.ToolStripButton();
            this.taCategories = new Ezra.DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter();
            this.taVendors = new Ezra.DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter();
            this.bndsBankTrans = new System.Windows.Forms.BindingSource(this.components);
            this.taBankTrans = new Ezra.DataAccess.EzraDataSetTableAdapters.BankTransTableAdapter();
            this.bankTransDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taQueries = new Ezra.DataAccess.EzraDataSetTableAdapters.QueriesTableAdapter();
            chkIDLabel = new System.Windows.Forms.Label();
            chkDateLabel = new System.Windows.Forms.Label();
            chkNoLabel = new System.Windows.Forms.Label();
            chkPymtLabel = new System.Windows.Forms.Label();
            chkDepLabel = new System.Windows.Forms.Label();
            chkBalanceLabel = new System.Windows.Forms.Label();
            chkMemoLabel = new System.Windows.Forms.Label();
            newCatIDLabel = new System.Windows.Forms.Label();
            chkVendIDLabel = new System.Windows.Forms.Label();
            chkDepNoLabel = new System.Windows.Forms.Label();
            chkBanTransNoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnCKCUChecking)).BeginInit();
            this.bndnCKCUChecking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsBankTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankTransDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chkIDLabel
            // 
            chkIDLabel.AutoSize = true;
            chkIDLabel.Location = new System.Drawing.Point(27, 33);
            chkIDLabel.Name = "chkIDLabel";
            chkIDLabel.Size = new System.Drawing.Size(21, 13);
            chkIDLabel.TabIndex = 0;
            chkIDLabel.Text = "ID:";
            // 
            // chkDateLabel
            // 
            chkDateLabel.AutoSize = true;
            chkDateLabel.Location = new System.Drawing.Point(171, 33);
            chkDateLabel.Name = "chkDateLabel";
            chkDateLabel.Size = new System.Drawing.Size(67, 13);
            chkDateLabel.TabIndex = 2;
            chkDateLabel.Text = "Check Date:";
            // 
            // chkNoLabel
            // 
            chkNoLabel.AutoSize = true;
            chkNoLabel.Location = new System.Drawing.Point(417, 33);
            chkNoLabel.Name = "chkNoLabel";
            chkNoLabel.Size = new System.Drawing.Size(66, 13);
            chkNoLabel.TabIndex = 4;
            chkNoLabel.Text = "Check Num:";
            // 
            // chkPymtLabel
            // 
            chkPymtLabel.AutoSize = true;
            chkPymtLabel.Location = new System.Drawing.Point(24, 114);
            chkPymtLabel.Name = "chkPymtLabel";
            chkPymtLabel.Size = new System.Drawing.Size(72, 13);
            chkPymtLabel.TabIndex = 8;
            chkPymtLabel.Text = "Payment Amt:";
            // 
            // chkDepLabel
            // 
            chkDepLabel.AutoSize = true;
            chkDepLabel.Location = new System.Drawing.Point(261, 114);
            chkDepLabel.Name = "chkDepLabel";
            chkDepLabel.Size = new System.Drawing.Size(67, 13);
            chkDepLabel.TabIndex = 10;
            chkDepLabel.Text = "Deposit Amt:";
            // 
            // chkBalanceLabel
            // 
            chkBalanceLabel.AutoSize = true;
            chkBalanceLabel.Location = new System.Drawing.Point(488, 114);
            chkBalanceLabel.Name = "chkBalanceLabel";
            chkBalanceLabel.Size = new System.Drawing.Size(49, 13);
            chkBalanceLabel.TabIndex = 12;
            chkBalanceLabel.Text = "Balance:";
            // 
            // chkMemoLabel
            // 
            chkMemoLabel.AutoSize = true;
            chkMemoLabel.Location = new System.Drawing.Point(26, 202);
            chkMemoLabel.Name = "chkMemoLabel";
            chkMemoLabel.Size = new System.Drawing.Size(61, 13);
            chkMemoLabel.TabIndex = 18;
            chkMemoLabel.Text = "Chk Memo:";
            // 
            // newCatIDLabel
            // 
            newCatIDLabel.AutoSize = true;
            newCatIDLabel.Location = new System.Drawing.Point(27, 74);
            newCatIDLabel.Name = "newCatIDLabel";
            newCatIDLabel.Size = new System.Drawing.Size(52, 13);
            newCatIDLabel.TabIndex = 20;
            newCatIDLabel.Text = "Category:";
            // 
            // chkVendIDLabel
            // 
            chkVendIDLabel.AutoSize = true;
            chkVendIDLabel.Location = new System.Drawing.Point(385, 74);
            chkVendIDLabel.Name = "chkVendIDLabel";
            chkVendIDLabel.Size = new System.Drawing.Size(44, 13);
            chkVendIDLabel.TabIndex = 22;
            chkVendIDLabel.Text = "Pay To:";
            // 
            // chkDepNoLabel
            // 
            chkDepNoLabel.AutoSize = true;
            chkDepNoLabel.Location = new System.Drawing.Point(160, 161);
            chkDepNoLabel.Name = "chkDepNoLabel";
            chkDepNoLabel.Size = new System.Drawing.Size(71, 13);
            chkDepNoLabel.TabIndex = 24;
            chkDepNoLabel.Text = "Deposit Num:";
            // 
            // chkBanTransNoLabel
            // 
            chkBanTransNoLabel.AutoSize = true;
            chkBanTransNoLabel.Location = new System.Drawing.Point(345, 161);
            chkBanTransNoLabel.Name = "chkBanTransNoLabel";
            chkBanTransNoLabel.Size = new System.Drawing.Size(82, 13);
            chkBanTransNoLabel.TabIndex = 26;
            chkBanTransNoLabel.Text = "Bank Trans No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(chkIDLabel);
            this.groupBox1.Controls.Add(this.txtChkID);
            this.groupBox1.Controls.Add(chkDateLabel);
            this.groupBox1.Controls.Add(this.chkDateDateTimePicker);
            this.groupBox1.Controls.Add(chkNoLabel);
            this.groupBox1.Controls.Add(this.chkNoTextBox);
            this.groupBox1.Controls.Add(chkPymtLabel);
            this.groupBox1.Controls.Add(this.chkPymtTextBox);
            this.groupBox1.Controls.Add(chkDepLabel);
            this.groupBox1.Controls.Add(this.chkDepTextBox);
            this.groupBox1.Controls.Add(chkBalanceLabel);
            this.groupBox1.Controls.Add(this.chkBalanceTextBox);
            this.groupBox1.Controls.Add(this.chkRecCheckBox);
            this.groupBox1.Controls.Add(chkMemoLabel);
            this.groupBox1.Controls.Add(this.chkMemoTextBox);
            this.groupBox1.Controls.Add(newCatIDLabel);
            this.groupBox1.Controls.Add(this.newCatIDComboBox);
            this.groupBox1.Controls.Add(chkVendIDLabel);
            this.groupBox1.Controls.Add(this.chkVendIDComboBox);
            this.groupBox1.Controls.Add(chkDepNoLabel);
            this.groupBox1.Controls.Add(this.chkDepNoTextBox);
            this.groupBox1.Controls.Add(chkBanTransNoLabel);
            this.groupBox1.Controls.Add(this.txtChkBanTransNo);
            this.groupBox1.Location = new System.Drawing.Point(41, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Record";
            // 
            // txtChkID
            // 
            this.txtChkID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkID", true));
            this.txtChkID.Enabled = false;
            this.txtChkID.Location = new System.Drawing.Point(62, 29);
            this.txtChkID.Name = "txtChkID";
            this.txtChkID.Size = new System.Drawing.Size(70, 20);
            this.txtChkID.TabIndex = 1;
            // 
            // bndsCKCUChecking
            // 
            this.bndsCKCUChecking.DataMember = "CKCUChecking";
            this.bndsCKCUChecking.DataSource = this.dsEzra;
            // 
            // dsEzra
            // 
            this.dsEzra.DataSetName = "EzraDataSet";
            this.dsEzra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkDateDateTimePicker
            // 
            this.chkDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bndsCKCUChecking, "ChkDate", true));
            this.chkDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.chkDateDateTimePicker.Location = new System.Drawing.Point(253, 29);
            this.chkDateDateTimePicker.Name = "chkDateDateTimePicker";
            this.chkDateDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.chkDateDateTimePicker.TabIndex = 3;
            // 
            // chkNoTextBox
            // 
            this.chkNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkNo", true));
            this.chkNoTextBox.Location = new System.Drawing.Point(521, 29);
            this.chkNoTextBox.Name = "chkNoTextBox";
            this.chkNoTextBox.Size = new System.Drawing.Size(156, 20);
            this.chkNoTextBox.TabIndex = 5;
            // 
            // chkPymtTextBox
            // 
            this.chkPymtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkPymt", true));
            this.chkPymtTextBox.Location = new System.Drawing.Point(113, 111);
            this.chkPymtTextBox.Name = "chkPymtTextBox";
            this.chkPymtTextBox.Size = new System.Drawing.Size(125, 20);
            this.chkPymtTextBox.TabIndex = 9;
            // 
            // chkDepTextBox
            // 
            this.chkDepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkDep", true));
            this.chkDepTextBox.Location = new System.Drawing.Point(334, 111);
            this.chkDepTextBox.Name = "chkDepTextBox";
            this.chkDepTextBox.Size = new System.Drawing.Size(129, 20);
            this.chkDepTextBox.TabIndex = 11;
            // 
            // chkBalanceTextBox
            // 
            this.chkBalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkBalance", true));
            this.chkBalanceTextBox.Location = new System.Drawing.Point(546, 111);
            this.chkBalanceTextBox.Name = "chkBalanceTextBox";
            this.chkBalanceTextBox.Size = new System.Drawing.Size(131, 20);
            this.chkBalanceTextBox.TabIndex = 13;
            // 
            // chkRecCheckBox
            // 
            this.chkRecCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRecCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bndsCKCUChecking, "ChkRec", true));
            this.chkRecCheckBox.Location = new System.Drawing.Point(27, 156);
            this.chkRecCheckBox.Name = "chkRecCheckBox";
            this.chkRecCheckBox.Size = new System.Drawing.Size(91, 24);
            this.chkRecCheckBox.TabIndex = 17;
            this.chkRecCheckBox.Text = "Reconciled:";
            this.chkRecCheckBox.UseVisualStyleBackColor = true;
            // 
            // chkMemoTextBox
            // 
            this.chkMemoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkMemo", true));
            this.chkMemoTextBox.Location = new System.Drawing.Point(130, 199);
            this.chkMemoTextBox.Multiline = true;
            this.chkMemoTextBox.Name = "chkMemoTextBox";
            this.chkMemoTextBox.Size = new System.Drawing.Size(533, 54);
            this.chkMemoTextBox.TabIndex = 19;
            // 
            // newCatIDComboBox
            // 
            this.newCatIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bndsCKCUChecking, "NewCatID", true));
            this.newCatIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bndsCKCUChecking, "NewCatID", true));
            this.newCatIDComboBox.DataSource = this.bndsCategories;
            this.newCatIDComboBox.DisplayMember = "CatName";
            this.newCatIDComboBox.FormattingEnabled = true;
            this.newCatIDComboBox.Location = new System.Drawing.Point(85, 70);
            this.newCatIDComboBox.Name = "newCatIDComboBox";
            this.newCatIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.newCatIDComboBox.TabIndex = 21;
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
            this.chkVendIDComboBox.Location = new System.Drawing.Point(435, 70);
            this.chkVendIDComboBox.Name = "chkVendIDComboBox";
            this.chkVendIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.chkVendIDComboBox.TabIndex = 23;
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
            this.chkDepNoTextBox.Location = new System.Drawing.Point(235, 158);
            this.chkDepNoTextBox.Name = "chkDepNoTextBox";
            this.chkDepNoTextBox.Size = new System.Drawing.Size(50, 20);
            this.chkDepNoTextBox.TabIndex = 25;
            // 
            // txtChkBanTransNo
            // 
            this.txtChkBanTransNo.AcceptsTab = true;
            this.txtChkBanTransNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsCKCUChecking, "ChkBanTransNo", true));
            this.txtChkBanTransNo.Location = new System.Drawing.Point(449, 158);
            this.txtChkBanTransNo.Name = "txtChkBanTransNo";
            this.txtChkBanTransNo.Size = new System.Drawing.Size(200, 20);
            this.txtChkBanTransNo.TabIndex = 27;
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
            this.cKCUCheckingBindingNavigatorSaveItem,
            this.tsbViewAllRecords,
            this.tsbViewUnlinked});
            this.bndnCKCUChecking.Location = new System.Drawing.Point(0, 0);
            this.bndnCKCUChecking.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndnCKCUChecking.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndnCKCUChecking.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndnCKCUChecking.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndnCKCUChecking.Name = "bndnCKCUChecking";
            this.bndnCKCUChecking.PositionItem = this.bindingNavigatorPositionItem;
            this.bndnCKCUChecking.Size = new System.Drawing.Size(851, 25);
            this.bndnCKCUChecking.TabIndex = 1;
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
            // tsbViewAllRecords
            // 
            this.tsbViewAllRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewAllRecords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbViewAllRecords.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewAllRecords.Image")));
            this.tsbViewAllRecords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewAllRecords.Name = "tsbViewAllRecords";
            this.tsbViewAllRecords.Padding = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.tsbViewAllRecords.Size = new System.Drawing.Size(109, 22);
            this.tsbViewAllRecords.Text = "View All Records";
            this.tsbViewAllRecords.Click += new System.EventHandler(this.tsbViewAllRecords_Click);
            // 
            // tsbViewUnlinked
            // 
            this.tsbViewUnlinked.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewUnlinked.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbViewUnlinked.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewUnlinked.Image")));
            this.tsbViewUnlinked.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewUnlinked.Name = "tsbViewUnlinked";
            this.tsbViewUnlinked.Padding = new System.Windows.Forms.Padding(1, 0, 2, 0);
            this.tsbViewUnlinked.Size = new System.Drawing.Size(143, 22);
            this.tsbViewUnlinked.Text = "View Unlinked Records";
            this.tsbViewUnlinked.Click += new System.EventHandler(this.tsbViewUnlinked_Click);
            // 
            // taCategories
            // 
            this.taCategories.ClearBeforeFill = true;
            // 
            // taVendors
            // 
            this.taVendors.ClearBeforeFill = true;
            // 
            // bndsBankTrans
            // 
            this.bndsBankTrans.DataMember = "BankTrans";
            this.bndsBankTrans.DataSource = this.dsEzra;
            // 
            // taBankTrans
            // 
            this.taBankTrans.ClearBeforeFill = true;
            // 
            // bankTransDataGridView
            // 
            this.bankTransDataGridView.AllowUserToAddRows = false;
            this.bankTransDataGridView.AllowUserToDeleteRows = false;
            this.bankTransDataGridView.AutoGenerateColumns = false;
            this.bankTransDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankTransDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.bankTransDataGridView.DataSource = this.bndsBankTrans;
            this.bankTransDataGridView.Location = new System.Drawing.Point(21, 339);
            this.bankTransDataGridView.Name = "bankTransDataGridView";
            this.bankTransDataGridView.Size = new System.Drawing.Size(793, 220);
            this.bankTransDataGridView.TabIndex = 2;
            this.bankTransDataGridView.SelectionChanged += new System.EventHandler(this.bankTransDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tranNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "tranNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tranType";
            this.dataGridViewTextBoxColumn2.HeaderText = "tranType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tranDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tranAmt";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tranBankID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Trans Num";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tranCheckNo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Chk No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tranName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "tranMemo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tranChkID";
            this.dataGridViewTextBoxColumn9.HeaderText = "tranChkID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // frmBankTransToDoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 605);
            this.Controls.Add(this.bankTransDataGridView);
            this.Controls.Add(this.bndnCKCUChecking);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBankTransToDoDetail";
            this.Text = "frmBankTransToDoDetail";
            this.Load += new System.EventHandler(this.frmBankTransToDoDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnCKCUChecking)).EndInit();
            this.bndnCKCUChecking.ResumeLayout(false);
            this.bndnCKCUChecking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsBankTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankTransDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.TextBox txtChkID;
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
        private System.Windows.Forms.TextBox txtChkBanTransNo;
        private System.Windows.Forms.BindingSource bndsCategories;
        private DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter taCategories;
        private System.Windows.Forms.BindingSource bndsVendors;
        private DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter taVendors;
        private System.Windows.Forms.BindingSource bndsBankTrans;
        private DataAccess.EzraDataSetTableAdapters.BankTransTableAdapter taBankTrans;
        private System.Windows.Forms.DataGridView bankTransDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataAccess.EzraDataSetTableAdapters.QueriesTableAdapter taQueries;
        private System.Windows.Forms.ToolStripButton tsbViewAllRecords;
        private System.Windows.Forms.ToolStripButton tsbViewUnlinked;
    }
}