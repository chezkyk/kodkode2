using Microsoft.AspNetCore.Mvc.Rendering;
using OtzarOfBooks.Models;

namespace OtzarOfBooks.ViewModels
{
	public class GenerAndBooks
	{
		public Book? book { get; set; }
		public List<BookLibrary>? libraries { get; set; }
		public int LibraryId { get; set; }
        public GenerAndBooks()
        {
            book = new Book();
            libraries = new List<BookLibrary>();
        }

    }
}
