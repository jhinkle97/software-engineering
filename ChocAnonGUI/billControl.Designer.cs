namespace ChocAnonGUI
{
    partial class BillControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.billButton = new System.Windows.Forms.Button();
            this.quickviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Billing Panel";
            // 
            // billButton
            // 
            this.billButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.Location = new System.Drawing.Point(20, 155);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(272, 107);
            this.billButton.TabIndex = 1;
            this.billButton.Text = "Bill Member";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // quickviewButton
            // 
            this.quickviewButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickviewButton.Location = new System.Drawing.Point(326, 155);
            this.quickviewButton.Name = "quickviewButton";
            this.quickviewButton.Size = new System.Drawing.Size(272, 107);
            this.quickviewButton.TabIndex = 2;
            this.quickviewButton.Text = "Quickview Member";
            this.quickviewButton.UseVisualStyleBackColor = true;
            this.quickviewButton.Click += new System.EventHandler(this.quickviewButton_Click);
            // 
            // BillControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quickviewButton);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.label1);
            this.Name = "BillControl";
            this.Size = new System.Drawing.Size(620, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Button quickviewButton;
    }
}
