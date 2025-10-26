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
        { }

        public void DisplayMatchInfo()
        { }
    }
}