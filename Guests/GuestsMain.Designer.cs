namespace Guests
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
            this.listBoxGuset = new System.Windows.Forms.ListBox();
            this.lblHostEnterCategory = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxGuests = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxGuset
            // 
            this.listBoxGuset.FormattingEnabled = true;
            this.listBoxGuset.ItemHeight = 16;
            this.listBoxGuset.Location = new System.Drawing.Point(322, 211);
            this.listBoxGuset.Name = "listBoxGuset";
            this.listBoxGuset.Size = new System.Drawing.Size(159, 148);
            this.listBoxGuset.TabIndex = 15;
            this.listBoxGuset.DoubleClick += new System.EventHandler(this.listBoxGuset_DoubleClick);
            // 
            // lblHostEnterCategory
            // 
            this.lblHostEnterCategory.AutoSize = true;
            this.lblHostEnterCategory.Location = new System.Drawing.Point(297, 21);
            this.lblHostEnterCategory.Name = "lblHostEnterCategory";
            this.lblHostEnterCategory.Size = new System.Drawing.Size(209, 16);
            this.lblHostEnterCategory.TabIndex = 14;
            this.lblHostEnterCategory.Text = "Enter a name or select from the list";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(472, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 64);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBoxGuests
            // 
            this.txtBoxGuests.Location = new System.Drawing.Point(300, 78);
            this.txtBoxGuests.Name = "txtBoxGuests";
            this.txtBoxGuests.Size = new System.Drawing.Size(206, 22);
            this.txtBoxGuests.TabIndex = 12;
            this.txtBoxGuests.TextChanged += new System.EventHandler(this.txtBoxGuests_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(412, 403);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(263, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 64);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.listBoxGuset);
            this.Controls.Add(this.lblHostEnterCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBoxGuests);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxGuset;
        private System.Windows.Forms.Label lblHostEnterCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBoxGuests;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAdd;
    }
}

