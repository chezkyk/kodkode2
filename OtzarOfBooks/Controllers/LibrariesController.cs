using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel;
using OtzarOfBooks.DAL;
using OtzarOfBooks.Models;

namespace OtzarOfBooks.Controllers
{
    public class LibrariesController : Controller
    {
        private readonly OtzarOfBooksDBContext _otzarOfBooksDBContext;

        public LibrariesController(OtzarOfBooksDBContext otzarOfBooksDBContext)
        {
            _otzarOfBooksDBContext = otzarOfBooksDBContext;
        }

        // GET: Libraries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Libraries/Create
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(BookLibrary library)
        {
            // פה אני מוסיף ספריות לדאטה ביייס
            _otzarOfBooksDBContext.Add(library);
            _otzarOfBooksDBContext.SaveChanges();
            return RedirectToAction("index","Home");

        }
        public IActionResult Index()
        {
            var libraries = _otzarOfBooksDBContext.libraries.ToList();
            return View(libraries);
        }
    }
}
