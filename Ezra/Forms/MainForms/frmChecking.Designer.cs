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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsEzra = new Ezra.DataAccess.EzraDataSet();
            this.bndsCKCUChecking = new System.Windows.Forms.BindingSource(this.components);
            this.taCKCUChecking = new Ezra.DataAccess.EzraDataSetTableAdapters.CKCUCheckingTableAdapter();
            this.taManager = new Ezra.DataAccess.EzraDataSetTableAdapters.TableAdapterManager();
            this.dgvCKCUChecking = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bndsVendors = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bndsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taCategories = new Ezra.DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter();
            this.taVendors = new Ezra.DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter();
            this.tsbChecking = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCKCUChecking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).BeginInit();
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
            // dgvCKCUChecking
            // 
            this.dgvCKCUChecking.AutoGenerateColumns = false;
            this.dgvCKCUChecking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCKCUChecking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8});
            this.dgvCKCUChecking.DataSource = this.bndsCKCUChecking;
            this.dgvCKCUChecking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCKCUChecking.Location = new System.Drawing.Point(0, 25);
            this.dgvCKCUChecking.Name = "dgvCKCUChecking";
            this.dgvCKCUChecking.Size = new System.Drawing.Size(839, 521);
            this.dgvCKCUChecking.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn11.HeaderText = "Paid To";
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
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NewCatID";
            this.dataGridViewTextBoxColumn10.DataSource = this.bndsCategories;
            this.dataGridViewTextBoxColumn10.DisplayMember = "CatName";
            this.dataGridViewTextBoxColumn10.HeaderText = "Category";
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
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn5.HeaderText = "Payment";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ChkDep";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn6.HeaderText = "Deposit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ChkBalance";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn7.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ChkRec";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Rec";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ChkDepNo";
            this.dataGridViewTextBoxColumn12.HeaderText = "DepNo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 40;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ChkBanTransNo";
            this.dataGridViewTextBoxColumn13.HeaderText = "Bank Trans No";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ChkMemo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
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
            // taCategories
            // 
            this.taCategories.ClearBeforeFill = true;
            // 
            // taVendors
            // 
            this.taVendors.ClearBeforeFill = true;
            // 
            // tsbChecking
            // 
            this.tsbChecking.Location = new System.Drawing.Point(0, 0);
            this.tsbChecking.Name = "tsbChecking";
            this.tsbChecking.Size = new System.Drawing.Size(839, 25);
            this.tsbChecking.TabIndex = 2;
            this.tsbChecking.Text = "toolStrip1";
            // 
            // frmChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 546);
            this.Controls.Add(this.dgvCKCUChecking);
            this.Controls.Add(this.tsbChecking);
            this.Name = "frmChecking";
            this.Text = "CKCU Checking";
            this.Load += new System.EventHandler(this.frmChecking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCKCUChecking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStrip tsbChecking;
    }
}