using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using survey.Models;

namespace survey.Controllers
{
    public class FirstController : Controller
    {
        public static List<Survey> allInfo = new List<Survey>();
        
        [HttpGet]

        [Route("")]
        public ViewResult Index()
        {
            ViewBag.title = "Dojo Survey";
            ViewBag.allInfo = allInfo;

            return View("Index");
        }

        [HttpPost("addInfo")]
        public IActionResult result(Survey newInfo)
        {Console.WriteLine("Attempting to submit");
            if(ModelState.IsValid)
            {
                allInfo.Add(newInfo);
                Console.WriteLine("Form submitted");
                return RedirectToAction("Index");
            } else{
                ViewBag.allInfo = allInfo;
                Console.WriteLine("Form NOT submitted");
                return View("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}