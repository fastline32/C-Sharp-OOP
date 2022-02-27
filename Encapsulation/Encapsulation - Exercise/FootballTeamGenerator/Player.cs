using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;

        public Player(string name, double endurance,double sprint,double dribble,double passing,double shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
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
                this.name = value;
            }
        }

        public double Endurance
        {
            get => endurance;
            private set
            {
                CheckIsValid(nameof(Endurance),value);
                this.endurance = value;
            }
        }

        public double Sprint
        {
            get => sprint;
            private set
            {
                CheckIsValid(nameof(Sprint), value);
                this.sprint = value;
            }

        }

        public double Dribble
        {
            get => dribble;
            private set
            {
                CheckIsValid(nameof(Sprint), value);
                dribble = value;
            }
        }

        public double Passing
        {
            get => passing;
            private set
            {
                CheckIsValid(nameof(Passing), value);
                this.passing = value;
            }
        }

        public double Shooting
        {
            get => shooting;
            private set
            {
                CheckIsValid(nameof(Shooting), value);
                this.shooting = value;
            }
        }

        public double Stats => AverageStats();

        private double AverageStats()
        {
            double average = (endurance + sprint + dribble + passing + shooting) / 5.0;
            return average;
        }

        private void CheckIsValid(string valueName,double n)
        {
            if (n < 0 || n > 100)
            {
                throw new ArgumentException($"{valueName} should be between 0 and 100.");
            }
        }
    }
}
