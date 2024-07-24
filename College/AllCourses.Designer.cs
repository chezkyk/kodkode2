namespace College
{
    partial class AllCourses
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
            this.lblHelloStudent = new System.Windows.Forms.Label();
            this.lblAllCourses = new System.Windows.Forms.Label();
            this.lblCourseSignUp = new System.Windows.Forms.Label();
            this.lblNameCourse = new System.Windows.Forms.Label();
            this.dtGrdVwAllCourses = new System.Windows.Forms.DataGridView();
            this.txtBoxNameCourse = new System.Windows.Forms.TextBox();
            this.lstBoxNameCourse = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwAllCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelloStudent
            // 
            this.lblHelloStudent.AutoSize = true;
            this.lblHelloStudent.Location = new System.Drawing.Point(353, 9);
            this.lblHelloStudent.Name = "lblHelloStudent";
            this.lblHelloStudent.Size = new System.Drawing.Size(85, 16);
            this.lblHelloStudent.TabIndex = 0;
            this.lblHelloStudent.Text = "Hello student";
            // 
            // lblAllCourses
            // 
            this.lblAllCourses.AutoSize = true;
            this.lblAllCourses.Location = new System.Drawing.Point(353, 40);
            this.lblAllCourses.Name = "lblAllCourses";
            this.lblAllCourses.Size = new System.Drawing.Size(73, 16);
            this.lblAllCourses.TabIndex = 1;
            this.lblAllCourses.Text = "All courses";
            // 
            // lblCourseSignUp
            // 
            this.lblCourseSignUp.AutoSize = true;
            this.lblCourseSignUp.Location = new System.Drawing.Point(351, 195);
            this.lblCourseSignUp.Name = "lblCourseSignUp";
            this.lblCourseSignUp.Size = new System.Drawing.Size(125, 16);
            this.lblCourseSignUp.TabIndex = 2;
            this.lblCourseSignUp.Text = "Sign up for a course";
            // 
            // lblNameCourse
            // 
            this.lblNameCourse.AutoSize = true;
            this.lblNameCourse.Location = new System.Drawing.Point(310, 227);
            this.lblNameCourse.Name = "lblNameCourse";
            this.lblNameCourse.Size = new System.Drawing.Size(204, 16);
            this.lblNameCourse.TabIndex = 3;
            this.lblNameCourse.Text = "type a name or select from the list";
            // 
            // dtGrdVwAllCourses
            // 
            this.dtGrdVwAllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwAllCourses.Location = new System.Drawing.Point(132, 59);
            this.dtGrdVwAllCourses.Name = "dtGrdVwAllCourses";
            this.dtGrdVwAllCourses.RowHeadersWidth = 51;
            this.dtGrdVwAllCourses.RowTemplate.Height = 24;
            this.dtGrdVwAllCourses.Size = new System.Drawing.Size(556, 133);
            this.dtGrdVwAllCourses.TabIndex = 4;
            // 
            // txtBoxNameCourse
            // 
            this.txtBoxNameCourse.Location = new System.Drawing.Point(356, 267);
            this.txtBoxNameCourse.Name = "txtBoxNameCourse";
            this.txtBoxNameCourse.Size = new System.Drawing.Size(100, 22);
            this.txtBoxNameCourse.TabIndex = 5;
            this.txtBoxNameCourse.TextChanged += new System.EventHandler(this.txtBoxNameCourse_TextChanged);
            // 
            // lstBoxNameCourse
            // 
            this.lstBoxNameCourse.FormattingEnabled = true;
            this.lstBoxNameCourse.ItemHeight = 16;
            this.lstBoxNameCourse.Location = new System.Drawing.Point(356, 295);
            this.lstBoxNameCourse.Name = "lstBoxNameCourse";
            this.lstBoxNameCourse.Size = new System.Drawing.Size(120, 84);
            this.lstBoxNameCourse.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(71, 401);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AllCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lstBoxNameCourse);
            this.Controls.Add(this.txtBoxNameCourse);
            this.Controls.Add(this.dtGrdVwAllCourses);
            this.Controls.Add(this.lblNameCourse);
            this.Controls.Add(this.lblCourseSignUp);
            this.Controls.Add(this.lblAllCourses);
            this.Controls.Add(this.lblHelloStudent);
            this.Name = "AllCourses";
            this.Text = "AllCourses";
            this.Load += new System.EventHandler(this.AllCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwAllCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloStudent;
        private System.Windows.Forms.Label lblAllCourses;
        private System.Windows.Forms.Label lblCourseSignUp;
        private System.Windows.Forms.Label lblNameCourse;
        private System.Windows.Forms.DataGridView dtGrdVwAllCourses;
        private System.Windows.Forms.TextBox txtBoxNameCourse;
        private System.Windows.Forms.ListBox lstBoxNameCourse;
        private System.Windows.Forms.Button btnOk;
    }
}