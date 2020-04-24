using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI
{
    partial class SettingsForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.devTitle = new System.Windows.Forms.Label();
            this.rileyLabel = new System.Windows.Forms.Label();
            this.kyleLabel = new System.Windows.Forms.Label();
            this.justinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(32, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(378, 33);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "CHOC ANON DASHBOARD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "EXTREME TEAM SOFTWARE SOLUTIONS";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(9, 92);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(56, 16);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version:";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(63, 93);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(46, 16);
            this.version.TabIndex = 3;
            this.version.Text = "V1.0.0";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(9, 113);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(71, 16);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Build Date:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(79, 115);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(66, 14);
            this.date.TabIndex = 5;
            this.date.Text = "4/28/2020";
            // 
            // devTitle
            // 
            this.devTitle.AutoSize = true;
            this.devTitle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devTitle.Location = new System.Drawing.Point(212, 92);
            this.devTitle.Name = "devTitle";
            this.devTitle.Size = new System.Drawing.Size(157, 19);
            this.devTitle.TabIndex = 6;
            this.devTitle.Text = "Leading Developers";
            // 
            // rileyLabel
            // 
            this.rileyLabel.AutoSize = true;
            this.rileyLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rileyLabel.Location = new System.Drawing.Point(171, 118);
            this.rileyLabel.Name = "rileyLabel";
            this.rileyLabel.Size = new System.Drawing.Size(250, 16);
            this.rileyLabel.TabIndex = 7;
            this.rileyLabel.Text = "Riley Kalb - UI and FrontEnd Development";
            // 
            // kyleLabel
            // 
            this.kyleLabel.AutoSize = true;
            this.kyleLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyleLabel.Location = new System.Drawing.Point(160, 139);
            this.kyleLabel.Name = "kyleLabel";
            this.kyleLabel.Size = new System.Drawing.Size(286, 16);
            this.kyleLabel.TabIndex = 8;
            this.kyleLabel.Text = "Kyle Sherman - Program Flow and Requirements";
            // 
            // justinLabel
            // 
            this.justinLabel.AutoSize = true;
            this.justinLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justinLabel.Location = new System.Drawing.Point(141, 158);
            this.justinLabel.Name = "justinLabel";
            this.justinLabel.Size = new System.Drawing.Size(326, 16);
            this.justinLabel.TabIndex = 9;
            this.justinLabel.Text = "Justin Hinkle - Backend Data Control and SQL Database";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 207);
            this.Controls.Add(this.justinLabel);
            this.Controls.Add(this.kyleLabel);
            this.Controls.Add(this.rileyLabel);
            this.Controls.Add(this.devTitle);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.version);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChocAnon Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label devTitle;
        private System.Windows.Forms.Label rileyLabel;
        private System.Windows.Forms.Label kyleLabel;
        private System.Windows.Forms.Label justinLabel;
    }
}