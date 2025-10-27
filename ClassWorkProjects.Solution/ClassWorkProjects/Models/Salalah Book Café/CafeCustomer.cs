using ClassWorkProjects.Models.Salalah_Book_Café;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassWorkProjects.Models.Salalah_Book_Café
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
            if (borrowedbooks.Count >= 2)
            {
                Console.WriteLine($"sorry {CCName}, you can only borrow 2 books at a time!");
                return;
            }

            if (!book.isavailable)
            {
                Console.WriteLine($"sorry, '{book.Title}' is already borrowed.");
                return;
            }

            borrowedbooks.Add(book);
            book.isavailable = false;
            Console.WriteLine($"{CCName} borrowed: {book.Title}");
        }

        public void ReturnBook(Book book)
        {
            if (borrowedbooks.Contains(book))
            {
                borrowedbooks.Remove(book);
                book.isavailable = true;
                Console.WriteLine($"{CCName} returned: {book.Title}");
            }
            else
            {
                Console.WriteLine($"{CCName} doesn't have '{book.Title}' borrowed.");
            }
        }

        public void OrderItem(MenuItem item)
        {
            orders.Add(item);
            Console.WriteLine($"{CCName} ordered: {item.name} - {item.price:C} OMR");
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (MenuItem item in orders)
            {
                total += item.price;
            }
            return total;
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"customer ID: {id}");
            Console.WriteLine($"name: {CCName}");
            Console.WriteLine($"phone: {CCNumber}");

            Console.WriteLine($"\nborrowed books ({borrowedbooks.Count}/2):");
            if (borrowedbooks.Count == 0)
            {
                Console.WriteLine("  no books borrowed");
            }
            else
            {
                foreach (Book book in borrowedbooks)
                {
                    Console.WriteLine($"  - {book.Title} by {book.Author}");
                }
            }

            Console.WriteLine($"\norders:");
            if (orders.Count == 0)
            {
                Console.WriteLine("  no orders yet");
            }
            else
            {
                foreach (MenuItem item in orders)
                {
                    Console.WriteLine($"  - {item.name}: {item.price:C} OMR");
                }
                Console.WriteLine($"\ntotal: {CalculateTotal():C} OMR");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
    }
}