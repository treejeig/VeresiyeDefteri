using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VeresiyeDefteri.Helpers
{
    public class InputHelpers
    {
        public void AllowOnlyNumbersAndOneDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if(Regex.IsMatch((sender as TextBox).Text, @"\.\d\d"))
            {
                e.Handled |= true;
            }
        }

        public void AllowOnlyNumbers(object sender, KeyPressEventArgs e) 
        {
            if (((sender as TextBox).Text.Length == 0 && e.KeyChar == '0'))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
