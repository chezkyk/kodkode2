namespace Administrator
{
    partial class AddCourses
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxCourseName = new System.Windows.Forms.TextBox();
            this.txtBoxStartDay = new System.Windows.Forms.TextBox();
            this.txtBoxDaysAWeek = new System.Windows.Forms.TextBox();
            this.txtBoxStudyHours = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.dtGrdVwAllCourses = new System.Windows.Forms.DataGridView();
            this.btnShowInterested = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwAllCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Days a week";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Study hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "All courses";
            // 
            // txtBoxCourseName
            // 
            this.txtBoxCourseName.Location = new System.Drawing.Point(121, 157);
            this.txtBoxCourseName.Name = "txtBoxCourseName";
            this.txtBoxCourseName.Size = new System.Drawing.Size(145, 22);
            this.txtBoxCourseName.TabIndex = 7;
            // 
            // txtBoxStartDay
            // 
            this.txtBoxStartDay.Location = new System.Drawing.Point(121, 214);
            this.txtBoxStartDay.Name = "txtBoxStartDay";
            this.txtBoxStartDay.Size = new System.Drawing.Size(145, 22);
            this.txtBoxStartDay.TabIndex = 8;
            // 
            // txtBoxDaysAWeek
            // 
            this.txtBoxDaysAWeek.Location = new System.Drawing.Point(121, 267);
            this.txtBoxDaysAWeek.Name = "txtBoxDaysAWeek";
            this.txtBoxDaysAWeek.Size = new System.Drawing.Size(145, 22);
            this.txtBoxDaysAWeek.TabIndex = 9;
            // 
            // txtBoxStudyHours
            // 
            this.txtBoxStudyHours.Location = new System.Drawing.Point(121, 313);
            this.txtBoxStudyHours.Name = "txtBoxStudyHours";
            this.txtBoxStudyHours.Size = new System.Drawing.Size(145, 22);
            this.txtBoxStudyHours.TabIndex = 10;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(121, 361);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(145, 22);
            this.txtBoxPrice.TabIndex = 11;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(12, 395);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(223, 43);
            this.btnAddCourse.TabIndex = 12;
            this.btnAddCourse.Text = "Add course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // dtGrdVwAllCourses
            // 
            this.dtGrdVwAllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwAllCourses.Location = new System.Drawing.Point(287, 66);
            this.dtGrdVwAllCourses.Name = "dtGrdVwAllCourses";
            this.dtGrdVwAllCourses.RowHeadersWidth = 51;
            this.dtGrdVwAllCourses.RowTemplate.Height = 24;
            this.dtGrdVwAllCourses.Size = new System.Drawing.Size(501, 352);
            this.dtGrdVwAllCourses.TabIndex = 13;
            // 
            // btnShowInterested
            // 
            this.btnShowInterested.Location = new System.Drawing.Point(23, 34);
            this.btnShowInterested.Name = "btnShowInterested";
            this.btnShowInterested.Size = new System.Drawing.Size(163, 51);
            this.btnShowInterested.TabIndex = 14;
            this.btnShowInterested.Text = "Show interested";
            this.btnShowInterested.UseVisualStyleBackColor = true;
            this.btnShowInterested.Click += new System.EventHandler(this.btnShowInterested_Click);
            // 
            // AddCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowInterested);
            this.Controls.Add(this.dtGrdVwAllCourses);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxStudyHours);
            this.Controls.Add(this.txtBoxDaysAWeek);
            this.Controls.Add(this.txtBoxStartDay);
            this.Controls.Add(this.txtBoxCourseName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourses";
            this.Text = "AddCourses";
            this.Load += new System.EventHandler(this.AddCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwAllCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxCourseName;
        private System.Windows.Forms.TextBox txtBoxStartDay;
        private System.Windows.Forms.TextBox txtBoxDaysAWeek;
        private System.Windows.Forms.TextBox txtBoxStudyHours;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.DataGridView dtGrdVwAllCourses;
        private System.Windows.Forms.Button btnShowInterested;
    }
}