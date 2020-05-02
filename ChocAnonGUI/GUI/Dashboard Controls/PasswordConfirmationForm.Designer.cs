namespace ChocAnonGUI
{
    partial class PasswordConfirmForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.titleLabel = new System.Windows.Forms.Label();
            this.memcodeTextbox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.titleLabel.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(10, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(370, 22);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Please Swipe/Enter Member Card";
            // 
            // memcodeTextbox
            // 
            this.memcodeTextbox.Location = new System.Drawing.Point(14, 56);
            this.memcodeTextbox.MaxLength = 9;
            this.memcodeTextbox.Name = "memcodeTextbox";
            this.memcodeTextbox.Size = new System.Drawing.Size(366, 20);
            this.memcodeTextbox.TabIndex = 1;
            this.memcodeTextbox.Text = "Enter member number";
            this.memcodeTextbox.Enter += new System.EventHandler(this.memcodeTextbox_Enter);
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(10, 94);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(366, 62);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm Member Password";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.confirmationLabel);
            this.panel1.Location = new System.Drawing.Point(10, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 27);
            this.panel1.TabIndex = 3;
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationLabel.Location = new System.Drawing.Point(30, 1);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(316, 19);
            this.confirmationLabel.TabIndex = 0;
            this.confirmationLabel.Text = "Here is where an error would go";
            // 
            // PasswordConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(391, 197);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.memcodeTextbox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PasswordConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bill a Member";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox memcodeTextbox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label confirmationLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}