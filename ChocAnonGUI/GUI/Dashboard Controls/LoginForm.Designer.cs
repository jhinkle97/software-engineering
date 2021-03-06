﻿namespace ChocAnonGUI
{
    partial class LoginForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(72, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(305, 26);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Welcome To ChocAnon";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.ForeColor = System.Drawing.Color.White;
            this.topPanel.Location = new System.Drawing.Point(-1, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(444, 58);
            this.topPanel.TabIndex = 2;
            // 
            // lowerPanel
            // 
            this.lowerPanel.BackColor = System.Drawing.Color.Silver;
            this.lowerPanel.Controls.Add(this.inputTextbox);
            this.lowerPanel.Controls.Add(this.outputLabel);
            this.lowerPanel.Controls.Add(this.enterButton);
            this.lowerPanel.Location = new System.Drawing.Point(-1, 58);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(444, 116);
            this.lowerPanel.TabIndex = 3;
            // 
            // inputTextbox
            // 
            this.inputTextbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.inputTextbox.Location = new System.Drawing.Point(79, 23);
            this.inputTextbox.MaxLength = 9;
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(288, 20);
            this.inputTextbox.TabIndex = 3;
            this.inputTextbox.Text = "Enter provider number";
            this.inputTextbox.Enter += new System.EventHandler(this.inputTextbox_Enter);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(76, 89);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(79, 57);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(288, 29);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Login";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(440, 172);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Login";
            this.Load += new System.EventHandler(this.terminalLogin_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.lowerPanel.ResumeLayout(false);
            this.lowerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox inputTextbox;
    }
}

