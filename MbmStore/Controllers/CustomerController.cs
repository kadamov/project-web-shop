using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using MbmStore.Models;
using System.Threading.Tasks;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
                private List<Customer> users = new List<Customer>();
        public IActionResult Index()
        {
            

            /*try {*/
                var user1 = new Customer("Jakob", "Ottosen", "Lysbrovænget 2", 8600, "Silkeborg", new DateTime(1997, 7, 16));
                user1.AddPhone("+4550520662");
                user1.AddPhone("+4564123849");
                var user2 = new Customer("Jens", "Bladderson", "Kronborgvej 4", 8000, "Aarhus", new DateTime(1992, 4, 12));
                user2.AddPhone("+4552061248");
                var user3 = new Customer("Kira", "Wellington", "Agertoften 13", 5450, "Otterup", new DateTime(1975, 10, 13));
                user3.AddPhone("+4523371337");
                var user4 = new Customer("Kira", "Wellington", "Agertoften 13", 5450, "Otterup", new DateTime(1903, 10, 13));
                users.Add(user1);
                users.Add(user2);
                users.Add(user3);
                users.Add(user4);

                ViewBag.Customer1 = user1;
                ViewBag.Customer2 = user2;
                ViewBag.Customer3 = user3;
                ViewBag.Customer4 = user4;
            /*} catch(Exception)
            {
                Console.WriteLine("oopsie");
            }*/

            ViewBag.Customers = users;

            return View();
        }
    }
}
