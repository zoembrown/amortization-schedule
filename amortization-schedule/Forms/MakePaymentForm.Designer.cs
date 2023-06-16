namespace amortization_schedule_calculator.Forms
{
    partial class MakePaymentForm
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
			this.lblCalendar = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.lblLoanInfo = new System.Windows.Forms.Label();
			this.lblInstructions = new System.Windows.Forms.Label();
			this.lblPaymentAmount = new System.Windows.Forms.Label();
			this.nupPayment = new System.Windows.Forms.NumericUpDown();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnMakePayment = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nupPayment)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCalendar
			// 
			this.lblCalendar.AutoSize = true;
			this.lblCalendar.Location = new System.Drawing.Point(70, 336);
			this.lblCalendar.Name = "lblCalendar";
			this.lblCalendar.Size = new System.Drawing.Size(124, 19);
			this.lblCalendar.TabIndex = 41;
			this.lblCalendar.Text = "Month of Payment:";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(214, 330);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(311, 26);
			this.dateTimePicker.TabIndex = 40;
			// 
			// lblLoanInfo
			// 
			this.lblLoanInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblLoanInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLoanInfo.Location = new System.Drawing.Point(44, 124);
			this.lblLoanInfo.Name = "lblLoanInfo";
			this.lblLoanInfo.Size = new System.Drawing.Size(502, 128);
			this.lblLoanInfo.TabIndex = 39;
			this.lblLoanInfo.Text = "label1";
			// 
			// lblInstructions
			// 
			this.lblInstructions.AutoSize = true;
			this.lblInstructions.Location = new System.Drawing.Point(102, 88);
			this.lblInstructions.Name = "lblInstructions";
			this.lblInstructions.Size = new System.Drawing.Size(316, 19);
			this.lblInstructions.TabIndex = 38;
			this.lblInstructions.Text = "You want to make a payment on the following loan:";
			// 
			// lblPaymentAmount
			// 
			this.lblPaymentAmount.AutoSize = true;
			this.lblPaymentAmount.Location = new System.Drawing.Point(158, 283);
			this.lblPaymentAmount.Name = "lblPaymentAmount";
			this.lblPaymentAmount.Size = new System.Drawing.Size(115, 19);
			this.lblPaymentAmount.TabIndex = 37;
			this.lblPaymentAmount.Text = "Payment Amount:";
			// 
			// nupPayment
			// 
			this.nupPayment.DecimalPlaces = 2;
			this.nupPayment.Location = new System.Drawing.Point(306, 281);
			this.nupPayment.Name = "nupPayment";
			this.nupPayment.Size = new System.Drawing.Size(131, 26);
			this.nupPayment.TabIndex = 36;
			this.nupPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(218, 30);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(146, 24);
			this.lblTitle.TabIndex = 35;
			this.lblTitle.Text = "Make Payment";
			// 
			// btnMakePayment
			// 
			this.btnMakePayment.BackColor = System.Drawing.Color.Tan;
			this.btnMakePayment.Location = new System.Drawing.Point(117, 388);
			this.btnMakePayment.Name = "btnMakePayment";
			this.btnMakePayment.Size = new System.Drawing.Size(145, 74);
			this.btnMakePayment.TabIndex = 34;
			this.btnMakePayment.Text = "Make Payment";
			this.btnMakePayment.UseVisualStyleBackColor = false;
			this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Tan;
			this.btnCancel.Location = new System.Drawing.Point(332, 388);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(145, 74);
			this.btnCancel.TabIndex = 33;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// MakePaymentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(591, 493);
			this.Controls.Add(this.lblCalendar);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.lblLoanInfo);
			this.Controls.Add(this.lblInstructions);
			this.Controls.Add(this.lblPaymentAmount);
			this.Controls.Add(this.nupPayment);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnMakePayment);
			this.Controls.Add(this.btnCancel);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MakePaymentForm";
			this.Text = "MakePaymentForm";
			((System.ComponentModel.ISupportInitialize)(this.nupPayment)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblLoanInfo;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.NumericUpDown nupPayment;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Button btnCancel;
    }
}