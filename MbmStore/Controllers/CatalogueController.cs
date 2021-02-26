using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using MbmStore.Models;
using MbmStore.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Book> books;
            books = Repository.Products.OfType<Book>().ToList(); 
            ViewBag.Books = books;

            IEnumerable<MusicCD> musicCDs;
            musicCDs = Repository.Products.OfType<MusicCD>().ToList();
            ViewBag.Books = musicCDs;

            IEnumerable<Movie> Movies;
            Movies = Repository.Products.OfType<Movie>().ToList();
            ViewBag.Books = Movies;

            ViewBag.MusicCDs = musicCDs;
            ViewBag.Books = books;
            ViewBag.Movies = Movies;

            return View();
        }
    }
}
