using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        static Repository()
        {
            //books
            //book1
            var book1 = new Book("Don Norman", "Design of Everyday Things", 159.00m, 1988);
            book1.Publisher = "Basic Books";
            book1.ImageFileName = "design.png";
            book1.ISBN = "978-0-465-06710-7";
            //book2
            var book2 = new Book("Ben Forta", "SQL in 10 Minutes, Sams Teach Yourself", 319.00m, 2012);
            book2.Publisher = "Sams Publishing";
            book2.ImageFileName = "sql.jpg";
            book2.ISBN = "978-0-672-33607-2";

            Products.Add(book1);
            Products.Add(book2);

            //musicCDs
            //musicCD1
            var musicCD1 = new MusicCD("Neutral Milk Hotel", "In the Aeroplane Over the Sea", 119.00m, 1998);
            musicCD1.Label = "Merge";
            musicCD1.ImageFileName = "aeroplane.jpg";
            var CD1track1 = new Track("The King of Carrot Flowers, Pt. One", "Jeff Mangum", new TimeSpan(0, 2, 00));
            var CD1track2 = new Track("The King of Carrot Flowers, Pts. Two & Three", "Jeff Mangum", new TimeSpan(0, 3, 06));
            var CD1track3 = new Track("In the Aeroplane Over the Sea", "Jeff Mangum", new TimeSpan(0, 3, 22));
            var CD1track4 = new Track("Two-Headed Boy", "Jeff Mangum", new TimeSpan(0, 4, 26));
            var CD1track5 = new Track("The Fool", "Jeff Mangum", new TimeSpan(0, 1, 53));
            var CD1track6 = new Track("Holland, 1945", "Jeff Mangum", new TimeSpan(0, 3, 15));
            var CD1track7 = new Track("Communist Daughter", "Jeff Mangum", new TimeSpan(0, 1, 57));
            var CD1track8 = new Track("Oh Comely", "Jeff Mangum", new TimeSpan(0, 8, 18));
            var CD1track9 = new Track("Ghost", "Jeff Mangum", new TimeSpan(0, 4, 08));
            var CD1track10 = new Track("Untitled", "Jeff Mangum", new TimeSpan(0, 2, 16));
            var CD1track11 = new Track("Two-Headed Boy, Pt. Two", "Jeff Mangum", new TimeSpan(0, 5, 13));
            musicCD1.AddTrack(CD1track1);
            musicCD1.AddTrack(CD1track2);
            musicCD1.AddTrack(CD1track3);
            musicCD1.AddTrack(CD1track4);
            musicCD1.AddTrack(CD1track5);
            musicCD1.AddTrack(CD1track6);
            musicCD1.AddTrack(CD1track7);
            musicCD1.AddTrack(CD1track8);
            musicCD1.AddTrack(CD1track9);
            musicCD1.AddTrack(CD1track10);
            musicCD1.AddTrack(CD1track11);

            //musicCD2

            var musicCD2 = new MusicCD("Daft Punk", "Discovery", 119.00m, 2001);
            musicCD2.Label = "Parlophone";
            musicCD2.ImageFileName = "discovery.jpg";
            var CD2track1 = new Track("One More Time", "Thomas Bangalter & Guy-Manuel de Homem-Christo (featuring Romanthony)", new TimeSpan(0, 5, 20));
            var CD2track2 = new Track("Aerodynamic", "Thomas Bangalter & 	Guy-Manuel de Homem-Christo", new TimeSpan(0, 3, 27));
            var CD2track3 = new Track("Digital Love", "Thomas Bangalter & Guy-Manuel de Homem-Christo", new TimeSpan(0, 4, 58));
            var CD2track4 = new Track("Harder, Better, Faster, Stronger", "Thomas Bangalter & Guy-Manuel de Homem-Christo", new TimeSpan(0, 3, 45));
            var CD2track5 = new Track("Crescendolls", "Thomas Bangalter & Guy-Manuel de Homem-Christo", new TimeSpan(0, 3, 31));
            var CD2track6 = new Track("Nightvision", "Thomas Bangalter & Guy-Manuel de Homem-Christo", new TimeSpan(0, 1, 44));
            var CD2track7 = new Track("Superheroes", "Thomas Bangalter & Guy-Manuel de Homem-Christo", new TimeSpan(0, 3, 57));
            var CD2track8 = new Track("High Life", "Thomas Bangalter & Guy-Manuel de Homem-Christo", new TimeSpan(0, 3, 22));
            var CD2track9 = new Track("Something About Us", "Thomas Bangalter & Guy-Manuel de Homem-Christo", new TimeSpan(0, 3, 51));
            var CD2track10 = new Track("Voyager", "Thomas Bangalter & Guy-Manuel de Homem-Christo", new TimeSpan(0, 3, 47));
            var CD2track11 = new Track("Veridis Quo", "Thomas Bangalter & Guy-Manuel de Homem-Christo", new TimeSpan(0, 5, 44));
            var CD2track12 = new Track("Short Circuit", "Thomas Bangalter & Guy-Manuel de Homem-Christo", new TimeSpan(0, 3, 26));
            var CD2track13 = new Track("Face to Face", "Thomas Bangalter & Guy-Manuel de Homem-Christo (featuring Todd Edwards)", new TimeSpan(0, 3, 58));
            var CD2track14 = new Track("Too Long", "Thomas Bangalter & Guy-Manuel de Homem-Christo (featuring Romanthony)", new TimeSpan(0, 10, 00));
            musicCD2.AddTrack(CD2track1);
            musicCD2.AddTrack(CD2track2);
            musicCD2.AddTrack(CD2track3);
            musicCD2.AddTrack(CD2track4);
            musicCD2.AddTrack(CD2track5);
            musicCD2.AddTrack(CD2track6);
            musicCD2.AddTrack(CD2track7);
            musicCD2.AddTrack(CD2track8);
            musicCD2.AddTrack(CD2track9);
            musicCD2.AddTrack(CD2track10);
            musicCD2.AddTrack(CD2track11);
            musicCD2.AddTrack(CD2track12);
            musicCD2.AddTrack(CD2track13);
            musicCD2.AddTrack(CD2track14);

            Products.Add(musicCD1);
            Products.Add(musicCD2);

            //movies
            //movie1

            var jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Jon Favreau");

            //movie2

            var gladiator = new Movie("Gladiator", 165.50m, "gladiator.jpg", "Ridley Scott");

            Products.Add(jungleBook);
            Products.Add(gladiator);
        }
    }
}
