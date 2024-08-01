using System.ComponentModel.DataAnnotations;

namespace OtzarOfBooks.Models
{
    public class BookLibrary
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Genre is required")]
        public string Genre { get; set; }
        public List<Shelf> Shelves { get; set; } = new List<Shelf>();

        public BookLibrary() { }
        public BookLibrary(string genre)
        {
            Genre = genre;
        }
    }
}
