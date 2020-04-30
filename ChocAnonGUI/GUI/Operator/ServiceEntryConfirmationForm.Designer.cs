namespace ChocAnonGUI.GUI.Operator
{
    partial class ServiceEntryConfirmationForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.serviceCodeLabel = new System.Windows.Forms.Label();
            this.servicenameLabel = new System.Windows.Forms.Label();
            this.servicecostLabel = new System.Windows.Forms.Label();
            this.servicenameTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.servicecodeTextbox = new System.Windows.Forms.TextBox();
            this.servicecostTextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(6, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(268, 19);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Service Entry/Edit Completed";
            // 
            // serviceCodeLabel
            // 
            this.serviceCodeLabel.AutoSize = true;
            this.serviceCodeLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCodeLabel.Location = new System.Drawing.Point(8, 78);
            this.serviceCodeLabel.Name = "serviceCodeLabel";
            this.serviceCodeLabel.Size = new System.Drawing.Size(93, 16);
            this.serviceCodeLabel.TabIndex = 1;
            this.serviceCodeLabel.Text = "Service Code: ";
            // 
            // servicenameLabel
            // 
            this.servicenameLabel.AutoSize = true;
            this.servicenameLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicenameLabel.Location = new System.Drawing.Point(7, 44);
            this.servicenameLabel.Name = "servicenameLabel";
            this.servicenameLabel.Size = new System.Drawing.Size(92, 16);
            this.servicenameLabel.TabIndex = 2;
            this.servicenameLabel.Text = "Service Name:";
            // 
            // servicecostLabel
            // 
            this.servicecostLabel.AutoSize = true;
            this.servicecostLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicecostLabel.Location = new System.Drawing.Point(10, 109);
            this.servicecostLabel.Name = "servicecostLabel";
            this.servicecostLabel.Size = new System.Drawing.Size(85, 16);
            this.servicecostLabel.TabIndex = 3;
            this.servicecostLabel.Text = "Service Cost:";
            // 
            // servicenameTextbox
            // 
            this.servicenameTextbox.Location = new System.Drawing.Point(106, 44);
            this.servicenameTextbox.Name = "servicenameTextbox";
            this.servicenameTextbox.ReadOnly = true;
            this.servicenameTextbox.Size = new System.Drawing.Size(159, 20);
            this.servicenameTextbox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 32);
            this.panel1.TabIndex = 5;
            // 
            // servicecodeTextbox
            // 
            this.servicecodeTextbox.Location = new System.Drawing.Point(106, 77);
            this.servicecodeTextbox.Name = "servicecodeTextbox";
            this.servicecodeTextbox.ReadOnly = true;
            this.servicecodeTextbox.Size = new System.Drawing.Size(159, 20);
            this.servicecodeTextbox.TabIndex = 6;
            // 
            // servicecostTextbox
            // 
            this.servicecostTextbox.Location = new System.Drawing.Point(106, 109);
            this.servicecostTextbox.Name = "servicecostTextbox";
            this.servicecostTextbox.ReadOnly = true;
            this.servicecostTextbox.Size = new System.Drawing.Size(159, 20);
            this.servicecostTextbox.TabIndex = 7;
            // 
            // ServiceEntryConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 141);
            this.Controls.Add(this.servicecostTextbox);
            this.Controls.Add(this.servicecodeTextbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.servicenameTextbox);
            this.Controls.Add(this.servicecostLabel);
            this.Controls.Add(this.servicenameLabel);
            this.Controls.Add(this.serviceCodeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServiceEntryConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Service Confirmation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label serviceCodeLabel;
        private System.Windows.Forms.Label servicenameLabel;
        private System.Windows.Forms.Label servicecostLabel;
        private System.Windows.Forms.TextBox servicenameTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox servicecodeTextbox;
        private System.Windows.Forms.TextBox servicecostTextbox;
    }
}