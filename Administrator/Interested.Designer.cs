﻿namespace Administrator
{
    partial class Interested
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
            this.dtGidVwShowInterested = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGidVwShowInterested)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show interested";
            // 
            // dtGidVwShowInterested
            // 
            this.dtGidVwShowInterested.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGidVwShowInterested.Location = new System.Drawing.Point(37, 95);
            this.dtGidVwShowInterested.Name = "dtGidVwShowInterested";
            this.dtGidVwShowInterested.RowHeadersWidth = 51;
            this.dtGidVwShowInterested.RowTemplate.Height = 24;
            this.dtGidVwShowInterested.Size = new System.Drawing.Size(723, 330);
            this.dtGidVwShowInterested.TabIndex = 1;
            // 
            // Interested
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGidVwShowInterested);
            this.Controls.Add(this.label1);
            this.Name = "Interested";
            this.Text = "Interested";
            this.Load += new System.EventHandler(this.Interested_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGidVwShowInterested)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGidVwShowInterested;
    }
}