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
            String val = "", wholenumber = inputNumber, decimalnumbers = "", andString = "", decimalString = "";
            String StringEnd = "";
            int decimalvalue = 0;
            bool beginsZero = false;
            try
            {
                int decimalPlace = inputNumber.IndexOf(".");

                if (decimalPlace > 0)
                {
                    wholenumber = inputNumber.Substring(0, decimalPlace);
                    double dblAmt = (Convert.ToDouble(wholenumber));

                    if (dblAmt > 0)
                    {
                        beginsZero = wholenumber.StartsWith("0");
                    }
                        decimalnumbers = inputNumber.Substring(decimalPlace + 1);
                    decimalvalue = Convert.ToInt32(decimalnumbers);

                    decimalnumbers = Convert.ToString(decimalLengthCheck(decimalvalue));

                    if (Convert.ToInt32(decimalnumbers) > 0)
                    {
                        string isAnd = string.Empty;
                        string isDollars = string.Empty;

                        if ((wholenumber.Length > 0 && wholenumber == "0") || (wholenumber.Length == 0))
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
                val = String.Format("{0} {1}{2} {3}", Helpers.ConversionHelpers.ConvertWholeNumber(wholenumber).Trim(), andString, decimalString, StringEnd);
            }
            catch
            {

                //TODO: add better error checking. 
            }
            return val;
        }

        private static int decimalLengthCheck(int decimalvalue)
        {
            int decimallength = Convert.ToString(decimalvalue).Length, _decimalvalue = decimalvalue;

            switch (decimallength)
            {
                case 1:
                    _decimalvalue = decimalvalue * 10;
                    return _decimalvalue;
                default:
                    return _decimalvalue;
            }
        }
    }
}
