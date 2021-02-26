﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            var jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Jon Favreau");
            var gladiator = new Movie("Gladiator", 165.50m, "gladiator.jpg", "Ridley Scott");
            var forrestGump = new Movie("Forrest Gump", 150.50m, "forrest-gump.jpg", "Robert Zemeckis");

            // assign a ViewBag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.Gladiator = gladiator;
            ViewBag.ForrestGump = forrestGump;

            // return the default view
            return View();
        }
    }
}