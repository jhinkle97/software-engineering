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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.verticalPanel = new System.Windows.Forms.Panel();
            this.ReportButton = new System.Windows.Forms.Button();
            this.MemberServiceButton = new System.Windows.Forms.Button();
            this.verticalLine = new System.Windows.Forms.Panel();
            this.horizontalPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.settingPicture = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usertitleLabel = new System.Windows.Forms.Label();
            this.dashLabel2 = new System.Windows.Forms.Label();
            this.dashTitle1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BillingControlPanel = new ChocAnonGUI.BillControl();
            this.InvalidControlPanel = new ChocAnonGUI.GUI.Operator.InvalidControlPanel();
            this.ReportControlPanel = new ChocAnonGUI.ReportControl();
            this.OperatorControlPanel = new ChocAnonGUI.OpControl();
            this.WelcomeControlPanel = new ChocAnonGUI.WelcomePanel();
            this.verticalPanel.SuspendLayout();
            this.horizontalPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // verticalPanel
            // 
            this.verticalPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.verticalPanel.Controls.Add(this.ReportButton);
            this.verticalPanel.Controls.Add(this.MemberServiceButton);
            this.verticalPanel.Location = new System.Drawing.Point(-1, 100);
            this.verticalPanel.Name = "verticalPanel";
            this.verticalPanel.Size = new System.Drawing.Size(230, 316);
            this.verticalPanel.TabIndex = 0;
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(18, 171);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(193, 145);
            this.ReportButton.TabIndex = 2;
            this.ReportButton.Text = "Report Generator";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // MemberServiceButton
            // 
            this.MemberServiceButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberServiceButton.Location = new System.Drawing.Point(20, 10);
            this.MemberServiceButton.Name = "MemberServiceButton";
            this.MemberServiceButton.Size = new System.Drawing.Size(191, 145);
            this.MemberServiceButton.TabIndex = 0;
            this.MemberServiceButton.Text = "Member Services";
            this.MemberServiceButton.UseVisualStyleBackColor = true;
            this.MemberServiceButton.Click += new System.EventHandler(this.MemberServiceButton_Click);
            // 
            // verticalLine
            // 
            this.verticalLine.BackColor = System.Drawing.Color.Gainsboro;
            this.verticalLine.Location = new System.Drawing.Point(2, 90);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(865, 12);
            this.verticalLine.TabIndex = 3;
            // 
            // horizontalPanel
            // 
            this.horizontalPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.horizontalPanel.Controls.Add(this.panel7);
            this.horizontalPanel.Controls.Add(this.panel5);
            this.horizontalPanel.Controls.Add(this.panel2);
            this.horizontalPanel.Controls.Add(this.panel3);
            this.horizontalPanel.Controls.Add(this.usertitleLabel);
            this.horizontalPanel.Controls.Add(this.dashLabel2);
            this.horizontalPanel.Controls.Add(this.dashTitle1);
            this.horizontalPanel.Location = new System.Drawing.Point(0, -1);
            this.horizontalPanel.Name = "horizontalPanel";
            this.horizontalPanel.Size = new System.Drawing.Size(877, 100);
            this.horizontalPanel.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.AliceBlue;
            this.panel7.Controls.Add(this.settingPicture);
            this.panel7.Location = new System.Drawing.Point(818, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(35, 35);
            this.panel7.TabIndex = 10;
            // 
            // settingPicture
            // 
            this.settingPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingPicture.BackgroundImage")));
            this.settingPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingPicture.Location = new System.Drawing.Point(3, 3);
            this.settingPicture.Name = "settingPicture";
            this.settingPicture.Size = new System.Drawing.Size(30, 30);
            this.settingPicture.TabIndex = 0;
            this.settingPicture.TabStop = false;
            this.settingPicture.Click += new System.EventHandler(this.settingPicture_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(863, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 100);
            this.panel5.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(871, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 100);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(863, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 431);
            this.panel3.TabIndex = 7;
            // 
            // usertitleLabel
            // 
            this.usertitleLabel.AutoSize = true;
            this.usertitleLabel.BackColor = System.Drawing.Color.White;
            this.usertitleLabel.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertitleLabel.Location = new System.Drawing.Point(229, 29);
            this.usertitleLabel.Name = "usertitleLabel";
            this.usertitleLabel.Size = new System.Drawing.Size(584, 32);
            this.usertitleLabel.TabIndex = 3;
            this.usertitleLabel.Text = "This is where the name of the person goes.";
            // 
            // dashLabel2
            // 
            this.dashLabel2.AutoSize = true;
            this.dashLabel2.BackColor = System.Drawing.Color.AliceBlue;
            this.dashLabel2.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLabel2.Location = new System.Drawing.Point(12, 48);
            this.dashLabel2.Name = "dashLabel2";
            this.dashLabel2.Size = new System.Drawing.Size(184, 34);
            this.dashLabel2.TabIndex = 1;
            this.dashLabel2.Text = "Dashboard";
            // 
            // dashTitle1
            // 
            this.dashTitle1.AutoSize = true;
            this.dashTitle1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashTitle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashTitle1.Location = new System.Drawing.Point(22, 10);
            this.dashTitle1.Name = "dashTitle1";
            this.dashTitle1.Size = new System.Drawing.Size(157, 30);
            this.dashTitle1.TabIndex = 0;
            this.dashTitle1.Text = "ChocoHolic";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(-1, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 16);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(225, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 10);
            this.panel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(865, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(17, 434);
            this.panel6.TabIndex = 9;
            // 
            // BillingControlPanel
            // 
            this.BillingControlPanel.Location = new System.Drawing.Point(228, 110);
            this.BillingControlPanel.Name = "BillingControlPanel";
            this.BillingControlPanel.Size = new System.Drawing.Size(639, 306);
            this.BillingControlPanel.TabIndex = 15;
            // 
            // InvalidControlPanel
            // 
            this.InvalidControlPanel.Location = new System.Drawing.Point(228, 110);
            this.InvalidControlPanel.Name = "InvalidControlPanel";
            this.InvalidControlPanel.Size = new System.Drawing.Size(639, 306);
            this.InvalidControlPanel.TabIndex = 14;
            // 
            // ReportControlPanel
            // 
            this.ReportControlPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReportControlPanel.Location = new System.Drawing.Point(228, 110);
            this.ReportControlPanel.Name = "ReportControlPanel";
            this.ReportControlPanel.Size = new System.Drawing.Size(639, 306);
            this.ReportControlPanel.TabIndex = 13;
            // 
            // OperatorControlPanel
            // 
            this.OperatorControlPanel.Location = new System.Drawing.Point(15, 110);
            this.OperatorControlPanel.Name = "OperatorControlPanel";
            this.OperatorControlPanel.Size = new System.Drawing.Size(855, 306);
            this.OperatorControlPanel.TabIndex = 11;
            // 
            // WelcomeControlPanel
            // 
            this.WelcomeControlPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WelcomeControlPanel.Location = new System.Drawing.Point(228, 110);
            this.WelcomeControlPanel.Name = "WelcomeControlPanel";
            this.WelcomeControlPanel.Size = new System.Drawing.Size(639, 306);
            this.WelcomeControlPanel.TabIndex = 10;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 428);
            this.Controls.Add(this.BillingControlPanel);
            this.Controls.Add(this.InvalidControlPanel);
            this.Controls.Add(this.ReportControlPanel);
            this.Controls.Add(this.OperatorControlPanel);
            this.Controls.Add(this.WelcomeControlPanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.verticalLine);
            this.Controls.Add(this.horizontalPanel);
            this.Controls.Add(this.verticalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChocAnon Dashboard";
            this.verticalPanel.ResumeLayout(false);
            this.horizontalPanel.ResumeLayout(false);
            this.horizontalPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel verticalPanel;
        private System.Windows.Forms.Panel horizontalPanel;
        private System.Windows.Forms.Label dashLabel2;
        private System.Windows.Forms.Label dashTitle1;
        private System.Windows.Forms.Panel verticalLine;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button MemberServiceButton;
        private System.Windows.Forms.Label usertitleLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox settingPicture;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private WelcomePanel WelcomeControlPanel;
        private OpControl OperatorControlPanel;
        private ReportControl ReportControlPanel;
        private GUI.Operator.InvalidControlPanel InvalidControlPanel;
        private BillControl BillingControlPanel;
    }
}