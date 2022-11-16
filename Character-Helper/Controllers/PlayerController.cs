using Character_Helper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Character_Helper.Controllers
{
    public class PlayerController : Controller
    {
        private static List<PlayerViewModel> players = new List<PlayerViewModel>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var playerVM = new PlayerViewModel();
            playerVM.Id = players.Count();
            return View(playerVM);
        }

        public IActionResult CreatePlayer(PlayerViewModel playerVM)
        {
            players.Add(playerVM);
            return RedirectToAction(nameof(Index));
        }
    }
}
