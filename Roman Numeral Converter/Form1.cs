using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roman_Numeral_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
                // Checks to make sure the input fits the variable.
                if (int.TryParse(numberTextBox.Text, out int number))
                {
                    // If the number does not fit in the 1-10 range, an error is displayed.
                    if ((number <= 10) && (number >= 1))
                    {
                        // All the cases for the numbers 1-10 and their associated roman numerals will be displayed.
                        switch (number)
                        {
                            case 1:
                                romanNumeralLabel.Text = "I";
                                break;
                            case 2:
                                romanNumeralLabel.Text = "II";
                                break;
                            case 3:
                                romanNumeralLabel.Text = "III";
                                break;
                            case 4:
                                romanNumeralLabel.Text = "IV";
                                break;
                            case 5:
                                romanNumeralLabel.Text = "V";
                                break;
                            case 6:
                                romanNumeralLabel.Text = "VI";
                                break;
                            case 7:
                                romanNumeralLabel.Text = "VII";
                                break;
                            case 8:
                                romanNumeralLabel.Text = "VIII";
                                break;
                            case 9:
                                romanNumeralLabel.Text = "IX";
                                break;
                            case 10:
                                romanNumeralLabel.Text = "X";
                                break;
                        }
                    }
                    // If the number is not between 1 and 10, an error message will be displayed.
                    else
                    {
                        MessageBox.Show("Invalid input. Enter a number between 1 and 10.");
                    }
            }
            // If the variable is not a integer for 1 and 10, an error message will be displayed.
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the text box in which to enter the number and the label that shows the roman numeral equivalent.
            numberTextBox.Text = "";
            romanNumeralLabel.Text = "";
            // The focus is cleared.
            numberTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
