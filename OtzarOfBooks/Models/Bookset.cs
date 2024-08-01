namespace OtzarOfBooks.Models
{
    public class Bookset
    {
        public int LibraryId { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
