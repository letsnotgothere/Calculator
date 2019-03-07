using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        Calculator calculator;

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = buttonTable;
            buttonTable.Focus();
            this.currentValueBox.Text = "0";
            calculator = new Calculator();

            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            this.KeyDown += new KeyEventHandler(Form1_Key);

        }

        private void Form1_Key(object sender, KeyEventArgs e)
        {
            Keys k = e.KeyCode;
            Boolean backspace = k == Keys.Back;
            Boolean escape = k == Keys.Escape;
            Boolean plus = k == Keys.Add;


            if (backspace) backButton_Click(null, null);
            if (escape) cancelButton_Click(null, null);

        }

        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.currentValueBox.Focus();
        }

        private void InsertTextValue(string s)
        {
            if (this.currentValueBox.Text == "0")
            {
                this.currentValueBox.Text = string.Empty;
            }

            int i = this.currentValueBox.Text.Length;
            this.currentValueBox.Text = this.currentValueBox.Text.Insert(i, s);
        }

        private void RemoveTextValue()
        {
            int i = this.currentValueBox.Text.Length;
            if (i != 0)
            {
                this.currentValueBox.Text = this.currentValueBox.Text.Remove(i - 1);
                i = this.currentValueBox.Text.Length;
                if (i == 0)
                {
                    this.currentValueBox.Text = "0";

                }
            }
        }

        #endregion

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                return;

            switch (e.KeyChar)
            {
                case '0':
                    zeroButton_Click(null, null);
                    break;
                case '1':
                    oneButton_Click(null, null);
                    break;
                case '2':
                    twoButton_Click(null, null);
                    break;
                case '3':
                    threeButton_Click(null, null);
                    break;
                case '4':
                    fourButton_Click(null, null);
                    break;
                case '5':
                    fiveButton_Click(null, null);
                    break;
                case '6':
                    sixButton_Click(null, null);
                    break;
                case '7':
                    sevenButton_Click(null, null);
                    break;
                case '8':
                    eightButton_Click(null, null);
                    break;
                case '9':
                    nineButton_Click(null, null);
                    break;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.currentValueBox.Text != "0")
            {
                RemoveTextValue();
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text += this.currentValueBox.Text;
            this.currentValueBox.Text = "0";
            MessageBox.Show("Calculating result...");
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;
            this.currentValueBox.Text = "0";

            //Focus the user input text
            FocusInputText();
        }

        #region Number Methods

        private void dotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            this.buttonTable.Focus();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            this.buttonTable.Focus();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            this.buttonTable.Focus();
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            this.buttonTable.Focus();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            this.buttonTable.Focus();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            this.buttonTable.Focus();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            this.buttonTable.Focus();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            this.buttonTable.Focus();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            this.buttonTable.Focus();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            this.buttonTable.Focus();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            this.buttonTable.Focus();
        }

        #endregion

        #region Operator Methods

        private void OperatorPressed(string s)
        {
            this.UserInputText.Text += this.currentValueBox.Text;
            this.UserInputText.Text += " " + s + " ";
            this.currentValueBox.Text = "0";
            this.buttonTable.Focus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OperatorPressed("+");
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            OperatorPressed("-");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            OperatorPressed("*");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            OperatorPressed("/");
        }



        #endregion

        
    }
}
