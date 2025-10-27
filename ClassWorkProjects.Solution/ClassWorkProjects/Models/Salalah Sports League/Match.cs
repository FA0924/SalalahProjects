using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkProjects.Models.Salalah_Sports_League
{
    public class Match
    {
        public Match(int matchid, Team team1, Team team2, int score1, int score2)
        {
            this.matchid = matchid;
            this.team1 = team1;
            this.team2 = team2;
            this.score1 = score1;
            this.score2 = score2;

            DetermineWinner();
        }

        public int matchid { get; set; }
        public Team team1 { get; set; }
        public Team team2 { get; set; }
        public int score1 { get; set; }
        public int score2 { get; set; }
        public string winner { get; set; }

        private void DetermineWinner()
        {
            if (score1 > score2)
            {
                winner = team1.name;
                team1.UpdateStats("win");
                team2.UpdateStats("loss");
            }
            else if (score2 > score1)
            {
                winner = team2.name;
                team2.UpdateStats("win");
                team1.UpdateStats("loss");
            }
            else
            {
                winner = "Draw";
                team1.UpdateStats("draw");
                team2.UpdateStats("draw");
            }
        }

        public void DisplayMatchInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"match #{matchid}");
            Console.WriteLine($"{team1.name} vs {team2.name}");
            Console.WriteLine($"score: {score1} - {score2}");
            Console.WriteLine($"result: {winner}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
    }
}