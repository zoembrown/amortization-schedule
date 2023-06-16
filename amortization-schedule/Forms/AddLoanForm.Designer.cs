namespace amortization_schedule_calculator.Forms
{
    partial class AddLoanForm
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblDate = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.btnAddLoan = new System.Windows.Forms.Button();
			this.txtBxDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblCreditor = new System.Windows.Forms.Label();
			this.txtBxCreditor = new System.Windows.Forms.TextBox();
			this.lblYears = new System.Windows.Forms.Label();
			this.nupPaymentPeriod = new System.Windows.Forms.NumericUpDown();
			this.lblDollarSign = new System.Windows.Forms.Label();
			this.lblPercent = new System.Windows.Forms.Label();
			this.nupInterest = new System.Windows.Forms.NumericUpDown();
			this.nupInitialValue = new System.Windows.Forms.NumericUpDown();
			this.lblPaymentPeriod = new System.Windows.Forms.Label();
			this.lblInterest = new System.Windows.Forms.Label();
			this.lblInitialValue = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nupPaymentPeriod)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupInterest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupInitialValue)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Tan;
			this.btnCancel.Location = new System.Drawing.Point(421, 423);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(125, 55);
			this.btnCancel.TabIndex = 40;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(455, 125);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(263, 19);
			this.lblDate.TabIndex = 39;
			this.lblDate.Text = "Choose the day you borrowed the money.";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(459, 161);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(275, 26);
			this.dateTimePicker.TabIndex = 38;
			// 
			// btnAddLoan
			// 
			this.btnAddLoan.BackColor = System.Drawing.Color.Tan;
			this.btnAddLoan.Location = new System.Drawing.Point(221, 423);
			this.btnAddLoan.Name = "btnAddLoan";
			this.btnAddLoan.Size = new System.Drawing.Size(125, 55);
			this.btnAddLoan.TabIndex = 37;
			this.btnAddLoan.Text = "Add Loan";
			this.btnAddLoan.UseVisualStyleBackColor = false;
			this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
			// 
			// txtBxDescription
			// 
			this.txtBxDescription.Location = new System.Drawing.Point(232, 336);
			this.txtBxDescription.Name = "txtBxDescription";
			this.txtBxDescription.Size = new System.Drawing.Size(409, 26);
			this.txtBxDescription.TabIndex = 36;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(126, 341);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(81, 19);
			this.lblDescription.TabIndex = 35;
			this.lblDescription.Text = "Description:";
			// 
			// lblCreditor
			// 
			this.lblCreditor.AutoSize = true;
			this.lblCreditor.Location = new System.Drawing.Point(150, 303);
			this.lblCreditor.Name = "lblCreditor";
			this.lblCreditor.Size = new System.Drawing.Size(63, 19);
			this.lblCreditor.TabIndex = 34;
			this.lblCreditor.Text = "Creditor:";
			// 
			// txtBxCreditor
			// 
			this.txtBxCreditor.Location = new System.Drawing.Point(232, 300);
			this.txtBxCreditor.Name = "txtBxCreditor";
			this.txtBxCreditor.Size = new System.Drawing.Size(409, 26);
			this.txtBxCreditor.TabIndex = 33;
			// 
			// lblYears
			// 
			this.lblYears.AutoSize = true;
			this.lblYears.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYears.Location = new System.Drawing.Point(354, 187);
			this.lblYears.Name = "lblYears";
			this.lblYears.Size = new System.Drawing.Size(49, 21);
			this.lblYears.TabIndex = 32;
			this.lblYears.Text = "years";
			// 
			// nupPaymentPeriod
			// 
			this.nupPaymentPeriod.Location = new System.Drawing.Point(179, 183);
			this.nupPaymentPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nupPaymentPeriod.Name = "nupPaymentPeriod";
			this.nupPaymentPeriod.Size = new System.Drawing.Size(170, 26);
			this.nupPaymentPeriod.TabIndex = 31;
			this.nupPaymentPeriod.Tag = "";
			this.nupPaymentPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nupPaymentPeriod.ThousandsSeparator = true;
			this.nupPaymentPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblDollarSign
			// 
			this.lblDollarSign.AutoSize = true;
			this.lblDollarSign.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDollarSign.Location = new System.Drawing.Point(159, 103);
			this.lblDollarSign.Name = "lblDollarSign";
			this.lblDollarSign.Size = new System.Drawing.Size(19, 21);
			this.lblDollarSign.TabIndex = 30;
			this.lblDollarSign.Text = "$";
			// 
			// lblPercent
			// 
			this.lblPercent.AutoSize = true;
			this.lblPercent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPercent.Location = new System.Drawing.Point(358, 145);
			this.lblPercent.Name = "lblPercent";
			this.lblPercent.Size = new System.Drawing.Size(26, 21);
			this.lblPercent.TabIndex = 29;
			this.lblPercent.Text = "%";
			// 
			// nupInterest
			// 
			this.nupInterest.DecimalPlaces = 2;
			this.nupInterest.Location = new System.Drawing.Point(179, 141);
			this.nupInterest.Name = "nupInterest";
			this.nupInterest.Size = new System.Drawing.Size(170, 26);
			this.nupInterest.TabIndex = 28;
			this.nupInterest.Tag = "";
			this.nupInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nupInterest.ThousandsSeparator = true;
			// 
			// nupInitialValue
			// 
			this.nupInitialValue.DecimalPlaces = 2;
			this.nupInitialValue.Location = new System.Drawing.Point(179, 99);
			this.nupInitialValue.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
			this.nupInitialValue.Name = "nupInitialValue";
			this.nupInitialValue.Size = new System.Drawing.Size(170, 26);
			this.nupInitialValue.TabIndex = 27;
			this.nupInitialValue.Tag = "";
			this.nupInitialValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nupInitialValue.ThousandsSeparator = true;
			// 
			// lblPaymentPeriod
			// 
			this.lblPaymentPeriod.AutoSize = true;
			this.lblPaymentPeriod.Location = new System.Drawing.Point(32, 187);
			this.lblPaymentPeriod.Name = "lblPaymentPeriod";
			this.lblPaymentPeriod.Size = new System.Drawing.Size(108, 19);
			this.lblPaymentPeriod.TabIndex = 26;
			this.lblPaymentPeriod.Text = "Payment Period:";
			// 
			// lblInterest
			// 
			this.lblInterest.AutoSize = true;
			this.lblInterest.Location = new System.Drawing.Point(53, 145);
			this.lblInterest.Name = "lblInterest";
			this.lblInterest.Size = new System.Drawing.Size(89, 19);
			this.lblInterest.TabIndex = 25;
			this.lblInterest.Text = "Interest Rate:";
			// 
			// lblInitialValue
			// 
			this.lblInitialValue.AutoSize = true;
			this.lblInitialValue.Location = new System.Drawing.Point(62, 103);
			this.lblInitialValue.Name = "lblInitialValue";
			this.lblInitialValue.Size = new System.Drawing.Size(81, 19);
			this.lblInitialValue.TabIndex = 24;
			this.lblInitialValue.Text = "Initial Value:";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(303, 41);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(160, 24);
			this.lblTitle.TabIndex = 23;
			this.lblTitle.Text = "Add a New Loan";
			// 
			// AddLoanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(766, 518);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.btnAddLoan);
			this.Controls.Add(this.txtBxDescription);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblCreditor);
			this.Controls.Add(this.txtBxCreditor);
			this.Controls.Add(this.lblYears);
			this.Controls.Add(this.nupPaymentPeriod);
			this.Controls.Add(this.lblDollarSign);
			this.Controls.Add(this.lblPercent);
			this.Controls.Add(this.nupInterest);
			this.Controls.Add(this.nupInitialValue);
			this.Controls.Add(this.lblPaymentPeriod);
			this.Controls.Add(this.lblInterest);
			this.Controls.Add(this.lblInitialValue);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddLoanForm";
			this.Text = "Add Loan";
			((System.ComponentModel.ISupportInitialize)(this.nupPaymentPeriod)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupInterest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupInitialValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.TextBox txtBxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCreditor;
        private System.Windows.Forms.TextBox txtBxCreditor;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.NumericUpDown nupPaymentPeriod;
        private System.Windows.Forms.Label lblDollarSign;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.NumericUpDown nupInterest;
        private System.Windows.Forms.NumericUpDown nupInitialValue;
        private System.Windows.Forms.Label lblPaymentPeriod;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblInitialValue;
        private System.Windows.Forms.Label lblTitle;
    }
}