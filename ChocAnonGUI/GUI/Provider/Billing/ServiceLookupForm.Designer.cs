using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAnonGUI

{
    partial class ServiceLookupForm
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
            this.servicesListview = new System.Windows.Forms.ListView();
            this.serviceCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serviceFee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicesListview
            // 
            this.servicesListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serviceCode,
            this.serviceName,
            this.serviceFee});
            this.servicesListview.HideSelection = false;
            this.servicesListview.Location = new System.Drawing.Point(16, 81);
            this.servicesListview.Margin = new System.Windows.Forms.Padding(4);
            this.servicesListview.Name = "servicesListview";
            this.servicesListview.Size = new System.Drawing.Size(585, 437);
            this.servicesListview.TabIndex = 2;
            this.servicesListview.UseCompatibleStateImageBehavior = false;
            this.servicesListview.View = System.Windows.Forms.View.Details;
            this.servicesListview.SelectedIndexChanged += new System.EventHandler(this.servicesListview_SelectedIndexChanged);
            // 
            // serviceCode
            // 
            this.serviceCode.Text = "Service Code";
            this.serviceCode.Width = 120;
            // 
            // serviceName
            // 
            this.serviceName.Text = "Service Name";
            this.serviceName.Width = 130;
            // 
            // serviceFee
            // 
            this.serviceFee.Text = "Service Fee";
            this.serviceFee.Width = 105;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 48);
            this.panel1.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(319, 12);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(176, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "MEMBER NAME";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(23, 12);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(235, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Services Available For:";
            // 
            // ServiceLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(620, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.servicesListview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServiceLookupForm";
            this.Text = "ServiceLookupForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView servicesListview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label titleLabel;
        private ColumnHeader serviceCode;
        private ColumnHeader serviceName;
        private ColumnHeader serviceFee;
    }
}