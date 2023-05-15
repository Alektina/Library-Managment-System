using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using LibraryMvcEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryMvcEF.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationContext Context;

        public BooksController(ApplicationContext _context)
        {
            Context = _context;
        }
        public IActionResult Index()
        {
            List<Book> AllBooks = Context.Books.ToList();
            return View(AllBooks);
        }
        public IActionResult Details(int id)
        {
            Book CurrentBook = new Book();
            CurrentBook = Context.Books.FirstOrDefault(x => x.Id == id);
            return View(CurrentBook);          
        }
        
        public IActionResult RemoveOneBook(int id)

        {            
            
            return RedirectToAction(nameof(Details));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string Title, string Author, string ISBN, string Quantity)
        {
            Book NewBook = new Book();
            NewBook.Title = Title;
            NewBook.Author = Author;
            NewBook.ISBN = ISBN;
            NewBook.Quantity = Quantity;
            Context.Books.Add(NewBook);
            Context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Edit(int Id)
        {
            Book book = Context.Books.FirstOrDefault(x => x.Id == Id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(int Id, string Title, string Author, string ISBN, string Quantity)
        {
            Book book = Context.Books.FirstOrDefault(x => x.Id == Id);
            book.Title = Title;
            book.Author = Author;
            book.ISBN = ISBN;
            book.Quantity = Quantity;
            Context.Books.Update(book);            
            Context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}