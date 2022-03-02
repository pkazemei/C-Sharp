using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using chefsndishes.Models;
using Microsoft.EntityFrameworkCore;

namespace chefsndishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index() //view all chefs page
        {
            List<Chef> allChefs = _context.Chefs.ToList();
            ViewBag.AllChefs = allChefs;
            return View();
        }

        [HttpGet("new")] //view add chef form
        public IActionResult addChef()
        {
            List<Chef> allChefs = _context.Chefs.ToList();
            ViewBag.AllChefs = allChefs;
            return View();
        }

        [HttpPost("addChef")] //post a new chef
        public IActionResult addChef(Chef newChef)
        {
            List<Chef> allChefs = _context.Chefs.ToList();
            ViewBag.AllChefs = allChefs;
            if(ModelState.IsValid)
            {
                _context.Chefs.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("AddChef");
            }
        }

        [HttpGet("AllDishes")] //view all dishes page
        public IActionResult AllDishes()
        {
            ViewBag.AllDishes = _context.Dishes.Include(a => a.Chef).ToList();
            return View();
        }
        
        [HttpGet("newDish")] //view add dish form
        public IActionResult AddDish()
        {
            List<Chef> allChefs = _context.Chefs.ToList();
            ViewBag.AllChefs = allChefs;
            // ViewBag.AllDishes = _context.Dishes.Include(a => a.Chef).ToList();
            return View("AddDish");
        }

        [HttpPost("addDish")] //post a new dish
        public IActionResult addDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                Console.WriteLine(newDish);
                _context.SaveChanges();
                return RedirectToAction("AllDishes");
            } else {
                List<Chef> allChefs = _context.Chefs.ToList();
                ViewBag.AllChefs = allChefs;
                return View("AddDish"); //return to same page for validation
            }
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
