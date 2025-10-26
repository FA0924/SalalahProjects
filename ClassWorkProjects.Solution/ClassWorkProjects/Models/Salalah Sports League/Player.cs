using ClassWorkProjects.Models.Salalah_Book_Café;
using ClassWorkProjects.Models.Salalah_Delivery_Express;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassWorkProjects.Models.Salalah_Sports_League
{
    public class Player
    {
        public Player(int playerid, string playername, int age)
        {

            this.playerid = playerid;
            this.playername = playername;
            this.age = age;
            this.position = position;



        }
        public int playerid { get; set; }
        public string playername { get; set; }
        public int age { get; set; }
        public string position { get; set; }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"  #{playerid} {playername} ({age} yrs) - {position}");
        }
    }
}
