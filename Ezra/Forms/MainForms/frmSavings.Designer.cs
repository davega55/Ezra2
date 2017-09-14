namespace Ezra.Forms.MainForms
{
    partial class frmSavings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSavings));
            this.ezraDataSet = new Ezra.DataAccess.EzraDataSet();
            this.cKCUSavingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cKCUSavingsTableAdapter = new Ezra.DataAccess.EzraDataSetTableAdapters.CKCUSavingsTableAdapter();
            this.tableAdapterManager = new Ezra.DataAccess.EzraDataSetTableAdapters.TableAdapterManager();
            this.cKCUSavingsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cKCUSavingsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cKCUSavingsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ezraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUSavingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUSavingsBindingNavigator)).BeginInit();
            this.cKCUSavingsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUSavingsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ezraDataSet
            // 
            this.ezraDataSet.DataSetName = "EzraDataSet";
            this.ezraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cKCUSavingsBindingSource
            // 
            this.cKCUSavingsBindingSource.DataMember = "CKCUSavings";
            this.cKCUSavingsBindingSource.DataSource = this.ezraDataSet;
            // 
            // cKCUSavingsTableAdapter
            // 
            this.cKCUSavingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalancesTableAdapter = null;
            this.tableAdapterManager.BankTransTableAdapter = null;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CKCUCheckingTableAdapter = null;
            this.tableAdapterManager.CKCUSavingsTableAdapter = this.cKCUSavingsTableAdapter;
            this.tableAdapterManager.ContributionsTableAdapter = null;
            this.tableAdapterManager.ContributorsTableAdapter = null;
            this.tableAdapterManager.ControlTableAdapter = null;
            this.tableAdapterManager.CreditCardTableAdapter = null;
            this.tableAdapterManager.EmployeePayDatesTableAdapter = null;
            this.tableAdapterManager.EmployeePayDedTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.FundsTableAdapter = null;
            this.tableAdapterManager.FundTransactionsTableAdapter = null;
            this.tableAdapterManager.GroupsTableAdapter = null;
            this.tableAdapterManager.PeoplesCheckingTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ezra.DataAccess.EzraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = null;
            // 
            // cKCUSavingsBindingNavigator
            // 
            this.cKCUSavingsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cKCUSavingsBindingNavigator.BindingSource = this.cKCUSavingsBindingSource;
            this.cKCUSavingsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cKCUSavingsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cKCUSavingsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cKCUSavingsBindingNavigatorSaveItem});
            this.cKCUSavingsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cKCUSavingsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cKCUSavingsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cKCUSavingsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cKCUSavingsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cKCUSavingsBindingNavigator.Name = "cKCUSavingsBindingNavigator";
            this.cKCUSavingsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cKCUSavingsBindingNavigator.Size = new System.Drawing.Size(821, 25);
            this.cKCUSavingsBindingNavigator.TabIndex = 0;
            this.cKCUSavingsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cKCUSavingsBindingNavigatorSaveItem
            // 
            this.cKCUSavingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cKCUSavingsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cKCUSavingsBindingNavigatorSaveItem.Image")));
            this.cKCUSavingsBindingNavigatorSaveItem.Name = "cKCUSavingsBindingNavigatorSaveItem";
            this.cKCUSavingsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cKCUSavingsBindingNavigatorSaveItem.Text = "Save Data";
            this.cKCUSavingsBindingNavigatorSaveItem.Click += new System.EventHandler(this.cKCUSavingsBindingNavigatorSaveItem_Click);
            // 
            // cKCUSavingsDataGridView
            // 
            this.cKCUSavingsDataGridView.AutoGenerateColumns = false;
            this.cKCUSavingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cKCUSavingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.cKCUSavingsDataGridView.DataSource = this.cKCUSavingsBindingSource;
            this.cKCUSavingsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cKCUSavingsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.cKCUSavingsDataGridView.Name = "cKCUSavingsDataGridView";
            this.cKCUSavingsDataGridView.Size = new System.Drawing.Size(821, 386);
            this.cKCUSavingsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "savID";
            this.dataGridViewTextBoxColumn1.HeaderText = "savID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "savDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "savDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "savDesc";
            this.dataGridViewTextBoxColumn3.HeaderText = "savDesc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "savPymt";
            this.dataGridViewTextBoxColumn4.HeaderText = "savPymt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "savDep";
            this.dataGridViewTextBoxColumn5.HeaderText = "savDep";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "savBal";
            this.dataGridViewTextBoxColumn6.HeaderText = "savBal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "savMemo";
            this.dataGridViewTextBoxColumn7.HeaderText = "savMemo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "savIsDiv";
            this.dataGridViewCheckBoxColumn1.HeaderText = "savIsDiv";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frmSavings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 411);
            this.Controls.Add(this.cKCUSavingsDataGridView);
            this.Controls.Add(this.cKCUSavingsBindingNavigator);
            this.Name = "frmSavings";
            this.Text = "frmSavings";
            this.Load += new System.EventHandler(this.frmSavings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ezraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUSavingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUSavingsBindingNavigator)).EndInit();
            this.cKCUSavingsBindingNavigator.ResumeLayout(false);
            this.cKCUSavingsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUSavingsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataAccess.EzraDataSet ezraDataSet;
        private System.Windows.Forms.BindingSource cKCUSavingsBindingSource;
        private DataAccess.EzraDataSetTableAdapters.CKCUSavingsTableAdapter cKCUSavingsTableAdapter;
        private DataAccess.EzraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cKCUSavingsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cKCUSavingsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cKCUSavingsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}