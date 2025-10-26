using ClassWorkProjects.Models.Dhofar_Car_Rental;
using ClassWorkProjects.Models.Salalah_Delivery_Express;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DhofarCarRental.modules
{
    public class RentalRecord
    {
        public RentalRecord(int rentalid, CarRentalCustomer customer, Car car, int durationdays)
        {
            this.rentalid = rentalid;
            this.customer = customer;
            this.car = car;
            this.durationdays = durationdays;
            this.totalcost = car.dailyrate * durationdays;
            this.isactive = true;
        }

        public int rentalid { get; set; }
        public Customer customer { get; set; }
        public Car car { get; set; }
        public int durationdays { get; set; }
        public decimal totalcost { get; set; }
        public bool isactive { get; set; }

        public void DisplayRentalInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"rental ID: {rentalid}");
            Console.WriteLine($"status: {(isactive ? "active" : "completed")}");
            Console.WriteLine($"\ncustomer: {customer.name}");
            Console.WriteLine($"phone: {customer.phone}");  /// what am i doing here
            Console.WriteLine($"\ncar: {car.brand} {car.model}"); // idk what im doing here either
            Console.WriteLine($"daily rate: {car.dailyrate:C} OMR");
            Console.WriteLine($"duration: {durationdays} days");
            Console.WriteLine($"total cost: {totalcost:C} OMR");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
    }
}
