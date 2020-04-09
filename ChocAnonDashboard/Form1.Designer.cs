namespace ChocAnonDashboard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.managerButton = new System.Windows.Forms.Button();
            this.operatorButton = new System.Windows.Forms.Button();
            this.memberButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.providerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.providerPage1 = new ChocAnonDashboard.providerPage();
            this.operatorPage1 = new ChocAnonDashboard.operatorPage();
            this.memberPage1 = new ChocAnonDashboard.memberPage();
            this.managerPage1 = new ChocAnonDashboard.managerPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.managerButton);
            this.panel1.Controls.Add(this.operatorButton);
            this.panel1.Controls.Add(this.memberButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.providerButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 629);
            this.panel1.TabIndex = 0;
            // 
            // managerButton
            // 
            this.managerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerButton.Location = new System.Drawing.Point(7, 493);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(217, 124);
            this.managerButton.TabIndex = 2;
            this.managerButton.Text = "Manager";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // operatorButton
            // 
            this.operatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorButton.Location = new System.Drawing.Point(7, 362);
            this.operatorButton.Name = "operatorButton";
            this.operatorButton.Size = new System.Drawing.Size(217, 125);
            this.operatorButton.TabIndex = 2;
            this.operatorButton.Text = "Operator";
            this.operatorButton.UseVisualStyleBackColor = true;
            this.operatorButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // memberButton
            // 
            this.memberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberButton.Location = new System.Drawing.Point(7, 231);
            this.memberButton.Name = "memberButton";
            this.memberButton.Size = new System.Drawing.Size(217, 125);
            this.memberButton.TabIndex = 3;
            this.memberButton.Text = "Member";
            this.memberButton.UseVisualStyleBackColor = true;
            this.memberButton.Click += new System.EventHandler(this.memberButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dashboard";
            // 
            // providerButton
            // 
            this.providerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerButton.Location = new System.Drawing.Point(7, 100);
            this.providerButton.Name = "providerButton";
            this.providerButton.Size = new System.Drawing.Size(217, 125);
            this.providerButton.TabIndex = 2;
            this.providerButton.Text = "Provider";
            this.providerButton.UseVisualStyleBackColor = true;
            this.providerButton.Click += new System.EventHandler(this.providerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ChocoHolic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.Controls.Add(this.settingsButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(236, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 71);
            this.panel2.TabIndex = 1;
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(809, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(69, 44);
            this.settingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsButton.TabIndex = 1;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(687, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "***Welcome To The ChocoAnon Dashboard ***";
            // 
            // providerPage1
            // 
            this.providerPage1.Location = new System.Drawing.Point(242, 78);
            this.providerPage1.Name = "providerPage1";
            this.providerPage1.Size = new System.Drawing.Size(871, 538);
            this.providerPage1.TabIndex = 5;
            // 
            // operatorPage1
            // 
            this.operatorPage1.Location = new System.Drawing.Point(263, 78);
            this.operatorPage1.Name = "operatorPage1";
            this.operatorPage1.Size = new System.Drawing.Size(880, 540);
            this.operatorPage1.TabIndex = 4;
            // 
            // memberPage1
            // 
            this.memberPage1.Location = new System.Drawing.Point(263, 78);
            this.memberPage1.Name = "memberPage1";
            this.memberPage1.Size = new System.Drawing.Size(871, 552);
            this.memberPage1.TabIndex = 3;
            // 
            // managerPage1
            // 
            this.managerPage1.Location = new System.Drawing.Point(263, 80);
            this.managerPage1.Name = "managerPage1";
            this.managerPage1.Size = new System.Drawing.Size(880, 550);
            this.managerPage1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1142, 629);
            this.Controls.Add(this.providerPage1);
            this.Controls.Add(this.operatorPage1);
            this.Controls.Add(this.memberPage1);
            this.Controls.Add(this.managerPage1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ChocoAnon Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button managerButton;
        private System.Windows.Forms.Button operatorButton;
        private System.Windows.Forms.Button memberButton;
        private System.Windows.Forms.Button providerButton;
        private System.Windows.Forms.Label label3;
        private managerPage managerPage1;
        private memberPage memberPage1;
        private operatorPage operatorPage1;
        private providerPage providerPage1;
        private System.Windows.Forms.PictureBox settingsButton;
    }
}

