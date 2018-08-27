using System;

namespace PublisherOperations.Models
{
    public class BasicFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key} : {value}";
        }
    }
}