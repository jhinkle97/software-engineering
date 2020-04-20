namespace ChocAnonGUI
{
    partial class billquickviewPanel
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
            this.quickTitleLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.membernumLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateTextbox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipcodeTextbox = new System.Windows.Forms.TextBox();
            this.serviceProvidedLabel = new System.Windows.Forms.Label();
            this.quicklistView = new System.Windows.Forms.ListView();
            this.membernumTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quickTitleLabel
            // 
            this.quickTitleLabel.AutoSize = true;
            this.quickTitleLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickTitleLabel.Location = new System.Drawing.Point(99, 11);
            this.quickTitleLabel.Name = "quickTitleLabel";
            this.quickTitleLabel.Size = new System.Drawing.Size(188, 23);
            this.quickTitleLabel.TabIndex = 0;
            this.quickTitleLabel.Text = "Member Summary";
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(5, 51);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(84, 15);
            this.firstLabel.TabIndex = 1;
            this.firstLabel.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name:";
            // 
            // membernumLabel
            // 
            this.membernumLabel.AutoSize = true;
            this.membernumLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membernumLabel.Location = new System.Drawing.Point(5, 83);
            this.membernumLabel.Name = "membernumLabel";
            this.membernumLabel.Size = new System.Drawing.Size(79, 15);
            this.membernumLabel.TabIndex = 3;
            this.membernumLabel.Text = "Member #:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(5, 116);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(122, 15);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Member Address:";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(87, 50);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(88, 20);
            this.firstnameTextbox.TabIndex = 5;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(130, 114);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(233, 20);
            this.addressTextbox.TabIndex = 7;
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(263, 49);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextbox.TabIndex = 8;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(183, 82);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(40, 15);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "City:";
            this.cityLabel.Click += new System.EventHandler(this.cityLabel_Click);
            // 
            // cityTextbox
            // 
            this.cityTextbox.Location = new System.Drawing.Point(227, 80);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(135, 20);
            this.cityTextbox.TabIndex = 10;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(7, 150);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(44, 15);
            this.stateLabel.TabIndex = 11;
            this.stateLabel.Text = "State:";
            // 
            // stateTextbox
            // 
            this.stateTextbox.Location = new System.Drawing.Point(54, 148);
            this.stateTextbox.Name = "stateTextbox";
            this.stateTextbox.Size = new System.Drawing.Size(69, 20);
            this.stateTextbox.TabIndex = 12;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(136, 149);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(68, 15);
            this.zipLabel.TabIndex = 13;
            this.zipLabel.Text = "Zip Code:";
            // 
            // zipcodeTextbox
            // 
            this.zipcodeTextbox.Location = new System.Drawing.Point(210, 147);
            this.zipcodeTextbox.Name = "zipcodeTextbox";
            this.zipcodeTextbox.Size = new System.Drawing.Size(153, 20);
            this.zipcodeTextbox.TabIndex = 14;
            // 
            // serviceProvidedLabel
            // 
            this.serviceProvidedLabel.AutoSize = true;
            this.serviceProvidedLabel.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceProvidedLabel.Location = new System.Drawing.Point(17, 186);
            this.serviceProvidedLabel.Name = "serviceProvidedLabel";
            this.serviceProvidedLabel.Size = new System.Drawing.Size(335, 19);
            this.serviceProvidedLabel.TabIndex = 15;
            this.serviceProvidedLabel.Text = "--------All Services Provided History--------";
            // 
            // quicklistView
            // 
            this.quicklistView.HideSelection = false;
            this.quicklistView.Location = new System.Drawing.Point(10, 209);
            this.quicklistView.Name = "quicklistView";
            this.quicklistView.Size = new System.Drawing.Size(352, 115);
            this.quicklistView.TabIndex = 16;
            this.quicklistView.UseCompatibleStateImageBehavior = false;
            // 
            // membernumTextbox
            // 
            this.membernumTextbox.Location = new System.Drawing.Point(89, 81);
            this.membernumTextbox.Name = "membernumTextbox";
            this.membernumTextbox.Size = new System.Drawing.Size(84, 20);
            this.membernumTextbox.TabIndex = 17;
            // 
            // billquickviewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.membernumTextbox);
            this.Controls.Add(this.quicklistView);
            this.Controls.Add(this.serviceProvidedLabel);
            this.Controls.Add(this.zipcodeTextbox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateTextbox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityTextbox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.lastnameTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.firstnameTextbox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.membernumLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.quickTitleLabel);
            this.Name = "billquickviewPanel";
            this.Size = new System.Drawing.Size(372, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quickTitleLabel;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label membernumLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateTextbox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox zipcodeTextbox;
        private System.Windows.Forms.Label serviceProvidedLabel;
        private System.Windows.Forms.ListView quicklistView;
        private System.Windows.Forms.TextBox membernumTextbox;
    }
}
