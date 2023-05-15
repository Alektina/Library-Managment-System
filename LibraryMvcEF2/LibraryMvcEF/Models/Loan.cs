﻿using System;
namespace LibraryMvcEF.Models
{
	public class Loan
	{
		public int Id { get; set; }
		public int BookId { get; set; }
        public int UserId { get; set; }
		public string BookQuantity { get; set; }
		public DateTime? LoanPeriod { get; set; }
		public Book Book { get; set; }
        public User User { get; set; }
	}
}

