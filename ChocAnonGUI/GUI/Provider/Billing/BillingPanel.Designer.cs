namespace ChocAnonGUI
{
    partial class BillingPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.billButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.memnameTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.memnumberTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.memstateTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.memcityTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stateLabel = new System.Windows.Forms.Label();
            this.memzipTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.memaddressLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.memaddressTextbox = new System.Windows.Forms.TextBox();
            this.memstatusTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.servicecodeLabel = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.serviceCodeTextBox = new System.Windows.Forms.TextBox();
            this.lookupButton = new System.Windows.Forms.Button();
            this.contextMenuStrip8 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.commentsBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip7 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Service Dashboard";
            // 
            // billButton
            // 
            this.billButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.Location = new System.Drawing.Point(5, 321);
            this.billButton.Margin = new System.Windows.Forms.Padding(4);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(405, 53);
            this.billButton.TabIndex = 1;
            this.billButton.Text = "Bill for Service";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(435, 108);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(160, 23);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Member Name:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(436, 149);
            this.numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(117, 23);
            this.numberLabel.TabIndex = 3;
            this.numberLabel.Text = "Member #:";
            // 
            // memnameTextbox
            // 
            this.memnameTextbox.Location = new System.Drawing.Point(609, 108);
            this.memnameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.memnameTextbox.Name = "memnameTextbox";
            this.memnameTextbox.ReadOnly = true;
            this.memnameTextbox.Size = new System.Drawing.Size(223, 22);
            this.memnameTextbox.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // memnumberTextbox
            // 
            this.memnumberTextbox.Location = new System.Drawing.Point(563, 149);
            this.memnumberTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.memnumberTextbox.Name = "memnumberTextbox";
            this.memnumberTextbox.ReadOnly = true;
            this.memnumberTextbox.Size = new System.Drawing.Size(132, 22);
            this.memnumberTextbox.TabIndex = 6;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Member Status:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(436, 193);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(57, 23);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "City:";
            // 
            // memstateTextbox
            // 
            this.memstateTextbox.Location = new System.Drawing.Point(769, 149);
            this.memstateTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.memstateTextbox.Name = "memstateTextbox";
            this.memstateTextbox.ReadOnly = true;
            this.memstateTextbox.Size = new System.Drawing.Size(61, 22);
            this.memstateTextbox.TabIndex = 10;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // memcityTextbox
            // 
            this.memcityTextbox.Location = new System.Drawing.Point(497, 192);
            this.memcityTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.memcityTextbox.Name = "memcityTextbox";
            this.memcityTextbox.ReadOnly = true;
            this.memcityTextbox.Size = new System.Drawing.Size(132, 22);
            this.memcityTextbox.TabIndex = 12;
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(701, 149);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(63, 23);
            this.stateLabel.TabIndex = 14;
            this.stateLabel.Text = "State:";
            // 
            // memzipTextbox
            // 
            this.memzipTextbox.Location = new System.Drawing.Point(744, 192);
            this.memzipTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.memzipTextbox.Name = "memzipTextbox";
            this.memzipTextbox.ReadOnly = true;
            this.memzipTextbox.Size = new System.Drawing.Size(81, 22);
            this.memzipTextbox.TabIndex = 15;
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(61, 4);
            // 
            // memaddressLabel
            // 
            this.memaddressLabel.AutoSize = true;
            this.memaddressLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memaddressLabel.Location = new System.Drawing.Point(436, 231);
            this.memaddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memaddressLabel.Name = "memaddressLabel";
            this.memaddressLabel.Size = new System.Drawing.Size(94, 23);
            this.memaddressLabel.TabIndex = 17;
            this.memaddressLabel.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Zip Code:";
            // 
            // memaddressTextbox
            // 
            this.memaddressTextbox.Location = new System.Drawing.Point(541, 231);
            this.memaddressTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.memaddressTextbox.Name = "memaddressTextbox";
            this.memaddressTextbox.ReadOnly = true;
            this.memaddressTextbox.Size = new System.Drawing.Size(284, 22);
            this.memaddressTextbox.TabIndex = 19;
            // 
            // memstatusTextbox
            // 
            this.memstatusTextbox.Location = new System.Drawing.Point(612, 267);
            this.memstatusTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.memstatusTextbox.Name = "memstatusTextbox";
            this.memstatusTextbox.ReadOnly = true;
            this.memstatusTextbox.Size = new System.Drawing.Size(213, 22);
            this.memstatusTextbox.TabIndex = 20;
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip6.Name = "contextMenuStrip6";
            this.contextMenuStrip6.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(419, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 329);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Bill For Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "Member Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 12);
            this.panel2.TabIndex = 25;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(4, 110);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(168, 23);
            this.dateLabel.TabIndex = 26;
            this.dateLabel.Text = "Date Performed:";
            // 
            // servicecodeLabel
            // 
            this.servicecodeLabel.AutoSize = true;
            this.servicecodeLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicecodeLabel.Location = new System.Drawing.Point(4, 149);
            this.servicecodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.servicecodeLabel.Name = "servicecodeLabel";
            this.servicecodeLabel.Size = new System.Drawing.Size(141, 23);
            this.servicecodeLabel.TabIndex = 27;
            this.servicecodeLabel.Text = "Service Code:";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(131, 180);
            this.commentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(161, 33);
            this.commentsLabel.TabIndex = 28;
            this.commentsLabel.Text = "Comments";
            // 
            // serviceCodeTextBox
            // 
            this.serviceCodeTextBox.Location = new System.Drawing.Point(154, 150);
            this.serviceCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.serviceCodeTextBox.MaxLength = 6;
            this.serviceCodeTextBox.Name = "serviceCodeTextBox";
            this.serviceCodeTextBox.ReadOnly = true;
            this.serviceCodeTextBox.Size = new System.Drawing.Size(87, 22);
            this.serviceCodeTextBox.TabIndex = 31;
            // 
            // lookupButton
            // 
            this.lookupButton.Location = new System.Drawing.Point(255, 146);
            this.lookupButton.Margin = new System.Windows.Forms.Padding(4);
            this.lookupButton.Name = "lookupButton";
            this.lookupButton.Size = new System.Drawing.Size(154, 28);
            this.lookupButton.TabIndex = 32;
            this.lookupButton.Text = "Select a Service";
            this.lookupButton.UseVisualStyleBackColor = true;
            this.lookupButton.Click += new System.EventHandler(this.lookupButton_Click);
            // 
            // contextMenuStrip8
            // 
            this.contextMenuStrip8.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip8.Name = "contextMenuStrip8";
            this.contextMenuStrip8.Size = new System.Drawing.Size(61, 4);
            // 
            // commentsBox
            // 
            this.commentsBox.Location = new System.Drawing.Point(5, 215);
            this.commentsBox.Margin = new System.Windows.Forms.Padding(4);
            this.commentsBox.MaxLength = 100;
            this.commentsBox.Name = "commentsBox";
            this.commentsBox.Size = new System.Drawing.Size(404, 98);
            this.commentsBox.TabIndex = 35;
            this.commentsBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(441, 316);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 58);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(547, 316);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 58);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(656, 316);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 58);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(759, 316);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 58);
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 110);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // contextMenuStrip7
            // 
            this.contextMenuStrip7.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip7.Name = "contextMenuStrip7";
            this.contextMenuStrip7.Size = new System.Drawing.Size(61, 4);
            // 
            // BillingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.commentsBox);
            this.Controls.Add(this.lookupButton);
            this.Controls.Add(this.serviceCodeTextBox);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.servicecodeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.memstatusTextbox);
            this.Controls.Add(this.memaddressTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.memaddressLabel);
            this.Controls.Add(this.memzipTextbox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.memcityTextbox);
            this.Controls.Add(this.memstateTextbox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memnumberTextbox);
            this.Controls.Add(this.memnameTextbox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BillingPanel";
            this.Size = new System.Drawing.Size(852, 382);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox memnameTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox memnumberTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox memstateTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.TextBox memcityTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox memzipTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.Label memaddressLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox memaddressTextbox;
        private System.Windows.Forms.TextBox memstatusTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label servicecodeLabel;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox serviceCodeTextBox;
        private System.Windows.Forms.Button lookupButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip8;
        private System.Windows.Forms.RichTextBox commentsBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip7;
    }
}
