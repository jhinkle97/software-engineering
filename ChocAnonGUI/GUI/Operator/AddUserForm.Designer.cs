namespace ChocAnonGUI
{
    partial class addmemberForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.zipTextbox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.typeCombobox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Street Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zip Code:";
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(73, 121);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(55, 21);
            this.stateComboBox.TabIndex = 6;
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(78, 12);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(184, 20);
            this.firstnameTextbox.TabIndex = 7;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(144, 85);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(118, 20);
            this.addressTextbox.TabIndex = 9;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Location = new System.Drawing.Point(185, 122);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(77, 20);
            this.cityTextbox.TabIndex = 10;
            // 
            // zipTextbox
            // 
            this.zipTextbox.Location = new System.Drawing.Point(99, 158);
            this.zipTextbox.Name = "zipTextbox";
            this.zipTextbox.Size = new System.Drawing.Size(164, 20);
            this.zipTextbox.TabIndex = 11;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(17, 232);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(247, 60);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Add New User";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "User Type:";
            // 
            // typeCombobox
            // 
            this.typeCombobox.FormattingEnabled = true;
            this.typeCombobox.Location = new System.Drawing.Point(100, 196);
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(162, 21);
            this.typeCombobox.TabIndex = 16;
            this.typeCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // addmemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 305);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.typeCombobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.zipTextbox);
            this.Controls.Add(this.cityTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.firstnameTextbox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addmemberForm";
            this.Text = "Add a User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.TextBox zipTextbox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox typeCombobox;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}