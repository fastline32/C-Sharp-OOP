using System;
using System.Collections.Generic;
using MilitaryElite.Implementations;
using MilitaryElite.Interfaces;

namespace MilitaryElite
{
    public class Program
    {
        static void Main()
        {
            Dictionary<int ,ISoldier> soldiers = new Dictionary<int, ISoldier>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputInfo = input.Split();
                string action = inputInfo[0];
                int id = int.Parse(inputInfo[1]);
                string firstName = inputInfo[2];
                string lastName = inputInfo[3];
                if (action == "Private")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    IPrivate @private = new Private(id, firstName, lastName, salary);
                    soldiers.Add(id, @private);
                }
                else if (action == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);
                    for (int i = 5; i < inputInfo.Length; i++)
                    {
                        int privateId = int.Parse(inputInfo[i]);
                        IPrivate @private = soldiers[privateId] as IPrivate;
                        lieutenantGeneral.Privates.Add(@private);
                    }
                    soldiers.Add(id,lieutenantGeneral);
                }
                else if (action == "Engineer")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    string corp = inputInfo[5];
                    bool isValid = Enum.TryParse(corp, out Corps result);
                    if (!isValid)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, result);
                    for (int i = 6; i < inputInfo.Length; i+=2)
                    {
                        string repairPart = inputInfo[i];
                        int repairHours = int.Parse(inputInfo[i + 1]);
                        IRepair repair = new Repair(repairPart, repairHours);
                        engineer.Repairs.Add(repair);
                    }
                    soldiers.Add(id,engineer);
                }
                else if (action == "Commando")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    string corp = inputInfo[5];
                    bool isValid = Enum.TryParse(corp, out Corps result);
                    if (!isValid)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    ICommando commando = new Commando(id, firstName, lastName, salary, result);

                    for (int i = 6; i < inputInfo.Length; i+=2)
                    {
                        string missionName = inputInfo[i];
                        string missionStatus = inputInfo[i + 1];

                        bool isValidMission = Enum.TryParse(missionStatus, out Status status);
                        if (!isValidMission)
                        {
                            continue;
                        }

                        IMission mission = new Mission(missionName, status);
                        commando.Missions.Add(mission);
                    }
                    soldiers.Add(id,commando);
                }
                else if (action == "Spy")
                {
                    string codeNumber = inputInfo[4];
                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);
                    soldiers.Add(id,spy);
                }
                input = Console.ReadLine();
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.Value.ToString());
            }
        }
    }
}
