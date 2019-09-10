namespace Number_Converter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxDec = new System.Windows.Forms.TextBox();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.textBoxBin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBinBit = new System.Windows.Forms.Label();
            this.checkBoxTOP = new System.Windows.Forms.CheckBox();
            this.btnAsciiTable = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTittle = new System.Windows.Forms.Label();
            this.lblDecBit = new System.Windows.Forms.Label();
            this.lblHexBit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownAsciiVal = new System.Windows.Forms.NumericUpDown();
            this.btnShowCalculator = new System.Windows.Forms.Button();
            this.textBoxAsciiChar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCopyToConverter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.textBoxCalcDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsciiVal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDec
            // 
            this.textBoxDec.Location = new System.Drawing.Point(55, 71);
            this.textBoxDec.MaxLength = 22;
            this.textBoxDec.Name = "textBoxDec";
            this.textBoxDec.Size = new System.Drawing.Size(205, 23);
            this.textBoxDec.TabIndex = 1;
            this.textBoxDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxDec_KeyUp);
            // 
            // textBoxHex
            // 
            this.textBoxHex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxHex.Location = new System.Drawing.Point(55, 44);
            this.textBoxHex.MaxLength = 18;
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(205, 23);
            this.textBoxHex.TabIndex = 0;
            this.textBoxHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxHex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxHex_KeyUp);
            // 
            // textBoxBin
            // 
            this.textBoxBin.Location = new System.Drawing.Point(55, 97);
            this.textBoxBin.MaxLength = 64;
            this.textBoxBin.Name = "textBoxBin";
            this.textBoxBin.Size = new System.Drawing.Size(205, 23);
            this.textBoxBin.TabIndex = 2;
            this.textBoxBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBin.Click += new System.EventHandler(this.TextBoxBin_Click);
            this.textBoxBin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxBin_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "DEC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "HEX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "ASCII";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "BIN";
            // 
            // lblBinBit
            // 
            this.lblBinBit.Location = new System.Drawing.Point(265, 100);
            this.lblBinBit.Name = "lblBinBit";
            this.lblBinBit.Size = new System.Drawing.Size(22, 13);
            this.lblBinBit.TabIndex = 11;
            this.lblBinBit.Text = "64";
            this.lblBinBit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxTOP
            // 
            this.checkBoxTOP.AutoSize = true;
            this.checkBoxTOP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTOP.Checked = true;
            this.checkBoxTOP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTOP.Location = new System.Drawing.Point(212, 19);
            this.checkBoxTOP.Name = "checkBoxTOP";
            this.checkBoxTOP.Size = new System.Drawing.Size(47, 19);
            this.checkBoxTOP.TabIndex = 6;
            this.checkBoxTOP.Text = "Top";
            this.checkBoxTOP.UseVisualStyleBackColor = true;
            this.checkBoxTOP.CheckedChanged += new System.EventHandler(this.CheckBoxTOP_CheckedChanged);
            // 
            // btnAsciiTable
            // 
            this.btnAsciiTable.Location = new System.Drawing.Point(116, 17);
            this.btnAsciiTable.Name = "btnAsciiTable";
            this.btnAsciiTable.Size = new System.Drawing.Size(94, 23);
            this.btnAsciiTable.TabIndex = 4;
            this.btnAsciiTable.Text = "ASCII Table";
            this.btnAsciiTable.UseVisualStyleBackColor = true;
            this.btnAsciiTable.Click += new System.EventHandler(this.BtnAsciiTable_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoEllipsis = true;
            this.labelStatus.Location = new System.Drawing.Point(55, 126);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(204, 31);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTittle
            // 
            this.labelTittle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTittle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.Color.Blue;
            this.labelTittle.Location = new System.Drawing.Point(3, 0);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(298, 20);
            this.labelTittle.TabIndex = 13;
            this.labelTittle.Text = "Tittle";
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTittle.Click += new System.EventHandler(this.LabelTittle_Click);
            // 
            // lblDecBit
            // 
            this.lblDecBit.Location = new System.Drawing.Point(265, 74);
            this.lblDecBit.Name = "lblDecBit";
            this.lblDecBit.Size = new System.Drawing.Size(22, 13);
            this.lblDecBit.TabIndex = 14;
            this.lblDecBit.Text = "22";
            this.lblDecBit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHexBit
            // 
            this.lblHexBit.Location = new System.Drawing.Point(265, 47);
            this.lblHexBit.Name = "lblHexBit";
            this.lblHexBit.Size = new System.Drawing.Size(22, 13);
            this.lblHexBit.TabIndex = 15;
            this.lblHexBit.Text = "18";
            this.lblHexBit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownAsciiVal);
            this.groupBox1.Controls.Add(this.btnShowCalculator);
            this.groupBox1.Controls.Add(this.lblHexBit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDecBit);
            this.groupBox1.Controls.Add(this.textBoxDec);
            this.groupBox1.Controls.Add(this.textBoxHex);
            this.groupBox1.Controls.Add(this.textBoxBin);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.textBoxAsciiChar);
            this.groupBox1.Controls.Add(this.btnAsciiTable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxTOP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblBinBit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 170);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter";
            // 
            // numericUpDownAsciiVal
            // 
            this.numericUpDownAsciiVal.Location = new System.Drawing.Point(94, 17);
            this.numericUpDownAsciiVal.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownAsciiVal.Name = "numericUpDownAsciiVal";
            this.numericUpDownAsciiVal.Size = new System.Drawing.Size(18, 23);
            this.numericUpDownAsciiVal.TabIndex = 17;
            this.numericUpDownAsciiVal.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDownAsciiVal.ValueChanged += new System.EventHandler(this.NumericUpDownAsciiVal_ValueChanged);
            // 
            // btnShowCalculator
            // 
            this.btnShowCalculator.FlatAppearance.BorderSize = 0;
            this.btnShowCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCalculator.Location = new System.Drawing.Point(276, 145);
            this.btnShowCalculator.Name = "btnShowCalculator";
            this.btnShowCalculator.Size = new System.Drawing.Size(17, 23);
            this.btnShowCalculator.TabIndex = 16;
            this.btnShowCalculator.Text = "↓";
            this.btnShowCalculator.UseVisualStyleBackColor = true;
            this.btnShowCalculator.Click += new System.EventHandler(this.BtnShowCalculator_Click);
            // 
            // textBoxAsciiChar
            // 
            this.textBoxAsciiChar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAsciiChar.ForeColor = System.Drawing.Color.Blue;
            this.textBoxAsciiChar.Location = new System.Drawing.Point(55, 17);
            this.textBoxAsciiChar.MaxLength = 1;
            this.textBoxAsciiChar.Name = "textBoxAsciiChar";
            this.textBoxAsciiChar.Size = new System.Drawing.Size(38, 23);
            this.textBoxAsciiChar.TabIndex = 3;
            this.textBoxAsciiChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAsciiChar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAsciiChar_KeyDown);
            this.textBoxAsciiChar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAsciiChar_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCopyToConverter);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnPlus);
            this.groupBox2.Controls.Add(this.btnEqual);
            this.groupBox2.Controls.Add(this.btn0);
            this.groupBox2.Controls.Add(this.btnPoint);
            this.groupBox2.Controls.Add(this.btnCut);
            this.groupBox2.Controls.Add(this.btnAC);
            this.groupBox2.Controls.Add(this.btnMinus);
            this.groupBox2.Controls.Add(this.btn3);
            this.groupBox2.Controls.Add(this.btn2);
            this.groupBox2.Controls.Add(this.btn1);
            this.groupBox2.Controls.Add(this.btnInverse);
            this.groupBox2.Controls.Add(this.btnMultiply);
            this.groupBox2.Controls.Add(this.btn6);
            this.groupBox2.Controls.Add(this.btn5);
            this.groupBox2.Controls.Add(this.btn4);
            this.groupBox2.Controls.Add(this.btnPercent);
            this.groupBox2.Controls.Add(this.btnDivide);
            this.groupBox2.Controls.Add(this.btn9);
            this.groupBox2.Controls.Add(this.btn8);
            this.groupBox2.Controls.Add(this.btn7);
            this.groupBox2.Controls.Add(this.textBoxCalcDisplay);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 170);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculator";
            // 
            // buttonCopyToConverter
            // 
            this.buttonCopyToConverter.Location = new System.Drawing.Point(246, 54);
            this.buttonCopyToConverter.Name = "buttonCopyToConverter";
            this.buttonCopyToConverter.Size = new System.Drawing.Size(42, 23);
            this.buttonCopyToConverter.TabIndex = 28;
            this.buttonCopyToConverter.Text = "↑";
            this.buttonCopyToConverter.UseVisualStyleBackColor = true;
            this.buttonCopyToConverter.Click += new System.EventHandler(this.ButtonCopyToConverter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(198, 54);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(42, 23);
            this.btnPlus.TabIndex = 24;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(150, 141);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(42, 23);
            this.btnEqual.TabIndex = 23;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(102, 141);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(42, 23);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(54, 141);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(42, 23);
            this.btnPoint.TabIndex = 21;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(6, 112);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(42, 23);
            this.btnCut.TabIndex = 20;
            this.btnCut.Text = "-->";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.BtnCut_Click);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(6, 141);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(42, 23);
            this.btnAC.TabIndex = 19;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.BtnAC_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(198, 83);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(42, 23);
            this.btnMinus.TabIndex = 18;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(150, 112);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 23);
            this.btn3.TabIndex = 17;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(102, 112);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 23);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(54, 112);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 23);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(6, 83);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(42, 23);
            this.btnInverse.TabIndex = 14;
            this.btnInverse.Text = "1/X";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.BtnInverse_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(198, 112);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(42, 23);
            this.btnMultiply.TabIndex = 12;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(150, 83);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(42, 23);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(102, 83);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 23);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(54, 83);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 23);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Location = new System.Drawing.Point(6, 54);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(42, 23);
            this.btnPercent.TabIndex = 8;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.BtnPercent_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(198, 141);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(42, 23);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(150, 54);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 23);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(102, 54);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 23);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(54, 54);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(42, 23);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // textBoxCalcDisplay
            // 
            this.textBoxCalcDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCalcDisplay.Location = new System.Drawing.Point(6, 19);
            this.textBoxCalcDisplay.Multiline = true;
            this.textBoxCalcDisplay.Name = "textBoxCalcDisplay";
            this.textBoxCalcDisplay.ReadOnly = true;
            this.textBoxCalcDisplay.Size = new System.Drawing.Size(283, 29);
            this.textBoxCalcDisplay.TabIndex = 1;
            this.textBoxCalcDisplay.Text = "0";
            this.textBoxCalcDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCalcDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCalcDisplay_KeyDown);
            this.textBoxCalcDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCalcDisplay_KeyPress);
            this.textBoxCalcDisplay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TboxCalcDisplay_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelTittle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 372);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 372);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Number Converter";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsciiVal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDec;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.TextBox textBoxBin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBinBit;
        private System.Windows.Forms.CheckBox checkBoxTOP;
        private System.Windows.Forms.Button btnAsciiTable;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Label lblDecBit;
        private System.Windows.Forms.Label lblHexBit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCalcDisplay;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnShowCalculator;
        private System.Windows.Forms.Button buttonCopyToConverter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxAsciiChar;
        private System.Windows.Forms.NumericUpDown numericUpDownAsciiVal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

