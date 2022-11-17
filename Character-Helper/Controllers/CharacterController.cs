using Character_Helper.Data;
using Character_Helper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Character_Helper.Controllers
{
    public class CharacterController : Controller
    {

        private static List<CharacterViewModel> chars = new List<CharacterViewModel>();

        private readonly ApplicationDbContext _context;
        public CharacterController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            chars = _context.Characters.ToList();
            return View(chars);
        }

        public IActionResult Create()
        {
            CharacterViewModel charVM = new CharacterViewModel();
            return View(charVM);
        }
        
        public IActionResult CreateCharacter(CharacterViewModel charVM)
        {
            _context.Characters.Add(charVM);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
