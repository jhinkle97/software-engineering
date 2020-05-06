namespace ChocAnonGUI.GUI.Provider.Reports
{
    partial class GetMemberForm
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
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.topPanel.Controls.Add(this.topLabel);
            this.topPanel.Location = new System.Drawing.Point(-1, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(204, 46);
            this.topPanel.TabIndex = 0;
            // 
            // codeTextbox
            // 
            this.codeTextbox.Location = new System.Drawing.Point(12, 52);
            this.codeTextbox.MaxLength = 9;
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(155, 20);
            this.codeTextbox.TabIndex = 0;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.topLabel.Location = new System.Drawing.Point(15, 13);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(160, 19);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Enter Member Code";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(12, 79);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(155, 31);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Submit";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // GetMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 119);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.codeTextbox);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GetMemberForm";
            this.Text = "Code Entry";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TextBox codeTextbox;
        private System.Windows.Forms.Button enterButton;
    }
}