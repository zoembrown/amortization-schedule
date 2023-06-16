namespace amortization_schedule_calculator.Forms
{
    partial class PaymentHistoryForm
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
			this.PaymentHistoryDataGrid = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblLoanInfo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PaymentHistoryDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// PaymentHistoryDataGrid
			// 
			this.PaymentHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PaymentHistoryDataGrid.Location = new System.Drawing.Point(36, 159);
			this.PaymentHistoryDataGrid.Name = "PaymentHistoryDataGrid";
			this.PaymentHistoryDataGrid.ReadOnly = true;
			this.PaymentHistoryDataGrid.Size = new System.Drawing.Size(750, 332);
			this.PaymentHistoryDataGrid.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Tan;
			this.btnClose.Location = new System.Drawing.Point(339, 511);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(145, 74);
			this.btnClose.TabIndex = 34;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(338, 22);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(146, 22);
			this.lblTitle.TabIndex = 35;
			this.lblTitle.Text = "Payment History";
			// 
			// lblLoanInfo
			// 
			this.lblLoanInfo.Location = new System.Drawing.Point(195, 53);
			this.lblLoanInfo.Name = "lblLoanInfo";
			this.lblLoanInfo.Size = new System.Drawing.Size(432, 103);
			this.lblLoanInfo.TabIndex = 36;
			this.lblLoanInfo.Text = "label1";
			// 
			// PaymentHistoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(822, 609);
			this.Controls.Add(this.lblLoanInfo);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.PaymentHistoryDataGrid);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PaymentHistoryForm";
			this.Text = "PaymentHistory";
			((System.ComponentModel.ISupportInitialize)(this.PaymentHistoryDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PaymentHistoryDataGrid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoanInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
		//private App_Data.AmortizationDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
	}
}