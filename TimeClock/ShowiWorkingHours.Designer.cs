namespace TimeClock
{
    partial class ShowiWorkingHours
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
            this.txtBoxIDSWH = new System.Windows.Forms.TextBox();
            this.btnOkSWH = new System.Windows.Forms.Button();
            this.txtBoxPasswordSWH = new System.Windows.Forms.TextBox();
            this.lblIDSWH = new System.Windows.Forms.Label();
            this.lblPasswordSWH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxIDSWH
            // 
            this.txtBoxIDSWH.Location = new System.Drawing.Point(183, 41);
            this.txtBoxIDSWH.Name = "txtBoxIDSWH";
            this.txtBoxIDSWH.Size = new System.Drawing.Size(100, 22);
            this.txtBoxIDSWH.TabIndex = 0;
            // 
            // btnOkSWH
            // 
            this.btnOkSWH.Location = new System.Drawing.Point(183, 198);
            this.btnOkSWH.Name = "btnOkSWH";
            this.btnOkSWH.Size = new System.Drawing.Size(100, 23);
            this.btnOkSWH.TabIndex = 1;
            this.btnOkSWH.Text = "OK";
            this.btnOkSWH.UseVisualStyleBackColor = true;
            this.btnOkSWH.Click += new System.EventHandler(this.btnOkSWH_Click);
            // 
            // txtBoxPasswordSWH
            // 
            this.txtBoxPasswordSWH.Location = new System.Drawing.Point(183, 123);
            this.txtBoxPasswordSWH.Name = "txtBoxPasswordSWH";
            this.txtBoxPasswordSWH.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPasswordSWH.TabIndex = 2;
            // 
            // lblIDSWH
            // 
            this.lblIDSWH.AutoSize = true;
            this.lblIDSWH.Location = new System.Drawing.Point(89, 41);
            this.lblIDSWH.Name = "lblIDSWH";
            this.lblIDSWH.Size = new System.Drawing.Size(20, 16);
            this.lblIDSWH.TabIndex = 3;
            this.lblIDSWH.Text = "ID";
            // 
            // lblPasswordSWH
            // 
            this.lblPasswordSWH.AutoSize = true;
            this.lblPasswordSWH.Location = new System.Drawing.Point(89, 123);
            this.lblPasswordSWH.Name = "lblPasswordSWH";
            this.lblPasswordSWH.Size = new System.Drawing.Size(67, 16);
            this.lblPasswordSWH.TabIndex = 4;
            this.lblPasswordSWH.Text = "Password";
            this.lblPasswordSWH.Click += new System.EventHandler(this.lblPasswordSWH_Click);
            // 
            // ShowiWorkingHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPasswordSWH);
            this.Controls.Add(this.lblIDSWH);
            this.Controls.Add(this.txtBoxPasswordSWH);
            this.Controls.Add(this.btnOkSWH);
            this.Controls.Add(this.txtBoxIDSWH);
            this.Name = "ShowiWorkingHours";
            this.Text = "ShowiWorkingHours";
            this.Load += new System.EventHandler(this.ShowiWorkingHours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIDSWH;
        private System.Windows.Forms.Button btnOkSWH;
        private System.Windows.Forms.TextBox txtBoxPasswordSWH;
        private System.Windows.Forms.Label lblIDSWH;
        private System.Windows.Forms.Label lblPasswordSWH;
    }
}