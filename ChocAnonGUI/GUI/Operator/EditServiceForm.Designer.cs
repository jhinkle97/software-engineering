namespace ChocAnonGUI
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.serviceTextbox = new System.Windows.Forms.TextBox();
            this.feeTextbox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.topPanel.Controls.Add(this.inputTextbox);
            this.topPanel.Controls.Add(this.searchButton);
            this.topPanel.Location = new System.Drawing.Point(1, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(331, 54);
            this.topPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(216, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 32);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search Service";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(11, 17);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(191, 20);
            this.inputTextbox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(8, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(121, 19);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Service Name: ";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeLabel.Location = new System.Drawing.Point(9, 105);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(100, 19);
            this.feeLabel.TabIndex = 2;
            this.feeLabel.Text = "Service Fee:";
            // 
            // serviceTextbox
            // 
            this.serviceTextbox.Location = new System.Drawing.Point(132, 75);
            this.serviceTextbox.Name = "serviceTextbox";
            this.serviceTextbox.Size = new System.Drawing.Size(190, 20);
            this.serviceTextbox.TabIndex = 3;
            // 
            // feeTextbox
            // 
            this.feeTextbox.Location = new System.Drawing.Point(114, 107);
            this.feeTextbox.Name = "feeTextbox";
            this.feeTextbox.Size = new System.Drawing.Size(208, 20);
            this.feeTextbox.TabIndex = 4;
            this.feeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(12, 147);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(142, 59);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit Service";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(179, 147);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(142, 59);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete Service";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 224);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.feeTextbox);
            this.Controls.Add(this.serviceTextbox);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit or Delete Service";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.TextBox serviceTextbox;
        private System.Windows.Forms.TextBox feeTextbox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}