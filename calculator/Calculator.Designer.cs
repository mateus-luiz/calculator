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
            this.textResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textResult.Font = new System.Drawing.Font("Roboto Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textResult.Location = new System.Drawing.Point(9, 37);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textResult.Size = new System.Drawing.Size(317, 45);
            this.textResult.TabIndex = 0;
            this.textResult.TabStop = false;
            this.textResult.Text = "0";
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.LightGray;
            this.btnDecimal.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDecimal.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnDecimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDecimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.Font = new System.Drawing.Font("Roboto Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDecimal.Location = new System.Drawing.Point(171, 253);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 45);
            this.btnDecimal.TabIndex = 1;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.putDecimal);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.LightGray;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Roboto Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMinus.Location = new System.Drawing.Point(251, 202);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 45);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.Subtract);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.LightGray;
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMultiply.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Roboto Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMultiply.Location = new System.Drawing.Point(251, 151);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 45);
            this.btnMultiply.TabIndex = 1;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.Multiply);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.LightGray;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDivide.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Roboto Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDivide.Location = new System.Drawing.Point(251, 100);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 45);
            this.btnDivide.TabIndex = 1;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.Divide);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.LightGray;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnPlus.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Roboto Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPlus.Location = new System.Drawing.Point(250, 253);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 45);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.Sum);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.LightGray;
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnChange.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Roboto Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChange.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnChange.Location = new System.Drawing.Point(9, 253);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 45);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "+/-";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.changeOperator);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn1.Location = new System.Drawing.Point(9, 202);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 45);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.Control;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn0.Location = new System.Drawing.Point(90, 253);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 45);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Control;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn4.Location = new System.Drawing.Point(9, 151);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 45);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Control;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn3.Location = new System.Drawing.Point(170, 202);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 45);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn2.Location = new System.Drawing.Point(90, 202);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 45);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Control;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn6.Location = new System.Drawing.Point(170, 151);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 45);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Control;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn7.Location = new System.Drawing.Point(8, 100);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 45);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Control;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn5.Location = new System.Drawing.Point(90, 151);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 45);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Control;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn8.Location = new System.Drawing.Point(90, 100);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 45);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.Control;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn9.Location = new System.Drawing.Point(170, 100);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 45);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnResult.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnResult.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnResult.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnResult.Location = new System.Drawing.Point(170, 304);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(156, 45);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.Result);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Roboto Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClear.Location = new System.Drawing.Point(9, 306);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 45);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.LightGray;
            this.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnClearAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnClearAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Roboto Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearAll.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClearAll.Location = new System.Drawing.Point(90, 306);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 45);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "AC";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.ClearAll);
            // 
            // equationLabel
            // 
            this.equationLabel.AutoSize = true;
            this.equationLabel.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equationLabel.Location = new System.Drawing.Point(9, 9);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.Size = new System.Drawing.Size(0, 23);
            this.equationLabel.TabIndex = 2;
            // 
            // Calculator
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
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