namespace Ezra.Forms.MainForms
{
    partial class frmBankTransDetail
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
            System.Windows.Forms.Label tranTypeLabel;
            System.Windows.Forms.Label tranDateLabel;
            System.Windows.Forms.Label tranAmtLabel;
            System.Windows.Forms.Label tranBankIDLabel;
            System.Windows.Forms.Label tranCheckNoLabel;
            System.Windows.Forms.Label tranNameLabel;
            System.Windows.Forms.Label tranMemoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankTransDetail));
            this.dsEzra = new Ezra.DataAccess.EzraDataSet();
            this.bndsBankTrans = new System.Windows.Forms.BindingSource(this.components);
            this.taBankTrans = new Ezra.DataAccess.EzraDataSetTableAdapters.BankTransTableAdapter();
            this.taManager = new Ezra.DataAccess.EzraDataSetTableAdapters.TableAdapterManager();
            this.bndnBankTrans = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tranTypeTextBox = new System.Windows.Forms.TextBox();
            this.tranDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTranAmt = new System.Windows.Forms.TextBox();
            this.tranBankIDTextBox = new System.Windows.Forms.TextBox();
            this.tranCheckNoTextBox = new System.Windows.Forms.TextBox();
            this.tranNameTextBox = new System.Windows.Forms.TextBox();
            this.tranMemoTextBox = new System.Windows.Forms.TextBox();
            tranTypeLabel = new System.Windows.Forms.Label();
            tranDateLabel = new System.Windows.Forms.Label();
            tranAmtLabel = new System.Windows.Forms.Label();
            tranBankIDLabel = new System.Windows.Forms.Label();
            tranCheckNoLabel = new System.Windows.Forms.Label();
            tranNameLabel = new System.Windows.Forms.Label();
            tranMemoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsBankTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnBankTrans)).BeginInit();
            this.bndnBankTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // tranTypeLabel
            // 
            tranTypeLabel.AutoSize = true;
            tranTypeLabel.Location = new System.Drawing.Point(84, 48);
            tranTypeLabel.Name = "tranTypeLabel";
            tranTypeLabel.Size = new System.Drawing.Size(34, 13);
            tranTypeLabel.TabIndex = 3;
            tranTypeLabel.Text = "Type:";
            // 
            // tranDateLabel
            // 
            tranDateLabel.AutoSize = true;
            tranDateLabel.Location = new System.Drawing.Point(85, 75);
            tranDateLabel.Name = "tranDateLabel";
            tranDateLabel.Size = new System.Drawing.Size(33, 13);
            tranDateLabel.TabIndex = 5;
            tranDateLabel.Text = "Date:";
            // 
            // tranAmtLabel
            // 
            tranAmtLabel.AutoSize = true;
            tranAmtLabel.Location = new System.Drawing.Point(72, 100);
            tranAmtLabel.Name = "tranAmtLabel";
            tranAmtLabel.Size = new System.Drawing.Size(46, 13);
            tranAmtLabel.TabIndex = 7;
            tranAmtLabel.Text = "Amount:";
            // 
            // tranBankIDLabel
            // 
            tranBankIDLabel.AutoSize = true;
            tranBankIDLabel.Location = new System.Drawing.Point(12, 126);
            tranBankIDLabel.Name = "tranBankIDLabel";
            tranBankIDLabel.Size = new System.Drawing.Size(106, 13);
            tranBankIDLabel.TabIndex = 9;
            tranBankIDLabel.Text = "Transaction Number:";
            // 
            // tranCheckNoLabel
            // 
            tranCheckNoLabel.AutoSize = true;
            tranCheckNoLabel.Location = new System.Drawing.Point(60, 152);
            tranCheckNoLabel.Name = "tranCheckNoLabel";
            tranCheckNoLabel.Size = new System.Drawing.Size(58, 13);
            tranCheckNoLabel.TabIndex = 11;
            tranCheckNoLabel.Text = "Check No:";
            // 
            // tranNameLabel
            // 
            tranNameLabel.AutoSize = true;
            tranNameLabel.Location = new System.Drawing.Point(80, 178);
            tranNameLabel.Name = "tranNameLabel";
            tranNameLabel.Size = new System.Drawing.Size(38, 13);
            tranNameLabel.TabIndex = 13;
            tranNameLabel.Text = "Name:";
            // 
            // tranMemoLabel
            // 
            tranMemoLabel.AutoSize = true;
            tranMemoLabel.Location = new System.Drawing.Point(79, 204);
            tranMemoLabel.Name = "tranMemoLabel";
            tranMemoLabel.Size = new System.Drawing.Size(39, 13);
            tranMemoLabel.TabIndex = 15;
            tranMemoLabel.Text = "Memo:";
            // 
            // dsEzra
            // 
            this.dsEzra.DataSetName = "EzraDataSet";
            this.dsEzra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // taManager
            // 
            this.taManager.BackupDataSetBeforeUpdate = false;
            this.taManager.BalancesTableAdapter = null;
            this.taManager.BankTransTableAdapter = this.taBankTrans;
            this.taManager.BudgetTableAdapter = null;
            this.taManager.CategoriesTableAdapter = null;
            this.taManager.CKCUCheckingTableAdapter = null;
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
            // bndnBankTrans
            // 
            this.bndnBankTrans.AddNewItem = null;
            this.bndnBankTrans.BindingSource = this.bndsBankTrans;
            this.bndnBankTrans.CountItem = this.bindingNavigatorCountItem;
            this.bndnBankTrans.DeleteItem = null;
            this.bndnBankTrans.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bndnBankTrans.Location = new System.Drawing.Point(0, 0);
            this.bndnBankTrans.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndnBankTrans.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndnBankTrans.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndnBankTrans.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndnBankTrans.Name = "bndnBankTrans";
            this.bndnBankTrans.PositionItem = this.bindingNavigatorPositionItem;
            this.bndnBankTrans.Size = new System.Drawing.Size(351, 25);
            this.bndnBankTrans.TabIndex = 0;
            this.bndnBankTrans.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // tranTypeTextBox
            // 
            this.tranTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranType", true));
            this.tranTypeTextBox.Location = new System.Drawing.Point(128, 45);
            this.tranTypeTextBox.Name = "tranTypeTextBox";
            this.tranTypeTextBox.ReadOnly = true;
            this.tranTypeTextBox.Size = new System.Drawing.Size(117, 20);
            this.tranTypeTextBox.TabIndex = 4;
            // 
            // tranDateDateTimePicker
            // 
            this.tranDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bndsBankTrans, "tranDate", true));
            this.tranDateDateTimePicker.Enabled = false;
            this.tranDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tranDateDateTimePicker.Location = new System.Drawing.Point(128, 71);
            this.tranDateDateTimePicker.Name = "tranDateDateTimePicker";
            this.tranDateDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.tranDateDateTimePicker.TabIndex = 6;
            // 
            // txtTranAmt
            // 
            this.txtTranAmt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranAmt", true));
            this.txtTranAmt.Location = new System.Drawing.Point(128, 97);
            this.txtTranAmt.Name = "txtTranAmt";
            this.txtTranAmt.ReadOnly = true;
            this.txtTranAmt.Size = new System.Drawing.Size(117, 20);
            this.txtTranAmt.TabIndex = 8;
            // 
            // tranBankIDTextBox
            // 
            this.tranBankIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranBankID", true));
            this.tranBankIDTextBox.Location = new System.Drawing.Point(128, 123);
            this.tranBankIDTextBox.Name = "tranBankIDTextBox";
            this.tranBankIDTextBox.ReadOnly = true;
            this.tranBankIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.tranBankIDTextBox.TabIndex = 10;
            // 
            // tranCheckNoTextBox
            // 
            this.tranCheckNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranCheckNo", true));
            this.tranCheckNoTextBox.Location = new System.Drawing.Point(128, 149);
            this.tranCheckNoTextBox.Name = "tranCheckNoTextBox";
            this.tranCheckNoTextBox.ReadOnly = true;
            this.tranCheckNoTextBox.Size = new System.Drawing.Size(117, 20);
            this.tranCheckNoTextBox.TabIndex = 12;
            // 
            // tranNameTextBox
            // 
            this.tranNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranName", true));
            this.tranNameTextBox.Location = new System.Drawing.Point(128, 175);
            this.tranNameTextBox.Name = "tranNameTextBox";
            this.tranNameTextBox.ReadOnly = true;
            this.tranNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.tranNameTextBox.TabIndex = 14;
            // 
            // tranMemoTextBox
            // 
            this.tranMemoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsBankTrans, "tranMemo", true));
            this.tranMemoTextBox.Location = new System.Drawing.Point(128, 201);
            this.tranMemoTextBox.Name = "tranMemoTextBox";
            this.tranMemoTextBox.ReadOnly = true;
            this.tranMemoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tranMemoTextBox.TabIndex = 16;
            // 
            // frmBankTransDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 232);
            this.Controls.Add(tranTypeLabel);
            this.Controls.Add(this.tranTypeTextBox);
            this.Controls.Add(tranDateLabel);
            this.Controls.Add(this.tranDateDateTimePicker);
            this.Controls.Add(tranAmtLabel);
            this.Controls.Add(this.txtTranAmt);
            this.Controls.Add(tranBankIDLabel);
            this.Controls.Add(this.tranBankIDTextBox);
            this.Controls.Add(tranCheckNoLabel);
            this.Controls.Add(this.tranCheckNoTextBox);
            this.Controls.Add(tranNameLabel);
            this.Controls.Add(this.tranNameTextBox);
            this.Controls.Add(tranMemoLabel);
            this.Controls.Add(this.tranMemoTextBox);
            this.Controls.Add(this.bndnBankTrans);
            this.Name = "frmBankTransDetail";
            this.Text = "Transaction Detail";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmBankTransDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsBankTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnBankTrans)).EndInit();
            this.bndnBankTrans.ResumeLayout(false);
            this.bndnBankTrans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataAccess.EzraDataSet dsEzra;
        private System.Windows.Forms.BindingSource bndsBankTrans;
        private DataAccess.EzraDataSetTableAdapters.BankTransTableAdapter taBankTrans;
        private DataAccess.EzraDataSetTableAdapters.TableAdapterManager taManager;
        private System.Windows.Forms.BindingNavigator bndnBankTrans;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox tranTypeTextBox;
        private System.Windows.Forms.DateTimePicker tranDateDateTimePicker;
        private System.Windows.Forms.TextBox txtTranAmt;
        private System.Windows.Forms.TextBox tranBankIDTextBox;
        private System.Windows.Forms.TextBox tranCheckNoTextBox;
        private System.Windows.Forms.TextBox tranNameTextBox;
        private System.Windows.Forms.TextBox tranMemoTextBox;
    }
}