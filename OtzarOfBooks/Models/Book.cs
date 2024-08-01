using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtzarOfBooks.Models
{
	public class Book
	{
		[Key]
		public int Id { get; set; }

        [Display(Name = "name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name{ get; set; }

		[Display(Name = "Hight")]
		[Required(ErrorMessage = "Hight is required")]
		public float Hight { get; set; }
		[Display(Name = "Width")]
		[Required(ErrorMessage = "Width is required")]
		public float Width { get; set; }

        [ForeignKey("Shelf")]
        public int ShelfId { get; set; }

        public Shelf Shelf { get; set; }

    }
}
