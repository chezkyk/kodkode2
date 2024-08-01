using OtzarOfBooks.Models;

namespace OtzarOfBooks.ViewModels
{
    public class GenerAndSetBook
    {
        public Bookset Bookset { get; set; }
        public List<BookLibrary> Libraries { get; set; }
        public int LibraryId { get; set; }

        public GenerAndSetBook()
        {
            Bookset = new Bookset();
            Libraries = new List<BookLibrary>();
        }
    }
}
