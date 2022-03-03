using System;
using System.Collections.Generic;
using System.Linq;
using BorderControl.Interfaces;
using BorderControl.Models;

namespace BorderControl.Core
{
    public class Engine
    {
        private IList<IIdent> idents;

        public Engine()
        {
            this.idents = new List<IIdent>();
        }

        public void Run()
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] inputData = command.Split();
                if (inputData.Length == 2)
                {
                    Robot robot = new Robot(inputData[0], inputData[1]);
                    this.idents.Add(robot);
                }
                else if (inputData.Length == 3)
                {
                    Citizen citizen = new Citizen(inputData[0], int.Parse(inputData[1]), inputData[2]);
                    this.idents.Add(citizen);
                }
                command = Console.ReadLine();
            }
            string forCheck = Console.ReadLine();

            foreach (var ident in idents.Where(c => c.Id.EndsWith(forCheck)))
            {
                Console.WriteLine(ident.Id);
            }
            
        }
    }
}
