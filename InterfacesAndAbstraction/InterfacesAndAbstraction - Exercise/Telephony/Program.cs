using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            foreach (var num in nums)
            {
                if (num.Length == 7)
                {
                    StationaryPhone phone = new StationaryPhone();
                    phone.Call(num);
                }
                else if (num.Length == 10)
                {
                    Smartphone phone = new Smartphone();
                    phone.Call(num);
                }
                else
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
            string[] urls = Console.ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            foreach (var url in urls)
            {
                Smartphone phone = new Smartphone();
                phone.Browsing(url);
            }
        }
    }
}
