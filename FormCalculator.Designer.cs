namespace Calculator
{
    partial class FormCalculator
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.journal = new System.Windows.Forms.ListBox();
            this.display = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonRaise = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonSinh = new System.Windows.Forms.Button();
            this.buttonCosh = new System.Windows.Forms.Button();
            this.buttonExp = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonLg = new System.Windows.Forms.Button();
            this.buttonRound = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.journal);
            this.splitContainer1.Panel1.Controls.Add(this.display);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(245, 695);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 0;
            // 
            // journal
            // 
            this.journal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.journal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.journal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journal.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journal.ForeColor = System.Drawing.Color.Gray;
            this.journal.FormattingEnabled = true;
            this.journal.ItemHeight = 25;
            this.journal.Location = new System.Drawing.Point(0, 0);
            this.journal.Name = "journal";
            this.journal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.journal.Size = new System.Drawing.Size(245, 242);
            this.journal.TabIndex = 1;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.display.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(0, 242);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(245, 25);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button0);
            this.flowLayoutPanel1.Controls.Add(this.buttonDot);
            this.flowLayoutPanel1.Controls.Add(this.buttonPi);
            this.flowLayoutPanel1.Controls.Add(this.buttonNegative);
            this.flowLayoutPanel1.Controls.Add(this.buttonPlus);
            this.flowLayoutPanel1.Controls.Add(this.buttonMinus);
            this.flowLayoutPanel1.Controls.Add(this.buttonDivide);
            this.flowLayoutPanel1.Controls.Add(this.buttonMultiply);
            this.flowLayoutPanel1.Controls.Add(this.buttonRaise);
            this.flowLayoutPanel1.Controls.Add(this.buttonSqrt);
            this.flowLayoutPanel1.Controls.Add(this.buttonSin);
            this.flowLayoutPanel1.Controls.Add(this.buttonCos);
            this.flowLayoutPanel1.Controls.Add(this.buttonSinh);
            this.flowLayoutPanel1.Controls.Add(this.buttonCosh);
            this.flowLayoutPanel1.Controls.Add(this.buttonExp);
            this.flowLayoutPanel1.Controls.Add(this.buttonMod);
            this.flowLayoutPanel1.Controls.Add(this.buttonLog);
            this.flowLayoutPanel1.Controls.Add(this.buttonLg);
            this.flowLayoutPanel1.Controls.Add(this.buttonRound);
            this.flowLayoutPanel1.Controls.Add(this.buttonClear);
            this.flowLayoutPanel1.Controls.Add(this.buttonEquals);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 424);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(84, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(165, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 36);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(84, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 36);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(165, 87);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 36);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(3, 129);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 36);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(84, 129);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(75, 36);
            this.buttonDot.TabIndex = 10;
            this.buttonDot.Text = ",";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.Location = new System.Drawing.Point(165, 129);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(75, 36);
            this.buttonPi.TabIndex = 28;
            this.buttonPi.Text = "pi";
            this.buttonPi.UseVisualStyleBackColor = true;
            this.buttonPi.Click += new System.EventHandler(this.buttonImmediateOperation_Click);
            // 
            // buttonNegative
            // 
            this.buttonNegative.Location = new System.Drawing.Point(3, 171);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(75, 36);
            this.buttonNegative.TabIndex = 11;
            this.buttonNegative.Text = "+/-";
            this.buttonNegative.UseVisualStyleBackColor = true;
            this.buttonNegative.Click += new System.EventHandler(this.buttonImmediateOperation_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(84, 171);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 36);
            this.buttonPlus.TabIndex = 12;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(165, 171);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 36);
            this.buttonMinus.TabIndex = 13;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(3, 213);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(75, 36);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(84, 213);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(75, 36);
            this.buttonMultiply.TabIndex = 15;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonRaise
            // 
            this.buttonRaise.Location = new System.Drawing.Point(165, 213);
            this.buttonRaise.Name = "buttonRaise";
            this.buttonRaise.Size = new System.Drawing.Size(75, 36);
            this.buttonRaise.TabIndex = 16;
            this.buttonRaise.Text = "^";
            this.buttonRaise.UseVisualStyleBackColor = true;
            this.buttonRaise.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Location = new System.Drawing.Point(3, 255);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(75, 36);
            this.buttonSqrt.TabIndex = 17;
            this.buttonSqrt.Text = "sqrt";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonImmediateOperation_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.Location = new System.Drawing.Point(84, 255);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(75, 36);
            this.buttonSin.TabIndex = 18;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.buttonImmediateOperation_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.Location = new System.Drawing.Point(165, 255);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(75, 36);
            this.buttonCos.TabIndex = 19;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = true;
            this.buttonCos.Click += new System.EventHandler(this.buttonImmediateOperation_Click);
            // 
            // buttonSinh
            // 
            this.buttonSinh.Location = new System.Drawing.Point(3, 297);
            this.buttonSinh.Name = "buttonSinh";
            this.buttonSinh.Size = new System.Drawing.Size(75, 36);
            this.buttonSinh.TabIndex = 20;
            this.buttonSinh.Text = "sinh";
            this.buttonSinh.UseVisualStyleBackColor = true;
            this.buttonSinh.Click += new System.EventHandler(this.buttonImmediateOperation_Click);
            // 
            // buttonCosh
            // 
            this.buttonCosh.Location = new System.Drawing.Point(84, 297);
            this.buttonCosh.Name = "buttonCosh";
            this.buttonCosh.Size = new System.Drawing.Size(75, 36);
            this.buttonCosh.TabIndex = 21;
            this.buttonCosh.Text = "cosh";
            this.buttonCosh.UseVisualStyleBackColor = true;
            this.buttonCosh.Click += new System.EventHandler(this.buttonImmediateOperation_Click);
            // 
            // buttonExp
            // 
            this.buttonExp.Location = new System.Drawing.Point(165, 297);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(75, 36);
            this.buttonExp.TabIndex = 22;
            this.buttonExp.Text = "Exp";
            this.buttonExp.UseVisualStyleBackColor = true;
            this.buttonExp.Click += new System.EventHandler(this.buttonImmediateOperation_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(3, 339);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(75, 36);
            this.buttonMod.TabIndex = 23;
            this.buttonMod.Text = "Mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonImmediateOperation_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(84, 339);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 36);
            this.buttonLog.TabIndex = 24;
            this.buttonLog.Text = "log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonLg
            // 
            this.buttonLg.Location = new System.Drawing.Point(165, 339);
            this.buttonLg.Name = "buttonLg";
            this.buttonLg.Size = new System.Drawing.Size(75, 36);
            this.buttonLg.TabIndex = 26;
            this.buttonLg.Text = "log10";
            this.buttonLg.UseVisualStyleBackColor = true;
            this.buttonLg.Click += new System.EventHandler(this.buttonImmediateOperation_Click);
            // 
            // buttonRound
            // 
            this.buttonRound.Location = new System.Drawing.Point(3, 381);
            this.buttonRound.Name = "buttonRound";
            this.buttonRound.Size = new System.Drawing.Size(75, 36);
            this.buttonRound.TabIndex = 29;
            this.buttonRound.Text = "round";
            this.buttonRound.UseVisualStyleBackColor = true;
            this.buttonRound.Click += new System.EventHandler(this.buttonImmediateOperation_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(84, 381);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 36);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(165, 381);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(75, 36);
            this.buttonEquals.TabIndex = 25;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 695);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox journal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonRaise;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonSinh;
        private System.Windows.Forms.Button buttonCosh;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonLg;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPi;
        private System.Windows.Forms.Button buttonRound;
    }
}

