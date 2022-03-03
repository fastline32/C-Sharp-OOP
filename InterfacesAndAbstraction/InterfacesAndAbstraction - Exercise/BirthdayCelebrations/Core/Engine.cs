using System;
using System.Collections.Generic;
using System.Linq;
using BirthdayCelebrations.Interfaces;
using BirthdayCelebrations.Models;

namespace BirthdayCelebrations.Core
{
    public class Engine
    {
        private IList<IIdent> idents;
        private List<IIdent> birthdays;

        public Engine()
        {
            this.idents = new List<IIdent>();
            this.birthdays = new List<IIdent>();
        }

        public void Run()
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] inputData = command.Split();
                if (inputData[0] == "Robot")
                {
                    command = Console.ReadLine();
                    continue;
                }
                if(inputData[0] == "Citizen")
                {
                    Citizen citizen = new Citizen(inputData[1], int.Parse(inputData[2]), inputData[3], inputData[4]);
                    idents.Add(citizen);
                }
                else if(inputData[0] == "Pet")
                {
                    Pet pet = new Pet(inputData[1], inputData[2]);
                    idents.Add(pet);
                }

                command = Console.ReadLine();
            }
            string forCheck = Console.ReadLine();
            this.birthdays = idents.Where(x => x.Birthday.EndsWith(forCheck)).ToList();
            if (this.birthdays.Count != 0)
            {
                foreach (var ident in birthdays)
                {
                    Console.WriteLine(ident.Birthday);
                }
            }
        }
    }
}
