using Character_Helper.Data;
using Character_Helper.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Character_Helper.Controllers
{
    public class PlayerController : Controller
    {
        private static List<PlayerViewModel> players = new List<PlayerViewModel>();

        private readonly ApplicationDbContext _context;

        public PlayerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            players = _context.Players.ToList();
            return View(players);
        }

        public IActionResult Create()
        {
            var playerVM = new PlayerViewModel();
            return View(playerVM);
        }

        public IActionResult CreatePlayer(PlayerViewModel playerVM)
        {
            _context.Players.Add(playerVM);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
