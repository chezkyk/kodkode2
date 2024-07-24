namespace Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.btnPoint = new System.Windows.Forms.Button();
            this.Operator = new System.Windows.Forms.ComboBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEqual, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblResult, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textNum1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textNum2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPoint, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Operator, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPlus, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSub, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMult, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDiv, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPower, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnRoot, 3, 4);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 70);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 61);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click_Global);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(252, 70);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(109, 61);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click_Global);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 137);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(103, 62);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click_Global);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(112, 137);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(134, 62);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click_Global);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(252, 137);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(109, 62);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click_Global);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(252, 205);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(109, 72);
            this.btn9.TabIndex = 23;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click_Global);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 205);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(103, 72);
            this.btn7.TabIndex = 25;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click_Global);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(112, 70);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(134, 61);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click_Global);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(112, 283);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(134, 75);
            this.btn0.TabIndex = 27;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_Click_Global);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(112, 205);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(134, 72);
            this.btn8.TabIndex = 24;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click_Global);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(367, 3);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(92, 61);
            this.btnEqual.TabIndex = 29;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(471, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 9;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(3, 3);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 22);
            this.textNum1.TabIndex = 30;
            this.textNum1.TextChanged += new System.EventHandler(this.textNum1_TextChanged);
            this.textNum1.Enter += new System.EventHandler(this.textNum1_Enter);
            this.textNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNum1_KeyPress);
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(252, 3);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(100, 22);
            this.textNum2.TabIndex = 31;
            this.textNum2.TextChanged += new System.EventHandler(this.textNum2_TextChanged);
            this.textNum2.Enter += new System.EventHandler(this.textNum2_Enter);
            this.textNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNum2_KeyPress);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(252, 283);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(109, 75);
            this.btnPoint.TabIndex = 32;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btn_Click_Global);
            // 
            // Operator
            // 
            this.Operator.FormattingEnabled = true;
            this.Operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "power",
            "root"});
            this.Operator.Location = new System.Drawing.Point(112, 3);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(121, 24);
            this.Operator.TabIndex = 33;
            this.Operator.SelectedIndexChanged += new System.EventHandler(this.Operator_SelectedIndexChanged);
            this.Operator.Enter += new System.EventHandler(this.Operator_Enter);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(471, 70);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(103, 61);
            this.btnPlus.TabIndex = 34;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(471, 137);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(103, 62);
            this.btnSub.TabIndex = 35;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(471, 205);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(103, 72);
            this.btnMult.TabIndex = 36;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(471, 283);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(103, 75);
            this.btnDiv.TabIndex = 37;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(367, 205);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(98, 72);
            this.btnPower.TabIndex = 38;
            this.btnPower.Text = "power";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.Location = new System.Drawing.Point(367, 283);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(98, 75);
            this.btnRoot.TabIndex = 39;
            this.btnRoot.Text = "root";
            this.btnRoot.UseVisualStyleBackColor = true;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(717, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.ComboBox Operator;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnRoot;
    }
}

