namespace ChocAnonGUI
{
    partial class WelcomePanel

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
            this.mainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mainLabel.Location = new System.Drawing.Point(88, 39);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(470, 250);
            this.mainLabel.TabIndex = 13;
            this.mainLabel.Text = "Welcome to the ChocAnon\r\nProvider Dashboard. Please\r\nselect an option on the left" +
    "\r\ninterface bar. \r\n\r\n";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLabel.Click += new System.EventHandler(this.mainLabel_Click);
            // 
            // DefaultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.mainLabel);
            this.Name = "DefaultControl";
            this.Size = new System.Drawing.Size(633, 306);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mainLabel;
    }
}
