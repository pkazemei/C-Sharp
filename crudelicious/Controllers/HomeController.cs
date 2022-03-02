using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crudelicious.Models;

namespace crudelicious.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MyContext _context;

        // Below takes our controller here and links it to our MyContext(DB Model) and creates a variable context to access it then within the block it makes _context = to context variable
        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {   
            // This gets me all dishes from DB
            List<Dish> allDishes = _context.Dish.ToList();
            ViewBag.AllDishes = allDishes;
            return View();
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View("CreateOne");
        }

        [HttpPost("process")]
        public IActionResult Process(Dish newDish)
        {
            List<Dish> allDishes = _context.Dish.ToList();
            ViewBag.AllDishes = allDishes;
            if(ModelState.IsValid)
            {
                Console.WriteLine("Added dish");
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                Console.WriteLine("Did not add dish");
                return View("CreateOne");
            }
        }

        [HttpGet("delete/{dishid}")]
        public IActionResult DeleteOne(int dishid)
        {
            Dish dishToDelete = _context.Dish.SingleOrDefault(a => a.DishID == dishid);
            _context.Dish.Remove(dishToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpGet("view/{dishid}")]
        public IActionResult ViewOne(int dishid)
        {
            Dish dishToView = _context.Dish.FirstOrDefault(a => a.DishID == dishid);
            ViewBag.Dish = dishToView;
            return View("ViewOne");
        }

        [HttpGet("edit/{dishid}")]
        public IActionResult EditOne(int dishid)
        {
            Dish dishToEdit = _context.Dish.FirstOrDefault(a => a.DishID == dishid);
            _context.SaveChanges();
            // Here we use the Function to View to 
            return View(dishToEdit);
        }

        [HttpPost("update/{dishid}")]
        public IActionResult UpdateOne(int dishid, Dish editedDish)
        {
        
            Dish Original = _context.Dish.FirstOrDefault(a => a.DishID == dishid);
            Original.Name = editedDish.Name;
            Original.Chef = editedDish.Chef;
            Original.Tastiness = editedDish.Tastiness;
            Original.Calories = editedDish.Calories;
            Original.Description = editedDish.Description;
            Original.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
            
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
