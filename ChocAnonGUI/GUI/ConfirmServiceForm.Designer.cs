namespace ChocAnonGUI
{
    partial class ConfirmServiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.prompt1Label = new System.Windows.Forms.Label();
            this.prompt2Label = new System.Windows.Forms.Label();
            this.checkvalueTextbox = new System.Windows.Forms.TextBox();
            this.prompt3 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.providerLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Does this look correct???";
            // 
            // prompt1Label
            // 
            this.prompt1Label.AutoSize = true;
            this.prompt1Label.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt1Label.Location = new System.Drawing.Point(12, 66);
            this.prompt1Label.Name = "prompt1Label";
            this.prompt1Label.Size = new System.Drawing.Size(112, 15);
            this.prompt1Label.TabIndex = 1;
            this.prompt1Label.Text = "Provider NAME:";
            // 
            // prompt2Label
            // 
            this.prompt2Label.AutoSize = true;
            this.prompt2Label.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt2Label.Location = new System.Drawing.Point(15, 101);
            this.prompt2Label.Name = "prompt2Label";
            this.prompt2Label.Size = new System.Drawing.Size(101, 15);
            this.prompt2Label.TabIndex = 2;
            this.prompt2Label.Text = "Service CODE:";
            // 
            // checkvalueTextbox
            // 
            this.checkvalueTextbox.Location = new System.Drawing.Point(86, 147);
            this.checkvalueTextbox.Name = "checkvalueTextbox";
            this.checkvalueTextbox.Size = new System.Drawing.Size(224, 20);
            this.checkvalueTextbox.TabIndex = 3;
            // 
            // prompt3
            // 
            this.prompt3.AutoSize = true;
            this.prompt3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt3.Location = new System.Drawing.Point(15, 133);
            this.prompt3.Name = "prompt3";
            this.prompt3.Size = new System.Drawing.Size(65, 45);
            this.prompt3.TabIndex = 4;
            this.prompt3.Text = "Re-Enter \r\nService\r\nCode ";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(18, 207);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(131, 36);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(178, 207);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 36);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerLabel.Location = new System.Drawing.Point(130, 67);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(145, 13);
            this.providerLabel.TabIndex = 7;
            this.providerLabel.Text = "Here is where the name goes";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabel.Location = new System.Drawing.Point(109, 101);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(219, 13);
            this.serviceLabel.TabIndex = 8;
            this.serviceLabel.Text = "Here is where the service code entered goes";
            // 
            // ConfirmServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 266);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.providerLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.prompt3);
            this.Controls.Add(this.checkvalueTextbox);
            this.Controls.Add(this.prompt2Label);
            this.Controls.Add(this.prompt1Label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfirmServiceForm";
            this.Text = "Confirm Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prompt1Label;
        private System.Windows.Forms.Label prompt2Label;
        private System.Windows.Forms.TextBox checkvalueTextbox;
        private System.Windows.Forms.Label prompt3;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label providerLabel;
        private System.Windows.Forms.Label serviceLabel;
    }
}