using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project09_02_2021
{
    class Teams
    {
        // Properties
        public string Name { get; set; }
        public int Played { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int GoalDifference { get; set; }
        public int Points { get; set; }
        public int YearFounded { get; set; }
        public int Networth { get; set; }
        public int Titles { get; set; }
        public string Manager { get; set; }

        // Constructors
        public Teams(string name, int played, int wins, int draws, int losses, int goalDifference, int points, int yearFounded, int networth, int titles, string manager)
        {
            Name = name;
            Played = played;
            Wins = wins;
            Draws = draws;
            Losses = losses;
            GoalDifference = goalDifference;
            Points = points;
            YearFounded = yearFounded;
            Networth = networth;
            Titles = titles;
            Manager = manager;
        }
        public Teams()
        {

        }

        public class Player
        {
            // Properties for players Table
            public int PlayerID { get; set; }
            public string Name { get; set; }        
            public string Position { get; set; }
            public int Age { get; set; }
            public string Nationality { get; set; }
            public string PlayerImage { get; set; }

            public int Goals { get; set; }
            public int Assists { get; set; }
            public int GamesPlayed { get; set; }

            public List<Player> Players { get; set; }
        }
        public class PlayerData : DbContext
        {
            public PlayerData() : base("PlayerData") { } // Gives DB it's name

            public DbSet<Player> Players { get; set; } // creates players TBL

        }

        // ToString method for ListBox
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}", Name, Played, Wins, Draws, Losses, GoalDifference, Points);
        }
    }
}
