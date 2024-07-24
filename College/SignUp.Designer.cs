namespace College
{
    partial class SignUp
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
            this.lblEnterAName = new System.Windows.Forms.Label();
            this.txtBoxEnterAName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterAName
            // 
            this.lblEnterAName.AutoSize = true;
            this.lblEnterAName.Location = new System.Drawing.Point(368, 46);
            this.lblEnterAName.Name = "lblEnterAName";
            this.lblEnterAName.Size = new System.Drawing.Size(86, 16);
            this.lblEnterAName.TabIndex = 0;
            this.lblEnterAName.Text = "Enter a name";
            // 
            // txtBoxEnterAName
            // 
            this.txtBoxEnterAName.Location = new System.Drawing.Point(371, 89);
            this.txtBoxEnterAName.Name = "txtBoxEnterAName";
            this.txtBoxEnterAName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxEnterAName.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(75, 356);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBoxEnterAName);
            this.Controls.Add(this.lblEnterAName);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterAName;
        private System.Windows.Forms.TextBox txtBoxEnterAName;
        private System.Windows.Forms.Button btnOK;
    }
}