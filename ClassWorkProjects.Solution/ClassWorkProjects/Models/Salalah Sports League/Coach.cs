using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkProjects.Models.Salalah_Sports_League
{
    public class Coach
    {
            public Coach(int coachid, string coachname, int age)
            {

                this.playerid = playerid;
                this.playername = playername;
                this.age = age;


            }
            public int playerid { get; set; }
            public string playername { get; set; }
            public int age { get; set; }
        
    }

}
