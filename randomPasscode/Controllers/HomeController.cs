using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using randomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace randomPasscode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.passcode=HttpContext.Session.GetString("randomPasscode");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet("Randomize")]
        public IActionResult Randomize()
        {
            HttpContext.Session.Clear();
            string[] val={"A", "B", "C","D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", 
            "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", 
            "7", "8", "9"};
            string passcode="";
            Random rand = new Random();
            for(var i =1; i<=14; i++)
            {
                int randomVal = rand.Next(val.Length);
                passcode+= val[randomVal]; //add string to string
            }
                HttpContext.Session.SetString("randomPasscode", passcode);
                string RandomPass=HttpContext.Session.GetString("randomPasscode");
                Console.WriteLine(RandomPass);
                return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
