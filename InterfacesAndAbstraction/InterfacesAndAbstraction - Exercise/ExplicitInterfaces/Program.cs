using System;
using ExplicitInterfaces.Core;

namespace ExplicitInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
