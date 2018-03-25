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
            this.dgvCKCUChecking = new System.Windows.Forms.DataGridView();
            this.bndsVendors = new System.Windows.Forms.BindingSource(this.components);
            this.bndsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.taCategories = new Ezra.DataAccess.EzraDataSetTableAdapters.CategoriesTableAdapter();
            this.taVendors = new Ezra.DataAccess.EzraDataSetTableAdapters.VendorsTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCKCUChecking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn14});
            this.dgvCKCUChecking.DataSource = this.bndsCKCUChecking;
            this.dgvCKCUChecking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCKCUChecking.Location = new System.Drawing.Point(0, 25);
            this.dgvCKCUChecking.Name = "dgvCKCUChecking";
            this.dgvCKCUChecking.Size = new System.Drawing.Size(867, 356);
            this.dgvCKCUChecking.TabIndex = 1;
            // 
            // bndsVendors
            // 
            this.bndsVendors.DataMember = "Vendors";
            this.bndsVendors.DataSource = this.dsEzra;
            this.bndsVendors.Sort = "VendName";
            // 
            // bndsCategories
            // 
            this.bndsCategories.DataMember = "Categories";
            this.bndsCategories.DataSource = this.dsEzra;
            this.bndsCategories.Sort = "CatName";
            // 
            // taCategories
            // 
            this.taCategories.ClearBeforeFill = true;
            // 
            // taVendors
            // 
            this.taVendors.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUpdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(52, 22);
            this.tsbUpdate.Text = "Update";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
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
            this.dataGridViewTextBoxColumn11.Width = 125;
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
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ChkPymt";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "ChkPymt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ChkDep";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "ChkDep";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ChkBalance";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.HeaderText = "ChkBalance";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ChkDepNo";
            this.dataGridViewTextBoxColumn12.HeaderText = "ChkDepNo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ChkRec";
            this.dataGridViewCheckBoxColumn1.HeaderText = "ChkRec";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ChkDesc";
            this.dataGridViewTextBoxColumn4.HeaderText = "ChkDesc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ChkMemo";
            this.dataGridViewTextBoxColumn9.HeaderText = "ChkMemo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ChkBanTransNo";
            this.dataGridViewTextBoxColumn13.HeaderText = "ChkBanTransNo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ChkCat";
            this.dataGridViewTextBoxColumn8.HeaderText = "ChkCat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(867, 381);
            this.Controls.Add(this.dgvCKCUChecking);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmReconcile";
            this.Text = "frmReconcile";
            this.Load += new System.EventHandler(this.frmReconcile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEzra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCKCUChecking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCKCUChecking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsCategories)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}