namespace Guests
{
    partial class Form2
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
            this.dtGrdVwMyChoice = new System.Windows.Forms.DataGridView();
            this.dtGrdVwGuestsChoice = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAddSelection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtBoxAddSelection = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwMyChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwGuestsChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdVwMyChoice
            // 
            this.dtGrdVwMyChoice.AllowUserToAddRows = false;
            this.dtGrdVwMyChoice.AllowUserToDeleteRows = false;
            this.dtGrdVwMyChoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwMyChoice.Location = new System.Drawing.Point(104, 259);
            this.dtGrdVwMyChoice.Name = "dtGrdVwMyChoice";
            this.dtGrdVwMyChoice.ReadOnly = true;
            this.dtGrdVwMyChoice.RowHeadersWidth = 51;
            this.dtGrdVwMyChoice.RowTemplate.Height = 24;
            this.dtGrdVwMyChoice.Size = new System.Drawing.Size(635, 126);
            this.dtGrdVwMyChoice.TabIndex = 17;
            // 
            // dtGrdVwGuestsChoice
            // 
            this.dtGrdVwGuestsChoice.AllowUserToAddRows = false;
            this.dtGrdVwGuestsChoice.AllowUserToDeleteRows = false;
            this.dtGrdVwGuestsChoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwGuestsChoice.Location = new System.Drawing.Point(104, 54);
            this.dtGrdVwGuestsChoice.Name = "dtGrdVwGuestsChoice";
            this.dtGrdVwGuestsChoice.ReadOnly = true;
            this.dtGrdVwGuestsChoice.RowHeadersWidth = 51;
            this.dtGrdVwGuestsChoice.RowTemplate.Height = 24;
            this.dtGrdVwGuestsChoice.Size = new System.Drawing.Size(635, 136);
            this.dtGrdVwGuestsChoice.TabIndex = 16;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(104, 415);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "<<";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(664, 415);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = ">>";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAddSelection
            // 
            this.btnAddSelection.Location = new System.Drawing.Point(600, 196);
            this.btnAddSelection.Name = "btnAddSelection";
            this.btnAddSelection.Size = new System.Drawing.Size(139, 41);
            this.btnAddSelection.TabIndex = 13;
            this.btnAddSelection.Text = "Add selection";
            this.btnAddSelection.UseVisualStyleBackColor = true;
            this.btnAddSelection.Click += new System.EventHandler(this.btnAddSelection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "My choice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Guests\' choice";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(368, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(149, 196);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxAddSelection
            // 
            this.txtBoxAddSelection.Location = new System.Drawing.Point(371, 196);
            this.txtBoxAddSelection.Name = "txtBoxAddSelection";
            this.txtBoxAddSelection.Size = new System.Drawing.Size(100, 22);
            this.txtBoxAddSelection.TabIndex = 19;
            this.txtBoxAddSelection.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxAddSelection);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dtGrdVwMyChoice);
            this.Controls.Add(this.dtGrdVwGuestsChoice);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnAddSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCategory);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwMyChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwGuestsChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVwMyChoice;
        private System.Windows.Forms.DataGridView dtGrdVwGuestsChoice;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnAddSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtBoxAddSelection;
    }
}