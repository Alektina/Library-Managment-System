using System;
namespace LibraryMvcEF.Models
{
	public class Genre
	{
		public int Id { get; set; }        
        public string Category { get; set; }
		public List<Book> Books { get; set; }
	}
}

