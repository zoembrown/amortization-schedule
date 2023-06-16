namespace amortization_schedule_calculator.Forms
{
	partial class LoanSelectForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.loanDataGrid = new System.Windows.Forms.DataGridView();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnSelectLoan = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.loanDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// loanDataGrid
			// 
			this.loanDataGrid.AllowUserToAddRows = false;
			this.loanDataGrid.AllowUserToDeleteRows = false;
			this.loanDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.loanDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.loanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.loanDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.loanDataGrid.Location = new System.Drawing.Point(63, 98);
			this.loanDataGrid.Margin = new System.Windows.Forms.Padding(4);
			this.loanDataGrid.MultiSelect = false;
			this.loanDataGrid.Name = "loanDataGrid";
			this.loanDataGrid.ReadOnly = true;
			dataGridViewCellStyle1.NullValue = null;
			this.loanDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.loanDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.loanDataGrid.Size = new System.Drawing.Size(884, 365);
			this.loanDataGrid.TabIndex = 2;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(445, 32);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(121, 22);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "Select a Loan";
			// 
			// btnSelectLoan
			// 
			this.btnSelectLoan.BackColor = System.Drawing.Color.Tan;
			this.btnSelectLoan.Location = new System.Drawing.Point(285, 510);
			this.btnSelectLoan.Name = "btnSelectLoan";
			this.btnSelectLoan.Size = new System.Drawing.Size(150, 66);
			this.btnSelectLoan.TabIndex = 38;
			this.btnSelectLoan.Text = "Select Loan";
			this.btnSelectLoan.UseVisualStyleBackColor = false;
			this.btnSelectLoan.Click += new System.EventHandler(this.btnSelectLoan_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Tan;
			this.btnCancel.Location = new System.Drawing.Point(576, 510);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(150, 66);
			this.btnCancel.TabIndex = 39;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// LoanSelectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1011, 618);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSelectLoan);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.loanDataGrid);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "LoanSelectForm";
			this.Text = "LoanSelectForm";
			((System.ComponentModel.ISupportInitialize)(this.loanDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView loanDataGrid;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnSelectLoan;
		private System.Windows.Forms.Button btnCancel;
	}
}