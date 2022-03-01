using System;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICall,IBrowse
    {
        public void Call(string number)
        {
            if (number.All(Char.IsDigit))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        public void Browsing(string url)
        {
            if (url.Any(Char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine("Browsing: {0}!",url);
            }
        }
    }
}
