namespace TimeClock
{
    partial class ChangePassword
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtBoxChangePasswordID = new System.Windows.Forms.TextBox();
            this.txtBoxOldPassword = new System.Windows.Forms.TextBox();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(376, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(38, 125);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(202, 32);
            this.lblOldPassword.TabIndex = 1;
            this.lblOldPassword.Text = "Old Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(38, 177);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(213, 32);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(30, 231);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(327, 32);
            this.lblConfirmNewPassword.TabIndex = 3;
            this.lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // txtBoxChangePasswordID
            // 
            this.txtBoxChangePasswordID.Location = new System.Drawing.Point(272, 53);
            this.txtBoxChangePasswordID.Name = "txtBoxChangePasswordID";
            this.txtBoxChangePasswordID.Size = new System.Drawing.Size(235, 22);
            this.txtBoxChangePasswordID.TabIndex = 4;
            this.txtBoxChangePasswordID.TextChanged += new System.EventHandler(this.txtBoxChangePasswordID_TextChanged);
            // 
            // txtBoxOldPassword
            // 
            this.txtBoxOldPassword.Location = new System.Drawing.Point(416, 125);
            this.txtBoxOldPassword.Name = "txtBoxOldPassword";
            this.txtBoxOldPassword.Size = new System.Drawing.Size(235, 22);
            this.txtBoxOldPassword.TabIndex = 5;
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Location = new System.Drawing.Point(416, 177);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.Size = new System.Drawing.Size(235, 22);
            this.txtBoxNewPassword.TabIndex = 6;
            // 
            // txtBoxConfirmNewPassword
            // 
            this.txtBoxConfirmNewPassword.Location = new System.Drawing.Point(416, 241);
            this.txtBoxConfirmNewPassword.Name = "txtBoxConfirmNewPassword";
            this.txtBoxConfirmNewPassword.Size = new System.Drawing.Size(235, 22);
            this.txtBoxConfirmNewPassword.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(272, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(252, 87);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBoxConfirmNewPassword);
            this.Controls.Add(this.txtBoxNewPassword);
            this.Controls.Add(this.txtBoxOldPassword);
            this.Controls.Add(this.txtBoxChangePasswordID);
            this.Controls.Add(this.lblConfirmNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.lblID);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.TextBox txtBoxChangePasswordID;
        private System.Windows.Forms.TextBox txtBoxOldPassword;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.TextBox txtBoxConfirmNewPassword;
        private System.Windows.Forms.Button btnOk;
    }
}