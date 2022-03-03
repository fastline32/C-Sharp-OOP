using System;
using System.Collections.Generic;

namespace Telephony.Core
{
    
    public class Engine
    {
        private Smartphone smartPhone;
        private IList<string> phoneNumbers;
        private IList<string> urls;

        public Engine()
        {
            this.smartPhone = new Smartphone();
            this.phoneNumbers = new List<string>();
            this.urls = new List<string>();
        }

        public void Run()
        {
            this.phoneNumbers = Console.ReadLine()!.Split();
            this.urls = Console.ReadLine()!.Split();

            CallingNumbers();
            BrowsingWeb();

        }

        private void BrowsingWeb()
        {
            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(this.smartPhone.Browsing(url));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }

        private void CallingNumbers()
        {
            foreach (var phoneNumber in this.phoneNumbers)
            {
                try
                {
                    Console.WriteLine(this.smartPhone.Call(phoneNumber));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}