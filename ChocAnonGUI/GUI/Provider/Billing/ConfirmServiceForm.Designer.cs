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
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.prompt3 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.providerLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printmemberLabel = new System.Windows.Forms.Label();
            this.printserviceLabel = new System.Windows.Forms.Label();
            this.printfeeLabel = new System.Windows.Forms.Label();
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
            this.prompt1Label.Location = new System.Drawing.Point(15, 54);
            this.prompt1Label.Name = "prompt1Label";
            this.prompt1Label.Size = new System.Drawing.Size(108, 15);
            this.prompt1Label.TabIndex = 1;
            this.prompt1Label.Text = "Provider Name:";
            // 
            // prompt2Label
            // 
            this.prompt2Label.AutoSize = true;
            this.prompt2Label.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt2Label.Location = new System.Drawing.Point(14, 145);
            this.prompt2Label.Name = "prompt2Label";
            this.prompt2Label.Size = new System.Drawing.Size(101, 15);
            this.prompt2Label.TabIndex = 2;
            this.prompt2Label.Text = "Service CODE:";
            // 
            // codeTextbox
            // 
            this.codeTextbox.Location = new System.Drawing.Point(86, 182);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(224, 20);
            this.codeTextbox.TabIndex = 3;
            // 
            // prompt3
            // 
            this.prompt3.AutoSize = true;
            this.prompt3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt3.Location = new System.Drawing.Point(15, 167);
            this.prompt3.Name = "prompt3";
            this.prompt3.Size = new System.Drawing.Size(65, 45);
            this.prompt3.TabIndex = 4;
            this.prompt3.Text = "Re-Enter \r\nService\r\nCode ";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(18, 218);
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
            this.cancelButton.Location = new System.Drawing.Point(174, 218);
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
            this.providerLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerLabel.Location = new System.Drawing.Point(123, 53);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(174, 16);
            this.providerLabel.TabIndex = 7;
            this.providerLabel.Text = "Here is where the name goes";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabel.Location = new System.Drawing.Point(113, 142);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(185, 16);
            this.serviceLabel.TabIndex = 8;
            this.serviceLabel.Text = "Here is where the service code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Member Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Service Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Service Fee:";
            // 
            // printmemberLabel
            // 
            this.printmemberLabel.AutoSize = true;
            this.printmemberLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printmemberLabel.Location = new System.Drawing.Point(123, 75);
            this.printmemberLabel.Name = "printmemberLabel";
            this.printmemberLabel.Size = new System.Drawing.Size(116, 16);
            this.printmemberLabel.TabIndex = 12;
            this.printmemberLabel.Text = "printMemberLabel";
            // 
            // printserviceLabel
            // 
            this.printserviceLabel.AutoSize = true;
            this.printserviceLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printserviceLabel.Location = new System.Drawing.Point(114, 98);
            this.printserviceLabel.Name = "printserviceLabel";
            this.printserviceLabel.Size = new System.Drawing.Size(88, 16);
            this.printserviceLabel.TabIndex = 13;
            this.printserviceLabel.Text = "Service Name";
            // 
            // printfeeLabel
            // 
            this.printfeeLabel.AutoSize = true;
            this.printfeeLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printfeeLabel.Location = new System.Drawing.Point(107, 121);
            this.printfeeLabel.Name = "printfeeLabel";
            this.printfeeLabel.Size = new System.Drawing.Size(72, 16);
            this.printfeeLabel.TabIndex = 14;
            this.printfeeLabel.Text = "Fee Output";
            // 
            // ConfirmServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 266);
            this.Controls.Add(this.printfeeLabel);
            this.Controls.Add(this.printserviceLabel);
            this.Controls.Add(this.printmemberLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.providerLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.prompt3);
            this.Controls.Add(this.codeTextbox);
            this.Controls.Add(this.prompt2Label);
            this.Controls.Add(this.prompt1Label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfirmServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prompt1Label;
        private System.Windows.Forms.Label prompt2Label;
        private System.Windows.Forms.TextBox codeTextbox;
        private System.Windows.Forms.Label prompt3;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label providerLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label printmemberLabel;
        private System.Windows.Forms.Label printserviceLabel;
        private System.Windows.Forms.Label printfeeLabel;
    }
}