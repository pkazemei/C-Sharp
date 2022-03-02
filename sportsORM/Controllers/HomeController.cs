using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.LeaguesWomen =  _context.Leagues
                .Where(w => w.Name.Contains("Womens"));
            ViewBag.LeaguesHockey =  _context.Leagues
                .Where(w => w.Sport.Contains("Hockey"));
            ViewBag.LeaguesNoFootball = _context.Leagues
                .Where(nf => !nf.Sport.Contains("Football"));
            ViewBag.LeaguesConference = _context.Leagues
                .Where(c => c.Name.Contains("Conference"));
            ViewBag.LeaguesAtlantic = _context.Leagues
                .Where(a => a.Name.Contains("Atlantic"));
            ViewBag.TeamsDallas = _context.Teams
                .Where(d => d.Location.Contains("Dallas"));
            ViewBag.TeamsRaptors = _context.Teams
                .Where(r => r.TeamName.Contains("Raptors"));
            ViewBag.TeamsCity = _context.Teams
                .Where(c => c.Location.Contains("City"));
            ViewBag.TeamsWithT = _context.Teams
                .Where(t => t.TeamName.StartsWith("T"));
            IEnumerable<Team> teamsLocation = _context.Teams.OrderBy(a => a.Location);
            ViewBag.TeamsLocation = teamsLocation;
            IEnumerable<Team> teamsName = _context.Teams.OrderByDescending(a => a.TeamName);
            ViewBag.TeamsName = teamsName;
            ViewBag.PlayersCooper = _context.Players
                .Where(p => p.LastName.Contains("Cooper"));
            ViewBag.PlayersJoshua = _context.Players
                .Where(p => p.FirstName.Contains("Joshua"));
            ViewBag.PlayersCnotJ = _context.Players
                .Where(cnj => cnj.LastName.Contains("Cooper") && !cnj.FirstName.Contains("Joshua"));
            ViewBag.PlayersAorW = _context.Players
                .Where(aow => aow.FirstName.Contains("Alexander") || aow.FirstName.Contains("Wyatt"));
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}