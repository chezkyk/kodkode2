using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OtzarOfBooks.DAL;
using OtzarOfBooks.Models;
using OtzarOfBooks.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace OtzarOfBooks.Controllers
{
    public class BooksetController : Controller
    {
        private readonly OtzarOfBooksDBContext _context;

        public BooksetController(OtzarOfBooksDBContext context)
        {
            _context = context;
        }

        // GET: Bookset/Create
        public IActionResult Create()
        {
            // למשתנה viewModel ייכנס רשימה של כל הספריות + רשימה ריקה של ספרים בכדי שיוכל להוסיף ספרים חדשים
            var viewModel = new GenerAndSetBook
            {
                Libraries = _context.libraries.ToList(),
                Bookset = new Bookset()
            };
            return View(viewModel);
        }

        // POST: Bookset/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GenerAndSetBook viewModel)
        {
            // המשתנה library יקבל פה ספרייה לפי ID שנשלח לו
            var library = _context.libraries
                .Include(l => l.Shelves)
                .ThenInclude(s => s.books)
                .FirstOrDefault(l => l.Id == viewModel.LibraryId);

            if (library != null)
            {
                // למשתנה totalSetWidth ייכנס הרוחב הכולל של כל הספרים בסט הנוכחי
                float totalSetWidth = viewModel.Bookset.Books.Sum(b => b.Width);
                // למשתנה maxBookHeight ייכנס האורך הכולל של כל הספרים בסט הנוכחי
                float maxBookHeight = viewModel.Bookset.Books.Max(b => b.Hight);
                // המשתנה suitableShelf מחפש מדף מתאים בספריה שבו ניתן לאחסן את כל הסט, לפי הגובה המרבי של הספרים והרוחב הכולל של הספרים בסט.
                var suitableShelf = library.Shelves
                    .Where(s => s.Hight >= maxBookHeight &&
                                (s.Width - s.books.Sum(b => b.Width)) >= totalSetWidth)
                    .OrderBy(s => s.Width)
                    .FirstOrDefault();

                if (suitableShelf != null)
                {
                    // פה הוא ייכנס רק עם עבר את כל הבדיקות של האורך ורוחב ואז יכניס אותו לדאטה בייס של ספרים
                    foreach (var book in viewModel.Bookset.Books)
                    {
                        book.ShelfId = suitableShelf.Id;
                        _context.books.Add(book);
                    }
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // לפה הוא יגיע רק עם הוא בדק וראה שאין מקום לכל הסט *ביחד* להיכנס לדאטה בייס ויציג הודעה מתאימה למשתמש
                    ModelState.AddModelError("", "No suitable shelf found for this set of books.");
                }
            }
            else
            {
                // ידפיס הודעה למתמש אם לא מצא את הספרייה
                ModelState.AddModelError("", "Selected library not found.");
            }


            // If we got this far, something failed; redisplay form
            viewModel.Libraries = _context.libraries.ToList();
            return View(viewModel);
        }

    }
}