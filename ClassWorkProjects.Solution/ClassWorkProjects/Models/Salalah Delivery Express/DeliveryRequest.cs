using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkProjects.Models.Salalah_Delivery_Express
{
    public class DeliveryRequest
    {
        
            public DeliveryRequest(int deliveryid, Customer customer, Driver driver)
            {
                this.deliveryid = deliveryid;
                this.customer = customer;
                this.driver = driver;
                this.status = "Pending";
            }

            public int deliveryid { get; set; }
            public Customer customer { get; set; }
            public Driver driver { get; set; }
            public string status { get; set; }



        public void UpdateStatus(string newstatus)
        {
            if (newstatus == "Pending" || newstatus == "On the Way" || newstatus == "Delivered")
            {
                this.status = newstatus;
                Console.WriteLine($"delivery #{deliveryid} status updated to: {status}");
            }
            else
            {
                Console.WriteLine("invalid status! use: Pending, On the Way, or Delivered");
            }
        }

        public void DisplayDeliveryInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"delivery ID: {deliveryid}");
            Console.WriteLine($"status: {status}");
            Console.WriteLine("\ncustomer details:");
            customer.DisplayCustomerInfo();
            Console.WriteLine("\ndriver details:");
            driver.DisplayDriverrInfo();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }


    }
}