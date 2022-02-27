using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public IReadOnlyCollection<Player> Players { get; }

        public int Rating => this.players.Count == 0 ? 0 : (int)Math.Round(players.Average(x => x.Stats));
        public void Add(Player player)
        {
            this.players.Add(player);
        }

        public void Remove(string playerName)
        {
            Player player = players.FirstOrDefault(x => x.Name == playerName);
            if (player == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {Name} team.");
            }
            this.players.Remove(player);
        }
    }
}