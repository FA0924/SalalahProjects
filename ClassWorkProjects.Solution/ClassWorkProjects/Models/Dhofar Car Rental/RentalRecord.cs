using ClassWorkProjects.Models.Dhofar_Car_Rental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkProjects.Models.Dhofar_Car_Rental
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

            // Mark car as rented
            car.isavailable = false;
        }

        public int rentalid { get; set; }
        public CarRentalCustomer customer { get; set; }
        public Car car { get; set; }
        public int durationdays { get; set; }
        public decimal totalcost { get; set; }
        public bool isactive { get; set; }

        public void CompleteRental()
        {
            if (isactive)
            {
                isactive = false;
                car.isavailable = true;
                Console.WriteLine($"rental #{rentalid} completed. {car.brand} {car.model} is now available.");
            }
            else
            {
                Console.WriteLine($"rental #{rentalid} is already completed.");
            }
        }

        public void DisplayRentalInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"rental ID: {rentalid}");
            Console.WriteLine($"status: {(isactive ? "active" : "completed")}");
            Console.WriteLine($"\ncustomer: {customer.CRname}");
            Console.WriteLine($"phone: {customer.CRphone}");
            Console.WriteLine($"license: {customer.licensenumber}");
            Console.WriteLine($"\ncar: {car.brand} {car.model}");
            Console.WriteLine($"daily rate: {car.dailyrate:C} OMR");
            Console.WriteLine($"duration: {durationdays} days");
            Console.WriteLine($"total cost: {totalcost:C} OMR");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
    }
}