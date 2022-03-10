using Football_Notifier.Entities;
using Football_Notifier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Football_Notifier.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<Match> Matches = new List<Match>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //team 1
            Team team1 = new Team();
            team1.Id = 1;
            team1.Name = "Real Madrid";

            Player player1 = new Player();
            team1.Players = new List<Player>();
            player1.Id = 1;
            player1.Name = "Ronaldo";

            team1.Players.Add(player1);

            //team 2
            Team team2 = new Team();
            team2.Id = 2;
            team2.Name = "Barcelona";

            Player player2 = new Player();
            player2.Id = 2;
            player2.Name = "Messi";
            team2.Players = new List<Player>();
            team2.Players.Add(player2);

            Matches = new List<Match>
            {
                new Match()
                {
                    Id = 1,
                    Team1 = team1,
                    Team2 = team2,
                }
            };
            IndexViewModel model = new IndexViewModel();
            model.model = Matches;
            return View(model);
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
