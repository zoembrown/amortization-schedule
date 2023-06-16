namespace amortization_schedule_calculator
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
            System.Windows.Forms.TabControl TabControl;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.loanEditorPage = new System.Windows.Forms.TabPage();
            this.btnDeleteLoan = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnNewLoan = new System.Windows.Forms.Button();
            this.loanDataGrid = new System.Windows.Forms.DataGridView();
            this.amortizationTablesPage = new System.Windows.Forms.TabPage();
            this.lstBxSelectLoan = new System.Windows.Forms.ListBox();
            this.whatIfPage = new System.Windows.Forms.TabPage();
            TabControl = new System.Windows.Forms.TabControl();
            TabControl.SuspendLayout();
            this.loanEditorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanDataGrid)).BeginInit();
            this.amortizationTablesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(417, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(311, 24);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Amortization Schedule Calculator";
            // 
            // TabControl
            // 
            TabControl.Controls.Add(this.loanEditorPage);
            TabControl.Controls.Add(this.amortizationTablesPage);
            TabControl.Controls.Add(this.whatIfPage);
            TabControl.Location = new System.Drawing.Point(25, 81);
            TabControl.Margin = new System.Windows.Forms.Padding(4);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new System.Drawing.Size(1130, 595);
            TabControl.TabIndex = 3;
            // 
            // loanEditorPage
            // 
            this.loanEditorPage.BackColor = System.Drawing.Color.Tan;
            this.loanEditorPage.Controls.Add(this.btnDeleteLoan);
            this.loanEditorPage.Controls.Add(this.btnPayment);
            this.loanEditorPage.Controls.Add(this.btnNewLoan);
            this.loanEditorPage.Controls.Add(this.loanDataGrid);
            this.loanEditorPage.Location = new System.Drawing.Point(4, 28);
            this.loanEditorPage.Margin = new System.Windows.Forms.Padding(4);
            this.loanEditorPage.Name = "loanEditorPage";
            this.loanEditorPage.Padding = new System.Windows.Forms.Padding(4);
            this.loanEditorPage.Size = new System.Drawing.Size(1122, 563);
            this.loanEditorPage.TabIndex = 0;
            this.loanEditorPage.Text = "Edit Loan List";
            // 
            // btnDeleteLoan
            // 
            this.btnDeleteLoan.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteLoan.Location = new System.Drawing.Point(761, 453);
            this.btnDeleteLoan.Name = "btnDeleteLoan";
            this.btnDeleteLoan.Size = new System.Drawing.Size(219, 61);
            this.btnDeleteLoan.TabIndex = 4;
            this.btnDeleteLoan.Text = "Delete Loan";
            this.btnDeleteLoan.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPayment.Location = new System.Drawing.Point(451, 453);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(219, 61);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnNewLoan
            // 
            this.btnNewLoan.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNewLoan.Location = new System.Drawing.Point(141, 453);
            this.btnNewLoan.Name = "btnNewLoan";
            this.btnNewLoan.Size = new System.Drawing.Size(219, 61);
            this.btnNewLoan.TabIndex = 2;
            this.btnNewLoan.Text = "Add Loan";
            this.btnNewLoan.UseVisualStyleBackColor = false;
            // 
            // loanDataGrid
            // 
            this.loanDataGrid.AllowUserToAddRows = false;
            this.loanDataGrid.AllowUserToDeleteRows = false;
            this.loanDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loanDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.loanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.loanDataGrid.Location = new System.Drawing.Point(34, 31);
            this.loanDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.loanDataGrid.MultiSelect = false;
            this.loanDataGrid.Name = "loanDataGrid";
            this.loanDataGrid.ReadOnly = true;
            dataGridViewCellStyle1.NullValue = null;
            this.loanDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.loanDataGrid.Size = new System.Drawing.Size(1052, 389);
            this.loanDataGrid.TabIndex = 1;
            // 
            // amortizationTablesPage
            // 
            this.amortizationTablesPage.BackColor = System.Drawing.Color.Tan;
            this.amortizationTablesPage.Controls.Add(this.lstBxSelectLoan);
            this.amortizationTablesPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.amortizationTablesPage.Location = new System.Drawing.Point(4, 28);
            this.amortizationTablesPage.Margin = new System.Windows.Forms.Padding(4);
            this.amortizationTablesPage.Name = "amortizationTablesPage";
            this.amortizationTablesPage.Padding = new System.Windows.Forms.Padding(4);
            this.amortizationTablesPage.Size = new System.Drawing.Size(1122, 563);
            this.amortizationTablesPage.TabIndex = 1;
            this.amortizationTablesPage.Text = "Amortization Tables";
            // 
            // lstBxSelectLoan
            // 
            this.lstBxSelectLoan.FormattingEnabled = true;
            this.lstBxSelectLoan.ItemHeight = 19;
            this.lstBxSelectLoan.Location = new System.Drawing.Point(19, 21);
            this.lstBxSelectLoan.Name = "lstBxSelectLoan";
            this.lstBxSelectLoan.Size = new System.Drawing.Size(246, 422);
            this.lstBxSelectLoan.TabIndex = 0;
            // 
            // whatIfPage
            // 
            this.whatIfPage.BackColor = System.Drawing.Color.Tan;
            this.whatIfPage.Location = new System.Drawing.Point(4, 28);
            this.whatIfPage.Name = "whatIfPage";
            this.whatIfPage.Padding = new System.Windows.Forms.Padding(3);
            this.whatIfPage.Size = new System.Drawing.Size(1122, 563);
            this.whatIfPage.TabIndex = 2;
            this.whatIfPage.Text = "What If?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1181, 700);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(TabControl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Amortiztion Schedule Calculator";
            TabControl.ResumeLayout(false);
            this.loanEditorPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loanDataGrid)).EndInit();
            this.amortizationTablesPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage loanEditorPage;
        private System.Windows.Forms.Button btnDeleteLoan;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnNewLoan;
        private System.Windows.Forms.DataGridView loanDataGrid;
        private System.Windows.Forms.TabPage amortizationTablesPage;
        private System.Windows.Forms.ListBox lstBxSelectLoan;
        private System.Windows.Forms.TabPage whatIfPage;
    }
}

