using System;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICall,IBrowse
    {
        public string Call(string number)
        {
            if (!number.All(c => Char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return number.Length > 7 ? $"Calling... {number}" : $"Dialing... {number}";
        }

        public string Browsing(string url)
        {
            if (url.Any(c => Char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }
    }
}
