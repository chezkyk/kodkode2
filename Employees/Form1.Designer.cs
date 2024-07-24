namespace Employees
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
            this.DtTmPckrDateBirth = new System.Windows.Forms.DateTimePicker();
            this.RdBtnSingle = new System.Windows.Forms.RadioButton();
            this.RdBtnMarried = new System.Windows.Forms.RadioButton();
            this.RdBtnDivorcee = new System.Windows.Forms.RadioButton();
            this.RdBtnWidower = new System.Windows.Forms.RadioButton();
            this.RdBtnMale = new System.Windows.Forms.RadioButton();
            this.RdBtnFemale = new System.Windows.Forms.RadioButton();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.TxtBoxFirstName = new System.Windows.Forms.TextBox();
            this.TxtBoxSecondName = new System.Windows.Forms.TextBox();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.TxtBoxCity = new System.Windows.Forms.TextBox();
            this.TxtBoxStreetNumber = new System.Windows.Forms.TextBox();
            this.TxtBoxlStreetName = new System.Windows.Forms.TextBox();
            this.TxtBoxMobileNumber = new System.Windows.Forms.TextBox();
            this.TxtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearchEmployeeByCode = new System.Windows.Forms.Button();
            this.BtnSearchEmployeeById = new System.Windows.Forms.Button();
            this.LblCode = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblSecondName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.LblMobileNumber = new System.Windows.Forms.Label();
            this.LblStreetName = new System.Windows.Forms.Label();
            this.LblStreetNumber = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtBoxCode = new System.Windows.Forms.TextBox();
            this.TxtBoxAge = new System.Windows.Forms.TextBox();
            this.LblDateBirth = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtTmPckrDateBirth
            // 
            this.DtTmPckrDateBirth.Location = new System.Drawing.Point(136, 78);
            this.DtTmPckrDateBirth.Name = "DtTmPckrDateBirth";
            this.DtTmPckrDateBirth.Size = new System.Drawing.Size(200, 22);
            this.DtTmPckrDateBirth.TabIndex = 4;
            this.DtTmPckrDateBirth.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // RdBtnSingle
            // 
            this.RdBtnSingle.AutoSize = true;
            this.RdBtnSingle.Location = new System.Drawing.Point(49, 3);
            this.RdBtnSingle.Name = "RdBtnSingle";
            this.RdBtnSingle.Size = new System.Drawing.Size(66, 20);
            this.RdBtnSingle.TabIndex = 5;
            this.RdBtnSingle.TabStop = true;
            this.RdBtnSingle.Text = "Single";
            this.RdBtnSingle.UseVisualStyleBackColor = true;
            // 
            // RdBtnMarried
            // 
            this.RdBtnMarried.AutoSize = true;
            this.RdBtnMarried.Location = new System.Drawing.Point(41, 29);
            this.RdBtnMarried.Name = "RdBtnMarried";
            this.RdBtnMarried.Size = new System.Drawing.Size(74, 20);
            this.RdBtnMarried.TabIndex = 6;
            this.RdBtnMarried.TabStop = true;
            this.RdBtnMarried.Text = "Married";
            this.RdBtnMarried.UseVisualStyleBackColor = true;
            // 
            // RdBtnDivorcee
            // 
            this.RdBtnDivorcee.AutoSize = true;
            this.RdBtnDivorcee.Location = new System.Drawing.Point(32, 55);
            this.RdBtnDivorcee.Name = "RdBtnDivorcee";
            this.RdBtnDivorcee.Size = new System.Drawing.Size(83, 20);
            this.RdBtnDivorcee.TabIndex = 7;
            this.RdBtnDivorcee.TabStop = true;
            this.RdBtnDivorcee.Text = "Divorcee";
            this.RdBtnDivorcee.UseVisualStyleBackColor = true;
            // 
            // RdBtnWidower
            // 
            this.RdBtnWidower.AutoSize = true;
            this.RdBtnWidower.Location = new System.Drawing.Point(34, 81);
            this.RdBtnWidower.Name = "RdBtnWidower";
            this.RdBtnWidower.Size = new System.Drawing.Size(81, 20);
            this.RdBtnWidower.TabIndex = 8;
            this.RdBtnWidower.TabStop = true;
            this.RdBtnWidower.Text = "Widower";
            this.RdBtnWidower.UseVisualStyleBackColor = true;
            // 
            // RdBtnMale
            // 
            this.RdBtnMale.AutoSize = true;
            this.RdBtnMale.Location = new System.Drawing.Point(50, 15);
            this.RdBtnMale.Name = "RdBtnMale";
            this.RdBtnMale.Size = new System.Drawing.Size(58, 20);
            this.RdBtnMale.TabIndex = 9;
            this.RdBtnMale.TabStop = true;
            this.RdBtnMale.Text = "Male";
            this.RdBtnMale.UseVisualStyleBackColor = true;
            // 
            // RdBtnFemale
            // 
            this.RdBtnFemale.AutoSize = true;
            this.RdBtnFemale.Location = new System.Drawing.Point(34, 58);
            this.RdBtnFemale.Name = "RdBtnFemale";
            this.RdBtnFemale.Size = new System.Drawing.Size(74, 20);
            this.RdBtnFemale.TabIndex = 10;
            this.RdBtnFemale.TabStop = true;
            this.RdBtnFemale.Text = "Female";
            this.RdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.Location = new System.Drawing.Point(578, 78);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxId.TabIndex = 12;
            // 
            // TxtBoxFirstName
            // 
            this.TxtBoxFirstName.Location = new System.Drawing.Point(472, 78);
            this.TxtBoxFirstName.Name = "TxtBoxFirstName";
            this.TxtBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxFirstName.TabIndex = 13;
            // 
            // TxtBoxSecondName
            // 
            this.TxtBoxSecondName.Location = new System.Drawing.Point(366, 78);
            this.TxtBoxSecondName.Name = "TxtBoxSecondName";
            this.TxtBoxSecondName.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxSecondName.TabIndex = 14;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(490, 269);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(128, 42);
            this.BtnPrevious.TabIndex = 16;
            this.BtnPrevious.Text = ">>";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(138, 269);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(133, 42);
            this.BtnNext.TabIndex = 17;
            this.BtnNext.Text = "<<";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // TxtBoxCity
            // 
            this.TxtBoxCity.Location = new System.Drawing.Point(12, 339);
            this.TxtBoxCity.Name = "TxtBoxCity";
            this.TxtBoxCity.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxCity.TabIndex = 18;
            // 
            // TxtBoxStreetNumber
            // 
            this.TxtBoxStreetNumber.Location = new System.Drawing.Point(138, 339);
            this.TxtBoxStreetNumber.Name = "TxtBoxStreetNumber";
            this.TxtBoxStreetNumber.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxStreetNumber.TabIndex = 19;
            // 
            // TxtBoxlStreetName
            // 
            this.TxtBoxlStreetName.Location = new System.Drawing.Point(278, 338);
            this.TxtBoxlStreetName.Name = "TxtBoxlStreetName";
            this.TxtBoxlStreetName.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxlStreetName.TabIndex = 20;
            // 
            // TxtBoxMobileNumber
            // 
            this.TxtBoxMobileNumber.Location = new System.Drawing.Point(401, 338);
            this.TxtBoxMobileNumber.Name = "TxtBoxMobileNumber";
            this.TxtBoxMobileNumber.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxMobileNumber.TabIndex = 21;
            // 
            // TxtBoxPhoneNumber
            // 
            this.TxtBoxPhoneNumber.Location = new System.Drawing.Point(521, 338);
            this.TxtBoxPhoneNumber.Name = "TxtBoxPhoneNumber";
            this.TxtBoxPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxPhoneNumber.TabIndex = 22;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(484, 384);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 23;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Location = new System.Drawing.Point(344, 384);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(118, 23);
            this.BtnAddEmployee.TabIndex = 24;
            this.BtnAddEmployee.Text = "Add Employee";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(263, 383);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 25;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(182, 383);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 26;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearchEmployeeByCode
            // 
            this.BtnSearchEmployeeByCode.Location = new System.Drawing.Point(401, 413);
            this.BtnSearchEmployeeByCode.Name = "BtnSearchEmployeeByCode";
            this.BtnSearchEmployeeByCode.Size = new System.Drawing.Size(257, 23);
            this.BtnSearchEmployeeByCode.TabIndex = 27;
            this.BtnSearchEmployeeByCode.Text = "Search Employee By Code";
            this.BtnSearchEmployeeByCode.UseVisualStyleBackColor = true;
            // 
            // BtnSearchEmployeeById
            // 
            this.BtnSearchEmployeeById.Location = new System.Drawing.Point(136, 415);
            this.BtnSearchEmployeeById.Name = "BtnSearchEmployeeById";
            this.BtnSearchEmployeeById.Size = new System.Drawing.Size(217, 23);
            this.BtnSearchEmployeeById.TabIndex = 28;
            this.BtnSearchEmployeeById.Text = "Search Employee By Id";
            this.BtnSearchEmployeeById.UseVisualStyleBackColor = true;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(721, 59);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(40, 16);
            this.LblCode.TabIndex = 29;
            this.LblCode.Text = "Code";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(600, 59);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(18, 16);
            this.LblId.TabIndex = 30;
            this.LblId.Text = "Id";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(487, 59);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(69, 16);
            this.LblFirstName.TabIndex = 31;
            this.LblFirstName.Text = "FirstName";
            // 
            // LblSecondName
            // 
            this.LblSecondName.AutoSize = true;
            this.LblSecondName.Location = new System.Drawing.Point(371, 56);
            this.LblSecondName.Name = "LblSecondName";
            this.LblSecondName.Size = new System.Drawing.Size(91, 16);
            this.LblSecondName.TabIndex = 32;
            this.LblSecondName.Text = "SecondName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 33;
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Location = new System.Drawing.Point(524, 314);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(97, 16);
            this.LblPhoneNumber.TabIndex = 34;
            this.LblPhoneNumber.Text = "Phone Number";
            // 
            // LblMobileNumber
            // 
            this.LblMobileNumber.AutoSize = true;
            this.LblMobileNumber.Location = new System.Drawing.Point(402, 312);
            this.LblMobileNumber.Name = "LblMobileNumber";
            this.LblMobileNumber.Size = new System.Drawing.Size(99, 16);
            this.LblMobileNumber.TabIndex = 35;
            this.LblMobileNumber.Text = "Mobile Number";
            // 
            // LblStreetName
            // 
            this.LblStreetName.AutoSize = true;
            this.LblStreetName.Location = new System.Drawing.Point(284, 314);
            this.LblStreetName.Name = "LblStreetName";
            this.LblStreetName.Size = new System.Drawing.Size(82, 16);
            this.LblStreetName.TabIndex = 36;
            this.LblStreetName.Text = "Street Name";
            // 
            // LblStreetNumber
            // 
            this.LblStreetNumber.AutoSize = true;
            this.LblStreetNumber.Location = new System.Drawing.Point(145, 314);
            this.LblStreetNumber.Name = "LblStreetNumber";
            this.LblStreetNumber.Size = new System.Drawing.Size(93, 16);
            this.LblStreetNumber.TabIndex = 37;
            this.LblStreetNumber.Text = "Street Number";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(60, 312);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(29, 16);
            this.LblCity.TabIndex = 38;
            this.LblCity.Text = "City";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(39, 59);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(32, 16);
            this.LblAge.TabIndex = 39;
            this.LblAge.Text = "Age";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(388, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RdBtnMale);
            this.panel1.Controls.Add(this.RdBtnFemale);
            this.panel1.Location = new System.Drawing.Point(578, 147);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RdBtnSingle);
            this.panel2.Controls.Add(this.RdBtnMarried);
            this.panel2.Controls.Add(this.RdBtnDivorcee);
            this.panel2.Controls.Add(this.RdBtnWidower);
            this.panel2.Location = new System.Drawing.Point(138, 134);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(200, 113);
            this.panel2.TabIndex = 43;
            // 
            // TxtBoxCode
            // 
            this.TxtBoxCode.Location = new System.Drawing.Point(684, 78);
            this.TxtBoxCode.Name = "TxtBoxCode";
            this.TxtBoxCode.ReadOnly = true;
            this.TxtBoxCode.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxCode.TabIndex = 46;
            // 
            // TxtBoxAge
            // 
            this.TxtBoxAge.Location = new System.Drawing.Point(11, 78);
            this.TxtBoxAge.Name = "TxtBoxAge";
            this.TxtBoxAge.ReadOnly = true;
            this.TxtBoxAge.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxAge.TabIndex = 47;
            // 
            // LblDateBirth
            // 
            this.LblDateBirth.AutoSize = true;
            this.LblDateBirth.Location = new System.Drawing.Point(209, 56);
            this.LblDateBirth.Name = "LblDateBirth";
            this.LblDateBirth.Size = new System.Drawing.Size(81, 16);
            this.LblDateBirth.TabIndex = 48;
            this.LblDateBirth.Text = "Date Of Birth";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(341, 13);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(92, 16);
            this.LblTitle.TabIndex = 49;
            this.LblTitle.Text = "Employee List";
            this.LblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblDateBirth);
            this.Controls.Add(this.TxtBoxAge);
            this.Controls.Add(this.TxtBoxCode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblStreetNumber);
            this.Controls.Add(this.LblStreetName);
            this.Controls.Add(this.LblMobileNumber);
            this.Controls.Add(this.LblPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblSecondName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.BtnSearchEmployeeById);
            this.Controls.Add(this.BtnSearchEmployeeByCode);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAddEmployee);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TxtBoxPhoneNumber);
            this.Controls.Add(this.TxtBoxMobileNumber);
            this.Controls.Add(this.TxtBoxlStreetName);
            this.Controls.Add(this.TxtBoxStreetNumber);
            this.Controls.Add(this.TxtBoxCity);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.TxtBoxSecondName);
            this.Controls.Add(this.TxtBoxFirstName);
            this.Controls.Add(this.TxtBoxId);
            this.Controls.Add(this.DtTmPckrDateBirth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DtTmPckrDateBirth;
        private System.Windows.Forms.RadioButton RdBtnSingle;
        private System.Windows.Forms.RadioButton RdBtnMarried;
        private System.Windows.Forms.RadioButton RdBtnDivorcee;
        private System.Windows.Forms.RadioButton RdBtnWidower;
        private System.Windows.Forms.RadioButton RdBtnMale;
        private System.Windows.Forms.RadioButton RdBtnFemale;
        private System.Windows.Forms.TextBox TxtBoxId;
        private System.Windows.Forms.TextBox TxtBoxFirstName;
        private System.Windows.Forms.TextBox TxtBoxSecondName;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.TextBox TxtBoxCity;
        private System.Windows.Forms.TextBox TxtBoxStreetNumber;
        private System.Windows.Forms.TextBox TxtBoxlStreetName;
        private System.Windows.Forms.TextBox TxtBoxMobileNumber;
        private System.Windows.Forms.TextBox TxtBoxPhoneNumber;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearchEmployeeByCode;
        private System.Windows.Forms.Button BtnSearchEmployeeById;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblSecondName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.Label LblMobileNumber;
        private System.Windows.Forms.Label LblStreetName;
        private System.Windows.Forms.Label LblStreetNumber;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtBoxCode;
        private System.Windows.Forms.TextBox TxtBoxAge;
        private System.Windows.Forms.Label LblDateBirth;
        private System.Windows.Forms.Label LblTitle;
    }
}

