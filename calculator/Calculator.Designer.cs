namespace calculator
{
    partial class Calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.equationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // textResult
            // 
            this.textResult.BackColor = System.Drawing.SystemColors.Window;
            this.textResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResult.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textResult.Location = new System.Drawing.Point(9, 37);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textResult.Size = new System.Drawing.Size(318, 57);
            this.textResult.TabIndex = 0;
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDecimal
            // 
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDecimal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.Location = new System.Drawing.Point(171, 253);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 45);
            this.btnDecimal.TabIndex = 1;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.putDecimal);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(251, 202);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 45);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.Subtract);
            // 
            // btnMultiply
            // 
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(251, 151);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 45);
            this.btnMultiply.TabIndex = 1;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.Multiply);
            // 
            // btnDivide
            // 
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(251, 100);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 45);
            this.btnDivide.TabIndex = 1;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Divide);
            // 
            // btnPlus
            // 
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(250, 253);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 45);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.Sum);
            // 
            // btnChange
            // 
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChange.Location = new System.Drawing.Point(9, 253);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 45);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "+/-";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.changeOperator);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(9, 202);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 45);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(90, 253);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 45);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(9, 151);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 45);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(170, 202);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 45);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(90, 202);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 45);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(170, 151);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 45);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(8, 100);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 45);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(90, 151);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 45);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(90, 100);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 45);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(170, 100);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 45);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnResult
            // 
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResult.Location = new System.Drawing.Point(170, 304);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(156, 45);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.Result);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(9, 306);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 45);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearAll.Location = new System.Drawing.Point(90, 306);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 45);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "AC";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearAll);
            // 
            // equationLabel
            // 
            this.equationLabel.AutoSize = true;
            this.equationLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equationLabel.Location = new System.Drawing.Point(9, 9);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.Size = new System.Drawing.Size(0, 25);
            this.equationLabel.TabIndex = 2;
            // 
            // Calculator
            // 
            this.ClientSize = new System.Drawing.Size(338, 364);
            this.Controls.Add(this.equationLabel);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.textResult);
            this.Name = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textResult;
        private Button btnDecimal;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnPlus;
        private Button btnChange;
        private Button btn1;
        private Button btn0;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn6;
        private Button btn7;
        private Button btn5;
        private Button btn8;
        private Button btn9;
        private Button btnResult;
        private Button btnClear;
        private Button btnClearAll;
        private Label equationLabel;
    }
}