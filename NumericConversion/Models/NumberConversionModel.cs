using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NumericConversion.Controllers;
using NumericConversion.Helpers;


namespace NumericConversion.Models
{
    public class NumberConversionModel
    {
        [Required(ErrorMessage = "An entry is required")]
        [Range(0, 2000000)]        
        [RegularExpression(@"^?\d+(\.\d+)?$", ErrorMessage = "Please enter a non-negative decimal")]
        public double number { get; set; }

        public string DecimalToWords(double number) // 1520132.54
        {
            string words = string.Empty;

            words = Factories.ConversionFactory.ConvertToText(number.ToString());
            
            return words;
        }

    }
}
