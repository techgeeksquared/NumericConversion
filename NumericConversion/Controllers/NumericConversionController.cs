using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NumericConversion.Models;

namespace NumericConversion.Controllers
{
    public class NumericConversionController : Controller
    {
        private readonly NumberConversionModel _conversionSettings;

        public NumericConversionController()
        {
            _conversionSettings = new NumberConversionModel();
        }

        [HttpGet]
        public IActionResult NumericConverterLanding()
        {
            return View("NumericConversion");
        }

        [HttpPost]
        public IActionResult NumericConverterLanding(NumberConversionModel model)
        {
            if (ModelState.IsValid)
            {
              ViewData["conversion_result"] =  NumericConverter(model);
            }

            return View("NumericConversion");
        }

        public string NumericConverter(NumberConversionModel num) //1520132.54
        { 
           return _conversionSettings.DecimalToWords(num.number);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
