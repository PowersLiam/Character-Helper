using Character_Helper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Character_Helper.Controllers
{
    public class CharacterController : Controller
    {

        private static List<CharacterViewModel> chars = new List<CharacterViewModel>();

        public IActionResult Index()
        {
            return View(chars);
        }

        public IActionResult Create()
        {
            var charVM = new CharacterViewModel();
            return View(charVM);
        }
        
        public IActionResult CreateCharacter(CharacterViewModel charVM)
        {
            chars.Add(charVM);
            return RedirectToAction(nameof(Index));
        }
    }
}
