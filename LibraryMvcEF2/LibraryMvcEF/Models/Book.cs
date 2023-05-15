using System;
namespace LibraryMvcEF.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }        
        public string Quantity { get; set; }
        public List<Author> Authors { get; set; }
        public List<Genre> Genres { get; set; }
    }
}

