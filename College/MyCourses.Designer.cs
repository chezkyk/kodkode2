namespace College
{
    partial class MyCourses
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
            this.lblMyCourses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEnterAmount = new System.Windows.Forms.Label();
            this.txtBoxEnterAmount = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtGrdVwMyCourses = new System.Windows.Forms.DataGridView();
            this.lblDebtBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwMyCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelloStudent
            // 
            this.lblHelloStudent.AutoSize = true;
            this.lblHelloStudent.Location = new System.Drawing.Point(374, 9);
            this.lblHelloStudent.Name = "lblHelloStudent";
            this.lblHelloStudent.Size = new System.Drawing.Size(87, 16);
            this.lblHelloStudent.TabIndex = 0;
            this.lblHelloStudent.Text = "Hello Student";
            // 
            // lblMyCourses
            // 
            this.lblMyCourses.AutoSize = true;
            this.lblMyCourses.Location = new System.Drawing.Point(622, 55);
            this.lblMyCourses.Name = "lblMyCourses";
            this.lblMyCourses.Size = new System.Drawing.Size(76, 16);
            this.lblMyCourses.TabIndex = 1;
            this.lblMyCourses.Text = "My courses";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            // 
            // lblEnterAmount
            // 
            this.lblEnterAmount.AutoSize = true;
            this.lblEnterAmount.Location = new System.Drawing.Point(338, 363);
            this.lblEnterAmount.Name = "lblEnterAmount";
            this.lblEnterAmount.Size = new System.Drawing.Size(143, 16);
            this.lblEnterAmount.TabIndex = 3;
            this.lblEnterAmount.Text = "Enter an amount to pay";
            // 
            // txtBoxEnterAmount
            // 
            this.txtBoxEnterAmount.Location = new System.Drawing.Point(361, 401);
            this.txtBoxEnterAmount.Name = "txtBoxEnterAmount";
            this.txtBoxEnterAmount.Size = new System.Drawing.Size(100, 22);
            this.txtBoxEnterAmount.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(247, 401);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtGrdVwMyCourses
            // 
            this.dtGrdVwMyCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwMyCourses.Location = new System.Drawing.Point(106, 74);
            this.dtGrdVwMyCourses.Name = "dtGrdVwMyCourses";
            this.dtGrdVwMyCourses.RowHeadersWidth = 51;
            this.dtGrdVwMyCourses.RowTemplate.Height = 24;
            this.dtGrdVwMyCourses.Size = new System.Drawing.Size(592, 221);
            this.dtGrdVwMyCourses.TabIndex = 6;
            // 
            // lblDebtBalance
            // 
            this.lblDebtBalance.AutoSize = true;
            this.lblDebtBalance.Location = new System.Drawing.Point(358, 322);
            this.lblDebtBalance.Name = "lblDebtBalance";
            this.lblDebtBalance.Size = new System.Drawing.Size(88, 16);
            this.lblDebtBalance.TabIndex = 8;
            this.lblDebtBalance.Text = "Debt balance";
            // 
            // MyCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDebtBalance);
            this.Controls.Add(this.dtGrdVwMyCourses);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBoxEnterAmount);
            this.Controls.Add(this.lblEnterAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMyCourses);
            this.Controls.Add(this.lblHelloStudent);
            this.Name = "MyCourses";
            this.Text = "MyCourses";
            this.Load += new System.EventHandler(this.MyCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwMyCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloStudent;
        private System.Windows.Forms.Label lblMyCourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEnterAmount;
        private System.Windows.Forms.TextBox txtBoxEnterAmount;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dtGrdVwMyCourses;
        private System.Windows.Forms.Label lblDebtBalance;
    }
}