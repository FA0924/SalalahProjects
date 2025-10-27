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
    public class Book
    {
        public Book(int bookid, string title, string author)
        {
            this.Bookid = bookid;
            this.Title = title;
            this.Author = author;
            this.isavailable = true;
        }

        public int Bookid { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool isavailable { get; set; }


        public void DisplayBookInfo()
        {
            string status = isavailable ? "[available]" : "[borrowed]";
            Console.WriteLine($"{Bookid}. {Title} by {Author} {status}");
        }
    }
}