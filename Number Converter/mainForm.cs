using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Number_Converter
{
    public partial class MainForm : Form
    {
        #region Const and Enums

        private const string DeveloperUrl = "www.gsmrana.com";
        private readonly Size _minWindowSize = new Size(324, 233);
        private readonly Size _fullWindowSize = new Size(324, 420);

        private enum Format { HEX, DEC, BIN, ASCII };

        #endregion

        #region Data

        private string _inputstr = "";
        private string _operand1 = "";
        private string _operand2 = "";
        private char _operation = ' ';
        private double _result = 0.0;
        private int _prevNumVal = 0;
        private bool _calculatorVisible = false;

        public AsciiTableForm AsciiTable { get; set; } = new AsciiTableForm();

        #endregion

        #region Helper Methods

        private void ConvertNumber(string input, Format format)
        {
            if (string.IsNullOrEmpty(input))
            {
                textBoxHex.Clear();
                textBoxDec.Clear();
                textBoxBin.Clear();
                textBoxAsciiChar.Clear();
                lblHexBit.Text = "";
                lblDecBit.Text = "";
                lblBinBit.Text = "";
                labelStatus.Text = "";
                return;
            }


            string hex = "", dec = "", bin = "", ascii = "";
            bool isConverted;
            try
            {
                if (format == Format.HEX)
                {
                    hex = input;
                    dec = Convert.ToUInt64(input, 16).ToString();                  //hex to decimal
                    bin = Convert.ToString(Convert.ToInt64(input, 16), 2);         //hex to binary
                    if (Convert.ToUInt64(input, 16) <= 255)
                        ascii = char.ConvertFromUtf32(Convert.ToInt32(input, 16));  //decimal ASCHII  code to ASCII symbol
                }
                else if (format == Format.DEC)
                {
                    dec = input;
                    hex = Convert.ToString(long.Parse(input), 16);          //decimal to hex
                    bin = Convert.ToString(long.Parse(input), 2);           //decimal to bin
                    if (long.Parse(input) <= 255)
                        ascii = char.ConvertFromUtf32(int.Parse(input));    //decimal ASCII  code to ASCII symbol
                }
                else if (format == Format.BIN)
                {
                    bin = input;
                    hex = Convert.ToString(Convert.ToInt64(input, 2), 16);         //binary to hex
                    dec = Convert.ToUInt64(input, 2).ToString();                   //binary to decimal
                    if (Convert.ToUInt64(input, 2) <= 255)
                        ascii = char.ConvertFromUtf32(Convert.ToInt32(input, 2));   //decimal ASCHII  code to ASCII symbol
                }
                else if (format == Format.ASCII)
                {
                    ascii = input;
                    hex = Convert.ToString((uint)input[0], 16);   //ASCII symbol to hex
                    dec = ((uint)input[0]).ToString();            //ASCII symbol to decimal ASCII code
                    bin = Convert.ToString((uint)input[0], 2);    //ASCII symbol to bin
                }

                isConverted = true;
            }
            catch (Exception ex)
            {
                isConverted = false;
                labelStatus.ForeColor = Color.DarkRed;
                labelStatus.Text = ex.Message;
            }

            textBoxHex.Text = hex;
            textBoxDec.Text = dec;
            textBoxBin.Text = bin;
            textBoxAsciiChar.Text = ascii;

            if (isConverted) labelStatus.Text = ""; //no error in convertion

            if (textBoxHex.TextLength > 0) lblHexBit.Text = textBoxHex.TextLength.ToString();
            else lblHexBit.Text = "";
            if (textBoxDec.TextLength > 0) lblDecBit.Text = textBoxDec.TextLength.ToString();
            else lblDecBit.Text = "";
            if (textBoxBin.TextLength > 0) lblBinBit.Text = textBoxBin.TextLength.ToString();
            else lblBinBit.Text = "";
        }

        private void UpdateBinSelectionResult()
        {
            if (textBoxBin.SelectionStart >= textBoxBin.Text.Length) return;

            try
            {
                var selstr = "";
                var end = 0;
                var start = textBoxBin.Text.Length - textBoxBin.SelectionStart - 1;
                if (textBoxBin.SelectionLength == 0)
                {
                    end = start;
                    selstr = textBoxBin.Text[textBoxBin.SelectionStart].ToString();
                }
                else
                {
                    end = start - textBoxBin.SelectionLength + 1;
                    selstr = textBoxBin.SelectedText;
                }
                var val = Convert.ToInt64(selstr, 2); //binary to decimal
                labelStatus.ForeColor = Color.Blue;
                labelStatus.Text = string.Format("{0}:{1} --> 0x{2:X2}", start, end, val);
            }
            catch (Exception ex)
            {
                labelStatus.ForeColor = Color.DarkMagenta;
                labelStatus.Text = ex.Message;
            }
        }

        private void DisplayResult()
        {
            try
            {
                _operand2 = _inputstr;
                _inputstr = string.Empty;
                double.TryParse(_operand1, out double num1);
                double.TryParse(_operand2, out double num2);

                if (_operation == '+')
                {
                    _result = num1 + num2;
                    textBoxCalcDisplay.Text = _result.ToString();
                }
                else if (_operation == '-')
                {
                    _result = num1 - num2;
                    textBoxCalcDisplay.Text = _result.ToString();
                }
                else if (_operation == '*')
                {
                    _result = num1 * num2;
                    textBoxCalcDisplay.Text = _result.ToString();
                }
                else if (_operation == '/')
                {
                    if (num2 != 0)
                    {
                        _result = num1 / num2;
                        textBoxCalcDisplay.Text = _result.ToString();
                    }
                    else
                    {
                        textBoxCalcDisplay.Text = "DIV/Zero!";
                    }
                }
            }
            catch (Exception ex)
            {
                labelStatus.ForeColor = Color.DarkMagenta;
                labelStatus.Text = ex.Message;
            }
        }

        #endregion

        #region ctor

        public MainForm()
        {
            InitializeComponent();

            this.Size = _minWindowSize;
            labelTittle.Text = DeveloperUrl;
            labelStatus.Text = "";
            _prevNumVal = (int)numericUpDownAsciiVal.Value;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Converter Events

        private void TextBoxAsciiChar_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertNumber(textBoxAsciiChar.Text, Format.ASCII);
        }

        private void TextBoxAsciiChar_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxAsciiChar.SelectAll(); //for replacing the previous input by current
        }

        private void NumericUpDownAsciiVal_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxDec.Text, out int decValue)) decValue = 47;
                var currentNumVal = (int)numericUpDownAsciiVal.Value;
                if (currentNumVal > _prevNumVal) decValue++;
                else decValue--;
                _prevNumVal = currentNumVal;

                if (decValue < 0 || decValue > 255) return;
                ConvertNumber(decValue.ToString(), Format.DEC);
            }
            catch (Exception ex)
            {
                labelStatus.ForeColor = Color.DarkMagenta;
                labelStatus.Text = ex.Message;
            }
        }

        private void TextBoxDec_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertNumber(textBoxDec.Text, Format.DEC);
        }

        private void TextBoxHex_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertNumber(textBoxHex.Text, Format.HEX);
        }

        private void TextBoxBin_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertNumber(textBoxBin.Text, Format.BIN);
            UpdateBinSelectionResult();
        }

        private void TextBoxBin_Click(object sender, EventArgs e)
        {
            UpdateBinSelectionResult();
        }

        private void CheckBoxTOP_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBoxTOP.Checked;
        }

        private void BtnAsciiTable_Click(object sender, EventArgs e)
        {
            if (AsciiTable.IsDisposed)
                AsciiTable = new AsciiTableForm();
            AsciiTable.Show();
            AsciiTable.Focus();
        }

        private void LabelTittle_Click(object sender, EventArgs e)
        {
            Process.Start(DeveloperUrl);
        }

        private void BtnShowCalculator_Click(object sender, EventArgs e)
        {
            if (!_calculatorVisible)
            {
                _calculatorVisible = true;
                this.Size = _fullWindowSize;
                btnShowCalculator.Text = "↑";
                textBoxCalcDisplay.Focus();

            }
            else
            {
                _calculatorVisible = false;
                this.Size = _minWindowSize;
                btnShowCalculator.Text = "↓";
                textBoxDec.Focus();
            }
        }

        #endregion

        #region Calculator Events

        private void DisplayError(string message)
        {
            labelStatus.ForeColor = Color.DarkMagenta;
            labelStatus.Text = message;
        }

        private void TextBoxCalcDisplay_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TextBoxCalcDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TboxCalcDisplay_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DisplayResult();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (_inputstr.Length > 0)
                    {
                        _inputstr = _inputstr.Substring(0, _inputstr.Length - 1);
                        textBoxCalcDisplay.Text = _inputstr;
                    }
                }
                else if (e.KeyCode == Keys.Add)
                {
                    _operand1 = _inputstr;
                    _operation = '+';
                    _inputstr = "";
                }
                else if (e.KeyCode == Keys.Subtract)
                {
                    _operand1 = _inputstr;
                    _operation = '-';
                    _inputstr = "";
                }
                else if (e.KeyCode == Keys.Multiply)
                {
                    _operand1 = _inputstr;
                    _operation = '*';
                    _inputstr = "";
                }
                else if (e.KeyCode == Keys.Divide)
                {
                    _operand1 = _inputstr;
                    _operation = '/';
                    _inputstr = "";
                }
                else if (e.KeyCode == Keys.Decimal)
                {
                    _inputstr += ".";
                    textBoxCalcDisplay.Text = _inputstr;
                }
                else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                {
                    _inputstr += (e.KeyCode - Keys.NumPad0);
                    textBoxCalcDisplay.Text = _inputstr;
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }

        private void BtnAC_Click(object sender, EventArgs e)
        {
            textBoxCalcDisplay.Text = "0";
            _inputstr = "";
            _operand1 = "";
            _operand2 = "";
        }

        private void BtnHex_Click(object sender, EventArgs e)
        {
            textBoxCalcDisplay.Text = Convert.ToString(long.Parse(_inputstr), 16);  //decimal to hex
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void BtnBin_Click(object sender, EventArgs e)
        {
            textBoxCalcDisplay.Text = Convert.ToString(long.Parse(_inputstr), 2);   //decimal to bin
        }

        private void BtnCut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_inputstr)) return;
            _inputstr = _inputstr.Substring(0, _inputstr.Length - 1);
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void BtnInverse_Click(object sender, EventArgs e)
        {

        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {

        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            _inputstr += ".";
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            _inputstr += "0";
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            _inputstr += "1";
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            _inputstr += "2";
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            _inputstr += "3";
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            _inputstr += "4";
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            _inputstr += "5";
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            _inputstr += "6";
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            _inputstr += "7";
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            _inputstr += "8";
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            _inputstr += "9";
            textBoxCalcDisplay.Text = _inputstr;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            _operand1 = _inputstr;
            _operation = '+';
            _inputstr = string.Empty;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            _operand1 = _inputstr;
            _operation = '-';
            _inputstr = string.Empty;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            _operand1 = _inputstr;
            _operation = '*';
            _inputstr = string.Empty;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            _operand1 = _inputstr;
            _operation = '/';
            _inputstr = string.Empty;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            DisplayResult();
        }

        private void ButtonCopyToConverter_Click(object sender, EventArgs e)
        {
            var result = ((int)_result).ToString();
            ConvertNumber(result, Format.DEC);
        }

        #endregion

        #region Form Close Events

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AsciiTable.Close();
        }

        #endregion

    }
}
