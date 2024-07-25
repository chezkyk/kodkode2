using Microsoft.AspNetCore.Mvc;
using MVCShoeShop.Models;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVCShoeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static List<Friends> friendsList = new List<Friends>
        {
            new Friends(1, "Moshe", 27),
            new Friends(2, "Dov", 22),
            new Friends(3, "Chezky", 21),
            new Friends(4, "Tal", 23)
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Friends()
        {
            return View(friendsList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Details(int id)
        {
            Friends friend = null;
            foreach (var f in friendsList)
            {
                if (f.Id == id)
                {
                    friend = f;
                    break;
                }
            }
            return View(friend);
        }
        public IActionResult AddFriend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFriend(Friends newFriend)
        {
            if (ModelState.IsValid) 
            {
                friendsList.Add(newFriend);
                return RedirectToAction("Friends"); 
            }
            return View(newFriend);
        }


    }
}
