namespace ChocAnonGUI
{
    partial class ReportControl
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
            this.changeButton = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.serviceButton = new System.Windows.Forms.Button();
            this.managerButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // providerButton
            // 
            this.providerButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerButton.Location = new System.Drawing.Point(13, 12);
            this.providerButton.Name = "providerButton";
            this.providerButton.Size = new System.Drawing.Size(127, 50);
            this.providerButton.TabIndex = 0;
            this.providerButton.Text = "Provider Report";
            this.providerButton.UseVisualStyleBackColor = true;
            this.providerButton.Click += new System.EventHandler(this.providerButton_Click);
            // 
            // memberButton
            // 
            this.memberButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberButton.Location = new System.Drawing.Point(13, 78);
            this.memberButton.Name = "memberButton";
            this.memberButton.Size = new System.Drawing.Size(127, 50);
            this.memberButton.TabIndex = 1;
            this.memberButton.Text = "Member Report";
            this.memberButton.UseVisualStyleBackColor = true;
            this.memberButton.Click += new System.EventHandler(this.memberButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(13, 142);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(127, 50);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Changes Report";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // serviceButton
            // 
            this.serviceButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceButton.Location = new System.Drawing.Point(13, 204);
            this.serviceButton.Name = "serviceButton";
            this.serviceButton.Size = new System.Drawing.Size(127, 50);
            this.serviceButton.TabIndex = 3;
            this.serviceButton.Text = "Service Report";
            this.serviceButton.UseVisualStyleBackColor = true;
            this.serviceButton.Click += new System.EventHandler(this.serviceButton_Click);
            // 
            // managerButton
            // 
            this.managerButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerButton.Location = new System.Drawing.Point(13, 266);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(127, 50);
            this.managerButton.TabIndex = 4;
            this.managerButton.Text = "Manager Report";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(157, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 249);
            this.dataGridView1.TabIndex = 5;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(157, 267);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(460, 49);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send Report Via Email To ***Whoever***";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.serviceButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.memberButton);
            this.Controls.Add(this.providerButton);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(620, 323);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button providerButton;
        private System.Windows.Forms.Button memberButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button changeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button serviceButton;
        private System.Windows.Forms.Button managerButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sendButton;
    }
}
