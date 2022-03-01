using System;
using System.Linq;

namespace Telephony
{
    public class StationaryPhone : ICall
    {
        private const string Message = "Dialing... {0}";

        public void Call(string number)
        {
            if (number.All(Char.IsDigit))
            {
                Console.WriteLine(Message,number);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
