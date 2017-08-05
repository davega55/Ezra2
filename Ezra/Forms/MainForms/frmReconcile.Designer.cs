namespace Ezra.Forms.MainForms
{
    partial class frmReconcile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReconcile));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsEzra = new Ezra.DataAccess.EzraDataSet();
            this.bndsCKCUChecking = new System.Windows.Forms.BindingSource(this.components);
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
            this.cKCUCheckingDataGridView = new System.Windows.Forms.DataGridView();
            this.bndsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.taCategories = new Ezra.DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter();
            this.bndsVendors = new System.Windows.Forms.BindingSource(this.components);
            this.taVendors = new Ezra.DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter();
            this.bndsBankTrans = new System.Windows.Forms.BindingSource(this.components);
            this.taBankTrans = new Ezra.DataAccess.EzraDataSetTableAdapters.BankTransTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnCKCUChecking)).BeginInit();
            this.bndnCKCUChecking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUCheckingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsBankTrans)).BeginInit();
            this.SuspendLayout();
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
            this.cKCUCheckingBindingNavigatorSaveItem});
            this.bndnCKCUChecking.Location = new System.Drawing.Point(0, 0);
            this.bndnCKCUChecking.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndnCKCUChecking.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndnCKCUChecking.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndnCKCUChecking.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndnCKCUChecking.Name = "bndnCKCUChecking";
            this.bndnCKCUChecking.PositionItem = this.bindingNavigatorPositionItem;
            this.bndnCKCUChecking.Size = new System.Drawing.Size(883, 25);
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
            // 
            // cKCUCheckingDataGridView
            // 
            this.cKCUCheckingDataGridView.AutoGenerateColumns = false;
            this.cKCUCheckingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cKCUCheckingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.cKCUCheckingDataGridView.DataSource = this.bndsCKCUChecking;
            this.cKCUCheckingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cKCUCheckingDataGridView.Location = new System.Drawing.Point(0, 25);
            this.cKCUCheckingDataGridView.Name = "cKCUCheckingDataGridView";
            this.cKCUCheckingDataGridView.Size = new System.Drawing.Size(883, 479);
            this.cKCUCheckingDataGridView.TabIndex = 1;
            // 
            // bndsCategories
            // 
            this.bndsCategories.DataMember = "Categories";
            this.bndsCategories.DataSource = this.dsEzra;
            // 
            // taCategories
            // 
            this.taCategories.ClearBeforeFill = true;
            // 
            // bndsVendors
            // 
            this.bndsVendors.DataMember = "Vendors";
            this.bndsVendors.DataSource = this.dsEzra;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ChkID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ChkID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ChkDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "ChkDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ChkNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "ChkNo";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ChkDesc";
            this.dataGridViewTextBoxColumn4.HeaderText = "ChkDesc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ChkPymt";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "ChkPymt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ChkDep";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "ChkDep";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ChkBalance";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
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
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ChkMemo";
            this.dataGridViewTextBoxColumn9.HeaderText = "ChkMemo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ChkDepNo";
            this.dataGridViewTextBoxColumn12.HeaderText = "ChkDepNo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ChkBanTransNo";
            this.dataGridViewTextBoxColumn13.DataSource = this.bndsBankTrans;
            this.dataGridViewTextBoxColumn13.DisplayMember = "tranBankID";
            this.dataGridViewTextBoxColumn13.HeaderText = "ChkBanTransNo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn13.ValueMember = "tranBankID";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ChkDepImage";
            this.dataGridViewTextBoxColumn14.HeaderText = "ChkDepImage";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // frmReconcile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 504);
            this.Controls.Add(this.cKCUCheckingDataGridView);
            this.Controls.Add(this.bndnCKCUChecking);
            this.Name = "frmReconcile";
            this.Text = "frmReconcile";
            this.Load += new System.EventHandler(this.frmReconcile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnCKCUChecking)).EndInit();
            this.bndnCKCUChecking.ResumeLayout(false);
            this.bndnCKCUChecking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUCheckingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsBankTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView cKCUCheckingDataGridView;
        private System.Windows.Forms.BindingSource bndsCategories;
        private DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter taCategories;
        private System.Windows.Forms.BindingSource bndsVendors;
        private DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter taVendors;
        private System.Windows.Forms.BindingSource bndsBankTrans;
        private DataAccess.EzraDataSetTableAdapters.BankTransTableAdapter taBankTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}