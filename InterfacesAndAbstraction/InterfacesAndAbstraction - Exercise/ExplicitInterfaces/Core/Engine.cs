using System;
using ExplicitInterfaces.Interfaces;
using ExplicitInterfaces.Models;

namespace ExplicitInterfaces.Core
{
    public class Engine : IEngine
    {
        public Engine()
        {
            
        }
        public void Run()
        {
            string command = Console.ReadLine();
            while (command!= "End")
            {
                string[] line = command.Split();
                string name = line[0];
                string country = line[1];
                int age = int.Parse(line[2]);
                Citizen citizen = new Citizen(name, country, age);
                IResident rezident = citizen;
                rezident.GetName();
                IPerson person = citizen;
                person.GetName();
                command = Console.ReadLine();
            }
        }
    }
}