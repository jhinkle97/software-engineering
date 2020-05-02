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
            this.servicefeeTextbox = new System.Windows.Forms.TextBox();
            this.serviceeditButton = new System.Windows.Forms.Button();
            this.servicenameTextbox = new System.Windows.Forms.TextBox();
            this.servicefeeLabel = new System.Windows.Forms.Label();
            this.servicenameLabel = new System.Windows.Forms.Label();
            this.searchserviceButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicefeeTextbox
            // 
            this.servicefeeTextbox.Location = new System.Drawing.Point(140, 124);
            this.servicefeeTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.servicefeeTextbox.Name = "servicefeeTextbox";
            this.servicefeeTextbox.Size = new System.Drawing.Size(216, 22);
            this.servicefeeTextbox.TabIndex = 11;
            // 
            // serviceeditButton
            // 
            this.serviceeditButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceeditButton.Location = new System.Drawing.Point(17, 172);
            this.serviceeditButton.Margin = new System.Windows.Forms.Padding(4);
            this.serviceeditButton.Name = "serviceeditButton";
            this.serviceeditButton.Size = new System.Drawing.Size(341, 59);
            this.serviceeditButton.TabIndex = 10;
            this.serviceeditButton.Text = "Edit Service";
            this.serviceeditButton.UseVisualStyleBackColor = true;
            this.serviceeditButton.Click += new System.EventHandler(this.serviceeditButton_Click);
            // 
            // servicenameTextbox
            // 
            this.servicenameTextbox.Location = new System.Drawing.Point(140, 79);
            this.servicenameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.servicenameTextbox.MaxLength = 20;
            this.servicenameTextbox.Name = "servicenameTextbox";
            this.servicenameTextbox.Size = new System.Drawing.Size(216, 22);
            this.servicenameTextbox.TabIndex = 9;
            this.servicenameTextbox.TextChanged += new System.EventHandler(this.servicenameTextbox_TextChanged);
            // 
            // servicefeeLabel
            // 
            this.servicefeeLabel.AutoSize = true;
            this.servicefeeLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicefeeLabel.Location = new System.Drawing.Point(19, 126);
            this.servicefeeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.servicefeeLabel.Name = "servicefeeLabel";
            this.servicefeeLabel.Size = new System.Drawing.Size(106, 20);
            this.servicefeeLabel.TabIndex = 8;
            this.servicefeeLabel.Text = "Service Fee:";
            // 
            // servicenameLabel
            // 
            this.servicenameLabel.AutoSize = true;
            this.servicenameLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicenameLabel.Location = new System.Drawing.Point(13, 80);
            this.servicenameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.servicenameLabel.Name = "servicenameLabel";
            this.servicenameLabel.Size = new System.Drawing.Size(127, 20);
            this.servicenameLabel.TabIndex = 7;
            this.servicenameLabel.Text = "Service Name: ";
            // 
            // searchserviceButton
            // 
            this.searchserviceButton.Location = new System.Drawing.Point(240, 16);
            this.searchserviceButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchserviceButton.Name = "searchserviceButton";
            this.searchserviceButton.Size = new System.Drawing.Size(117, 28);
            this.searchserviceButton.TabIndex = 37;
            this.searchserviceButton.Text = "Search Service";
            this.searchserviceButton.UseVisualStyleBackColor = true;
            this.searchserviceButton.Click += new System.EventHandler(this.searchService);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(16, 18);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextbox.MaxLength = 6;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(203, 22);
            this.searchTextbox.TabIndex = 36;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.topPanel.Controls.Add(this.searchTextbox);
            this.topPanel.Controls.Add(this.searchserviceButton);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(375, 64);
            this.topPanel.TabIndex = 38;
            // 
            // EditServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 246);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.servicefeeTextbox);
            this.Controls.Add(this.serviceeditButton);
            this.Controls.Add(this.servicenameTextbox);
            this.Controls.Add(this.servicefeeLabel);
            this.Controls.Add(this.servicenameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Service";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox servicefeeTextbox;
        private System.Windows.Forms.Button serviceeditButton;
        private System.Windows.Forms.TextBox servicenameTextbox;
        private System.Windows.Forms.Label servicefeeLabel;
        private System.Windows.Forms.Label servicenameLabel;
        private System.Windows.Forms.Button searchserviceButton;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Panel topPanel;
    }
}