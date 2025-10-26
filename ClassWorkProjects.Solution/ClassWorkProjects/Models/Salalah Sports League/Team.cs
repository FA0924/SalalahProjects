using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassWorkProjects.Models.Salalah_Sports_League
{
    public class Team
    {
        public Team(int id, string name, string coach)
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
        public string coach { get; set; }
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

        public void DisplayTeamInfo()
        {
        }
        public void DisplayFullTeamInfo()
        {
        }

        }
    }