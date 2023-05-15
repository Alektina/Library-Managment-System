using System;
using LibraryMvcEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LibraryMvcEF
{
    public class ApplicationContext : DbContext
    {
        private const string V = "2023-06-04";

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Copy> Copies { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Books Table
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "1984", Author = "George Orwell", ISBN = "9780141036144", Quantity = "5" });//"Science fiction" 
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 2, Title = "The War of the Worlds", Author = "H G Wells", ISBN = "9781847496461", Quantity = "2" });//"Science fiction" 
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 3, Title = "We: New translation", Author = "Yevgeny Zamyatin", ISBN = "9781847496768", Quantity = "3" });//"Science fiction" 
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 4, Title = "The Haunted Hotel", Author = "Wilkie Collins", ISBN = "9781847498397", Quantity = "6" });//BookGenre = "Drama",
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 5, Title = "Pride and Prejudice", Author = "Jane Austen", ISBN = "9780141439518", Quantity = "10" });//BookGenre = "Classic",
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 6, Title = "Tresuare Island", Author = "Robert Louis Stevenson", ISBN = "9784909069009", Quantity = "5" });//BookGenre = "Action and Adventure",

            // Genres Table
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Category = "Drama"});
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 2, Category = "Science fiction" });
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 3, Category = "Classic" });
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 4, Category = "Action and Adventure" });

            // Loans Table
            modelBuilder.Entity<Loan>().HasData(
                new Loan { Id = 1, BookId = 1, UserId = 2, BookQuantity = "1", LoanPeriod = DateTime.Now});
            modelBuilder.Entity<Loan>().HasData(
                new Loan { Id = 2, BookId = 3, UserId = 1, BookQuantity = "2", LoanPeriod = DateTime.Now });
            modelBuilder.Entity<Loan>().HasData(
                new Loan { Id = 3, BookId = 4, UserId = 3, BookQuantity = "3", LoanPeriod = DateTime.Now });
            modelBuilder.Entity<Loan>().HasData(
                new Loan { Id = 4, BookId = 6, UserId = 4, BookQuantity = "5", LoanPeriod = DateTime.Now });

            // Users Table
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Thomas Dahlman", Address = "Edingsvägen 6, 451 52 Uddevalla", PhoneNumber= "052212470" });
            modelBuilder.Entity<User>().HasData(
               new User { Id = 2, Name = "Johan Karlsson", Address = "Drottninggatan 10, 11 51 Stockholm", PhoneNumber = "01233445" });
            modelBuilder.Entity<User>().HasData(
               new User { Id = 3, Name = "Lisa Andersson", Address = "Botkyrkavägen 3, 143 30 Vårby", PhoneNumber = "0532412470" });
            modelBuilder.Entity<User>().HasData(
               new User { Id = 4, Name = "Stella Kobal", Address = "Fruängsgången 12, 129 52 Hägersten", PhoneNumber = "073235470" });

            //Copies Table
            modelBuilder.Entity<Copy>().HasData(
                new Copy { Id = 1, BookId = 2, BookTitle= "The War of the Worlds", Inhouse = "2", Checkedout = "0" });
            modelBuilder.Entity<Copy>().HasData(
                new Copy { Id = 2, BookId = 3, BookTitle = "We: New translation", Inhouse = "1", Checkedout = "2" });
            modelBuilder.Entity<Copy>().HasData(
                new Copy { Id = 3, BookId = 4, BookTitle = "The Haunted Hotel", Inhouse = "3", Checkedout = "3" });


            // Authors Table
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "George Orwell" });
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 2, Name = "H G Wells" });
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 3, Name = "Yevgeny Zamyatin" });
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 4, Name = "Wilkie Collins" });
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 5, Name = "Jane Austen" });            
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 6, Name = "Robert Louis Stevenson"});

            //AuthorBook Table
            modelBuilder.Entity("AuthorBook").HasData(
                new { AuthorsId = 1, BooksId = 1 });
            modelBuilder.Entity("AuthorBook").HasData(
                new { AuthorsId = 2, BooksId = 2 });
            modelBuilder.Entity("AuthorBook").HasData(
                new { AuthorsId = 3, BooksId = 3 });
            modelBuilder.Entity("AuthorBook").HasData(
                new { AuthorsId = 4, BooksId = 4 });
            modelBuilder.Entity("AuthorBook").HasData(
                new { AuthorsId = 5, BooksId = 5 });
            modelBuilder.Entity("AuthorBook").HasData(
                new { AuthorsId = 6, BooksId = 6 });

            //BookGenre Table
            modelBuilder.Entity("BookGenre").HasData(
                new { BooksId = 1, GenresId = 2 });
            modelBuilder.Entity("BookGenre").HasData(
                new { BooksId = 2, GenresId = 2 });
            modelBuilder.Entity("BookGenre").HasData(
                new { BooksId = 3, GenresId = 2 });
            modelBuilder.Entity("BookGenre").HasData(
                new { BooksId = 4, GenresId = 1 });
            modelBuilder.Entity("BookGenre").HasData(
                new { BooksId = 5, GenresId = 3 });
            modelBuilder.Entity("BookGenre").HasData(
                new { BooksId = 6, GenresId = 4 });
        }
    }
}


