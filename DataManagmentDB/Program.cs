using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Project09_02_2021;

namespace DataManagmentDB
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerData db = new PlayerData();

            using (db)
            {
                // Create some player objects
                Player p1 = new Player() { PlayerID = 1, Name = "Tammy Abraham", Position = "Striker", Age = 21, Nationality = "England", Club = "Chelsea", PlayerImage = "/images/abraham.png", Goals = 8, Assists = 5, GamesPlayed = 22};
                Player p2 = new Player() { PlayerID = 2, Name = "Sergio Aguero", Position = "Striker", Age = 32, Nationality = "Argentina", Club = "Man City", PlayerImage = "/images/aguero.png", Goals =17 , Assists = 5, GamesPlayed =21};
                Player p3 = new Player() { PlayerID = 3, Name = "Patrick Bamford", Position = "Striker", Age =28 , Nationality = "England", Club = "Leeds", PlayerImage = "/images/bamford.png", Goals = 10, Assists = 3, GamesPlayed =  23};
                Player p4 = new Player() { PlayerID = 4, Name = "Bruno Fernandes", Position = "Attacking Midfield", Age = 26 , Nationality = "Portugal", Club = "Man United", PlayerImage = "/images/bruno.png", Goals = 14, Assists = 10, GamesPlayed = 23};
                Player p5 = new Player() { PlayerID = 5, Name = "Kevin De Bruyne", Position = "Attacking Midfield", Age = 28, Nationality = "Belgium", Club = "Man City", PlayerImage = "/images/de-bruyne", Goals = 7, Assists = 10, GamesPlayed = 20};
                Player p6 = new Player() { PlayerID = 6, Name = "Mason Greenwood", Position = "Winger", Age = 19, Nationality = "England", Club = "Man United", PlayerImage = "/images/greenwood.png", Goals = 5, Assists = 3, GamesPlayed = 13};
                Player p7 = new Player() { PlayerID = 7, Name = "Danny Ings", Position = "Striker", Age = 28, Nationality = "England", Club = "Southhampton", PlayerImage = "/images/ing.png", Goals = 7, Assists = 2, GamesPlayed = 23};
                Player p8 = new Player() { PlayerID = 8, Name = "Gabriel Jesus", Position = "Striker", Age = 24, Nationality = "Brazil", Club = "Man City", PlayerImage = "/images/jesus.png", Goals = 4, Assists = 1, GamesPlayed = 14};
                Player p9 = new Player() { PlayerID = 9, Name = "Harry Kane", Position = "Striker", Age = 28, Nationality = "England", Club = "Spurs", PlayerImage = "/images/kane.png", Goals = 14, Assists = 5, GamesPlayed =  23};
                Player p10 = new Player() { PlayerID = 10, Name = "N'Golo Kante", Position = "Defensive Midfield", Age = 27, Nationality = "France", Club = "Chelsea", PlayerImage = "/images/kante.png", Goals = 4, Assists = 4, GamesPlayed = 23};
                Player p11 = new Player() { PlayerID = 11, Name = "Dominic Cailvert Lewin", Position = "Striker", Age = 24, Nationality = "England", Club = "Everton", PlayerImage = "/images/lewin.png", Goals = 5, Assists = 5, GamesPlayed = 15};
                Player p12 = new Player() { PlayerID = 12, Name = "Sadio Mane", Position = "Winger", Age = 28, Nationality = "Senegal", Club = "Liverpool", PlayerImage = "/images/mane.png", Goals = 13, Assists = 5, GamesPlayed =  20};
                Player p13 = new Player() { PlayerID = 13, Name = "Yerry Mina", Position = "Center Back", Age = 26, Nationality = "Columbia", Club = "Everton", PlayerImage = "/images/mina.png", Goals = 2, Assists = 4, GamesPlayed = 15};
                Player p14 = new Player() { PlayerID = 14, Name = "Paul Pogba", Position = "Central Midfield", Age = 27, Nationality = "France", Club = "Man United", PlayerImage = "/images/pogba.png", Goals = 7, Assists = 9, GamesPlayed = 18};
                Player p15 = new Player() { PlayerID = 15, Name = "Andrew Robertson", Position = "Full Back", Age = 27, Nationality = "Scottish", Club = "Liverpool", PlayerImage = "/images/roberston.png", Goals = 3, Assists = 12, GamesPlayed = 23};
                Player p16 = new Player() { PlayerID = 16, Name = "Mohammed Salah", Position = "Winger", Age = 28, Nationality = "Egypt", Club = "Liverpool", PlayerImage = "/images/salah.jpg", Goals = 16, Assists = 7, GamesPlayed = 23};
                Player p17 = new Player() { PlayerID = 17, Name = "Son Heung-min", Position = "Winger", Age = 28, Nationality = "South Korea", Club = "Spurs", PlayerImage = "/images/son.png", Goals = 13, Assists = 9, GamesPlayed =  23};
                Player p18 = new Player() { PlayerID = 18, Name = "Raheem Sterling", Position = "Winger", Age = 27, Nationality = "England", Club = "Man City", PlayerImage = "/images/sterling.png", Goals = 10, Assists = 5, GamesPlayed =  22};
                Player p19 = new Player() { PlayerID = 19, Name = "Trent Alexander Arnold", Position = "Full Back", Age = 22, Nationality = "England", Club = "Liverpool", PlayerImage = "/images/trent.png", Goals = 2, Assists = 9, GamesPlayed = 23};
                Player p20 = new Player() { PlayerID = 20, Name = "Timo Werner", Position = "Striker", Age = 25, Nationality = "Germany", Club = "Chelsea", PlayerImage = "/images/werner.png", Goals = 6, Assists = 2, GamesPlayed = 17};

                // Add player to Database
                db.Players.Add(p1);
                db.Players.Add(p2);
                db.Players.Add(p3);
                db.Players.Add(p4);
                db.Players.Add(p5);
                db.Players.Add(p6);
                db.Players.Add(p7);
                db.Players.Add(p8);
                db.Players.Add(p9);
                db.Players.Add(p10);
                db.Players.Add(p11);
                db.Players.Add(p12);
                db.Players.Add(p13);
                db.Players.Add(p14);
                db.Players.Add(p15);
                db.Players.Add(p16);
                db.Players.Add(p17);
                db.Players.Add(p18);
                db.Players.Add(p19);
                db.Players.Add(p20);


                Console.WriteLine("Added Players to DB");

                // Save database
                db.SaveChanges();

                Console.WriteLine("Saved to DB");
            }
        }
    }
}
