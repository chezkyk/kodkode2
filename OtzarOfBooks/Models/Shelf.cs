using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtzarOfBooks.Models
{
	public class Shelf
	{
		[Key]
		public int Id { get; set; }
		

		[Display(Name = "Hight")]
		[Required(ErrorMessage = "Hight is required")]
		public float Hight { get; set; }

		[Display(Name = "Width")]
		[Required(ErrorMessage = "Width is required")]
		public float Width { get; set; }

        [ForeignKey("BookLibrary")]
        public int LibraryId { get; set; }

        public BookLibrary Library { get; set; }
        public List<Book> books { get; set; } = new List<Book>();

	}
}
