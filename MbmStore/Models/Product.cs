using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        //fields
        private decimal price;
        //properties
        public string Title { get; set; }
        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }
        public string ImageFileName { get; set; }

        public Product()
        {

        }
        public Product(string title, decimal price)
        {
            Title = title;
            Price = price;
        }
    }
    
    
}
