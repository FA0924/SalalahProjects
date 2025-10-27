using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassWorkProjects.Models.Dhofar_Car_Rental
{
    public class Car
    {
        public Car(int carid, string model, string brand, decimal dailyrate)
        {
            this.carid = carid;
            this.model = model;
            this.brand = brand;
            this.dailyrate = dailyrate;
            this.isavailable = true;
        }

        public int carid { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
        public decimal dailyrate { get; set; }
        public bool isavailable { get; set; }


        public void DisplayCarInfo()
        {
            string status = isavailable ? "[available]" : "[rented]";
            Console.WriteLine($"{carid}. {brand} {model} - {dailyrate:C} OMR Per Day {status}");
        }
    }
}