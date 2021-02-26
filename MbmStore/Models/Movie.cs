using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // properties

        public string Director { get; private set; }

        


        // constructors
        public Movie() 
        {
            
        }
        public Movie(string title, decimal price, string imageFileName, string director) : base(title, price)
        {
            Title = title;
            Price = price;
            ImageFileName = imageFileName;
            Director = director;
        }
    }
}