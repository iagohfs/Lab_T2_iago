using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_T2_iago.Models;

namespace Lab_T2_iago.Controllers
{
    public class HomeController : Controller
    {
        private IStorage storage;

        public HomeController() { }

        public HomeController(IStorage inputStorage)
        {
            storage = inputStorage;
        }

        public IActionResult Index()
        {

            return View();
        }

        public bool Are_There_Products_That_Are_In_The_Selected_Section(string sectionName)
        {
            var products = storage.GetProducts();

            var newView = products.Where(p => p.Section == sectionName);

            int NumberOfItems = newView.Sum(p => p.ProductID);

            if (NumberOfItems > 0)
            {
                // Här låtsas vi att true är return View() och då om den är true så "kommer den returnera objektet till vyn". Annars blir skärmen tom bara.

                return true;
            }
            else
            {
                return false;
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
