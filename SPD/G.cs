using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace SPD
{
    public static class G
    {
        public static bool ValidateParsianDate(string date)
        {
            bool status = false;

            DateTime result = DateTime.Now;
            CultureInfo arabicCulture = new CultureInfo("fa-IR");
            status = DateTime.TryParseExact(date, "yyyy/MM/dd", arabicCulture, DateTimeStyles.None, out result);

            return status;
        }

        public static void OnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
        }
    }
}
