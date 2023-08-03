using LearnMVC.DataAccess;
using LearnMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnMVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly NewDbContext _context;
        public UsersController(NewDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            TempData["Message"] = "Hello World";
            ViewData["Message"] = "Hello World";
            ViewBag.Message = "Hello World";
            _context.Users.Where( u => u.Name );
            return View(_context.Users.Wher);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Update()
        {
            Users.FirstOrDefault(u => u.Id == "");
            Users.Remove(Users.FirstOrDefault(u => u.Id == ""));
            // select top 1  * from Users where Id = ""
            return View();
        }
        [HttpPost]
        public IActionResult Create(Users users)
        {
            Users.Add(users);
            return View();
        }
    }
}
