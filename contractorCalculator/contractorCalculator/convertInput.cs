using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contractorCalculator
{
    public static class convertInput
    {
        public static decimal stringToDecimal(TextBox textBox)
        {
            string textBoxText = textBox.Text;
            decimal textBoxTextToDecimal;
            decimal.TryParse(textBoxText,out textBoxTextToDecimal);
            return textBoxTextToDecimal;
        }

        public static string stringToMoney(string money)
        {
            return "$" + money;
        }
    }
}
