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
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.addserviceButton = new System.Windows.Forms.Button();
            this.feeTextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Service Menu";
            // 
            // servicenameLabel
            // 
            this.servicenameLabel.AutoSize = true;
            this.servicenameLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicenameLabel.Location = new System.Drawing.Point(8, 74);
            this.servicenameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.servicenameLabel.Name = "servicenameLabel";
            this.servicenameLabel.Size = new System.Drawing.Size(127, 20);
            this.servicenameLabel.TabIndex = 1;
            this.servicenameLabel.Text = "Service Name: ";
            // 
            // servicefeeLabel
            // 
            this.servicefeeLabel.AutoSize = true;
            this.servicefeeLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicefeeLabel.Location = new System.Drawing.Point(11, 113);
            this.servicefeeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.servicefeeLabel.Name = "servicefeeLabel";
            this.servicefeeLabel.Size = new System.Drawing.Size(106, 20);
            this.servicefeeLabel.TabIndex = 2;
            this.servicefeeLabel.Text = "Service Fee:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(131, 74);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextbox.MaxLength = 20;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(193, 22);
            this.nameTextbox.TabIndex = 3;
            // 
            // addserviceButton
            // 
            this.addserviceButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addserviceButton.Location = new System.Drawing.Point(12, 154);
            this.addserviceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addserviceButton.Name = "addserviceButton";
            this.addserviceButton.Size = new System.Drawing.Size(313, 59);
            this.addserviceButton.TabIndex = 5;
            this.addserviceButton.Text = "Add New Service";
            this.addserviceButton.UseVisualStyleBackColor = true;
            this.addserviceButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // feeTextbox
            // 
            this.feeTextbox.Location = new System.Drawing.Point(131, 112);
            this.feeTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.feeTextbox.Name = "feeTextbox";
            this.feeTextbox.Size = new System.Drawing.Size(193, 22);
            this.feeTextbox.TabIndex = 6;
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 228);
            this.Controls.Add(this.feeTextbox);
            this.Controls.Add(this.addserviceButton);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.servicefeeLabel);
            this.Controls.Add(this.servicenameLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Button addserviceButton;
        private System.Windows.Forms.TextBox feeTextbox;
    }
}