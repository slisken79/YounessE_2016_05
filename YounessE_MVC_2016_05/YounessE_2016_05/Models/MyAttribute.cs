using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace YounessE_2016_05.Models
{
    public class MyAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            return Regex.IsMatch(value.ToString(), @"^p-\d+$");
        }

        public override string FormatErrorMessage(string name)
        {
            return ("Måste innehålla p- i början. Ex: p-12");
        }
    }
}