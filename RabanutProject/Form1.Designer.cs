namespace RabanutProject
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
            this.lblDateWriting = new System.Windows.Forms.Label();
            this.lblDayInWeek = new System.Windows.Forms.Label();
            this.lblDayInMonth = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.comboBoxDayInWeek = new System.Windows.Forms.ComboBox();
            this.comboBoxDayInMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.btnShowDate = new System.Windows.Forms.Button();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDateWriting
            // 
            this.lblDateWriting.AutoSize = true;
            this.lblDateWriting.Location = new System.Drawing.Point(375, 30);
            this.lblDateWriting.Name = "lblDateWriting";
            this.lblDateWriting.Size = new System.Drawing.Size(76, 16);
            this.lblDateWriting.TabIndex = 0;
            this.lblDateWriting.Text = "Date writing";
            // 
            // lblDayInWeek
            // 
            this.lblDayInWeek.AutoSize = true;
            this.lblDayInWeek.Location = new System.Drawing.Point(692, 101);
            this.lblDayInWeek.Name = "lblDayInWeek";
            this.lblDayInWeek.Size = new System.Drawing.Size(80, 16);
            this.lblDayInWeek.TabIndex = 1;
            this.lblDayInWeek.Text = "Day in week";
            // 
            // lblDayInMonth
            // 
            this.lblDayInMonth.AutoSize = true;
            this.lblDayInMonth.Location = new System.Drawing.Point(508, 101);
            this.lblDayInMonth.Name = "lblDayInMonth";
            this.lblDayInMonth.Size = new System.Drawing.Size(84, 16);
            this.lblDayInMonth.TabIndex = 2;
            this.lblDayInMonth.Text = "Day in month";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(325, 101);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(43, 16);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "Month";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(101, 101);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 16);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // comboBoxDayInWeek
            // 
            this.comboBoxDayInWeek.FormattingEnabled = true;
            this.comboBoxDayInWeek.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "ששי"});
            this.comboBoxDayInWeek.Location = new System.Drawing.Point(651, 154);
            this.comboBoxDayInWeek.Name = "comboBoxDayInWeek";
            this.comboBoxDayInWeek.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDayInWeek.TabIndex = 5;
            // 
            // comboBoxDayInMonth
            // 
            this.comboBoxDayInMonth.FormattingEnabled = true;
            this.comboBoxDayInMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBoxDayInMonth.Location = new System.Drawing.Point(494, 154);
            this.comboBoxDayInMonth.Name = "comboBoxDayInMonth";
            this.comboBoxDayInMonth.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDayInMonth.TabIndex = 6;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "תשרי",
            "מרחשוון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר",
            "אדר הראשון",
            "אדר השני",
            "ניסן",
            "אייר",
            "סיוון",
            "תמוז",
            "אב ",
            "אלול"});
            this.comboBoxMonth.Location = new System.Drawing.Point(276, 154);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMonth.TabIndex = 7;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "תשפ\'\'ד",
            "תשפ\'\'ה",
            "תשפ\'\'ו",
            "תשפ\'\'ז",
            "תשפ\'\'ח",
            "תשפ\'\'ט",
            "תש\'\'צ",
            "תשצ\'\'א",
            "תשצ\'\'ב",
            "תשצ\'\'ג"});
            this.comboBoxYear.Location = new System.Drawing.Point(60, 154);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYear.TabIndex = 8;
            // 
            // btnShowDate
            // 
            this.btnShowDate.Location = new System.Drawing.Point(404, 247);
            this.btnShowDate.Name = "btnShowDate";
            this.btnShowDate.Size = new System.Drawing.Size(75, 23);
            this.btnShowDate.TabIndex = 9;
            this.btnShowDate.Text = "Show date";
            this.btnShowDate.UseVisualStyleBackColor = true;
            this.btnShowDate.Click += new System.EventHandler(this.btnShowDate_Click);
            // 
            // lblShowDate
            // 
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Location = new System.Drawing.Point(57, 313);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(69, 16);
            this.lblShowDate.TabIndex = 10;
            this.lblShowDate.Text = "ShowDate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 450);
            this.Controls.Add(this.lblShowDate);
            this.Controls.Add(this.btnShowDate);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxDayInMonth);
            this.Controls.Add(this.comboBoxDayInWeek);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblDayInMonth);
            this.Controls.Add(this.lblDayInWeek);
            this.Controls.Add(this.lblDateWriting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateWriting;
        private System.Windows.Forms.Label lblDayInWeek;
        private System.Windows.Forms.Label lblDayInMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox comboBoxDayInWeek;
        private System.Windows.Forms.ComboBox comboBoxDayInMonth;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Button btnShowDate;
        private System.Windows.Forms.Label lblShowDate;
    }
}

