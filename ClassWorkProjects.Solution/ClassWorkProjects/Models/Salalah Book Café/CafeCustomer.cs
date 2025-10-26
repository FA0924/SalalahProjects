using ClassWorkProjects.Models.Salalah_Book_Café;
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
    public class CafeCustomer
    {
        public CafeCustomer(int id, string CCName, string CCNumber)
        {

            this.id = id;
            this.CCName = CCName;
            this.CCNumber = CCNumber;
            this.borrowedbooks = new List<Book>();
            this.orders = new List<MenuItem>();

        }
        public int id { get; set; }
        public string CCName { get; set; }
        public string CCNumber { get; set; }
        public List<Book> borrowedbooks { get; set; }
        public List<MenuItem> orders { get; set; }




        public void BorrowBook(Book book)
        {
        }
        public void ReturnBook(Book book)
        {
        }
        public void OrderItem(MenuItem item)
        {
        }
        public decimal CalculateTotal()
        { }
        public void DisplayCustomerInfo()
        { }
    }
}
