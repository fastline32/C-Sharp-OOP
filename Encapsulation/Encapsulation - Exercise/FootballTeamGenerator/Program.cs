using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string,Team> teams = new Dictionary<string,Team>();
            while (command != "END")
            {
                string[] inputline = command.Split(';');
                try
                {
                    if (inputline[0] == "Team")
                    {
                        string teamName = inputline[1];
                        Team team = new Team(teamName);
                        teams.Add(teamName, team);
                    }
                    if (inputline[0] == "Add")
                    {
                        string teamName = inputline[1];
                        string playerName = inputline[2];
                        double endurance = double.Parse(inputline[3]);
                        double sprint = double.Parse(inputline[4]);
                        double dribble = double.Parse(inputline[5]);
                        double passing = double.Parse(inputline[6]);
                        double shooting = double.Parse(inputline[7]);

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            command = Console.ReadLine();
                            continue;
                        }

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        teams[teamName].Add(player);
                    }
                    else if (inputline[0] == "Remove")
                    {
                        string teamName = inputline[1];
                        string playerName = inputline[2];
                        teams[teamName].Remove(playerName);
                    }
                    else if (inputline[0] == "Rating")
                    {
                        string teamName = inputline[1];
                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            command = Console.ReadLine();
                            continue;
                        }

                        Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                command = Console.ReadLine();
            }
        }
    }
}
