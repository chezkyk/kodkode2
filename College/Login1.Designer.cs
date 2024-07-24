namespace College
{
    partial class Login1
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
            this.lblStudentLogin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnPersonalArea = new System.Windows.Forms.Button();
            this.btnCourseSignUp = new System.Windows.Forms.Button();
            this.lstBoxNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStudentLogin
            // 
            this.lblStudentLogin.AutoSize = true;
            this.lblStudentLogin.Location = new System.Drawing.Point(335, 36);
            this.lblStudentLogin.Name = "lblStudentLogin";
            this.lblStudentLogin.Size = new System.Drawing.Size(84, 16);
            this.lblStudentLogin.TabIndex = 0;
            this.lblStudentLogin.Text = "Student login";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(269, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(222, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "type your name or select from the list";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Location = new System.Drawing.Point(152, 307);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(168, 16);
            this.lblSignUp.TabIndex = 2;
            this.lblSignUp.Text = "Haven\'t you signed up yet?";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(313, 93);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 22);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(445, 307);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(84, 40);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnPersonalArea
            // 
            this.btnPersonalArea.Location = new System.Drawing.Point(624, 377);
            this.btnPersonalArea.Name = "btnPersonalArea";
            this.btnPersonalArea.Size = new System.Drawing.Size(132, 61);
            this.btnPersonalArea.TabIndex = 6;
            this.btnPersonalArea.Text = "Personal area";
            this.btnPersonalArea.UseVisualStyleBackColor = true;
            this.btnPersonalArea.Click += new System.EventHandler(this.btnPersonalArea_Click);
            // 
            // btnCourseSignUp
            // 
            this.btnCourseSignUp.Location = new System.Drawing.Point(58, 380);
            this.btnCourseSignUp.Name = "btnCourseSignUp";
            this.btnCourseSignUp.Size = new System.Drawing.Size(142, 58);
            this.btnCourseSignUp.TabIndex = 7;
            this.btnCourseSignUp.Text = "Sign up for a course";
            this.btnCourseSignUp.UseVisualStyleBackColor = true;
            this.btnCourseSignUp.Click += new System.EventHandler(this.btnCourseSignUp_Click);
            // 
            // lstBoxNames
            // 
            this.lstBoxNames.FormattingEnabled = true;
            this.lstBoxNames.ItemHeight = 16;
            this.lstBoxNames.Location = new System.Drawing.Point(313, 139);
            this.lstBoxNames.Name = "lstBoxNames";
            this.lstBoxNames.Size = new System.Drawing.Size(147, 148);
            this.lstBoxNames.TabIndex = 8;
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxNames);
            this.Controls.Add(this.btnCourseSignUp);
            this.Controls.Add(this.btnPersonalArea);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentLogin);
            this.Name = "Login1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentLogin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnPersonalArea;
        private System.Windows.Forms.Button btnCourseSignUp;
        private System.Windows.Forms.ListBox lstBoxNames;
    }
}

