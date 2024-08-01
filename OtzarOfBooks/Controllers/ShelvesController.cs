using Microsoft.AspNetCore.Mvc;
using OtzarOfBooks.DAL;
using OtzarOfBooks.Models;
using OtzarOfBooks.ViewModels;
using System.Linq;

namespace OtzarOfBooks.Controllers
{
    public class ShelvesController : Controller
    {
        private readonly OtzarOfBooksDBContext _otzarOfBooksDBContext;

        public ShelvesController(OtzarOfBooksDBContext otzarOfBooksDBContext)
        {
            _otzarOfBooksDBContext = otzarOfBooksDBContext;
        }

        // GET: Shelves/Create
        public IActionResult Create()
        {
            // המשתנה viewModel יכיל את כל הספריות בכדי להציג אותו למשתמש 
            var viewModel = new GenerAndLibrarys
            {
                libraries = _otzarOfBooksDBContext.libraries.ToList()
            };
            return View(viewModel);
        }

        // POST: Shelves/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GenerAndLibrarys viewModel)
        {

            var library = _otzarOfBooksDBContext.libraries.Find(viewModel.LibraryId);
            if (library != null)
            {
                // אם צריך לשייך את המדף לספריה
                library.Shelves.Add(viewModel.shelf);

                // שמירת המדף בבסיס הנתונים
                _otzarOfBooksDBContext.shelves.Add(viewModel.shelf);
                _otzarOfBooksDBContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Selected library not found");


            //פה אני טוען מחדש את הספריות כדי למלא את הרשימה הנפתחת
            viewModel.libraries = _otzarOfBooksDBContext.libraries.ToList();
            return View(viewModel);
        }
    }
}
