namespace amortization_schedule_calculator.Forms
{
	partial class ConfirmPaymentForm
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
			this.btnMakePayment = new System.Windows.Forms.Button();
			this.btnCancelPayment = new System.Windows.Forms.Button();
			this.lblMainText = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnMakePayment
			// 
			this.btnMakePayment.BackColor = System.Drawing.Color.Tan;
			this.btnMakePayment.Location = new System.Drawing.Point(243, 209);
			this.btnMakePayment.Name = "btnMakePayment";
			this.btnMakePayment.Size = new System.Drawing.Size(125, 58);
			this.btnMakePayment.TabIndex = 35;
			this.btnMakePayment.Text = "Make Payment";
			this.btnMakePayment.UseVisualStyleBackColor = false;
			this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
			// 
			// btnCancelPayment
			// 
			this.btnCancelPayment.BackColor = System.Drawing.Color.Tan;
			this.btnCancelPayment.Location = new System.Drawing.Point(48, 209);
			this.btnCancelPayment.Name = "btnCancelPayment";
			this.btnCancelPayment.Size = new System.Drawing.Size(125, 58);
			this.btnCancelPayment.TabIndex = 36;
			this.btnCancelPayment.Text = "Cancel Payment";
			this.btnCancelPayment.UseVisualStyleBackColor = false;
			this.btnCancelPayment.Click += new System.EventHandler(this.btnCancelPayment_Click);
			// 
			// lblMainText
			// 
			this.lblMainText.Location = new System.Drawing.Point(56, 25);
			this.lblMainText.Name = "lblMainText";
			this.lblMainText.Size = new System.Drawing.Size(312, 81);
			this.lblMainText.TabIndex = 37;
			this.lblMainText.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(332, 76);
			this.label1.TabIndex = 38;
			this.label1.Text = "Click \'Cancel Payment\' to cancel the payment.\r\n\r\nClick \'Make Payment\' to replace " +
    "the existing payment\r\nwith the new one.";
			// 
			// ConfirmPaymentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(417, 298);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblMainText);
			this.Controls.Add(this.btnCancelPayment);
			this.Controls.Add(this.btnMakePayment);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ConfirmPaymentForm";
			this.Text = "Confirm Payment";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnMakePayment;
		private System.Windows.Forms.Button btnCancelPayment;
		private System.Windows.Forms.Label lblMainText;
		private System.Windows.Forms.Label label1;
	}
}