using Microsoft.EntityFrameworkCore;
using OtzarOfBooks.Models;

namespace OtzarOfBooks.DAL
{
	public class OtzarOfBooksDBContext: DbContext
	{
		public OtzarOfBooksDBContext(DbContextOptions<OtzarOfBooksDBContext> options) : base(options)
		{

			Database.EnsureCreated();

		}
		
		public DbSet<Book> books  { get; set; }
		public DbSet<Shelf> shelves { get; set; }
		public DbSet<BookLibrary> libraries { get; set; }

	
	}
}
