using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contractorCalculator
{
    public static class validateInput
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        //checks if a character is there
        public static bool characterPresent(TextBox textbox, string requiredCharacter)
        {
            if (textbox.Text.Contains(requiredCharacter))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textbox.Name + " must contain" + requiredCharacter);
                return false;
            }
        }
        //checks if textbox has text
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Name + " is a required field.", Title);
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }
            return true;
        }

        //checks if item is decimal
        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }
        }

        // check if text is int
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }
        }

        //checks if text is within range
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        //the character limit is set by this
        public static bool characterLimit(TextBox textbox, int limitSet)
        {
            if (textbox.Text.Length > limitSet)
            {
                MessageBox.Show("Text box can only have " + limitSet + " characters");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool fieldsMatch(TextBox textBox1, TextBox textBox2)
        {
            if(textBox1.Text == textBox2.Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Fields must match!");
                return false;
            }
        }
    }
}
