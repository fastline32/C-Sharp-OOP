using System;
using System.Collections.Generic;
using System.Linq;
using FoodShortage.Interfaces;
using FoodShortage.Models;

namespace FoodShortage.Core
{
    public class Engine
    {
        private Dictionary<string, IBuyer> BuyerList;

        public Engine()
        {
            BuyerList = new Dictionary<string, IBuyer>();
        }

        public void Run()
        {
            int command = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < command; i++)
            {
                string[] inputInfo = Console.ReadLine()!.Split();
                if (inputInfo.Length == 3)
                {
                    Rebel rebel = new Rebel(inputInfo[0], int.Parse(inputInfo[1]), inputInfo[2]);
                    BuyerList.Add(inputInfo[0],rebel);
                }
                else if (inputInfo.Length == 4)
                {
                    Citizen citizen = new Citizen(inputInfo[0], int.Parse(inputInfo[1]), inputInfo[2], inputInfo[3]);
                    BuyerList.Add(inputInfo[0],citizen);
                }
            }

            string line = Console.ReadLine();
            while (line != "End")
            {
                if (BuyerList.ContainsKey(line))
                {
                    BuyerList[line].BuyFood();
                }
                line = Console.ReadLine();
            }

            int sum = 0;
            foreach (var buyer in BuyerList)
            {
                sum += buyer.Value.Food;
            }

            Console.WriteLine(sum);
        }
    }
}
