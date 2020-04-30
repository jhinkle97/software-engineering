namespace ChocAnonGUI.GUI.Operator
{
    partial class EditServiceForm
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
            this.costTextbox = new System.Windows.Forms.TextBox();
            this.serviceeditButton = new System.Windows.Forms.Button();
            this.servicenameTextbox = new System.Windows.Forms.TextBox();
            this.servicefeeLabel = new System.Windows.Forms.Label();
            this.servicenameLabel = new System.Windows.Forms.Label();
            this.searchserviceButton = new System.Windows.Forms.Button();
            this.servicennumberTextbox = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // costTextbox
            // 
            this.costTextbox.Location = new System.Drawing.Point(105, 101);
            this.costTextbox.Name = "costTextbox";
            this.costTextbox.Size = new System.Drawing.Size(163, 20);
            this.costTextbox.TabIndex = 11;
            // 
            // serviceeditButton
            // 
            this.serviceeditButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceeditButton.Location = new System.Drawing.Point(13, 140);
            this.serviceeditButton.Name = "serviceeditButton";
            this.serviceeditButton.Size = new System.Drawing.Size(256, 48);
            this.serviceeditButton.TabIndex = 10;
            this.serviceeditButton.Text = "Edit Service";
            this.serviceeditButton.UseVisualStyleBackColor = true;
            // 
            // servicenameTextbox
            // 
            this.servicenameTextbox.Location = new System.Drawing.Point(105, 64);
            this.servicenameTextbox.MaxLength = 20;
            this.servicenameTextbox.Name = "servicenameTextbox";
            this.servicenameTextbox.Size = new System.Drawing.Size(163, 20);
            this.servicenameTextbox.TabIndex = 9;
            this.servicenameTextbox.TextChanged += new System.EventHandler(this.servicenameTextbox_TextChanged);
            // 
            // servicefeeLabel
            // 
            this.servicefeeLabel.AutoSize = true;
            this.servicefeeLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicefeeLabel.Location = new System.Drawing.Point(14, 102);
            this.servicefeeLabel.Name = "servicefeeLabel";
            this.servicefeeLabel.Size = new System.Drawing.Size(79, 16);
            this.servicefeeLabel.TabIndex = 8;
            this.servicefeeLabel.Text = "Service Fee:";
            // 
            // servicenameLabel
            // 
            this.servicenameLabel.AutoSize = true;
            this.servicenameLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicenameLabel.Location = new System.Drawing.Point(10, 65);
            this.servicenameLabel.Name = "servicenameLabel";
            this.servicenameLabel.Size = new System.Drawing.Size(95, 16);
            this.servicenameLabel.TabIndex = 7;
            this.servicenameLabel.Text = "Service Name: ";
            // 
            // searchserviceButton
            // 
            this.searchserviceButton.Location = new System.Drawing.Point(180, 13);
            this.searchserviceButton.Name = "searchserviceButton";
            this.searchserviceButton.Size = new System.Drawing.Size(88, 23);
            this.searchserviceButton.TabIndex = 37;
            this.searchserviceButton.Text = "Search Service";
            this.searchserviceButton.UseVisualStyleBackColor = true;
            // 
            // servicennumberTextbox
            // 
            this.servicennumberTextbox.Location = new System.Drawing.Point(12, 15);
            this.servicennumberTextbox.MaxLength = 6;
            this.servicennumberTextbox.Name = "servicennumberTextbox";
            this.servicennumberTextbox.Size = new System.Drawing.Size(153, 20);
            this.servicennumberTextbox.TabIndex = 36;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.topPanel.Controls.Add(this.servicennumberTextbox);
            this.topPanel.Controls.Add(this.searchserviceButton);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(281, 52);
            this.topPanel.TabIndex = 38;
            // 
            // EditServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 200);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.costTextbox);
            this.Controls.Add(this.serviceeditButton);
            this.Controls.Add(this.servicenameTextbox);
            this.Controls.Add(this.servicefeeLabel);
            this.Controls.Add(this.servicenameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Service";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox costTextbox;
        private System.Windows.Forms.Button serviceeditButton;
        private System.Windows.Forms.TextBox servicenameTextbox;
        private System.Windows.Forms.Label servicefeeLabel;
        private System.Windows.Forms.Label servicenameLabel;
        private System.Windows.Forms.Button searchserviceButton;
        private System.Windows.Forms.TextBox servicennumberTextbox;
        private System.Windows.Forms.Panel topPanel;
    }
}