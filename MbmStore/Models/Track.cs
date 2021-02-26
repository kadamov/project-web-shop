﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Track
    {
        // properties
        public string Title { get; set; }
        public string Composer { get; set; }
        public TimeSpan Length { get; set; }
        

        public Track()
        {

        }
        public Track(string title, string composer, TimeSpan length)
        {
            Title = title;
            Composer = composer;
            Length = length;
        }
        public Track(string title, TimeSpan length)
        {
            Title = title;
            Length = length;
        }
    }
}
