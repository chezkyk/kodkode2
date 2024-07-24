namespace Vending_machine
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
            this.lblDrinkName = new System.Windows.Forms.Label();
            this.lblSugar = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.lblMilk = new System.Windows.Forms.Label();
            this.lblCocoa = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxDrinkName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.cmboBxSugar = new System.Windows.Forms.ComboBox();
            this.cmboBxMilk = new System.Windows.Forms.ComboBox();
            this.cmboBxCocoa = new System.Windows.Forms.ComboBox();
            this.cmboBxCoffee = new System.Windows.Forms.ComboBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.dataGridViewAllDrinks = new System.Windows.Forms.DataGridView();
            this.DrinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Milk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDrinkName
            // 
            this.lblDrinkName.AutoSize = true;
            this.lblDrinkName.Location = new System.Drawing.Point(270, 35);
            this.lblDrinkName.Name = "lblDrinkName";
            this.lblDrinkName.Size = new System.Drawing.Size(75, 16);
            this.lblDrinkName.TabIndex = 0;
            this.lblDrinkName.Text = "Drink name";
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Location = new System.Drawing.Point(195, 134);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(43, 16);
            this.lblSugar.TabIndex = 1;
            this.lblSugar.Text = "Sugar";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(94, 134);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(46, 16);
            this.lblCoffee.TabIndex = 2;
            this.lblCoffee.Text = "Coffee";
            // 
            // lblMilk
            // 
            this.lblMilk.AutoSize = true;
            this.lblMilk.Location = new System.Drawing.Point(299, 134);
            this.lblMilk.Name = "lblMilk";
            this.lblMilk.Size = new System.Drawing.Size(31, 16);
            this.lblMilk.TabIndex = 3;
            this.lblMilk.Text = "Milk";
            // 
            // lblCocoa
            // 
            this.lblCocoa.AutoSize = true;
            this.lblCocoa.Location = new System.Drawing.Point(415, 134);
            this.lblCocoa.Name = "lblCocoa";
            this.lblCocoa.Size = new System.Drawing.Size(47, 16);
            this.lblCocoa.TabIndex = 4;
            this.lblCocoa.Text = "Cocoa";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(561, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtBoxDrinkName
            // 
            this.txtBoxDrinkName.Location = new System.Drawing.Point(362, 32);
            this.txtBoxDrinkName.Name = "txtBoxDrinkName";
            this.txtBoxDrinkName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxDrinkName.TabIndex = 6;
            this.txtBoxDrinkName.TextChanged += new System.EventHandler(this.txtBoxDrinkName_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(380, 558);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 61);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(44, 558);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 61);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(622, 558);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 61);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 61);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(633, 182);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(38, 33);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(633, 124);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(37, 36);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // cmboBxSugar
            // 
            this.cmboBxSugar.FormattingEnabled = true;
            this.cmboBxSugar.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.cmboBxSugar.Location = new System.Drawing.Point(175, 182);
            this.cmboBxSugar.Name = "cmboBxSugar";
            this.cmboBxSugar.Size = new System.Drawing.Size(92, 24);
            this.cmboBxSugar.TabIndex = 14;
            this.cmboBxSugar.Text = "1.0";
            // 
            // cmboBxMilk
            // 
            this.cmboBxMilk.FormattingEnabled = true;
            this.cmboBxMilk.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.cmboBxMilk.Location = new System.Drawing.Point(283, 182);
            this.cmboBxMilk.Name = "cmboBxMilk";
            this.cmboBxMilk.Size = new System.Drawing.Size(93, 24);
            this.cmboBxMilk.TabIndex = 15;
            this.cmboBxMilk.Text = "1.0";
            // 
            // cmboBxCocoa
            // 
            this.cmboBxCocoa.FormattingEnabled = true;
            this.cmboBxCocoa.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.cmboBxCocoa.Location = new System.Drawing.Point(393, 182);
            this.cmboBxCocoa.Name = "cmboBxCocoa";
            this.cmboBxCocoa.Size = new System.Drawing.Size(91, 24);
            this.cmboBxCocoa.TabIndex = 16;
            this.cmboBxCocoa.Text = "1.0";
            // 
            // cmboBxCoffee
            // 
            this.cmboBxCoffee.FormattingEnabled = true;
            this.cmboBxCoffee.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.cmboBxCoffee.Location = new System.Drawing.Point(71, 182);
            this.cmboBxCoffee.Name = "cmboBxCoffee";
            this.cmboBxCoffee.Size = new System.Drawing.Size(83, 24);
            this.cmboBxCoffee.TabIndex = 17;
            this.cmboBxCoffee.Text = "1.0";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(551, 182);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(48, 22);
            this.txtBoxPrice.TabIndex = 18;
            this.txtBoxPrice.TextChanged += new System.EventHandler(this.txtBoxPrice_TextChanged);
            // 
            // dataGridViewAllDrinks
            // 
            this.dataGridViewAllDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllDrinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrinkName,
            this.Coffee,
            this.Suger,
            this.Milk,
            this.Cocoa,
            this.Price});
            this.dataGridViewAllDrinks.Location = new System.Drawing.Point(44, 257);
            this.dataGridViewAllDrinks.Name = "dataGridViewAllDrinks";
            this.dataGridViewAllDrinks.RowHeadersWidth = 51;
            this.dataGridViewAllDrinks.RowTemplate.Height = 24;
            this.dataGridViewAllDrinks.Size = new System.Drawing.Size(669, 267);
            this.dataGridViewAllDrinks.TabIndex = 19;
            // 
            // DrinkName
            // 
            this.DrinkName.HeaderText = "Name";
            this.DrinkName.MinimumWidth = 6;
            this.DrinkName.Name = "DrinkName";
            this.DrinkName.Width = 125;
            // 
            // Coffee
            // 
            this.Coffee.HeaderText = "Coffee";
            this.Coffee.MinimumWidth = 6;
            this.Coffee.Name = "Coffee";
            this.Coffee.Width = 125;
            // 
            // Suger
            // 
            this.Suger.HeaderText = "Suger";
            this.Suger.MinimumWidth = 6;
            this.Suger.Name = "Suger";
            this.Suger.Width = 125;
            // 
            // Milk
            // 
            this.Milk.HeaderText = "Milk";
            this.Milk.MinimumWidth = 6;
            this.Milk.Name = "Milk";
            this.Milk.Width = 125;
            // 
            // Cocoa
            // 
            this.Cocoa.HeaderText = "Cocoa";
            this.Cocoa.MinimumWidth = 6;
            this.Cocoa.Name = "Cocoa";
            this.Cocoa.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.dataGridViewAllDrinks);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.cmboBxCoffee);
            this.Controls.Add(this.cmboBxCocoa);
            this.Controls.Add(this.cmboBxMilk);
            this.Controls.Add(this.cmboBxSugar);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBoxDrinkName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCocoa);
            this.Controls.Add(this.lblMilk);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.lblSugar);
            this.Controls.Add(this.lblDrinkName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrinkName;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblMilk;
        private System.Windows.Forms.Label lblCocoa;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxDrinkName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.ComboBox cmboBxSugar;
        private System.Windows.Forms.ComboBox cmboBxMilk;
        private System.Windows.Forms.ComboBox cmboBxCocoa;
        private System.Windows.Forms.ComboBox cmboBxCoffee;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.DataGridView dataGridViewAllDrinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrinkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Milk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

