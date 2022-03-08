using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class Program
    {
        static void Main()
        {
            List<IBasedHero> soldiers = new List<IBasedHero>();
            int n = int.Parse(Console.ReadLine()!);
            while (soldiers.Count != n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                switch (type)
                {
                    case "Druid":
                        IBasedHero druid = new Druid(name);
                        soldiers.Add(druid); break;
                    case "Paladin":
                        IBasedHero paladin = new Paladin(name);
                        soldiers.Add(paladin); break;
                    case "Rogue":
                        IBasedHero rogue = new Rogue(name);
                        soldiers.Add(rogue); break;
                    case "Warrior":
                        IBasedHero warrior = new Warrior(name);
                        soldiers.Add(warrior); break;

                    default: Console.WriteLine("Invalid hero!"); break;
                }
            }

            int bossStrainght = int.Parse(Console.ReadLine()!);
            int health = soldiers.Select(x=>x.Power).Sum();
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.CastAbility());
            }

            if (health >= bossStrainght)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
