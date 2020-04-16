namespace ChocAnonGUI
{
    partial class billmemberPanel
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateperfTextbox = new System.Windows.Forms.TextBox();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.servicecodeTextbox = new System.Windows.Forms.TextBox();
            this.directoryButton = new System.Windows.Forms.Button();
            this.commentsTextbox = new System.Windows.Forms.TextBox();
            this.confirmbillButton = new System.Windows.Forms.Button();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(14, 22);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(108, 15);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date Performed";
            // 
            // dateperfTextbox
            // 
            this.dateperfTextbox.Location = new System.Drawing.Point(154, 22);
            this.dateperfTextbox.Name = "dateperfTextbox";
            this.dateperfTextbox.Size = new System.Drawing.Size(195, 20);
            this.dateperfTextbox.TabIndex = 1;
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabel.Location = new System.Drawing.Point(17, 64);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(93, 15);
            this.serviceLabel.TabIndex = 2;
            this.serviceLabel.Text = "Service Code:";
            // 
            // servicecodeTextbox
            // 
            this.servicecodeTextbox.Location = new System.Drawing.Point(154, 63);
            this.servicecodeTextbox.Name = "servicecodeTextbox";
            this.servicecodeTextbox.Size = new System.Drawing.Size(105, 20);
            this.servicecodeTextbox.TabIndex = 3;
            // 
            // directoryButton
            // 
            this.directoryButton.Location = new System.Drawing.Point(274, 61);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(75, 23);
            this.directoryButton.TabIndex = 4;
            this.directoryButton.Text = "Lookup";
            this.directoryButton.UseVisualStyleBackColor = true;
            this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // commentsTextbox
            // 
            this.commentsTextbox.Location = new System.Drawing.Point(20, 127);
            this.commentsTextbox.Multiline = true;
            this.commentsTextbox.Name = "commentsTextbox";
            this.commentsTextbox.Size = new System.Drawing.Size(329, 126);
            this.commentsTextbox.TabIndex = 5;
            // 
            // confirmbillButton
            // 
            this.confirmbillButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbillButton.Location = new System.Drawing.Point(20, 270);
            this.confirmbillButton.Name = "confirmbillButton";
            this.confirmbillButton.Size = new System.Drawing.Size(329, 55);
            this.confirmbillButton.TabIndex = 6;
            this.confirmbillButton.Text = "Confirm Billing";
            this.confirmbillButton.UseVisualStyleBackColor = true;
            this.confirmbillButton.Click += new System.EventHandler(this.confirmbillButton_Click);
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(116, 99);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(125, 25);
            this.commentsLabel.TabIndex = 7;
            this.commentsLabel.Text = "Comments";
            // 
            // billmemberForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.confirmbillButton);
            this.Controls.Add(this.commentsTextbox);
            this.Controls.Add(this.directoryButton);
            this.Controls.Add(this.servicecodeTextbox);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.dateperfTextbox);
            this.Controls.Add(this.dateLabel);
            this.Name = "billmemberForm2";
            this.Size = new System.Drawing.Size(372, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateperfTextbox;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.TextBox servicecodeTextbox;
        private System.Windows.Forms.Button directoryButton;
        private System.Windows.Forms.TextBox commentsTextbox;
        private System.Windows.Forms.Button confirmbillButton;
        private System.Windows.Forms.Label commentsLabel;
    }
}
