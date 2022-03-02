using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginReg.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginReg.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyContext dbContext)
        {
            _logger = logger;
            _context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == newUser.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");
                    // You may consider returning to the View at this point
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Users.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetString("UserEmail", newUser.Email);
                return RedirectToAction("Success");
            } else {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LogUser logUser)
        {
            if(ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(s => s.Email == logUser.LEmail);
                if(userInDb == null)
                {
                    // If it's null then they are NOT in the database
                    ModelState.AddModelError("LEmail", "Invalid login attempt");
                    return View("Index");
                }
                // If we are the correct email it's time to check the password
                // First we make another instance of the password hasher
                PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logUser, userInDb.Password, logUser.LPassword);
                // When it's done it will return either a 1 or a 0
                // 1 means you were successful
                // 0 means you were not successful
                if(result == 0)
                {
                    ModelState.AddModelError("LEmail", "Invalid login attempt");
                    return View("Index");
                }
                HttpContext.Session.SetString("UserEmail", userInDb.Email);
                return RedirectToAction("Success");
            } else {
                return View("Index");
            }
        }

        [HttpGet("Success")]
        public IActionResult Success()
        {
            // I want to access my data
            string email = HttpContext.Session.GetString("UserEmail");
            User loggedIn = _context.Users.FirstOrDefault(d => d.Email == email);
            Console.WriteLine($"Welcome {loggedIn.FirstName} {loggedIn.LastName}");
            return View(loggedIn);
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
