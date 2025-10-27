using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkProjects.Models.Salalah_Book_Café
{
    public class MenuItem
    {
        public MenuItem(int id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }

        public void DisplayMenuItem()
        {
            Console.WriteLine($"{id}. {name} - {price:C} OMR");
        }
    }
}