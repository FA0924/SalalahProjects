using ClassWorkProjects.Models.Dhofar_Car_Rental;
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
    public class Customer
    {
        internal object name;
        internal object phone;

        public Customer(int id, string CustomerName, string CustomerNumber, string Address)
        {

            this.id = id; 
            this.CustomerName = CustomerName;
            this.CustomerNumber = CustomerNumber;
            this.Address = Address;

        }
        public int id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string Address { get; set; }


        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"customer ID: {id}");
            Console.WriteLine($"name: {CustomerName}");
            Console.WriteLine($"phone: {CustomerNumber}");
            Console.WriteLine($"address: {Address}");
        }

        public static implicit operator Customer(CarRentalCustomer v)
        {
            throw new NotImplementedException();
        }
    }
}
