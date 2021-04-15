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
                Player p1 = new Player() { PlayerID = 1, Name = "Tom", Position = "Defender", TeamID = 1, Team = t1 };
                Player p2 = new Player() { PlayerID = 1, Name = "John", Position = "Midfield", TeamID = 1, Team = t1 };

                Player p3 = new Player() { PlayerID = 1, Name = "Bill", Position = "Defender", TeamID = 2, Team = t2 };
                Player p4 = new Player() { PlayerID = 1, Name = "Jack", Position = "Forward", TeamID = 2, Team = t2 };

                db.Players.Add(p1);
                db.Players.Add(p2);
                db.Players.Add(p3);
                db.Players.Add(p4);
                Console.WriteLine("Added Players to DB");

                // Save database
                db.SaveChanges();

                Console.WriteLine("Saved to DB");
            }
        }
    }
}
