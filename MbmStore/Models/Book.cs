using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    {
        //properties
        public string Author { get; }
        public string Publisher { get; set; }
        public short Published { get; }
        public string ISBN { get; set; }

        public Book()
        {

        }
        public Book(string author, string title, decimal price, short published) : base(title, price)
        {
            Author = author;
            Title = title;
            Price = price;
            Published = published;
        }
    }
}
