using OtzarOfBooks.Models;

namespace OtzarOfBooks.ViewModels
{
    public class GenerAndLibrarys
    {
        public Shelf? shelf { get; set; }
        public List<BookLibrary>? libraries { get; set; }
        public int LibraryId { get; set; }
        public GenerAndLibrarys()
        {
            shelf = new Shelf();
            libraries = new List<BookLibrary>();
        }
    }
}
