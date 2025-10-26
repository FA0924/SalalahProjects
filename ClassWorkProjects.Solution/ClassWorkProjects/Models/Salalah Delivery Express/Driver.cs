using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkProjects.Models.Salalah_Delivery_Express
{
    public class Driver
    {
        public Driver(int id, string CustomerName, string CustomerNumber, string Address)
        {

            this.id = id;
            this.DriverrName = DriverrName;
            this.DriverrNumber = DriverrNumber;

        }
        public int id { get; set; }
        public string DriverrName { get; set; }
        public string DriverrNumber { get; set; }


        public void DisplayDriverrInfo()
        {
            Console.WriteLine($"customer ID: {id}");
            Console.WriteLine($"name: {DriverrName}");
            Console.WriteLine($"phone: {DriverrNumber}");
        }
    }
}
