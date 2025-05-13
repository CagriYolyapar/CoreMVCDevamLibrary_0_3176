using CoreMVCDevam_0.Models.ContextClasses;
using CoreMVCDevam_0.Models.Entities;
using CoreMVCDevam_0.Models.PageVMs;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCDevam_0.Controllers
{
    public class BookController : Controller
    {
        readonly MyContext _context;

        public BookController(MyContext context)
        {
            _context = context;
        }

        public IActionResult BookList()
        {
            return View(_context.Books.ToList());
        }

        public IActionResult CreateBook()
        {
            BookPageVm bpVm = new()
            {
                Categories = _context.Categories.ToList()
            };
            return View(bpVm);
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("BookList");
        }

        public IActionResult UpdateBook(int id)
        {
            BookPageVm bpVm = new()
            {
                Categories = _context.Categories.ToList(),
                Book = _context.Books.Find(id)
            };
            return View(bpVm);
        }

        [HttpPost]
        public IActionResult UpdateBook(BookPageVm bpVm)
        {
            Book original = _context.Books.Find(bpVm.Book.Id);

            original.Title = bpVm.Book.Title;
            original.CategoryId = bpVm.Book.CategoryId;
            _context.SaveChanges();
            return RedirectToAction("BookList");
        }

        public IActionResult DeleteBook(int id)
        {
            _context.Books.Remove(_context.Books.Find(id));
            _context.SaveChanges();
            return RedirectToAction("BookList");
        }
    }
}
