using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherOperations.Models
{
    public class UppercaseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key} : {value.ToUpper()}";
        }
    }
}
