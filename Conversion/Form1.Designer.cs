namespace Conversion
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.ezraDataSet = new Conversion.EzraDataSet();
            this.cKCUCheckingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cKCUCheckingTableAdapter = new Conversion.EzraDataSetTableAdapters.CKCUCheckingTableAdapter();
            this.tableAdapterManager = new Conversion.EzraDataSetTableAdapters.TableAdapterManager();
            this.church_FinancesDataSet = new Conversion.Church_FinancesDataSet();
            this.cKCUCheckingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cKCUCheckingTableAdapter1 = new Conversion.Church_FinancesDataSetTableAdapters.CKCUCheckingTableAdapter();
            this.tableAdapterManager1 = new Conversion.Church_FinancesDataSetTableAdapters.TableAdapterManager();
            this.cKCUCheckingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ezraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUCheckingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.church_FinancesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUCheckingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUCheckingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ezraDataSet
            // 
            this.ezraDataSet.DataSetName = "EzraDataSet";
            this.ezraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cKCUCheckingBindingSource
            // 
            this.cKCUCheckingBindingSource.DataMember = "CKCUChecking";
            this.cKCUCheckingBindingSource.DataSource = this.ezraDataSet;
            // 
            // cKCUCheckingTableAdapter
            // 
            this.cKCUCheckingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalancesTableAdapter = null;
            this.tableAdapterManager.BankTransTableAdapter = null;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CKCUCheckingTableAdapter = this.cKCUCheckingTableAdapter;
            this.tableAdapterManager.CKCUSavingsTableAdapter = null;
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
            this.tableAdapterManager.UpdateOrder = Conversion.EzraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = null;
            // 
            // church_FinancesDataSet
            // 
            this.church_FinancesDataSet.DataSetName = "Church_FinancesDataSet";
            this.church_FinancesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cKCUCheckingBindingSource1
            // 
            this.cKCUCheckingBindingSource1.DataMember = "CKCUChecking";
            this.cKCUCheckingBindingSource1.DataSource = this.church_FinancesDataSet;
            // 
            // cKCUCheckingTableAdapter1
            // 
            this.cKCUCheckingTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BalancesTableAdapter = null;
            this.tableAdapterManager1.BankTransTableAdapter = null;
            this.tableAdapterManager1.BudgetTableAdapter = null;
            this.tableAdapterManager1.CategoriesTableAdapter = null;
            this.tableAdapterManager1.CKCUCheckingTableAdapter = this.cKCUCheckingTableAdapter1;
            this.tableAdapterManager1.CKCUSavingsTableAdapter = null;
            this.tableAdapterManager1.ContributionsTableAdapter = null;
            this.tableAdapterManager1.ContributorsTableAdapter = null;
            this.tableAdapterManager1.ControlTableAdapter = null;
            this.tableAdapterManager1.CreditCardTableAdapter = null;
            this.tableAdapterManager1.EmployeePayDatesTableAdapter = null;
            this.tableAdapterManager1.EmployeePayDedTableAdapter = null;
            this.tableAdapterManager1.EmployeesTableAdapter = null;
            this.tableAdapterManager1.FundsTableAdapter = null;
            this.tableAdapterManager1.FundTransactionsTableAdapter = null;
            this.tableAdapterManager1.GroupsTableAdapter = null;
            this.tableAdapterManager1.PeoplesCheckingTableAdapter = null;
            this.tableAdapterManager1.TypeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Conversion.Church_FinancesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VendorsTableAdapter = null;
            // 
            // cKCUCheckingDataGridView
            // 
            this.cKCUCheckingDataGridView.AutoGenerateColumns = false;
            this.cKCUCheckingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cKCUCheckingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.cKCUCheckingDataGridView.DataSource = this.cKCUCheckingBindingSource1;
            this.cKCUCheckingDataGridView.Location = new System.Drawing.Point(36, 177);
            this.cKCUCheckingDataGridView.Name = "cKCUCheckingDataGridView";
            this.cKCUCheckingDataGridView.Size = new System.Drawing.Size(769, 220);
            this.cKCUCheckingDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ChkID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ChkID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ChkDesc";
            this.dataGridViewTextBoxColumn4.HeaderText = "ChkDesc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ChkPymt";
            this.dataGridViewTextBoxColumn5.HeaderText = "ChkPymt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ChkDep";
            this.dataGridViewTextBoxColumn6.HeaderText = "ChkDep";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ChkBalance";
            this.dataGridViewTextBoxColumn7.HeaderText = "ChkBalance";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ChkCat";
            this.dataGridViewTextBoxColumn8.HeaderText = "ChkCat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NewCatID";
            this.dataGridViewTextBoxColumn10.HeaderText = "NewCatID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ChkVendID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ChkVendID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
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
            this.dataGridViewTextBoxColumn13.HeaderText = "ChkBanTransNo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ChkDepImage";
            this.dataGridViewTextBoxColumn14.HeaderText = "ChkDepImage";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 496);
            this.Controls.Add(this.cKCUCheckingDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ezraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUCheckingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.church_FinancesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUCheckingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKCUCheckingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private EzraDataSet ezraDataSet;
        private System.Windows.Forms.BindingSource cKCUCheckingBindingSource;
        private EzraDataSetTableAdapters.CKCUCheckingTableAdapter cKCUCheckingTableAdapter;
        private EzraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Church_FinancesDataSet church_FinancesDataSet;
        private System.Windows.Forms.BindingSource cKCUCheckingBindingSource1;
        private Church_FinancesDataSetTableAdapters.CKCUCheckingTableAdapter cKCUCheckingTableAdapter1;
        private Church_FinancesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView cKCUCheckingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}

