namespace GuestsForShabbat
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
            this.txtBoxCategory = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblHostEnterCategory = new System.Windows.Forms.Label();
            this.listBoxHost = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnYourOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxCategory
            // 
            this.txtBoxCategory.Location = new System.Drawing.Point(291, 81);
            this.txtBoxCategory.Name = "txtBoxCategory";
            this.txtBoxCategory.Size = new System.Drawing.Size(255, 22);
            this.txtBoxCategory.TabIndex = 0;
            this.txtBoxCategory.TextChanged += new System.EventHandler(this.txtBoxCategory_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(441, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 78);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblHostEnterCategory
            // 
            this.lblHostEnterCategory.AutoSize = true;
            this.lblHostEnterCategory.Location = new System.Drawing.Point(346, 34);
            this.lblHostEnterCategory.Name = "lblHostEnterCategory";
            this.lblHostEnterCategory.Size = new System.Drawing.Size(131, 16);
            this.lblHostEnterCategory.TabIndex = 2;
            this.lblHostEnterCategory.Text = "Host - enter category";
            // 
            // listBoxHost
            // 
            this.listBoxHost.FormattingEnabled = true;
            this.listBoxHost.ItemHeight = 16;
            this.listBoxHost.Location = new System.Drawing.Point(291, 231);
            this.listBoxHost.Name = "listBoxHost";
            this.listBoxHost.Size = new System.Drawing.Size(255, 212);
            this.listBoxHost.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(291, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 78);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnYourOrder
            // 
            this.btnYourOrder.Location = new System.Drawing.Point(28, 354);
            this.btnYourOrder.Name = "btnYourOrder";
            this.btnYourOrder.Size = new System.Drawing.Size(140, 72);
            this.btnYourOrder.TabIndex = 5;
            this.btnYourOrder.Text = "Your order";
            this.btnYourOrder.UseVisualStyleBackColor = true;
            this.btnYourOrder.Click += new System.EventHandler(this.btnYourOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYourOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxHost);
            this.Controls.Add(this.lblHostEnterCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBoxCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHostEnterCategory;
        private System.Windows.Forms.ListBox listBoxHost;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnYourOrder;
    }
}

