namespace ChocAnonGUI
{
    partial class ReportsPanel
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
            this.providerButton = new System.Windows.Forms.Button();
            this.memberButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.managerButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // providerButton
            // 
            this.providerButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.providerButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.providerButton.Location = new System.Drawing.Point(13, 12);
            this.providerButton.Name = "providerButton";
            this.providerButton.Size = new System.Drawing.Size(127, 50);
            this.providerButton.TabIndex = 0;
            this.providerButton.Text = "Provider Report";
            this.providerButton.UseVisualStyleBackColor = false;
            this.providerButton.Click += new System.EventHandler(this.providerButton_Click);
            // 
            // memberButton
            // 
            this.memberButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.memberButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberButton.Location = new System.Drawing.Point(13, 77);
            this.memberButton.Name = "memberButton";
            this.memberButton.Size = new System.Drawing.Size(127, 50);
            this.memberButton.TabIndex = 1;
            this.memberButton.Text = "Member Report";
            this.memberButton.UseVisualStyleBackColor = false;
            this.memberButton.Click += new System.EventHandler(this.memberButton_Click);
            // 
            // managerButton
            // 
            this.managerButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.managerButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerButton.Location = new System.Drawing.Point(13, 145);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(127, 50);
            this.managerButton.TabIndex = 4;
            this.managerButton.Text = "Manager Report";
            this.managerButton.UseVisualStyleBackColor = false;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Wheat;
            this.sendButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(13, 211);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(127, 85);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Email Generated Report\r\n";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(153, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 324);
            this.panel1.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(172, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(452, 246);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(281, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(242, 23);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Report QuickView Panel";
            // 
            // ReportsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.memberButton);
            this.Controls.Add(this.providerButton);
            this.Name = "ReportsPanel";
            this.Size = new System.Drawing.Size(639, 306);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button providerButton;
        private System.Windows.Forms.Button memberButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button managerButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label titleLabel;
    }
}
