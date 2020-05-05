namespace ChocAnonGUI.GUI.Popup
{
    partial class SuccessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessForm));
            this.successLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.happyPicturebox = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.happyPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.successLabel.Location = new System.Drawing.Point(45, 8);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(191, 19);
            this.successLabel.TabIndex = 0;
            this.successLabel.Text = "-----Waiting input---------";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.topPanel.Controls.Add(this.successLabel);
            this.topPanel.Location = new System.Drawing.Point(-1, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(277, 72);
            this.topPanel.TabIndex = 1;
            // 
            // happyPicturebox
            // 
            this.happyPicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("happyPicturebox.BackgroundImage")));
            this.happyPicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.happyPicturebox.Location = new System.Drawing.Point(49, 83);
            this.happyPicturebox.Name = "happyPicturebox";
            this.happyPicturebox.Size = new System.Drawing.Size(175, 143);
            this.happyPicturebox.TabIndex = 2;
            this.happyPicturebox.TabStop = false;
            // 
            // SuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 234);
            this.Controls.Add(this.happyPicturebox);
            this.Controls.Add(this.topPanel);
            this.Name = "SuccessForm";
            this.Text = "SuccessForm";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.happyPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox happyPicturebox;
    }
}