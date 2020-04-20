namespace ChocAnonGUI
{
    partial class MainDashboard
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
            this.verticalPanel = new System.Windows.Forms.Panel();
            this.verticalLine = new System.Windows.Forms.Panel();
            this.reportButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.horizontalPanel = new System.Windows.Forms.Panel();
            this.usertitleLabel = new System.Windows.Forms.Label();
            this.verticalLine2 = new System.Windows.Forms.Panel();
            this.dashLabel2 = new System.Windows.Forms.Label();
            this.dashTitle1 = new System.Windows.Forms.Label();
            this.reportControl1 = new ChocAnonGUI.ReportControl();
            this.opControl1 = new ChocAnonGUI.OpControl();
            this.defaultControl1 = new ChocAnonGUI.DefaultControl();
            this.billControl1 = new ChocAnonGUI.BillControl();
            this.verticalPanel.SuspendLayout();
            this.horizontalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // verticalPanel
            // 
            this.verticalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.verticalPanel.Controls.Add(this.verticalLine);
            this.verticalPanel.Controls.Add(this.reportButton);
            this.verticalPanel.Controls.Add(this.billButton);
            this.verticalPanel.Location = new System.Drawing.Point(2, -1);
            this.verticalPanel.Name = "verticalPanel";
            this.verticalPanel.Size = new System.Drawing.Size(225, 429);
            this.verticalPanel.TabIndex = 0;
            // 
            // verticalLine
            // 
            this.verticalLine.BackColor = System.Drawing.Color.DarkGray;
            this.verticalLine.Location = new System.Drawing.Point(212, 100);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(13, 426);
            this.verticalLine.TabIndex = 3;
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(16, 284);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(184, 123);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Report Generator";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // billButton
            // 
            this.billButton.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.Location = new System.Drawing.Point(16, 130);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(184, 123);
            this.billButton.TabIndex = 0;
            this.billButton.Text = "Bill Member";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // horizontalPanel
            // 
            this.horizontalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.horizontalPanel.Controls.Add(this.usertitleLabel);
            this.horizontalPanel.Controls.Add(this.verticalLine2);
            this.horizontalPanel.Controls.Add(this.dashLabel2);
            this.horizontalPanel.Controls.Add(this.dashTitle1);
            this.horizontalPanel.Location = new System.Drawing.Point(2, -1);
            this.horizontalPanel.Name = "horizontalPanel";
            this.horizontalPanel.Size = new System.Drawing.Size(865, 100);
            this.horizontalPanel.TabIndex = 1;
            // 
            // usertitleLabel
            // 
            this.usertitleLabel.AutoSize = true;
            this.usertitleLabel.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertitleLabel.Location = new System.Drawing.Point(273, 30);
            this.usertitleLabel.Name = "usertitleLabel";
            this.usertitleLabel.Size = new System.Drawing.Size(535, 31);
            this.usertitleLabel.TabIndex = 3;
            this.usertitleLabel.Text = "This is where the name of the person goes.";
            // 
            // verticalLine2
            // 
            this.verticalLine2.BackColor = System.Drawing.Color.DarkGray;
            this.verticalLine2.Location = new System.Drawing.Point(212, 0);
            this.verticalLine2.Name = "verticalLine2";
            this.verticalLine2.Size = new System.Drawing.Size(13, 100);
            this.verticalLine2.TabIndex = 2;
            // 
            // dashLabel2
            // 
            this.dashLabel2.AutoSize = true;
            this.dashLabel2.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLabel2.Location = new System.Drawing.Point(10, 52);
            this.dashLabel2.Name = "dashLabel2";
            this.dashLabel2.Size = new System.Drawing.Size(184, 34);
            this.dashLabel2.TabIndex = 1;
            this.dashLabel2.Text = "Dashboard";
            // 
            // dashTitle1
            // 
            this.dashTitle1.AutoSize = true;
            this.dashTitle1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashTitle1.Location = new System.Drawing.Point(22, 10);
            this.dashTitle1.Name = "dashTitle1";
            this.dashTitle1.Size = new System.Drawing.Size(157, 30);
            this.dashTitle1.TabIndex = 0;
            this.dashTitle1.Text = "ChocoHolic";
            // 
            // reportControl1
            // 
            this.reportControl1.Location = new System.Drawing.Point(233, 101);
            this.reportControl1.Name = "reportControl1";
            this.reportControl1.Size = new System.Drawing.Size(634, 330);
            this.reportControl1.TabIndex = 5;
            // 
            // opControl1
            // 
            this.opControl1.Location = new System.Drawing.Point(2, 89);
            this.opControl1.Name = "opControl1";
            this.opControl1.Size = new System.Drawing.Size(865, 340);
            this.opControl1.TabIndex = 4;
            // 
            // defaultControl1
            // 
            this.defaultControl1.Location = new System.Drawing.Point(233, 101);
            this.defaultControl1.Name = "defaultControl1";
            this.defaultControl1.Size = new System.Drawing.Size(634, 329);
            this.defaultControl1.TabIndex = 3;
            // 
            // billControl1
            // 
            this.billControl1.Location = new System.Drawing.Point(233, 105);
            this.billControl1.Name = "billControl1";
            this.billControl1.Size = new System.Drawing.Size(619, 323);
            this.billControl1.TabIndex = 2;
            this.billControl1.Load += new System.EventHandler(this.billControl1_Load);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 425);
            this.Controls.Add(this.opControl1);
            this.Controls.Add(this.reportControl1);
            this.Controls.Add(this.defaultControl1);
            this.Controls.Add(this.billControl1);
            this.Controls.Add(this.horizontalPanel);
            this.Controls.Add(this.verticalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChocAnon Dashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.verticalPanel.ResumeLayout(false);
            this.horizontalPanel.ResumeLayout(false);
            this.horizontalPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel verticalPanel;
        private System.Windows.Forms.Panel horizontalPanel;
        private System.Windows.Forms.Label dashLabel2;
        private System.Windows.Forms.Label dashTitle1;
        private System.Windows.Forms.Panel verticalLine;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Panel verticalLine2;
        private System.Windows.Forms.Label usertitleLabel;
        private BillControl billControl1;
        private DefaultControl defaultControl1;
        private OpControl opControl1;
        private ReportControl reportControl1;
       
    }
}