using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NumericConversion.Models;
using NumericConversion.Helpers;

namespace NumericConversion.Factories
{
    public class ConversionFactory
    {
        public static String ConvertToText(String inputNumber)
        {
            String val = "", wholeNumber = inputNumber, decimalnumbers = "", andString = "", decimalString = "";
            String StringEnd = "";
            try
            {
                int decimalPlace = inputNumber.IndexOf(".");

                if (decimalPlace > 0)
                {
                    wholeNumber = inputNumber.Substring(0, decimalPlace);
                    decimalnumbers = inputNumber.Substring(decimalPlace + 1);

                    if (Convert.ToInt32(decimalnumbers) > 0)
                    {
                        string isAnd = string.Empty;
                        string isDollars = string.Empty;

                        if ((wholeNumber.Length > 0 && wholeNumber == "0") || (wholeNumber.Length == 0))
                        {

                            isDollars = Helpers.ConversionHelpers.isCurrencyType(1);
                            StringEnd = decimalnumbers.ToString() + "/100 " + isDollars;
                        }
                        else
                        {
                            isDollars = Helpers.ConversionHelpers.isCurrencyType(1);
                            isAnd = Helpers.ConversionHelpers.isAnd;
                            StringEnd = isAnd + " " + decimalnumbers.ToString() + "/100 " + isDollars;
                        }
                    }
                }
                val = String.Format("{0} {1}{2} {3}", Helpers.ConversionHelpers.ConvertWholeNumber(wholeNumber).Trim(), andString, decimalString, StringEnd);
            }
            catch {

                //TODO: add better error checking. 
            }
            return val;
        }

    }
}
