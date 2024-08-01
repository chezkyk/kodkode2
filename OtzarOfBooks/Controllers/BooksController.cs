using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OtzarOfBooks.DAL;
using OtzarOfBooks.Models;
using OtzarOfBooks.ViewModels;
using System.Linq;

namespace OtzarOfBooks.Controllers
{
    public class BooksController : Controller
    {
        private readonly OtzarOfBooksDBContext _context;

        public BooksController(OtzarOfBooksDBContext context)
        {
            _context = context;
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            // המשתנה viewModel מכיל עכשיו רשימה של כל הספריות כולל המדפים, וזה יעזור לי אחכ בכדי שהמשתמש יוכל למלא את החירה שלו 
            var viewModel = new GenerAndBooks
            {
                libraries = _context.libraries.Include(l => l.Shelves).ToList()
            };
            return View(viewModel);
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GenerAndBooks viewModel)
        {
            // המשתנה library יקבל פה ספרייה לפי ID שנשלח לו
            var library = _context.libraries
                                  .Include(l => l.Shelves)
                                  .FirstOrDefault(l => l.Id == viewModel.LibraryId);

            if (library != null && library.Shelves != null)
            {
                // המשתנה suitableShelf בודק אם אפשר להכניס למדף או לא ע'יי הנתונים שהוא קיבל
                var suitableShelf = library.Shelves
                                           .Where(s => s.Hight >= viewModel.book.Hight)
                                           .OrderBy(s => s.Width)
                                           .FirstOrDefault();

                if (suitableShelf != null)
                {
                    // פה אני בודק אם יש הפרש של 10 ס''מ ויותר בין הספר למדף
                    if (viewModel.book.Hight <= suitableShelf.Hight - 10)
                    {
                        TempData["AlertMessage"] = "The book is more than 10 cm shorter than the shelf, but will still be added.";
                    }
                    // המשתנה totalWidthOnShelf יכיל את הרוחב של כל הספרים שנמצאים כבר על המדף
                    var totalWidthOnShelf = _context.books
                                                    .Where(b => b.ShelfId == suitableShelf.Id)
                                                    .Sum(b => b.Width);

                    if (totalWidthOnShelf + viewModel.book.Width <= suitableShelf.Width)
                    {
                        // לפה אני ייכנס רק אם עברתי את מבחן הרוחב וזה מתאים להיכנס למדף
                        viewModel.book.ShelfId = suitableShelf.Id;
                        _context.books.Add(viewModel.book);
                        _context.SaveChanges();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        // מציג למשתמש הודעת שגיאה אם הוא לא יכול להיכנס למדף בגלל שהרוחב לא מתאים
                        TempData["AlertMessage"] = "Not enough space on the selected shelf for this book.";
                    }
                }
                //else
                //{
                //    TempData["AlertMessage"]("", "No suitable shelf found for the book height.");
                //}
            }
            else
            {
                // מדפיס הודעת שגיאה אם הוא לא מצא את הסםרייה המבוקשת
                TempData["AlertMessage"] = "Selected library not found or has no shelves.";
            }

            viewModel.libraries = _context.libraries.Include(l => l.Shelves).ToList();
            return View(viewModel);
        }

        // GET: Books/Index
        public IActionResult Index()
        {
            // למשתנה books ייכנס פה כל הספרים מה דאטה בייס כוול המדף
            var books = _context.books.Include(b => b.Shelf).ToList();
            return View(books);
        }
    }
}
