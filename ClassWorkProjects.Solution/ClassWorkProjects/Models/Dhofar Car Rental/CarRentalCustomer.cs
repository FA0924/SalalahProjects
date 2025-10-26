using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkProjects.Models.Dhofar_Car_Rental
{
    public class CarRentalCustomer
    {
        public CarRentalCustomer(int CRid, string CRname, string CRphone, string licensenumber)
        {
            this.CRid = CRid;
            this.CRname = CRname;
            this.CRphone = CRphone;
            this.licensenumber = licensenumber;
        }

        public int CRid { get; set; }
        public string   CRname { get; set; }
        public string CRphone { get; set; }
        public string licensenumber { get; set; }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"customer ID: {CRid}");
            Console.WriteLine($"name: {CRname}");
            Console.WriteLine($"phone: {CRphone}");
            Console.WriteLine($"license: {licensenumber}");
        }
    }
}