using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHelloWorld.Models;

namespace WebApplicationHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "FTW6 message test.";
            ViewData["Title"] = "My ABout us Page.";
            ViewData["Test"] = "This is test text";


            int x = 0;


            ViewData["Message"] = "Your contact page FTW6sdf" + x.ToString();


            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page FTW6sdf";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
