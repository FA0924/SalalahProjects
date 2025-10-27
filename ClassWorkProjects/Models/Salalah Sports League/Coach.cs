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
            this.coachid = coachid;
            this.coachname = coachname;
            this.age = age;
        }

        public int coachid { get; set; }
        public string coachname { get; set; }
        public int age { get; set; }

        public void DisplayCoachInfo()
        {
            Console.WriteLine($"coach: {coachname} (Age {age})");
        }
    }
}