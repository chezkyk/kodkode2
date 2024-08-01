using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OtzarOfBooks.DAL;
using OtzarOfBooks.Models;
using System.Diagnostics;

namespace OtzarOfBooks.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly OtzarOfBooksDBContext _otzarOfBooksDBContext;
		public HomeController(ILogger<HomeController> logger,OtzarOfBooksDBContext otzarOfBooksDBContext)
		{
			_logger = logger;
			_otzarOfBooksDBContext = otzarOfBooksDBContext;
		}

		public IActionResult Index()
		{
            // למשתנה libraries ייכנס הספריות בכדי להציג אותם במסך  index
            var libraries = _otzarOfBooksDBContext.libraries.ToList();
            return View(libraries);
        }
        // GET: Home/Details/id
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // להציג ספרייה לפי ID
            var library = _otzarOfBooksDBContext.libraries.FirstOrDefault(m => m.Id == id);
            if (library == null)
            {
                return NotFound();
            }

            return View(library);
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
