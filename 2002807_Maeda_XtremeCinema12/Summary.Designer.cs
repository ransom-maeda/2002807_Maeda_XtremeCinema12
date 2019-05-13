namespace _2002807_Maeda_XtremeCinema12
{
    partial class Summary
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
            this.labelCustomer = new System.Windows.Forms.Label();
            this.amountOutput = new System.Windows.Forms.TextBox();
            this.sumOutput = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(13, 13);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(113, 13);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Amount of Customers: ";
            // 
            // amountOutput
            // 
            this.amountOutput.Location = new System.Drawing.Point(132, 10);
            this.amountOutput.Name = "amountOutput";
            this.amountOutput.Size = new System.Drawing.Size(100, 20);
            this.amountOutput.TabIndex = 1;
            // 
            // sumOutput
            // 
            this.sumOutput.Location = new System.Drawing.Point(132, 36);
            this.sumOutput.Name = "sumOutput";
            this.sumOutput.Size = new System.Drawing.Size(100, 20);
            this.sumOutput.TabIndex = 3;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(13, 39);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(65, 13);
            this.labelSum.TabIndex = 2;
            this.labelSum.Text = "Rental Sum:";
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 73);
            this.Controls.Add(this.sumOutput);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.amountOutput);
            this.Controls.Add(this.labelCustomer);
            this.Name = "Summary";
            this.Text = "summary";
            this.Activated += new System.EventHandler(this.Summary_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.TextBox amountOutput;
        private System.Windows.Forms.TextBox sumOutput;
        private System.Windows.Forms.Label labelSum;
    }
}