namespace TimeClock
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
            this.lblEnterID = new System.Windows.Forms.Label();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.txtBoxEnterID = new System.Windows.Forms.TextBox();
            this.txtBoxEnterPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnShowiWorkingHours = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterID.Location = new System.Drawing.Point(331, 19);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(124, 32);
            this.lblEnterID.TabIndex = 0;
            this.lblEnterID.Text = "Enter ID";
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPassword.Location = new System.Drawing.Point(277, 178);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(227, 32);
            this.lblEnterPassword.TabIndex = 1;
            this.lblEnterPassword.Text = "Enter Password";
            this.lblEnterPassword.Click += new System.EventHandler(this.lblEnterPassword_Click);
            // 
            // txtBoxEnterID
            // 
            this.txtBoxEnterID.Location = new System.Drawing.Point(271, 68);
            this.txtBoxEnterID.Name = "txtBoxEnterID";
            this.txtBoxEnterID.Size = new System.Drawing.Size(245, 22);
            this.txtBoxEnterID.TabIndex = 2;
            // 
            // txtBoxEnterPassword
            // 
            this.txtBoxEnterPassword.Location = new System.Drawing.Point(271, 239);
            this.txtBoxEnterPassword.Name = "txtBoxEnterPassword";
            this.txtBoxEnterPassword.Size = new System.Drawing.Size(245, 22);
            this.txtBoxEnterPassword.TabIndex = 3;
            this.txtBoxEnterPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEnterPassword_KeyPress);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(32, 304);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(206, 120);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnShowiWorkingHours
            // 
            this.btnShowiWorkingHours.Location = new System.Drawing.Point(548, 304);
            this.btnShowiWorkingHours.Name = "btnShowiWorkingHours";
            this.btnShowiWorkingHours.Size = new System.Drawing.Size(210, 120);
            this.btnShowiWorkingHours.TabIndex = 5;
            this.btnShowiWorkingHours.Text = "Show working hours";
            this.btnShowiWorkingHours.UseVisualStyleBackColor = true;
            this.btnShowiWorkingHours.Click += new System.EventHandler(this.btnShowiWorkingHours_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowiWorkingHours);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtBoxEnterPassword);
            this.Controls.Add(this.txtBoxEnterID);
            this.Controls.Add(this.lblEnterPassword);
            this.Controls.Add(this.lblEnterID);
            this.Name = "Form1";
            this.Text = "Time Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterID;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.TextBox txtBoxEnterID;
        private System.Windows.Forms.TextBox txtBoxEnterPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnShowiWorkingHours;
    }
}

