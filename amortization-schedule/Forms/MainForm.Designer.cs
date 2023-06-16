using System.Windows.Forms;
using System.Drawing;

namespace amortization_schedule_calculator.Forms
{
    partial class MainForm
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
			System.Windows.Forms.TabControl TabControl;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.loanEditorPage = new System.Windows.Forms.TabPage();
			this.btnHistory = new System.Windows.Forms.Button();
			this.lblInstructions = new System.Windows.Forms.Label();
			this.btnPayment = new System.Windows.Forms.Button();
			this.btnNewLoan = new System.Windows.Forms.Button();
			this.loanDataGrid = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.creditorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountBorrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.interestRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateBorrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loansBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.amortizationDBDataSet = new amortization_schedule_calculator.App_Data.AmortizationDBDataSet();
			this.amortizationTablesPage = new System.Windows.Forms.TabPage();
			this.lblLoanInfo = new System.Windows.Forms.Label();
			this.grpBxPaymentAmount = new System.Windows.Forms.GroupBox();
			this.lblCustomPayment = new System.Windows.Forms.Label();
			this.nupCustomPayment = new System.Windows.Forms.NumericUpDown();
			this.chkBxMinimumPayment = new System.Windows.Forms.CheckBox();
			this.grpBxShowHistory = new System.Windows.Forms.GroupBox();
			this.radBtnNoShowPast = new System.Windows.Forms.RadioButton();
			this.radBtnShowPast = new System.Windows.Forms.RadioButton();
			this.amortizationTableDataGrid = new System.Windows.Forms.DataGridView();
			this.btnCalculateTable = new System.Windows.Forms.Button();
			this.btnChooseLoan = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.loansTableAdapter = new amortization_schedule_calculator.App_Data.AmortizationDBDataSetTableAdapters.LoansTableAdapter();
			TabControl = new System.Windows.Forms.TabControl();
			TabControl.SuspendLayout();
			this.loanEditorPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.loanDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.amortizationDBDataSet)).BeginInit();
			this.amortizationTablesPage.SuspendLayout();
			this.grpBxPaymentAmount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupCustomPayment)).BeginInit();
			this.grpBxShowHistory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.amortizationTableDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// TabControl
			// 
			TabControl.Controls.Add(this.loanEditorPage);
			TabControl.Controls.Add(this.amortizationTablesPage);
			TabControl.Location = new System.Drawing.Point(25, 81);
			TabControl.Margin = new System.Windows.Forms.Padding(4);
			TabControl.Name = "TabControl";
			TabControl.SelectedIndex = 0;
			TabControl.Size = new System.Drawing.Size(1130, 691);
			TabControl.TabIndex = 3;
			// 
			// loanEditorPage
			// 
			this.loanEditorPage.BackColor = System.Drawing.Color.Tan;
			this.loanEditorPage.Controls.Add(this.btnHistory);
			this.loanEditorPage.Controls.Add(this.lblInstructions);
			this.loanEditorPage.Controls.Add(this.btnPayment);
			this.loanEditorPage.Controls.Add(this.btnNewLoan);
			this.loanEditorPage.Controls.Add(this.loanDataGrid);
			this.loanEditorPage.Location = new System.Drawing.Point(4, 28);
			this.loanEditorPage.Margin = new System.Windows.Forms.Padding(4);
			this.loanEditorPage.Name = "loanEditorPage";
			this.loanEditorPage.Padding = new System.Windows.Forms.Padding(4);
			this.loanEditorPage.Size = new System.Drawing.Size(1122, 659);
			this.loanEditorPage.TabIndex = 0;
			this.loanEditorPage.Text = "Edit Loan List";
			// 
			// btnHistory
			// 
			this.btnHistory.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnHistory.Location = new System.Drawing.Point(721, 566);
			this.btnHistory.Name = "btnHistory";
			this.btnHistory.Size = new System.Drawing.Size(219, 61);
			this.btnHistory.TabIndex = 6;
			this.btnHistory.Text = "Payment History";
			this.btnHistory.UseVisualStyleBackColor = false;
			this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
			// 
			// lblInstructions
			// 
			this.lblInstructions.AutoSize = true;
			this.lblInstructions.Location = new System.Drawing.Point(253, 21);
			this.lblInstructions.Name = "lblInstructions";
			this.lblInstructions.Size = new System.Drawing.Size(616, 57);
			this.lblInstructions.TabIndex = 5;
			this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
			// 
			// btnPayment
			// 
			this.btnPayment.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnPayment.Location = new System.Drawing.Point(452, 566);
			this.btnPayment.Name = "btnPayment";
			this.btnPayment.Size = new System.Drawing.Size(219, 61);
			this.btnPayment.TabIndex = 3;
			this.btnPayment.Text = "Make Payment";
			this.btnPayment.UseVisualStyleBackColor = false;
			this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
			// 
			// btnNewLoan
			// 
			this.btnNewLoan.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnNewLoan.Location = new System.Drawing.Point(183, 566);
			this.btnNewLoan.Name = "btnNewLoan";
			this.btnNewLoan.Size = new System.Drawing.Size(219, 61);
			this.btnNewLoan.TabIndex = 2;
			this.btnNewLoan.Text = "Add Loan";
			this.btnNewLoan.UseVisualStyleBackColor = false;
			this.btnNewLoan.Click += new System.EventHandler(this.btnNewLoan_Click);
			// 
			// loanDataGrid
			// 
			this.loanDataGrid.AllowUserToAddRows = false;
			this.loanDataGrid.AllowUserToDeleteRows = false;
			this.loanDataGrid.AutoGenerateColumns = false;
			this.loanDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.loanDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.loanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.loanDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.creditorDataGridViewTextBoxColumn,
            this.amountBorrowedDataGridViewTextBoxColumn,
            this.interestRateDataGridViewTextBoxColumn,
            this.dateBorrowedDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.paymentPeriodDataGridViewTextBoxColumn});
			this.loanDataGrid.DataSource = this.loansBindingSource;
			this.loanDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.loanDataGrid.Location = new System.Drawing.Point(36, 120);
			this.loanDataGrid.Margin = new System.Windows.Forms.Padding(4);
			this.loanDataGrid.MultiSelect = false;
			this.loanDataGrid.Name = "loanDataGrid";
			this.loanDataGrid.ReadOnly = true;
			dataGridViewCellStyle1.NullValue = null;
			this.loanDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.loanDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.loanDataGrid.Size = new System.Drawing.Size(1052, 424);
			this.loanDataGrid.TabIndex = 1;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// creditorDataGridViewTextBoxColumn
			// 
			this.creditorDataGridViewTextBoxColumn.DataPropertyName = "Creditor";
			this.creditorDataGridViewTextBoxColumn.HeaderText = "Creditor";
			this.creditorDataGridViewTextBoxColumn.Name = "creditorDataGridViewTextBoxColumn";
			this.creditorDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// amountBorrowedDataGridViewTextBoxColumn
			// 
			this.amountBorrowedDataGridViewTextBoxColumn.DataPropertyName = "AmountBorrowed";
			this.amountBorrowedDataGridViewTextBoxColumn.HeaderText = "AmountBorrowed";
			this.amountBorrowedDataGridViewTextBoxColumn.Name = "amountBorrowedDataGridViewTextBoxColumn";
			this.amountBorrowedDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// interestRateDataGridViewTextBoxColumn
			// 
			this.interestRateDataGridViewTextBoxColumn.DataPropertyName = "InterestRate";
			this.interestRateDataGridViewTextBoxColumn.HeaderText = "InterestRate";
			this.interestRateDataGridViewTextBoxColumn.Name = "interestRateDataGridViewTextBoxColumn";
			this.interestRateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dateBorrowedDataGridViewTextBoxColumn
			// 
			this.dateBorrowedDataGridViewTextBoxColumn.DataPropertyName = "DateBorrowed";
			this.dateBorrowedDataGridViewTextBoxColumn.HeaderText = "DateBorrowed";
			this.dateBorrowedDataGridViewTextBoxColumn.Name = "dateBorrowedDataGridViewTextBoxColumn";
			this.dateBorrowedDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// paymentPeriodDataGridViewTextBoxColumn
			// 
			this.paymentPeriodDataGridViewTextBoxColumn.DataPropertyName = "PaymentPeriod";
			this.paymentPeriodDataGridViewTextBoxColumn.HeaderText = "PaymentPeriod";
			this.paymentPeriodDataGridViewTextBoxColumn.Name = "paymentPeriodDataGridViewTextBoxColumn";
			this.paymentPeriodDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// loansBindingSource
			// 
			this.loansBindingSource.DataMember = "Loans";
			this.loansBindingSource.DataSource = this.amortizationDBDataSet;
			// 
			// amortizationDBDataSet
			// 
			this.amortizationDBDataSet.DataSetName = "AmortizationDBDataSet";
			this.amortizationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// amortizationTablesPage
			// 
			this.amortizationTablesPage.BackColor = System.Drawing.Color.Tan;
			this.amortizationTablesPage.Controls.Add(this.lblLoanInfo);
			this.amortizationTablesPage.Controls.Add(this.grpBxPaymentAmount);
			this.amortizationTablesPage.Controls.Add(this.grpBxShowHistory);
			this.amortizationTablesPage.Controls.Add(this.amortizationTableDataGrid);
			this.amortizationTablesPage.Controls.Add(this.btnCalculateTable);
			this.amortizationTablesPage.Controls.Add(this.btnChooseLoan);
			this.amortizationTablesPage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.amortizationTablesPage.Location = new System.Drawing.Point(4, 28);
			this.amortizationTablesPage.Margin = new System.Windows.Forms.Padding(4);
			this.amortizationTablesPage.Name = "amortizationTablesPage";
			this.amortizationTablesPage.Padding = new System.Windows.Forms.Padding(4);
			this.amortizationTablesPage.Size = new System.Drawing.Size(1122, 659);
			this.amortizationTablesPage.TabIndex = 1;
			this.amortizationTablesPage.Text = "Amortization Tables";
			// 
			// lblLoanInfo
			// 
			this.lblLoanInfo.AutoSize = true;
			this.lblLoanInfo.Location = new System.Drawing.Point(25, 18);
			this.lblLoanInfo.Name = "lblLoanInfo";
			this.lblLoanInfo.Size = new System.Drawing.Size(115, 19);
			this.lblLoanInfo.TabIndex = 11;
			this.lblLoanInfo.Text = "No loan selected.";
			// 
			// grpBxPaymentAmount
			// 
			this.grpBxPaymentAmount.Controls.Add(this.lblCustomPayment);
			this.grpBxPaymentAmount.Controls.Add(this.nupCustomPayment);
			this.grpBxPaymentAmount.Controls.Add(this.chkBxMinimumPayment);
			this.grpBxPaymentAmount.Location = new System.Drawing.Point(775, 3);
			this.grpBxPaymentAmount.Name = "grpBxPaymentAmount";
			this.grpBxPaymentAmount.Size = new System.Drawing.Size(331, 100);
			this.grpBxPaymentAmount.TabIndex = 10;
			this.grpBxPaymentAmount.TabStop = false;
			this.grpBxPaymentAmount.Text = "Payment Amount";
			this.grpBxPaymentAmount.Visible = false;
			// 
			// lblCustomPayment
			// 
			this.lblCustomPayment.AutoSize = true;
			this.lblCustomPayment.Location = new System.Drawing.Point(6, 73);
			this.lblCustomPayment.Name = "lblCustomPayment";
			this.lblCustomPayment.Size = new System.Drawing.Size(147, 19);
			this.lblCustomPayment.TabIndex = 2;
			this.lblCustomPayment.Text = "Other payment amount";
			this.lblCustomPayment.Visible = false;
			// 
			// nupCustomPayment
			// 
			this.nupCustomPayment.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nupCustomPayment.Location = new System.Drawing.Point(159, 69);
			this.nupCustomPayment.Name = "nupCustomPayment";
			this.nupCustomPayment.Size = new System.Drawing.Size(158, 26);
			this.nupCustomPayment.TabIndex = 1;
			this.nupCustomPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nupCustomPayment.Visible = false;
			// 
			// chkBxMinimumPayment
			// 
			this.chkBxMinimumPayment.AutoSize = true;
			this.chkBxMinimumPayment.Checked = true;
			this.chkBxMinimumPayment.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkBxMinimumPayment.Location = new System.Drawing.Point(10, 22);
			this.chkBxMinimumPayment.Name = "chkBxMinimumPayment";
			this.chkBxMinimumPayment.Size = new System.Drawing.Size(308, 42);
			this.chkBxMinimumPayment.TabIndex = 0;
			this.chkBxMinimumPayment.Text = "Make minimum payments \r\n(Uncheck this box to change payment amount)";
			this.chkBxMinimumPayment.UseVisualStyleBackColor = true;
			this.chkBxMinimumPayment.CheckedChanged += new System.EventHandler(this.chkBxMinimumPayment_CheckedChanged);
			// 
			// grpBxShowHistory
			// 
			this.grpBxShowHistory.Controls.Add(this.radBtnNoShowPast);
			this.grpBxShowHistory.Controls.Add(this.radBtnShowPast);
			this.grpBxShowHistory.Location = new System.Drawing.Point(428, 3);
			this.grpBxShowHistory.Name = "grpBxShowHistory";
			this.grpBxShowHistory.Size = new System.Drawing.Size(331, 100);
			this.grpBxShowHistory.TabIndex = 9;
			this.grpBxShowHistory.TabStop = false;
			this.grpBxShowHistory.Text = "Show Past Payments";
			this.grpBxShowHistory.Visible = false;
			// 
			// radBtnNoShowPast
			// 
			this.radBtnNoShowPast.AutoSize = true;
			this.radBtnNoShowPast.Location = new System.Drawing.Point(10, 59);
			this.radBtnNoShowPast.Name = "radBtnNoShowPast";
			this.radBtnNoShowPast.Size = new System.Drawing.Size(193, 23);
			this.radBtnNoShowPast.TabIndex = 1;
			this.radBtnNoShowPast.TabStop = true;
			this.radBtnNoShowPast.Text = "Show future payments only.\r\n";
			this.radBtnNoShowPast.UseVisualStyleBackColor = true;
			// 
			// radBtnShowPast
			// 
			this.radBtnShowPast.AutoSize = true;
			this.radBtnShowPast.Location = new System.Drawing.Point(10, 25);
			this.radBtnShowPast.Name = "radBtnShowPast";
			this.radBtnShowPast.Size = new System.Drawing.Size(312, 23);
			this.radBtnShowPast.TabIndex = 0;
			this.radBtnShowPast.TabStop = true;
			this.radBtnShowPast.Text = "Include past payments in amortization schedule.";
			this.radBtnShowPast.UseVisualStyleBackColor = true;
			// 
			// amortizationTableDataGrid
			// 
			this.amortizationTableDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.amortizationTableDataGrid.Location = new System.Drawing.Point(29, 109);
			this.amortizationTableDataGrid.Name = "amortizationTableDataGrid";
			this.amortizationTableDataGrid.Size = new System.Drawing.Size(1077, 441);
			this.amortizationTableDataGrid.TabIndex = 8;
			// 
			// btnCalculateTable
			// 
			this.btnCalculateTable.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnCalculateTable.Location = new System.Drawing.Point(612, 569);
			this.btnCalculateTable.Name = "btnCalculateTable";
			this.btnCalculateTable.Size = new System.Drawing.Size(219, 61);
			this.btnCalculateTable.TabIndex = 4;
			this.btnCalculateTable.Text = "Calculate Table";
			this.btnCalculateTable.UseVisualStyleBackColor = false;
			this.btnCalculateTable.Click += new System.EventHandler(this.btnCalculateTable_Click);
			// 
			// btnChooseLoan
			// 
			this.btnChooseLoan.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnChooseLoan.Location = new System.Drawing.Point(251, 569);
			this.btnChooseLoan.Name = "btnChooseLoan";
			this.btnChooseLoan.Size = new System.Drawing.Size(219, 61);
			this.btnChooseLoan.TabIndex = 3;
			this.btnChooseLoan.Text = "Choose Loan";
			this.btnChooseLoan.UseVisualStyleBackColor = false;
			this.btnChooseLoan.Click += new System.EventHandler(this.btnChooseLoan_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(417, 25);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(311, 24);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Amortization Schedule Calculator";
			// 
			// loansTableAdapter
			// 
			this.loansTableAdapter.ClearBeforeFill = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1188, 799);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(TabControl);
			this.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Amortiztion Schedule Calculator";
			TabControl.ResumeLayout(false);
			this.loanEditorPage.ResumeLayout(false);
			this.loanEditorPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.loanDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.amortizationDBDataSet)).EndInit();
			this.amortizationTablesPage.ResumeLayout(false);
			this.amortizationTablesPage.PerformLayout();
			this.grpBxPaymentAmount.ResumeLayout(false);
			this.grpBxPaymentAmount.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupCustomPayment)).EndInit();
			this.grpBxShowHistory.ResumeLayout(false);
			this.grpBxShowHistory.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.amortizationTableDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private App_Data.AmortizationDBDataSet amortizationDBDataSet;
        private BindingSource loansBindingSource;
        private App_Data.AmortizationDBDataSetTableAdapters.LoansTableAdapter loansTableAdapter;
        private DataGridViewTextBoxColumn lastPaymentDateDataGridViewTextBoxColumn;
		private TabPage amortizationTablesPage;
		private Label lblLoanInfo;
		private GroupBox grpBxPaymentAmount;
		private Label lblCustomPayment;
		private NumericUpDown nupCustomPayment;
		private CheckBox chkBxMinimumPayment;
		private GroupBox grpBxShowHistory;
		private RadioButton radBtnNoShowPast;
		private RadioButton radBtnShowPast;
		private DataGridView amortizationTableDataGrid;
		private Button btnCalculateTable;
		private Button btnChooseLoan;
		private TabPage loanEditorPage;
		private Button btnHistory;
		private Label lblInstructions;
		private Button btnPayment;
		private Button btnNewLoan;
		private DataGridView loanDataGrid;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn creditorDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn amountBorrowedDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn interestRateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dateBorrowedDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn paymentPeriodDataGridViewTextBoxColumn;
	}
}

