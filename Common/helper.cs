using System;
using System.Globalization;
using System.Text.RegularExpressions;


namespace PurpleTreeSoftware.Currency.Common
{
    public static class helper
    {
        /// <summary>
        ///  Converts a text string to a decimal value
        /// </summary>
        /// <param name="pCurrencyString">The string to convert to decimal</param>
        /// <returns>A decimal representation of the text string provided</returns>
        public static decimal ConvertStringToDecimal(string pCurrencyString)
        {
            var radixCharacter = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator.ToCharArray();
            var currencyArray = pCurrencyString.Split(radixCharacter);
            var currencyArrayLength = currencyArray.Length;
            decimal decValue;

            if (currencyArrayLength == 2)
            {
                var integerComponent = Regex.Replace(currencyArray[0], @"[^\d]", "");
                var fractionComponent = Regex.Replace(currencyArray[1], @"[^\d]", "");

                // If string is empty then set value as zero
                if (String.IsNullOrEmpty(integerComponent) && String.IsNullOrEmpty(fractionComponent))
                {
                    integerComponent = "0";
                    fractionComponent = "0";
                }

                decValue = Convert.ToDecimal(@integerComponent + @"." + @fractionComponent);

            }
            else if (currencyArrayLength == 1)
            {
                var integerComponent = Regex.Replace(currencyArray[0], @"[^\d]", "");

                // If the string is empty then set value as zero
                if (String.IsNullOrEmpty(integerComponent))
                {
                    integerComponent = "0";
                }

                decValue = Convert.ToDecimal(integerComponent);
            }
            else
            {
                decValue = 0;
            }

            return decValue;
        }


        /// <summary>
        /// Converts a decimal value to a currency formatted string
        /// </summary>
        /// <param name="pCurrencyValue">The decimal value of the currency</param>
        /// <param name="pDecimalPlaces">Number of decimal places to display</param>
        /// <returns></returns>
        public static string ConvertDecimalToString(decimal pCurrencyValue, int pDecimalPlaces)
        {
            return pCurrencyValue.ToString(@"C" + Convert.ToString(pDecimalPlaces), CultureInfo.CurrentUICulture);
        }

    }
}
