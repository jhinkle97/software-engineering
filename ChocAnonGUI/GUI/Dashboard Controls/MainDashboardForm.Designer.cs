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
            this.logoutButton = new System.Windows.Forms.Button();
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
            this.BillingControlPanel = new ChocAnonGUI.BillingPanel();
            this.InvalidControlPanel = new ChocAnonGUI.GUI.Operator.InvalidControlPanel();
            this.ReportControlPanel = new ChocAnonGUI.ReportsPanel();
            this.OperatorControlPanel = new ChocAnonGUI.OperatorDashboardPanel();
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
            this.verticalPanel.Location = new System.Drawing.Point(-1, 123);
            this.verticalPanel.Margin = new System.Windows.Forms.Padding(4);
            this.verticalPanel.Name = "verticalPanel";
            this.verticalPanel.Size = new System.Drawing.Size(307, 389);
            this.verticalPanel.TabIndex = 0;
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(24, 210);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(257, 178);
            this.ReportButton.TabIndex = 2;
            this.ReportButton.Text = "Report Generator";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // MemberServiceButton
            // 
            this.MemberServiceButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberServiceButton.Location = new System.Drawing.Point(27, 12);
            this.MemberServiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.MemberServiceButton.Name = "MemberServiceButton";
            this.MemberServiceButton.Size = new System.Drawing.Size(255, 178);
            this.MemberServiceButton.TabIndex = 0;
            this.MemberServiceButton.Text = "Member Services";
            this.MemberServiceButton.UseVisualStyleBackColor = true;
            this.MemberServiceButton.Click += new System.EventHandler(this.MemberServiceButton_Click);
            // 
            // verticalLine
            // 
            this.verticalLine.BackColor = System.Drawing.Color.Gainsboro;
            this.verticalLine.Location = new System.Drawing.Point(3, 111);
            this.verticalLine.Margin = new System.Windows.Forms.Padding(4);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(1153, 15);
            this.verticalLine.TabIndex = 3;
            // 
            // horizontalPanel
            // 
            this.horizontalPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.horizontalPanel.Controls.Add(this.logoutButton);
            this.horizontalPanel.Controls.Add(this.panel7);
            this.horizontalPanel.Controls.Add(this.panel5);
            this.horizontalPanel.Controls.Add(this.panel2);
            this.horizontalPanel.Controls.Add(this.panel3);
            this.horizontalPanel.Controls.Add(this.usertitleLabel);
            this.horizontalPanel.Controls.Add(this.dashLabel2);
            this.horizontalPanel.Controls.Add(this.dashTitle1);
            this.horizontalPanel.Location = new System.Drawing.Point(0, -1);
            this.horizontalPanel.Margin = new System.Windows.Forms.Padding(4);
            this.horizontalPanel.Name = "horizontalPanel";
            this.horizontalPanel.Size = new System.Drawing.Size(1169, 123);
            this.horizontalPanel.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1068, 69);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(78, 30);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.AliceBlue;
            this.panel7.Controls.Add(this.settingPicture);
            this.panel7.Location = new System.Drawing.Point(1096, 14);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 43);
            this.panel7.TabIndex = 10;
            // 
            // settingPicture
            // 
            this.settingPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingPicture.BackgroundImage")));
            this.settingPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingPicture.Location = new System.Drawing.Point(3, 2);
            this.settingPicture.Margin = new System.Windows.Forms.Padding(4);
            this.settingPicture.Name = "settingPicture";
            this.settingPicture.Size = new System.Drawing.Size(40, 37);
            this.settingPicture.TabIndex = 0;
            this.settingPicture.TabStop = false;
            this.settingPicture.Click += new System.EventHandler(this.settingPicture_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(1151, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 123);
            this.panel5.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1161, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 123);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(1151, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 530);
            this.panel3.TabIndex = 7;
            // 
            // usertitleLabel
            // 
            this.usertitleLabel.AutoSize = true;
            this.usertitleLabel.BackColor = System.Drawing.Color.White;
            this.usertitleLabel.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertitleLabel.Location = new System.Drawing.Point(305, 36);
            this.usertitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usertitleLabel.Name = "usertitleLabel";
            this.usertitleLabel.Size = new System.Drawing.Size(738, 42);
            this.usertitleLabel.TabIndex = 3;
            this.usertitleLabel.Text = "This is where the name of the person goes.";
            // 
            // dashLabel2
            // 
            this.dashLabel2.AutoSize = true;
            this.dashLabel2.BackColor = System.Drawing.Color.AliceBlue;
            this.dashLabel2.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLabel2.Location = new System.Drawing.Point(16, 59);
            this.dashLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashLabel2.Name = "dashLabel2";
            this.dashLabel2.Size = new System.Drawing.Size(228, 40);
            this.dashLabel2.TabIndex = 1;
            this.dashLabel2.Text = "Dashboard";
            // 
            // dashTitle1
            // 
            this.dashTitle1.AutoSize = true;
            this.dashTitle1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashTitle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashTitle1.Location = new System.Drawing.Point(29, 12);
            this.dashTitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashTitle1.Name = "dashTitle1";
            this.dashTitle1.Size = new System.Drawing.Size(201, 36);
            this.dashTitle1.TabIndex = 0;
            this.dashTitle1.Text = "ChocoHolic";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(-1, 512);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 20);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(300, 126);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(856, 12);
            this.panel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(1153, -1);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(23, 534);
            this.panel6.TabIndex = 9;
            // 
            // BillingControlPanel
            // 
            this.BillingControlPanel.Location = new System.Drawing.Point(304, 135);
            this.BillingControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.BillingControlPanel.Name = "BillingControlPanel";
            this.BillingControlPanel.Size = new System.Drawing.Size(852, 377);
            this.BillingControlPanel.TabIndex = 15;
            // 
            // InvalidControlPanel
            // 
            this.InvalidControlPanel.Location = new System.Drawing.Point(304, 135);
            this.InvalidControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.InvalidControlPanel.Name = "InvalidControlPanel";
            this.InvalidControlPanel.Size = new System.Drawing.Size(852, 377);
            this.InvalidControlPanel.TabIndex = 14;
            // 
            // ReportControlPanel
            // 
            this.ReportControlPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReportControlPanel.Location = new System.Drawing.Point(304, 135);
            this.ReportControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.ReportControlPanel.Name = "ReportControlPanel";
            this.ReportControlPanel.Size = new System.Drawing.Size(852, 377);
            this.ReportControlPanel.TabIndex = 13;
            // 
            // OperatorControlPanel
            // 
            this.OperatorControlPanel.Location = new System.Drawing.Point(20, 135);
            this.OperatorControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.OperatorControlPanel.Name = "OperatorControlPanel";
            this.OperatorControlPanel.Size = new System.Drawing.Size(1140, 377);
            this.OperatorControlPanel.TabIndex = 11;
            // 
            // WelcomeControlPanel
            // 
            this.WelcomeControlPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WelcomeControlPanel.Location = new System.Drawing.Point(304, 135);
            this.WelcomeControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.WelcomeControlPanel.Name = "WelcomeControlPanel";
            this.WelcomeControlPanel.Size = new System.Drawing.Size(852, 377);
            this.WelcomeControlPanel.TabIndex = 10;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 527);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private OperatorDashboardPanel OperatorControlPanel;
        private ReportsPanel ReportControlPanel;
        private GUI.Operator.InvalidControlPanel InvalidControlPanel;
        private BillingPanel BillingControlPanel;
        private System.Windows.Forms.Button logoutButton;
    }
}