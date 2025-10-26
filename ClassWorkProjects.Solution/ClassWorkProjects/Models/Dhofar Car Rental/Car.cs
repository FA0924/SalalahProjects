using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassWorkProjects.Models.Salalah_Delivery_Express
{
    public class Car
    {
        public Car()
        {

            this.carid = carid;
            this.model = model;
            this.brand = brand;
            this.dailyrate = dailyrate;
            this.isavailable = isavailable;

        }
        public int carid { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
        public decimal dailyrate { get; set; }
        public bool isavailable { get; set; }


        public void DisplayCarInfo()
        {
            string status = isavailable ? "[available]" : "[borrowed]";
            Console.WriteLine($"{carid}. {brand} {model} - {dailyrate:C} OMR Per Day {status}");
        }
    }
}
