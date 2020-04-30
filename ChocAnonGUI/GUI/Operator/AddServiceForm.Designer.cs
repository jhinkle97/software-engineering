namespace ChocAnonGUI.GUI.Operator
{
    partial class AddServiceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.servicenameLabel = new System.Windows.Forms.Label();
            this.servicefeeLabel = new System.Windows.Forms.Label();
            this.servicenameTextbox = new System.Windows.Forms.TextBox();
            this.addserviceButton = new System.Windows.Forms.Button();
            this.costTextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Service Menu";
            // 
            // servicenameLabel
            // 
            this.servicenameLabel.AutoSize = true;
            this.servicenameLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicenameLabel.Location = new System.Drawing.Point(6, 60);
            this.servicenameLabel.Name = "servicenameLabel";
            this.servicenameLabel.Size = new System.Drawing.Size(95, 16);
            this.servicenameLabel.TabIndex = 1;
            this.servicenameLabel.Text = "Service Name: ";
            // 
            // servicefeeLabel
            // 
            this.servicefeeLabel.AutoSize = true;
            this.servicefeeLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicefeeLabel.Location = new System.Drawing.Point(8, 92);
            this.servicefeeLabel.Name = "servicefeeLabel";
            this.servicefeeLabel.Size = new System.Drawing.Size(79, 16);
            this.servicefeeLabel.TabIndex = 2;
            this.servicefeeLabel.Text = "Service Fee:";
            // 
            // servicenameTextbox
            // 
            this.servicenameTextbox.Location = new System.Drawing.Point(98, 60);
            this.servicenameTextbox.MaxLength = 20;
            this.servicenameTextbox.Name = "servicenameTextbox";
            this.servicenameTextbox.Size = new System.Drawing.Size(146, 20);
            this.servicenameTextbox.TabIndex = 3;
            // 
            // addserviceButton
            // 
            this.addserviceButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addserviceButton.Location = new System.Drawing.Point(9, 125);
            this.addserviceButton.Name = "addserviceButton";
            this.addserviceButton.Size = new System.Drawing.Size(235, 48);
            this.addserviceButton.TabIndex = 5;
            this.addserviceButton.Text = "Add New Service";
            this.addserviceButton.UseVisualStyleBackColor = true;
            // 
            // costTextbox
            // 
            this.costTextbox.Location = new System.Drawing.Point(98, 91);
            this.costTextbox.Name = "costTextbox";
            this.costTextbox.Size = new System.Drawing.Size(146, 20);
            this.costTextbox.TabIndex = 6;
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 185);
            this.Controls.Add(this.costTextbox);
            this.Controls.Add(this.addserviceButton);
            this.Controls.Add(this.servicenameTextbox);
            this.Controls.Add(this.servicefeeLabel);
            this.Controls.Add(this.servicenameLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Service";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label servicenameLabel;
        private System.Windows.Forms.Label servicefeeLabel;
        private System.Windows.Forms.TextBox servicenameTextbox;
        private System.Windows.Forms.Button addserviceButton;
        private System.Windows.Forms.TextBox costTextbox;
    }
}