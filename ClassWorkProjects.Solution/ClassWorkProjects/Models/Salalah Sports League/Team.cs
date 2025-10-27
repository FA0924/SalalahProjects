using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkProjects.Models.Salalah_Sports_League
{
    public class Team
    {
        public Team(int id, string name, Coach coach)
        {
            this.id = id;
            this.name = name;
            this.coach = coach;
            this.players = new List<Player>();
            this.wins = 0;
            this.losses = 0;
            this.draws = 0;
            this.points = 0;
        }

        public int id { get; set; }
        public string name { get; set; }
        public Coach coach { get; set; }
        public List<Player> players { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int draws { get; set; }
        public int points { get; set; }

        public void AddPlayer(Player player)
        {
            players.Add(player);
            Console.WriteLine($"{player.playername} added to {name}");
        }

        public void UpdateStats(string result)
        {
            if (result == "win")
            {
                wins++;
                points += 3;
            }
            else if (result == "draw")
            {
                draws++;
                points += 1;
            }
            else if (result == "loss")
            {
                losses++;
            }
        }

        public void DisplayTeamInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"team: {name}");
            Console.WriteLine($"coach: {coach.coachname}");
            Console.WriteLine($"\nplayers ({players.Count}):");

            if (players.Count == 0)
            {
                Console.WriteLine("  no players yet");
            }
            else
            {
                foreach (Player player in players)
                {
                    player.DisplayPlayerInfo();
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }

        public void DisplayStandings()
        {
            Console.WriteLine($"{name,-25} | W: {wins} D: {draws} L: {losses} | Points: {points}");
        }
    }
}