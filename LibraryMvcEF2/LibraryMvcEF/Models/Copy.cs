using System;
namespace LibraryMvcEF.Models
{
	public class Copy
	{
		public int Id { get; set; }
        public int BookId { get; set; }
		public string BookTitle { get; set; }
        public string Inhouse { get; set; }//Antal tillgänliga böcker		
		public string Checkedout { get; set; }//Antal utlånade böcker
		public Book Book { get; set; }

	}
}

