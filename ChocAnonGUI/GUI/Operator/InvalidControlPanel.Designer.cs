namespace ChocAnonGUI.GUI.Operator
{
    partial class InvalidControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvalidControlPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topTitleLabel = new System.Windows.Forms.Label();
            this.bottomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(199, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 184);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // topTitleLabel
            // 
            this.topTitleLabel.AutoSize = true;
            this.topTitleLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topTitleLabel.Location = new System.Drawing.Point(15, 14);
            this.topTitleLabel.Name = "topTitleLabel";
            this.topTitleLabel.Size = new System.Drawing.Size(607, 23);
            this.topTitleLabel.TabIndex = 1;
            this.topTitleLabel.Text = "ERROR!     EEROR!      ERROR!      ERROR!     ERROR!    ERROR!";
            // 
            // bottomLabel
            // 
            this.bottomLabel.AutoSize = true;
            this.bottomLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLabel.Location = new System.Drawing.Point(93, 256);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(487, 29);
            this.bottomLabel.TabIndex = 2;
            this.bottomLabel.Text = "Invalid Member Login Code, Try Again!";
            // 
            // InvalidControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomLabel);
            this.Controls.Add(this.topTitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InvalidControlPanel";
            this.Size = new System.Drawing.Size(639, 306);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label topTitleLabel;
        private System.Windows.Forms.Label bottomLabel;
    }
}
